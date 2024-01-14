Imports NModbus
Imports NModbus.Serial
Imports System.IO
Imports System.IO.Ports
Imports System.Net.Sockets

Public Class FormMain
    Dim ModbusRTU As New SerialPort
    Dim ModbusTCP As New TcpClient
    Dim IsPortOpen As Boolean = False
    Dim IsCommunication As Boolean = False
    Dim FirstRequest As Boolean = True
    Dim FirstDatalogger As Boolean = True





    '**********
    ' FUNKTIONEN ZUR STEUERUNG DER FORM
    '**********


    ' Wählt eine Konfiguration der seriellen Schnittstelle
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialBaud.SelectedItem = SerialBaud.Items.Item(0)
        ReadingHeadVersion.SelectedItem = ReadingHeadVersion.Items.Item(0)
        SerialParity.SelectedItem = SerialParity.Items.Item(0)
        SerialStopbits.SelectedItem = SerialStopbits.Items.Item(1)
        Logger("Start")
    End Sub


    ' Aktualisiert die verfügbaren Ports
    Private Sub PortSelect_MouseClick(sender As Object, e As MouseEventArgs) Handles RTUPort.MouseClick
        RTUPort.Items.Clear()

        For Each sp As String In My.Computer.Ports.SerialPortNames
            RTUPort.Items.Add(sp)
        Next
    End Sub


    ' Öffnet eine Website zur Hilfe dieser Software
    Private Sub LinkLabelHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelHelp.LinkClicked
        Process.Start("https://www.niklas-menke.de/projekte/smartmeter-auslesen/modbus/")
    End Sub


    ' Öffnet die Website zum Projekt
    Private Sub LinkLabelAuthor_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelAuthor.LinkClicked
        Process.Start("https://www.niklas-menke.de/projekte/smartmeter-auslesen/modbus/")
    End Sub





    '**********
    ' FUNKTIONEN ZUR STEUERUNG DER VERBINDUNG
    '**********


    ' Initiiert oder Beendet eine serielle Verbindung oder eine Netzwerkverbindung und passt die Steuerelemente entsprechend an.
    Private Sub PortConnect_Click(sender As Object, e As EventArgs) Handles ConnectionConnect.Click
        If IsPortOpen Then
            Try
                If TCPActive.Checked Then
                    ModbusTCP.Dispose()
                    Logger("Modbus TCP Verbindung wurde getrennt")
                Else
                    ModbusRTU.Close()
                    Logger("Modbus RTU Verbindung wurde getrennt")
                End If

                ConnectionConnect.Text = "Verbinden"
                FirstRequest = True

                GroupReadingHead.Enabled = True
                GroupSerial.Enabled = True
                TCPActive.Enabled = True
                If TCPActive.Checked Then
                    GroupTCP.Enabled = True
                Else
                    GroupRTU.Enabled = True
                End If

                GroupCommunication.Enabled = False

                LogActive.Checked = False

                GroupPin.Enabled = False

                GroupSettings.Enabled = False
                GroupSettingsParam.Enabled = False
                SettingWrite.Enabled = False

                IsPortOpen = False
            Catch ex As Exception
                MessageBox.Show("Fehler beim Schließen der Verbindung: " & ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Logger("Fehler beim Schließen der Verbindung: " & ex.Message)
            End Try
        Else
            Try
                Dim LoggerString As String = "Verbindung initiiert ; "
                If TCPActive.Checked Then
                    ModbusTCP = New TcpClient(TCPIPAddress.Text, TCPPort.Value)
                    ModbusTCP.ReceiveTimeout = 2000
                    LoggerString &= "Typ: Modbus TCP ; IP-Adresse: " & TCPIPAddress.Text & " ; Port: " & TCPPort.Value
                Else
                    LoggerString &= "Typ: Modbus RTU ; Port: " & RTUPort.SelectedItem & " ; Geschwindigkeit: " & SerialBaud.SelectedItem & " bit/s ; Codierung: 8"
                    With ModbusRTU
                        .PortName = RTUPort.SelectedItem
                        .BaudRate = SerialBaud.SelectedItem
                        .DataBits = 8
                        Select Case SerialParity.SelectedItem
                            Case "None"
                                .Parity = Parity.None
                                LoggerString &= "N"
                            Case "Even"
                                .Parity = Parity.Even
                                LoggerString &= "E"
                            Case "Odd"
                                .Parity = Parity.Odd
                                LoggerString &= "O"
                        End Select
                        If SerialStopbits.SelectedItem = 2 Then
                            .StopBits = StopBits.Two
                            LoggerString &= "2"
                        Else
                            .StopBits = StopBits.One
                            LoggerString &= "1"
                        End If
                        .ReadTimeout = 500
                    End With
                    ModbusRTU.Open()
                End If
                LoggerString &= " ; Geräteadresse: " & ReadingHeadAddress.Value & " ; Version Firmware: " & ReadingHeadVersion.SelectedItem

                ConnectionConnect.Text = "Trennen"
                FirstRequest = True


                GroupReadingHead.Enabled = False
                GroupSerial.Enabled = False
                TCPActive.Enabled = False
                GroupTCP.Enabled = False
                GroupRTU.Enabled = False

                GroupCommunication.Enabled = True

                GroupPin.Enabled = True

                GroupSettings.Enabled = True

                IsPortOpen = True
                Logger(LoggerString)
            Catch ex As Exception
                MessageBox.Show("Fehler bei der Initiierung der Verbindung: " & ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Logger("Fehler bei der Initiierung der Verbindung: " & ex.Message)
            End Try
        End If
    End Sub


    ' Verändert die Steuerelemente wenn Modbus TCP aktiviert bzw. deaktiviert wird
    Private Sub TCPActive_CheckedChanged(sender As Object, e As EventArgs) Handles TCPActive.CheckedChanged
        If TCPActive.Checked Then
            GroupTCP.Enabled = True
            GroupRTU.Enabled = False
            GroupSerial.Enabled = False
        Else
            GroupTCP.Enabled = False
            GroupRTU.Enabled = True
            GroupSerial.Enabled = True
        End If
    End Sub





    '**********
    ' FUNKTIONEN ZUR STEUERUNG DER KOMMUNIKATION
    '**********


    ' Steuert den Start oder Stopp der automatischen Datenabfrage und passt Steuerelemente entsprechend an.
    ' Während einer Kommunikation sind folgende Aktionen nicht erlaubt:
    ' - Intervall verändern
    ' - PIN senden
    ' - Einstellungen lesen/schreiben
    ' - Manuelle Datenabfrage
    Private Sub CommunicationStart_Click(sender As Object, e As EventArgs) Handles CommunicationStart.Click
        If IsCommunication Then
            IsCommunication = False
            ComInt.Enabled = False

            CommunicationManual.Enabled = True
            CommunicationIntervall.Enabled = True
            CommunicationStart.Text = "Start"
            CommunicationProgress.Value = 0

            GroupPin.Enabled = True
            GroupSettings.Enabled = True
        Else
            GroupPin.Enabled = False
            GroupSettings.Enabled = False
            GroupSettingsParam.Enabled = False
            SettingWrite.Enabled = False

            CommunicationManual.Enabled = False
            CommunicationIntervall.Enabled = False
            CommunicationStart.Text = "Stopp"
            ComInt.Interval = 100
            CommunicationProgress.Step = 100
            CommunicationProgress.Maximum = CommunicationIntervall.Value * 1000

            IsCommunication = True
            Logger("Automatische Messreihe Beginn")
            Read_data()
            Logger("Automatische Messreihe Ende")
            ComInt.Enabled = True
        End If
    End Sub


    ' Setzt den Fortschrittsbalken der automatischen Kommunikation um einen Schritt nach vorn.
    ' Wenn der Fortschrittsbalken voll ist, dann werden neue Daten vom Lesekopf abgefragt
    Private Sub ComInt_Tick(sender As Object, e As EventArgs) Handles ComInt.Tick
        CommunicationProgress.PerformStep()
        If CommunicationProgress.Value = CommunicationProgress.Maximum Then
            Logger("Automatische Messreihe Beginn")
            Read_data()
            Logger("Automatische Messreihe Ende")
            CommunicationProgress.Value = 0
        End If
    End Sub


    ' Ruft einaml Daten vom Lesekopf ab
    Private Sub CommunicationManual_Click(sender As Object, e As EventArgs) Handles CommunicationManual.Click
        Logger("Manuelle Messreihe Beginn")
        Read_data()
        Logger("Manuelle Messreihe Ende")
    End Sub


    ' Ruft alle Momentanwerte und Energiewerte vom Lesekopf über die zuvor initiierte Verbindung ab
    Private Sub Read_data()
        ' Temperatur, Aktualisiert
        Dim TempActual() As UShort = Modbus_FC03(8262, 2)

        ' Lesekopf-ID, Server-ID
        If FirstRequest Then
            Dim IDs() As UShort = Modbus_FC03(8252, 10)
            If IDs.Length = 10 Then
                ReadingHeadID.Text = ""
                ServerID.Text = ""
                For i = 0 To 4
                    ReadingHeadID.Text &= (IDs(i) >> 8).ToString("X2") & "-"
                    ReadingHeadID.Text &= (IDs(i) And &HFF).ToString("X2") & "-"
                    ServerID.Text &= (IDs(i + 5) >> 8).ToString("X2") & "-"
                    ServerID.Text &= (IDs(i + 5) And &HFF).ToString("X2") & "-"
                Next
                ReadingHeadID.Text = ReadingHeadID.Text.Remove(ReadingHeadID.Text.Length - 1)
                ServerID.Text = ServerID.Text.Remove(ServerID.Text.Length - 1)
            Else
                ReadingHeadID.Text = "N/A"
                ServerID.Text = "N/A"
                FirstRequest = False
            End If
        End If

        ' Datenlogger Datei Kopfzeile schreiben
        If FirstDatalogger Then
            Datalogger_write("Lesekopf-ID: " & ReadingHeadID.Text & ";" & vbCrLf & "Server-ID: " & ServerID.Text & ";" & vbCrLf & vbCrLf)
            Datalogger_write("Aktualisiert;Temperatur [°C];Zeitstempel Computer;Zeitstempel Lesekopf;Positive Wirkleistung Gesamt [W];Negative Wirkleistung Gesamt [W];Positive Blindleistung Gesamt [var];Negative Blindleistung Gesamt [var];Positive Scheinleistung Gesamt [VA];Negative Scheinleistung Gesamt [VA];Leistungsfaktor Gesamt;Frequenz [Hz];Wirkleistung Gesamt [W];Positive Wirkleistung L1 [W];Negative Wirkleistung L1 [W];Positive Blindleistung L1 [var];Negative Blindleistung L1 [var];Positive Scheinleistung L1 [VA];Negative Scheinleistung L1 [VA];Strom L1 [A];Spannung L1-N [V];Leistungsfaktor L1;Phasenverschiebung L1 [°];Positive Wirkleistung L2 [W];Negative Wirkleistung L2 [W];Positive Blindleistung L2 [var];Negative Blindleistung L2 [var];Positive Scheinleistung L2 [VA];Negative Scheinleistung L2 [VA];Strom L2 [A];Spannung L2-N [V];Leistungsfaktor L2;Phasenverschiebung L2 [°];Winkel U-L2 zu U-L1 [°];Positive Wirkleistung L3 [W];Negative Wirkleistung L3 [W];Positive Blindleistung L3 [var];Negative Blindleistung L3 [var];Positive Scheinleistung L3 [VA];Negative Scheinleistung L3 [VA];Strom L3 [A];Spannung L3-N [V];Leistungsfaktor L3;Phasenverschiebung L3 [°];Winkel U-L3 zu U-L1 [°];Positive Wirkenergie Tariflos [kWh]; Negative Wirkenergie Tariflos [kWh];Positive Wirkenergie Tarif 1 [kWh]; Negative Wirkenergie Tarif 1 [kWh];Positive Wirkenergie Tarif 2 [kWh]; Negative Wirkenergie Tarif 2 [kWh];")
            FirstDatalogger = False
        End If

        ' Neue Zeile beginnen mit Aktualisiert und Temperatur
        If TempActual.Length = 2 Then
            ReadingHeadTemperature.Text = TempActual(0) - 273 & " °C"
            ReadingHeadData.Text = IIf(TempActual(1), "Daten aktualisiert", "Daten nicht aktualisiert")
            Datalogger_write(vbCrLf & IIf(TempActual(1), "Ja;", "Nein;") & TempActual(0) - 273 & ";")
        Else
            ReadingHeadData.Text = "N/A"
            Datalogger_write(vbCrLf & "N/A;N/A;")
        End If

        ' Systemzeit einfügen
        Datalogger_write(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") & ";")

        ' Zeitstempel
        Dim TimestampArray() As UShort = Modbus_FC03(8245, 4)
        If TimestampArray.Length = 4 Then
            Dim Timestamp As ULong = (CType(TimestampArray(0), ULong) << 48) Or (CType(TimestampArray(1), ULong) << 32) Or (CType(TimestampArray(2), UInteger) << 16) Or TimestampArray(3)
            ReadingHeadTimestamp.Text = DateTimeOffset.FromUnixTimeSeconds(Timestamp).DateTime.ToString("dd.MM.yyyy HH:mm:ss")
            Datalogger_write(DateTimeOffset.FromUnixTimeSeconds(Timestamp).DateTime.ToString("dd.MM.yyyy HH:mm:ss") & ";")
        Else
            ReadingHeadTimestamp.Text = "N/A"
            Datalogger_write("N/A;")
        End If

        ' Registerblock 1 (Wirk- und Blindleistung Gesamt)
        Dim Block1() As UShort = Modbus_FC03(0, 8)
        If Block1.Length = 8 Then
            Dim Buffer As UInteger = (CType(Block1(0), UInteger) << 16) Or Block1(1)
            AcPoPSum.Text = IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0)
            Datalogger_write(IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0) & ";")

            Buffer = (CType(Block1(2), UInteger) << 16) Or Block1(3)
            AcPoNSum.Text = IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0)
            Datalogger_write(IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0) & ";")

            Buffer = (CType(Block1(4), UInteger) << 16) Or Block1(5)
            RePoPSum.Text = IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0)
            Datalogger_write(IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0) & ";")

            Buffer = (CType(Block1(6), UInteger) << 16) Or Block1(7)
            RePoNSum.Text = IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0)
            Datalogger_write(IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0) & ";")
        Else
            AcPoPSum.Text = "N/A"
            AcPoNSum.Text = "N/A"
            RePoPSum.Text = "N/A"
            RePoNSum.Text = "N/A"
            Datalogger_write("N/A;N/A;N/A;N/A;")
        End If

        ' Registerblock 2 (Scheinleistung Gesamt)
        Dim Block2() As UShort = Modbus_FC03(16, 4)
        If Block2.Length = 4 Then
            Dim Buffer As UInteger = (CType(Block2(0), UInteger) << 16) Or Block2(1)
            ApPoPSum.Text = IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0)
            Datalogger_write(IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0) & ";")

            Buffer = (CType(Block2(2), UInteger) << 16) Or Block2(3)
            ApPoNSum.Text = IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0)
            Datalogger_write(IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0) & ";")
        Else
            ApPoPSum.Text = "N/A"
            ApPoNSum.Text = "N/A"
            Datalogger_write("N/A;N/A;")
        End If

        ' Registerblock 3 (Leistungsfaktor Gesamt, Frequenz, Wirkleistung+-)
        Dim Block3() As UShort = Modbus_FC03(24, 6)
        'Dim Block3() As UShort = New UShort() {1, 2, 3, 4, 65535, 65530}
        If Block3.Length = 6 Then
            Dim Sbuffer As Integer = (CType(Block3(0), Integer) << 16) Or Block3(1)
            PoFaSum.Text = IIf(Sbuffer = -1, "N/A", Sbuffer / 1000.0)
            Datalogger_write(IIf(Sbuffer = -1, "N/A", Sbuffer / 1000.0) & ";")

            Dim Ubuffer As UInteger = (CType(Block3(2), UInteger) << 16) Or Block3(3)
            Frequency.Text = IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 1000.0)
            Datalogger_write(IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 1000.0) & ";")

            Sbuffer = (CType(Block3(4), Integer) << 16) Or Block3(5)
            AcPoPNSum.Text = IIf(Sbuffer = -1, "N/A", Sbuffer)
            Datalogger_write(IIf(Sbuffer = -1, "N/A", Sbuffer) & ";")
        Else
            PoFaSum.Text = "N/A"
            Frequency.Text = "N/A"
            AcPoPNSum.Text = "N/A"
            Datalogger_write("N/A;N/A;N/A;")
        End If

        ' Registerblock 4 (Wirk- und Blindleistung L1)
        Dim Block4() As UShort = Modbus_FC03(40, 8)
        If Block4.Length = 8 Then
            Dim Buffer As UInteger = (CType(Block4(0), UInteger) << 16) Or Block4(1)
            AcPoPL1.Text = IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0)
            Datalogger_write(IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0) & ";")

            Buffer = (CType(Block4(2), UInteger) << 16) Or Block4(3)
            AcPoNL1.Text = IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0)
            Datalogger_write(IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0) & ";")

            Buffer = (CType(Block4(4), UInteger) << 16) Or Block4(5)
            RePoPL1.Text = IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0)
            Datalogger_write(IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0) & ";")

            Buffer = (CType(Block4(6), UInteger) << 16) Or Block4(7)
            RePoNL1.Text = IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0)
            Datalogger_write(IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0) & ";")
        Else
            AcPoPL1.Text = "N/A"
            AcPoNL1.Text = "N/A"
            RePoPL1.Text = "N/A"
            RePoNL1.Text = "N/A"
            Datalogger_write("N/A;N/A;N/A;N/A;")
        End If

        ' Registerblock 5 (Scheinleistung, Strom, Spannung, Leistungsfaktor und Phasenverschiebung L1)
        Dim Block5() As UShort = Modbus_FC03(56, 11)
        If Block5.Length = 11 Then
            Dim Ubuffer As UInteger = (CType(Block5(0), UInteger) << 16) Or Block5(1)
            ApPoPL1.Text = IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 10.0)
            Datalogger_write(IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 10.0) & ";")

            Ubuffer = (CType(Block5(2), UInteger) << 16) Or Block5(3)
            ApPoNL1.Text = IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 10.0)
            Datalogger_write(IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 10.0) & ";")

            Ubuffer = (CType(Block5(4), UInteger) << 16) Or Block5(5)
            CurL1.Text = IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 1000.0)
            Datalogger_write(IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 1000.0) & ";")

            Ubuffer = (CType(Block5(6), UInteger) << 16) Or Block5(7)
            VolL1.Text = IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 1000.0)
            Datalogger_write(IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 1000.0) & ";")

            Dim Sbuffer As Integer = (CType(Block5(8), Integer) << 16) Or Block5(9)
            PoFaL1.Text = IIf(Sbuffer = -1, "N/A", Sbuffer / 1000.0)
            Datalogger_write(IIf(Sbuffer = -1, "N/A", Sbuffer / 1000.0) & ";")

            PhShL1.Text = IIf(Block5(10) = UShort.MaxValue, "N/A", Block5(10))
            Datalogger_write(IIf(Block5(10) = UShort.MaxValue, "N/A", Block5(10)) & ";")
        Else
            ApPoPL1.Text = "N/A"
            ApPoNL1.Text = "N/A"
            CurL1.Text = "N/A"
            VolL1.Text = "N/A"
            PoFaL1.Text = "N/A"
            PhShL1.Text = "N/A"
            Datalogger_write("N/A;N/A;N/A;N/A;N/A;N/A;")
        End If

        ' Registerblock 6 (Wirk- und Blindleistung L2)
        Dim Block6() As UShort = Modbus_FC03(80, 8)
        If Block6.Length = 8 Then
            Dim Buffer As UInteger = (CType(Block6(0), UInteger) << 16) Or Block6(1)
            AcPoPL2.Text = IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0)
            Datalogger_write(IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0) & ";")

            Buffer = (CType(Block6(2), UInteger) << 16) Or Block6(3)
            AcPoNL2.Text = IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0)
            Datalogger_write(IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0) & ";")

            Buffer = (CType(Block6(4), UInteger) << 16) Or Block6(5)
            RePoPL2.Text = IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0)
            Datalogger_write(IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0) & ";")

            Buffer = (CType(Block6(6), UInteger) << 16) Or Block6(7)
            RePoNL2.Text = IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0)
            Datalogger_write(IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0) & ";")
        Else
            AcPoPL2.Text = "N/A"
            AcPoNL2.Text = "N/A"
            RePoPL2.Text = "N/A"
            RePoNL2.Text = "N/A"
            Datalogger_write("N/A;N/A;N/A;N/A;")
        End If

        ' Registerblock 7 (Scheinleistung, Strom, Spannung, Leistungsfaktor und Phasenverschiebung L2 ; Winkel L2->L1)
        Dim Block7() As UShort = Modbus_FC03(96, 12)
        If Block7.Length = 12 Then
            Dim Ubuffer As UInteger = (CType(Block7(0), UInteger) << 16) Or Block7(1)
            ApPoPL2.Text = IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 10.0)
            Datalogger_write(IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 10.0) & ";")

            Ubuffer = (CType(Block7(2), UInteger) << 16) Or Block7(3)
            ApPoNL2.Text = IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 10.0)
            Datalogger_write(IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 10.0) & ";")

            Ubuffer = (CType(Block7(4), UInteger) << 16) Or Block7(5)
            CurL2.Text = IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 1000.0)
            Datalogger_write(IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 1000.0) & ";")

            Ubuffer = (CType(Block7(6), UInteger) << 16) Or Block7(7)
            VolL2.Text = IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 1000.0)
            Datalogger_write(IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 1000.0) & ";")

            Dim Sbuffer As Integer = (CType(Block7(8), Integer) << 16) Or Block7(9)
            PoFaL2.Text = IIf(Sbuffer = -1, "N/A", Sbuffer / 1000.0)
            Datalogger_write(IIf(Sbuffer = -1, "N/A", Sbuffer / 1000.0) & ";")

            PhShL2.Text = IIf(Block7(10) = UShort.MaxValue, "N/A", Block7(10))
            Datalogger_write(IIf(Block7(10) = UShort.MaxValue, "N/A", Block7(10)) & ";")

            AngL2L1.Text = IIf(Block7(11) = UShort.MaxValue, "N/A", Block7(11))
            Datalogger_write(IIf(Block7(11) = UShort.MaxValue, "N/A", Block7(11)) & ";")
        Else
            ApPoPL2.Text = "N/A"
            ApPoNL2.Text = "N/A"
            CurL2.Text = "N/A"
            VolL2.Text = "N/A"
            PoFaL2.Text = "N/A"
            PhShL2.Text = "N/A"
            AngL2L1.Text = "N/A"
            Datalogger_write("N/A;N/A;N/A;N/A;N/A;N/A;N/A;")
        End If

        ' Registerblock 8 (Wirk- und Blindleistung L3)
        Dim Block8() As UShort = Modbus_FC03(120, 8)
        If Block8.Length = 8 Then
            Dim Buffer As UInteger = (CType(Block8(0), UInteger) << 16) Or Block8(1)
            AcPoPL3.Text = IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0)
            Datalogger_write(IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0) & ";")

            Buffer = (CType(Block8(2), UInteger) << 16) Or Block8(3)
            AcPoNL3.Text = IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0)
            Datalogger_write(IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0) & ";")

            Buffer = (CType(Block8(4), UInteger) << 16) Or Block8(5)
            RePoPL3.Text = IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0)
            Datalogger_write(IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0) & ";")

            Buffer = (CType(Block8(6), UInteger) << 16) Or Block8(7)
            RePoNL3.Text = IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0)
            Datalogger_write(IIf(Buffer = UInteger.MaxValue, "N/A", Buffer / 10.0) & ";")
        Else
            AcPoPL3.Text = "N/A"
            AcPoNL3.Text = "N/A"
            RePoPL3.Text = "N/A"
            RePoNL3.Text = "N/A"
            Datalogger_write("N/A;N/A;N/A;N/A;")
        End If

        ' Registerblock 9 (Scheinleistung, Strom, Spannung, Leistungsfaktor und Phasenverschiebung L3 ; Winkel L3->L1)
        Dim Block9() As UShort = Modbus_FC03(136, 14)
        If Block9.Length = 14 Then
            Dim Ubuffer As UInteger = (CType(Block9(0), UInteger) << 16) Or Block9(1)
            ApPoPL3.Text = IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 10.0)
            Datalogger_write(IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 10.0) & ";")

            Ubuffer = (CType(Block9(2), UInteger) << 16) Or Block9(3)
            ApPoNL3.Text = IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 10.0)
            Datalogger_write(IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 10.0) & ";")

            Ubuffer = (CType(Block9(4), UInteger) << 16) Or Block9(5)
            CurL3.Text = IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 1000.0)
            Datalogger_write(IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 1000.0) & ";")

            Ubuffer = (CType(Block9(6), UInteger) << 16) Or Block9(7)
            VolL3.Text = IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 1000.0)
            Datalogger_write(IIf(Ubuffer = UInteger.MaxValue, "N/A", Ubuffer / 1000.0) & ";")

            Dim Sbuffer As Integer = (CType(Block9(8), Integer) << 16) Or Block9(9)
            PoFaL3.Text = IIf(Sbuffer = -1, "N/A", Sbuffer / 1000.0)
            Datalogger_write(IIf(Sbuffer = -1, "N/A", Sbuffer / 1000.0) & ";")

            PhShL3.Text = IIf(Block9(12) = UShort.MaxValue, "N/A", Block9(12))
            Datalogger_write(IIf(Block9(12) = UShort.MaxValue, "N/A", Block9(12)) & ";")

            AngL3L1.Text = IIf(Block9(13) = UShort.MaxValue, "N/A", Block9(13))
            Datalogger_write(IIf(Block9(13) = UShort.MaxValue, "N/A", Block9(13)) & ";")
        Else
            ApPoPL3.Text = "N/A"
            ApPoNL3.Text = "N/A"
            CurL3.Text = "N/A"
            VolL3.Text = "N/A"
            PoFaL3.Text = "N/A"
            PhShL3.Text = "N/A"
            AngL3L1.Text = "N/A"
            Datalogger_write("N/A;N/A;N/A;N/A;N/A;N/A;N/A;")
        End If

        ' Registerblock 10 (Energiewerte)
        Dim Block10() As UShort = Modbus_FC03(512, 24)
        'Dim Block10() As UShort = New UShort() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24}
        If Block10.Length = 24 Then
            Dim Buffer As ULong = (CType(Block10(0), ULong) << 48) Or (CType(Block10(1), ULong) << 32) Or (CType(Block10(2), UInteger) << 16) Or Block10(3)
            AcEnPT0.Text = IIf(Buffer = ULong.MaxValue, "N/A", CType(Buffer / 1000.0, ULong))
            Datalogger_write(IIf(Buffer = ULong.MaxValue, "N/A", CType(Buffer / 1000.0, ULong)) & ";")

            Buffer = (CType(Block10(4), ULong) << 48) Or (CType(Block10(5), ULong) << 32) Or (CType(Block10(6), UInteger) << 16) Or Block10(7)
            AcEnNT0.Text = IIf(Buffer = ULong.MaxValue, "N/A", CType(Buffer / 1000.0, ULong))
            Datalogger_write(IIf(Buffer = ULong.MaxValue, "N/A", CType(Buffer / 1000.0, ULong)) & ";")

            Buffer = (CType(Block10(8), ULong) << 48) Or (CType(Block10(9), ULong) << 32) Or (CType(Block10(10), UInteger) << 16) Or Block10(11)
            AcEnPT1.Text = IIf(Buffer = ULong.MaxValue, "N/A", CType(Buffer / 1000.0, ULong))
            Datalogger_write(IIf(Buffer = ULong.MaxValue, "N/A", CType(Buffer / 1000.0, ULong)) & ";")

            Buffer = (CType(Block10(12), ULong) << 48) Or (CType(Block10(13), ULong) << 32) Or (CType(Block10(14), UInteger) << 16) Or Block10(15)
            AcEnNT1.Text = IIf(Buffer = ULong.MaxValue, "N/A", CType(Buffer / 1000.0, ULong))
            Datalogger_write(IIf(Buffer = ULong.MaxValue, "N/A", CType(Buffer / 1000.0, ULong)) & ";")

            Buffer = (CType(Block10(16), ULong) << 48) Or (CType(Block10(17), ULong) << 32) Or (CType(Block10(18), UInteger) << 16) Or Block10(19)
            AcEnPT2.Text = IIf(Buffer = ULong.MaxValue, "N/A", CType(Buffer / 1000.0, ULong))
            Datalogger_write(IIf(Buffer = ULong.MaxValue, "N/A", CType(Buffer / 1000.0, ULong)) & ";")

            Buffer = (CType(Block10(20), ULong) << 48) Or (CType(Block10(21), ULong) << 32) Or (CType(Block10(22), UInteger) << 16) Or Block10(23)
            AcEnNT2.Text = IIf(Buffer = ULong.MaxValue, "N/A", CType(Buffer / 1000.0, ULong))
            Datalogger_write(IIf(Buffer = ULong.MaxValue, "N/A", CType(Buffer / 1000.0, ULong)) & ";")
        Else
            AcEnPT0.Text = "N/A"
            AcEnNT0.Text = "N/A"
            AcEnPT1.Text = "N/A"
            AcEnNT1.Text = "N/A"
            AcEnPT2.Text = "N/A"
            AcEnNT2.Text = "N/A"
            Datalogger_write("N/A;N/A;N/A;N/A;N/A;N/A;")
        End If
    End Sub





    '**********
    ' FUNKTIONEN FÜR DEN DATENLOGGER
    '**********


    ' Aktiviert bzw. Deaktiviert den Datenlogger
    ' Wenn der Datenlogger aktiviert wird, dann wird überprüft, ob bereits eine Datei exestiert und warnt ggf. vor dessen überschreibung.
    Private Sub LogActive_CheckedChanged(sender As Object, e As EventArgs) Handles LogActive.CheckedChanged
        If LogActive.Checked Then
            If Not LogFilePath.Text.EndsWith(".csv") Then
                LogFilePath.Text &= ".csv"
            End If

            Dim Result As DialogResult
            If File.Exists(LogFilePath.Text) Then
                Result = MessageBox.Show("Der ausgewählte Dateipfad exestiert bereits. Die bestehende Datei wird überschrieben." & vbCrLf & vbCrLf & "Möchten Sie fortfahren?", "Datei bereits vorhanden", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Else
                Result = DialogResult.Yes
            End If

            If Result = DialogResult.Yes Then
                Try
                    File.Create(LogFilePath.Text).Dispose()
                    LogFilePath.Enabled = False
                    LogSearchPath.Enabled = False
                    FirstDatalogger = True
                    LogFileOpen.Enabled = True
                Catch ex As Exception
                    MessageBox.Show("Fehler beim Starten des Datenlogger: " & ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Logger("Fehler beim Starten des Datenlogger: " & ex.Message)
                    LogActive.Checked = False
                End Try
            Else
                LogActive.Checked = False
            End If
        Else
            LogFilePath.Enabled = True
            LogSearchPath.Enabled = True
        End If
    End Sub


    ' Wählt einen Dateipfad für den Datenlogger
    Private Sub LogSearchPath_Click(sender As Object, e As EventArgs) Handles LogSearchPath.Click
        Dim saveFileDialog As New SaveFileDialog With {
            .Filter = "CSV (*.csv)|*.csv",
            .Title = "Datenabfragen in CSV exportieren",
            .FileName = "Datenlogger " & Replace(DateTime.Now.ToString(), ":", "-") & ".csv"
        }

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            LogFilePath.Text = saveFileDialog.FileName
        End If
    End Sub


    ' Verändert die Stuerelemente, wenn der Pfad des Datenloggers verändert wurde
    Private Sub LogFilePath_TextChanged(sender As Object, e As EventArgs) Handles LogFilePath.TextChanged
        If LogFilePath.TextLength Then
            LogActive.Enabled = True
            If File.Exists(LogFilePath.Text) Then
                LogFileOpen.Enabled = True
            Else
                LogFileOpen.Enabled = False
            End If
        Else
            LogFileOpen.Enabled = False
            LogActive.Enabled = False
        End If
    End Sub


    ' Öffnet die Datei des Datenloggers
    Private Sub LogFileOpen_Click(sender As Object, e As EventArgs) Handles LogFileOpen.Click
        Try
            Process.Start(LogFilePath.Text)
        Catch ex As Exception
            MessageBox.Show("Fehler beim Öffnen der Datei: " & ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Logger("Fehler beim Öffnen der Datei: " & ex.Message)
        End Try
    End Sub


    ' Schreibt Daten in den Datenlogger, wenn dieser aktivert ist
    Private Sub Datalogger_write(content As String)
        If LogActive.Checked Then
            Try
                Using writer As StreamWriter = File.AppendText(LogFilePath.Text)
                    writer.Write(content)
                End Using
            Catch ex As Exception
                MessageBox.Show("Fehler beim Schreiben in den Datenlogger: " & ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Logger("Fehler beim Schreiben in den Datenlogger: " & ex.Message)
                LogActive.Checked = False
            End Try
        End If
    End Sub





    '**********
    ' FUNKTIONEN ZUR ÜBERTRAGUNG DER PIN
    '**********


    ' Bestimmt die Dauer zur Übermittlung der PIN zwischen Lesekopf und Messeinrichtung und sendet die PIN zum Lesekopf
    Private Sub PINSend_Click(sender As Object, e As EventArgs) Handles PINSend.Click
        Dim Result As DialogResult = MessageBox.Show("Soll die PIN """ & PINNumber.Value.ToString("0000") & """ zur modernen Messeinrichtung übertragen werden?", "PIN senden", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = DialogResult.Yes Then
            GroupPin.Enabled = False
            GroupCommunication.Enabled = False
            GroupSettings.Enabled = False
            PINSend.Text = "Bitte warten..."

            Dim Buffer As UShort = PINNumber.Value
            Dim PIN() As UShort = {Buffer}

            ' Dauer der Übertragung ermitteln
            Dim Duration As UShort = 16500
            For i As Integer = 1 To 3
                Duration += (Buffer Mod 10) * 1000
                Buffer /= 10
            Next

            If Not Modbus_FC16(8251, PIN) Then
                PinWait.Interval = 100
                PinProgress.Step = 100
                PinProgress.Maximum = Duration
                PinWait.Enabled = True
            End If
        End If
    End Sub


    ' Aktualisiert den Fortschrittsbalken bei der Übertragung der PIN und meldet die Fertigstellung der Übertragung
    Private Sub PinWait_Tick(sender As Object, e As EventArgs) Handles PinWait.Tick
        PinProgress.PerformStep()
        If PinProgress.Value = PinProgress.Maximum Then
            PinWait.Enabled = False
            MessageBox.Show("PIN wurde übertragen." & vbCrLf & vbCrLf & "Es wurde nicht überprüft, ob die PIN gültig ist.", "PIN übertragen", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PinProgress.Value = 0
            PINSend.Text = "PIN senden"
            GroupPin.Enabled = True
            GroupCommunication.Enabled = True
            GroupSettings.Enabled = True
        End If
    End Sub






    '**********
    ' FUNKTIONEN ZUR ABFRAGE UND VERÄNDERUNG DER PARAMETER
    '**********


    ' Ruft die Parameter vom Lesekopf ab
    Private Sub SettingRead_Click(sender As Object, e As EventArgs) Handles SettingRead.Click
        ' Registerblock 11 (Hersteller, Gerät, Hardware- und Softwareversion)
        Dim Block11() As UShort = Modbus_FC03(8192, 4)
        If Block11.Length = 4 Then
            SettingManID.Value = Block11(0)
            SettingDevID.Value = Block11(1)
            SettingHWVer.Value = Block11(2)
            SettingFWVer.Value = Block11(3)
        Else
            SettingManID.Value = 0
            SettingDevID.Value = 0
            SettingHWVer.Value = 0
            SettingFWVer.Value = 0
        End If

        ' Registerblock 12 (Messintervall, Unixzeit, Messintervall Modus, Gesamtwirkleistung, Lesekopf-ID, Server-ID, Temperatur, Aktualisiert)
        Dim Block12() As UShort = Modbus_FC03(8244, 19)
        If Block12.Length = 19 Then
            SettingMeasInt.Value = Block12(0)
            SettingTimestamp.Value = (CType(Block12(1), ULong) << 48) Or (CType(Block12(2), ULong) << 32) Or (CType(Block12(3), UInteger) << 16) Or Block12(4)
            SettingMeasIntAuto.Checked = IIf(Block12(5), True, False)
            SettingAcPowCalc.Checked = IIf(Block12(6), True, False)
        Else
            SettingMeasInt.Value = 0
            SettingTimestamp.Value = 0
            SettingMeasIntAuto.Checked = False
            SettingAcPowCalc.Checked = False
        End If

        If (Block11.Length = 4) And (Block12.Length = 19) Then
            GroupSettingsParam.Enabled = True
            SettingWrite.Enabled = True
        Else
            GroupSettingsParam.Enabled = False
            SettingWrite.Enabled = False
        End If
    End Sub


    ' Sendet die geänderten Parameter zum Lesekopf
    Private Sub SettingSave_Click(sender As Object, e As EventArgs) Handles SettingWrite.Click
        GroupSettingsParam.Enabled = False
        SettingWrite.Enabled = False

        Dim timestamp As ULong = SettingTimestamp.Value
        Dim mask As UShort = UShort.MaxValue

        If ReadingHeadVersion.SelectedItem = "2.3.2" Then
            Dim Block11() As UShort = {SettingManID.Value, SettingDevID.Value, SettingHWVer.Value, SettingFWVer.Value}
            Modbus_FC16(8192, Block11)
            Dim Block12() As UShort = {SettingMeasInt.Value, timestamp >> 48, (timestamp >> 32) And mask, (timestamp >> 16) And mask, timestamp And mask, Convert.ToInt32(SettingMeasIntAuto.Checked), Convert.ToInt32(SettingAcPowCalc.Checked)}
            Modbus_FC16(8244, Block12)
        Else
            Dim buf() As UShort = {SettingManID.Value, SettingDevID.Value, SettingHWVer.Value}
            Modbus_FC16(8192, buf)
            buf = {SettingFWVer.Value}
            Modbus_FC16(8195, buf)
            buf = {SettingMeasInt.Value, SettingMeasInt.Value, timestamp >> 48}
            Modbus_FC16(8244, buf)
            buf = {(timestamp >> 32) And mask, (timestamp >> 16) And mask, timestamp And mask}
            Modbus_FC16(8247, buf)
            buf = {Convert.ToInt32(SettingMeasIntAuto.Checked), Convert.ToInt32(SettingAcPowCalc.Checked)}
            Modbus_FC16(8250, buf)
        End If
    End Sub





    '**********
    ' FUNKTIONEN FÜR DEN LOGGER
    '**********


    ' Fügt Ausgaben zum Logger hinzu und scrollt immer zur letzten Zeile
    Private Sub Logger(ByVal text As String)
        If LoggerOutput.TextLength Then
            LoggerOutput.AppendText(Environment.NewLine)
        End If
        LoggerOutput.AppendText(DateTime.Now.ToString() & ": " & text)

        LoggerOutput.SelectionStart = LoggerOutput.TextLength
        LoggerOutput.ScrollToCaret()
    End Sub


    ' Exportiert die Daten aus dem LOG in eine Textdatei
    Private Sub LoggerExport_Click(sender As Object, e As EventArgs) Handles LoggerExport.Click
        Dim saveFileDialog As New SaveFileDialog With {
            .Filter = "Textdateien (*.txt)|*.txt",
            .Title = "Inhalt der Konsole exportieren",
            .FileName = "LOG " & Replace(DateTime.Now.ToString(), ":", "-") & ".txt"
        }

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                File.WriteAllText(saveFileDialog.FileName, LoggerOutput.Text)

                Dim Result As DialogResult = MessageBox.Show("Der Inhalt der Konsole wurde erfolgreich in die Datei exportiert." & Environment.NewLine & Environment.NewLine & "Soll der Dateipfad geöffnet werden?", "Export erfolgreich", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If Result = DialogResult.Yes Then
                    Process.Start("explorer.exe", "/select, """ & saveFileDialog.FileName & """")
                End If
            Catch ex As Exception
                MessageBox.Show("Der Inhalt der Konsole konnte nicht in die Datei exportiert werden.", "Export fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    ' Leert den Logger
    Private Sub LoggerClear_Click(sender As Object, e As EventArgs) Handles LoggerClear.Click
        LoggerOutput.Clear()
    End Sub





    '**********
    ' FUNKTIONEN FÜR MODBUS
    '**********


    ' Ruft Holding Register vom Lesekopf ab
    Private Function Modbus_FC03(ByRef address As UShort, ByRef number As UShort)
        Dim Factory As New ModbusFactory
        Dim Master As IModbusMaster

        If TCPActive.Checked Then
            Master = Factory.CreateMaster(ModbusTCP)
        Else
            Master = Factory.CreateRtuMaster(ModbusRTU)
        End If

        Try
            Dim RegisterValues() As UShort = Master.ReadHoldingRegisters(ReadingHeadAddress.Value, address, number)
            Logger("FC03 ; Startregister: " & address & " ; Registeranzahl: " & number & " ; Daten: 0x" & String.Join(" 0x", RegisterValues.Select(Function(b) b.ToString("X4"))))
            Return RegisterValues
        Catch ex As Exception
            Logger("FC03 ; Startregister: " & address & " ; Registeranzahl: " & number & " ; Fehler: " & ex.Message)
        End Try

        Return New UShort(0) {&HFFFF}
    End Function


    ' Schreibt Holding Register vom Lesekopf
    Private Function Modbus_FC16(ByRef address As UShort, ByRef registers As UShort())
        Dim Factory As ModbusFactory = New ModbusFactory()
        Dim Master As IModbusMaster

        If TCPActive.Checked Then
            Master = Factory.CreateMaster(ModbusTCP)
        Else
            Master = Factory.CreateRtuMaster(ModbusRTU)
        End If

        Try
            Master.WriteMultipleRegisters(ReadingHeadAddress.Value, address, registers)
            Logger("FC16 ; Startregister: " & address & " ; Daten: 0x" & String.Join(" 0x", registers.Select(Function(b) b.ToString("X4"))))
            Return 0
        Catch ex As Exception
            Logger("FC16 ; Startregister: " & address & " ; Fehler: " & ex.Message)
        End Try

        Return -1
    End Function


    ' Berechnet die CRC Checksumme zur Modbus Kommunikation
    Private Function CalculateModbusCRC(ByVal data() As Byte, ByVal length As Integer) As UInt16
        Dim crc As UInt16 = &HFFFF
        For i As Integer = 0 To length - 1
            crc = crc Xor data(i)
            For j As Integer = 0 To 7
                If (crc And &H1) <> 0 Then
                    crc = (crc >> 1) Xor &HA001
                Else
                    crc >>= 1
                End If
            Next
        Next
        Return crc
    End Function
End Class
