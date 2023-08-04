<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.GroupConnection = New System.Windows.Forms.GroupBox()
        Me.TCPActive = New System.Windows.Forms.CheckBox()
        Me.ConnectionConnect = New System.Windows.Forms.Button()
        Me.GroupTCP = New System.Windows.Forms.GroupBox()
        Me.TCPPort = New System.Windows.Forms.NumericUpDown()
        Me.LabelTCPPort = New System.Windows.Forms.Label()
        Me.LabelTCPIP = New System.Windows.Forms.Label()
        Me.TCPIPAddress = New System.Windows.Forms.TextBox()
        Me.GroupReadingHead = New System.Windows.Forms.GroupBox()
        Me.ReadingHeadVersion = New System.Windows.Forms.ComboBox()
        Me.ReadingHeadAddress = New System.Windows.Forms.NumericUpDown()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelAddress = New System.Windows.Forms.Label()
        Me.GroupRTU = New System.Windows.Forms.GroupBox()
        Me.LabelTRUPort = New System.Windows.Forms.Label()
        Me.RTUPort = New System.Windows.Forms.ComboBox()
        Me.GroupSerial = New System.Windows.Forms.GroupBox()
        Me.LabelBaud = New System.Windows.Forms.Label()
        Me.LabelParity = New System.Windows.Forms.Label()
        Me.SerialBaud = New System.Windows.Forms.ComboBox()
        Me.SerialParity = New System.Windows.Forms.ComboBox()
        Me.SerialStopbits = New System.Windows.Forms.ComboBox()
        Me.LabelStopbits = New System.Windows.Forms.Label()
        Me.CommunicationManual = New System.Windows.Forms.Button()
        Me.CommunicationStart = New System.Windows.Forms.Button()
        Me.CommunicationIntervall = New System.Windows.Forms.NumericUpDown()
        Me.LabelInterval = New System.Windows.Forms.Label()
        Me.GroupActual = New System.Windows.Forms.GroupBox()
        Me.TableActual = New System.Windows.Forms.TableLayoutPanel()
        Me.Frequency = New System.Windows.Forms.TextBox()
        Me.AcPoPNSum = New System.Windows.Forms.TextBox()
        Me.AngL3L1 = New System.Windows.Forms.TextBox()
        Me.AngL2L1 = New System.Windows.Forms.TextBox()
        Me.PhShL3 = New System.Windows.Forms.TextBox()
        Me.PhShL2 = New System.Windows.Forms.TextBox()
        Me.PhShL1 = New System.Windows.Forms.TextBox()
        Me.VolL3 = New System.Windows.Forms.TextBox()
        Me.VolL2 = New System.Windows.Forms.TextBox()
        Me.VolL1 = New System.Windows.Forms.TextBox()
        Me.CurL3 = New System.Windows.Forms.TextBox()
        Me.CurL2 = New System.Windows.Forms.TextBox()
        Me.CurL1 = New System.Windows.Forms.TextBox()
        Me.PoFaSum = New System.Windows.Forms.TextBox()
        Me.PoFaL3 = New System.Windows.Forms.TextBox()
        Me.PoFaL2 = New System.Windows.Forms.TextBox()
        Me.PoFaL1 = New System.Windows.Forms.TextBox()
        Me.ApPoNSum = New System.Windows.Forms.TextBox()
        Me.ApPoNL3 = New System.Windows.Forms.TextBox()
        Me.ApPoNL2 = New System.Windows.Forms.TextBox()
        Me.ApPoNL1 = New System.Windows.Forms.TextBox()
        Me.ApPoPSum = New System.Windows.Forms.TextBox()
        Me.ApPoPL3 = New System.Windows.Forms.TextBox()
        Me.ApPoPL2 = New System.Windows.Forms.TextBox()
        Me.ApPoPL1 = New System.Windows.Forms.TextBox()
        Me.RePoNSum = New System.Windows.Forms.TextBox()
        Me.RePoNL3 = New System.Windows.Forms.TextBox()
        Me.RePoNL2 = New System.Windows.Forms.TextBox()
        Me.RePoNL1 = New System.Windows.Forms.TextBox()
        Me.RePoPSum = New System.Windows.Forms.TextBox()
        Me.RePoPL3 = New System.Windows.Forms.TextBox()
        Me.RePoPL2 = New System.Windows.Forms.TextBox()
        Me.RePoPL1 = New System.Windows.Forms.TextBox()
        Me.AcPoNSum = New System.Windows.Forms.TextBox()
        Me.AcPoNL3 = New System.Windows.Forms.TextBox()
        Me.AcPoNL2 = New System.Windows.Forms.TextBox()
        Me.AcPoNL1 = New System.Windows.Forms.TextBox()
        Me.AcPoPSum = New System.Windows.Forms.TextBox()
        Me.AcPoPL3 = New System.Windows.Forms.TextBox()
        Me.AcPoPL2 = New System.Windows.Forms.TextBox()
        Me.LabelAcPoP = New System.Windows.Forms.Label()
        Me.LabelSum = New System.Windows.Forms.Label()
        Me.LabelL3 = New System.Windows.Forms.Label()
        Me.LabelL2 = New System.Windows.Forms.Label()
        Me.LabelL1 = New System.Windows.Forms.Label()
        Me.LabelMeasurement = New System.Windows.Forms.Label()
        Me.LabelAcPoN = New System.Windows.Forms.Label()
        Me.LabelRePoP = New System.Windows.Forms.Label()
        Me.LabelRePoN = New System.Windows.Forms.Label()
        Me.LabelApPoP = New System.Windows.Forms.Label()
        Me.LabelApPoN = New System.Windows.Forms.Label()
        Me.LabelPoFa = New System.Windows.Forms.Label()
        Me.LabelCurrent = New System.Windows.Forms.Label()
        Me.LabelVoltage = New System.Windows.Forms.Label()
        Me.LabelPhSh = New System.Windows.Forms.Label()
        Me.LabelAnVol = New System.Windows.Forms.Label()
        Me.LabelAcPoPN = New System.Windows.Forms.Label()
        Me.LabelFreq = New System.Windows.Forms.Label()
        Me.LabelAngL1L1 = New System.Windows.Forms.Label()
        Me.LabelAcPoPNL1 = New System.Windows.Forms.Label()
        Me.LabelAcPoPNL2 = New System.Windows.Forms.Label()
        Me.LabelAcPoPNL3 = New System.Windows.Forms.Label()
        Me.LabelFreqL1 = New System.Windows.Forms.Label()
        Me.LabelFreqL3 = New System.Windows.Forms.Label()
        Me.LabelFreqL2 = New System.Windows.Forms.Label()
        Me.LabelAngSum = New System.Windows.Forms.Label()
        Me.LabelPhShSum = New System.Windows.Forms.Label()
        Me.LabelVoltageSum = New System.Windows.Forms.Label()
        Me.LabelCurSum = New System.Windows.Forms.Label()
        Me.AcPoPL1 = New System.Windows.Forms.TextBox()
        Me.GroupEnergy = New System.Windows.Forms.GroupBox()
        Me.TableEnergy = New System.Windows.Forms.TableLayoutPanel()
        Me.AcEnNT1 = New System.Windows.Forms.TextBox()
        Me.AcEnNT0 = New System.Windows.Forms.TextBox()
        Me.LabelMeasurementEn = New System.Windows.Forms.Label()
        Me.LabelTariff0 = New System.Windows.Forms.Label()
        Me.LabelTariff1 = New System.Windows.Forms.Label()
        Me.LabelTariff3 = New System.Windows.Forms.Label()
        Me.LabelAcEnPo = New System.Windows.Forms.Label()
        Me.AcEnPT2 = New System.Windows.Forms.TextBox()
        Me.AcEnPT0 = New System.Windows.Forms.TextBox()
        Me.AcEnPT1 = New System.Windows.Forms.TextBox()
        Me.AcEnNT2 = New System.Windows.Forms.TextBox()
        Me.LabelAcEnN = New System.Windows.Forms.Label()
        Me.GroupSettings = New System.Windows.Forms.GroupBox()
        Me.GroupSettingsParam = New System.Windows.Forms.GroupBox()
        Me.SettingAcPowCalc = New System.Windows.Forms.CheckBox()
        Me.SettingMeasIntAuto = New System.Windows.Forms.CheckBox()
        Me.SettingTimestamp = New System.Windows.Forms.NumericUpDown()
        Me.SettingMeasInt = New System.Windows.Forms.NumericUpDown()
        Me.LabelTimestamp = New System.Windows.Forms.Label()
        Me.SettingFWVer = New System.Windows.Forms.NumericUpDown()
        Me.LabelFWVer = New System.Windows.Forms.Label()
        Me.LabelMeasInt = New System.Windows.Forms.Label()
        Me.LabelHWVer = New System.Windows.Forms.Label()
        Me.LabelManufacturerID = New System.Windows.Forms.Label()
        Me.SettingHWVer = New System.Windows.Forms.NumericUpDown()
        Me.SettingManID = New System.Windows.Forms.NumericUpDown()
        Me.SettingDevID = New System.Windows.Forms.NumericUpDown()
        Me.LabelDeviceID = New System.Windows.Forms.Label()
        Me.SettingWrite = New System.Windows.Forms.Button()
        Me.SettingRead = New System.Windows.Forms.Button()
        Me.GroupPin = New System.Windows.Forms.GroupBox()
        Me.PinProgress = New System.Windows.Forms.ProgressBar()
        Me.PINNumber = New System.Windows.Forms.NumericUpDown()
        Me.PINSend = New System.Windows.Forms.Button()
        Me.GroupExtra = New System.Windows.Forms.GroupBox()
        Me.ReadingHeadTimestamp = New System.Windows.Forms.Label()
        Me.LabelTimestamp2 = New System.Windows.Forms.Label()
        Me.ReadingHeadData = New System.Windows.Forms.Label()
        Me.LabelData = New System.Windows.Forms.Label()
        Me.ReadingHeadTemperature = New System.Windows.Forms.Label()
        Me.LabelTemperature = New System.Windows.Forms.Label()
        Me.ServerID = New System.Windows.Forms.Label()
        Me.LabelServerID = New System.Windows.Forms.Label()
        Me.ReadingHeadID = New System.Windows.Forms.Label()
        Me.LabelReadingHeadID = New System.Windows.Forms.Label()
        Me.GroupLog = New System.Windows.Forms.GroupBox()
        Me.LogFileOpen = New System.Windows.Forms.Button()
        Me.LogActive = New System.Windows.Forms.CheckBox()
        Me.LogSearchPath = New System.Windows.Forms.Button()
        Me.LabelPath = New System.Windows.Forms.Label()
        Me.LogFilePath = New System.Windows.Forms.TextBox()
        Me.GroupLogger = New System.Windows.Forms.GroupBox()
        Me.LoggerExport = New System.Windows.Forms.Button()
        Me.LoggerClear = New System.Windows.Forms.Button()
        Me.LoggerOutput = New System.Windows.Forms.TextBox()
        Me.LinkLabelAuthor = New System.Windows.Forms.LinkLabel()
        Me.LabelVer = New System.Windows.Forms.Label()
        Me.ComInt = New System.Windows.Forms.Timer(Me.components)
        Me.PinWait = New System.Windows.Forms.Timer(Me.components)
        Me.GroupCommunication = New System.Windows.Forms.GroupBox()
        Me.CommunicationProgress = New System.Windows.Forms.ProgressBar()
        Me.LinkLabelHelp = New System.Windows.Forms.LinkLabel()
        Me.GroupConnection.SuspendLayout()
        Me.GroupTCP.SuspendLayout()
        CType(Me.TCPPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupReadingHead.SuspendLayout()
        CType(Me.ReadingHeadAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupRTU.SuspendLayout()
        Me.GroupSerial.SuspendLayout()
        CType(Me.CommunicationIntervall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupActual.SuspendLayout()
        Me.TableActual.SuspendLayout()
        Me.GroupEnergy.SuspendLayout()
        Me.TableEnergy.SuspendLayout()
        Me.GroupSettings.SuspendLayout()
        Me.GroupSettingsParam.SuspendLayout()
        CType(Me.SettingTimestamp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SettingMeasInt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SettingFWVer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SettingHWVer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SettingManID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SettingDevID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPin.SuspendLayout()
        CType(Me.PINNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupExtra.SuspendLayout()
        Me.GroupLog.SuspendLayout()
        Me.GroupLogger.SuspendLayout()
        Me.GroupCommunication.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupConnection
        '
        Me.GroupConnection.Controls.Add(Me.TCPActive)
        Me.GroupConnection.Controls.Add(Me.ConnectionConnect)
        Me.GroupConnection.Controls.Add(Me.GroupTCP)
        Me.GroupConnection.Controls.Add(Me.GroupReadingHead)
        Me.GroupConnection.Controls.Add(Me.GroupRTU)
        Me.GroupConnection.Controls.Add(Me.GroupSerial)
        Me.GroupConnection.Location = New System.Drawing.Point(12, 12)
        Me.GroupConnection.Name = "GroupConnection"
        Me.GroupConnection.Size = New System.Drawing.Size(365, 138)
        Me.GroupConnection.TabIndex = 0
        Me.GroupConnection.TabStop = False
        Me.GroupConnection.Text = "Verbindung"
        '
        'TCPActive
        '
        Me.TCPActive.AutoSize = True
        Me.TCPActive.Location = New System.Drawing.Point(6, 90)
        Me.TCPActive.Name = "TCPActive"
        Me.TCPActive.Size = New System.Drawing.Size(73, 17)
        Me.TCPActive.TabIndex = 4
        Me.TCPActive.Text = "TCP aktiv"
        Me.TCPActive.UseVisualStyleBackColor = True
        '
        'ConnectionConnect
        '
        Me.ConnectionConnect.Location = New System.Drawing.Point(6, 109)
        Me.ConnectionConnect.Name = "ConnectionConnect"
        Me.ConnectionConnect.Size = New System.Drawing.Size(113, 23)
        Me.ConnectionConnect.TabIndex = 3
        Me.ConnectionConnect.Text = "Verbinden"
        Me.ConnectionConnect.UseVisualStyleBackColor = True
        '
        'GroupTCP
        '
        Me.GroupTCP.Controls.Add(Me.TCPPort)
        Me.GroupTCP.Controls.Add(Me.LabelTCPPort)
        Me.GroupTCP.Controls.Add(Me.LabelTCPIP)
        Me.GroupTCP.Controls.Add(Me.TCPIPAddress)
        Me.GroupTCP.Enabled = False
        Me.GroupTCP.Location = New System.Drawing.Point(6, 19)
        Me.GroupTCP.Name = "GroupTCP"
        Me.GroupTCP.Size = New System.Drawing.Size(113, 65)
        Me.GroupTCP.TabIndex = 8
        Me.GroupTCP.TabStop = False
        Me.GroupTCP.Text = "Modbus TCP"
        '
        'TCPPort
        '
        Me.TCPPort.Location = New System.Drawing.Point(40, 39)
        Me.TCPPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.TCPPort.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TCPPort.Name = "TCPPort"
        Me.TCPPort.Size = New System.Drawing.Size(67, 20)
        Me.TCPPort.TabIndex = 14
        Me.TCPPort.Value = New Decimal(New Integer() {502, 0, 0, 0})
        '
        'LabelTCPPort
        '
        Me.LabelTCPPort.AutoSize = True
        Me.LabelTCPPort.Location = New System.Drawing.Point(8, 41)
        Me.LabelTCPPort.Name = "LabelTCPPort"
        Me.LabelTCPPort.Size = New System.Drawing.Size(26, 13)
        Me.LabelTCPPort.TabIndex = 2
        Me.LabelTCPPort.Text = "Port"
        '
        'LabelTCPIP
        '
        Me.LabelTCPIP.AutoSize = True
        Me.LabelTCPIP.Location = New System.Drawing.Point(6, 16)
        Me.LabelTCPIP.Name = "LabelTCPIP"
        Me.LabelTCPIP.Size = New System.Drawing.Size(17, 13)
        Me.LabelTCPIP.TabIndex = 1
        Me.LabelTCPIP.Text = "IP"
        '
        'TCPIPAddress
        '
        Me.TCPIPAddress.Location = New System.Drawing.Point(29, 13)
        Me.TCPIPAddress.Name = "TCPIPAddress"
        Me.TCPIPAddress.Size = New System.Drawing.Size(78, 20)
        Me.TCPIPAddress.TabIndex = 0
        '
        'GroupReadingHead
        '
        Me.GroupReadingHead.Controls.Add(Me.ReadingHeadVersion)
        Me.GroupReadingHead.Controls.Add(Me.ReadingHeadAddress)
        Me.GroupReadingHead.Controls.Add(Me.LabelVersion)
        Me.GroupReadingHead.Controls.Add(Me.LabelAddress)
        Me.GroupReadingHead.Location = New System.Drawing.Point(125, 65)
        Me.GroupReadingHead.Name = "GroupReadingHead"
        Me.GroupReadingHead.Size = New System.Drawing.Size(113, 67)
        Me.GroupReadingHead.TabIndex = 4
        Me.GroupReadingHead.TabStop = False
        Me.GroupReadingHead.Text = "Lesekopf"
        '
        'ReadingHeadVersion
        '
        Me.ReadingHeadVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ReadingHeadVersion.FormattingEnabled = True
        Me.ReadingHeadVersion.Items.AddRange(New Object() {"2.3.0"})
        Me.ReadingHeadVersion.Location = New System.Drawing.Point(57, 40)
        Me.ReadingHeadVersion.Name = "ReadingHeadVersion"
        Me.ReadingHeadVersion.Size = New System.Drawing.Size(50, 21)
        Me.ReadingHeadVersion.TabIndex = 4
        '
        'ReadingHeadAddress
        '
        Me.ReadingHeadAddress.Location = New System.Drawing.Point(57, 14)
        Me.ReadingHeadAddress.Maximum = New Decimal(New Integer() {247, 0, 0, 0})
        Me.ReadingHeadAddress.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ReadingHeadAddress.Name = "ReadingHeadAddress"
        Me.ReadingHeadAddress.Size = New System.Drawing.Size(50, 20)
        Me.ReadingHeadAddress.TabIndex = 3
        Me.ReadingHeadAddress.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Location = New System.Drawing.Point(6, 45)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(46, 13)
        Me.LabelVersion.TabIndex = 1
        Me.LabelVersion.Text = "Ver. FW"
        '
        'LabelAddress
        '
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.Location = New System.Drawing.Point(6, 16)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(45, 13)
        Me.LabelAddress.TabIndex = 0
        Me.LabelAddress.Text = "Adresse"
        '
        'GroupRTU
        '
        Me.GroupRTU.Controls.Add(Me.LabelTRUPort)
        Me.GroupRTU.Controls.Add(Me.RTUPort)
        Me.GroupRTU.Location = New System.Drawing.Point(125, 19)
        Me.GroupRTU.Name = "GroupRTU"
        Me.GroupRTU.Size = New System.Drawing.Size(113, 40)
        Me.GroupRTU.TabIndex = 3
        Me.GroupRTU.TabStop = False
        Me.GroupRTU.Text = "Modbus RTU"
        '
        'LabelTRUPort
        '
        Me.LabelTRUPort.AutoSize = True
        Me.LabelTRUPort.Location = New System.Drawing.Point(12, 16)
        Me.LabelTRUPort.Name = "LabelTRUPort"
        Me.LabelTRUPort.Size = New System.Drawing.Size(26, 13)
        Me.LabelTRUPort.TabIndex = 1
        Me.LabelTRUPort.Text = "Port"
        '
        'RTUPort
        '
        Me.RTUPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RTUPort.FormattingEnabled = True
        Me.RTUPort.Location = New System.Drawing.Point(44, 13)
        Me.RTUPort.Name = "RTUPort"
        Me.RTUPort.Size = New System.Drawing.Size(63, 21)
        Me.RTUPort.TabIndex = 0
        '
        'GroupSerial
        '
        Me.GroupSerial.Controls.Add(Me.LabelBaud)
        Me.GroupSerial.Controls.Add(Me.LabelParity)
        Me.GroupSerial.Controls.Add(Me.SerialBaud)
        Me.GroupSerial.Controls.Add(Me.SerialParity)
        Me.GroupSerial.Controls.Add(Me.SerialStopbits)
        Me.GroupSerial.Controls.Add(Me.LabelStopbits)
        Me.GroupSerial.Location = New System.Drawing.Point(244, 19)
        Me.GroupSerial.Name = "GroupSerial"
        Me.GroupSerial.Size = New System.Drawing.Size(115, 113)
        Me.GroupSerial.TabIndex = 5
        Me.GroupSerial.TabStop = False
        Me.GroupSerial.Text = "Seriell"
        '
        'LabelBaud
        '
        Me.LabelBaud.AutoSize = True
        Me.LabelBaud.Location = New System.Drawing.Point(6, 71)
        Me.LabelBaud.Name = "LabelBaud"
        Me.LabelBaud.Size = New System.Drawing.Size(32, 13)
        Me.LabelBaud.TabIndex = 5
        Me.LabelBaud.Text = "Baud"
        '
        'LabelParity
        '
        Me.LabelParity.AutoSize = True
        Me.LabelParity.Location = New System.Drawing.Point(6, 44)
        Me.LabelParity.Name = "LabelParity"
        Me.LabelParity.Size = New System.Drawing.Size(37, 13)
        Me.LabelParity.TabIndex = 3
        Me.LabelParity.Text = "Parität"
        '
        'SerialBaud
        '
        Me.SerialBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SerialBaud.FormattingEnabled = True
        Me.SerialBaud.Items.AddRange(New Object() {"9600", "19200", "38400"})
        Me.SerialBaud.Location = New System.Drawing.Point(44, 68)
        Me.SerialBaud.Name = "SerialBaud"
        Me.SerialBaud.Size = New System.Drawing.Size(65, 21)
        Me.SerialBaud.TabIndex = 4
        '
        'SerialParity
        '
        Me.SerialParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SerialParity.FormattingEnabled = True
        Me.SerialParity.Items.AddRange(New Object() {"None", "Even", "Odd"})
        Me.SerialParity.Location = New System.Drawing.Point(49, 41)
        Me.SerialParity.Name = "SerialParity"
        Me.SerialParity.Size = New System.Drawing.Size(60, 21)
        Me.SerialParity.TabIndex = 2
        '
        'SerialStopbits
        '
        Me.SerialStopbits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SerialStopbits.FormattingEnabled = True
        Me.SerialStopbits.Items.AddRange(New Object() {"1", "2"})
        Me.SerialStopbits.Location = New System.Drawing.Point(58, 13)
        Me.SerialStopbits.Name = "SerialStopbits"
        Me.SerialStopbits.Size = New System.Drawing.Size(51, 21)
        Me.SerialStopbits.TabIndex = 1
        '
        'LabelStopbits
        '
        Me.LabelStopbits.AutoSize = True
        Me.LabelStopbits.Location = New System.Drawing.Point(6, 16)
        Me.LabelStopbits.Name = "LabelStopbits"
        Me.LabelStopbits.Size = New System.Drawing.Size(46, 13)
        Me.LabelStopbits.TabIndex = 0
        Me.LabelStopbits.Text = "Stoppbit"
        '
        'CommunicationManual
        '
        Me.CommunicationManual.Location = New System.Drawing.Point(178, 14)
        Me.CommunicationManual.Name = "CommunicationManual"
        Me.CommunicationManual.Size = New System.Drawing.Size(59, 20)
        Me.CommunicationManual.TabIndex = 9
        Me.CommunicationManual.Text = "Manuell"
        Me.CommunicationManual.UseVisualStyleBackColor = True
        '
        'CommunicationStart
        '
        Me.CommunicationStart.Location = New System.Drawing.Point(114, 14)
        Me.CommunicationStart.Name = "CommunicationStart"
        Me.CommunicationStart.Size = New System.Drawing.Size(57, 20)
        Me.CommunicationStart.TabIndex = 8
        Me.CommunicationStart.Text = "Starten"
        Me.CommunicationStart.UseVisualStyleBackColor = True
        '
        'CommunicationIntervall
        '
        Me.CommunicationIntervall.Location = New System.Drawing.Point(70, 14)
        Me.CommunicationIntervall.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.CommunicationIntervall.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.CommunicationIntervall.Name = "CommunicationIntervall"
        Me.CommunicationIntervall.Size = New System.Drawing.Size(39, 20)
        Me.CommunicationIntervall.TabIndex = 7
        Me.CommunicationIntervall.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'LabelInterval
        '
        Me.LabelInterval.AutoSize = True
        Me.LabelInterval.Location = New System.Drawing.Point(6, 16)
        Me.LabelInterval.Name = "LabelInterval"
        Me.LabelInterval.Size = New System.Drawing.Size(58, 13)
        Me.LabelInterval.TabIndex = 6
        Me.LabelInterval.Text = "Intervall [s]"
        '
        'GroupActual
        '
        Me.GroupActual.Controls.Add(Me.TableActual)
        Me.GroupActual.Location = New System.Drawing.Point(12, 156)
        Me.GroupActual.Name = "GroupActual"
        Me.GroupActual.Size = New System.Drawing.Size(365, 348)
        Me.GroupActual.TabIndex = 1
        Me.GroupActual.TabStop = False
        Me.GroupActual.Text = "Momentanwerte"
        '
        'TableActual
        '
        Me.TableActual.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.TableActual.ColumnCount = 5
        Me.TableActual.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableActual.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableActual.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableActual.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableActual.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableActual.Controls.Add(Me.Frequency, 4, 13)
        Me.TableActual.Controls.Add(Me.AcPoPNSum, 4, 12)
        Me.TableActual.Controls.Add(Me.AngL3L1, 3, 11)
        Me.TableActual.Controls.Add(Me.AngL2L1, 2, 11)
        Me.TableActual.Controls.Add(Me.PhShL3, 3, 10)
        Me.TableActual.Controls.Add(Me.PhShL2, 2, 10)
        Me.TableActual.Controls.Add(Me.PhShL1, 1, 10)
        Me.TableActual.Controls.Add(Me.VolL3, 3, 9)
        Me.TableActual.Controls.Add(Me.VolL2, 2, 9)
        Me.TableActual.Controls.Add(Me.VolL1, 1, 9)
        Me.TableActual.Controls.Add(Me.CurL3, 3, 8)
        Me.TableActual.Controls.Add(Me.CurL2, 2, 8)
        Me.TableActual.Controls.Add(Me.CurL1, 1, 8)
        Me.TableActual.Controls.Add(Me.PoFaSum, 4, 7)
        Me.TableActual.Controls.Add(Me.PoFaL3, 3, 7)
        Me.TableActual.Controls.Add(Me.PoFaL2, 2, 7)
        Me.TableActual.Controls.Add(Me.PoFaL1, 1, 7)
        Me.TableActual.Controls.Add(Me.ApPoNSum, 4, 6)
        Me.TableActual.Controls.Add(Me.ApPoNL3, 3, 6)
        Me.TableActual.Controls.Add(Me.ApPoNL2, 2, 6)
        Me.TableActual.Controls.Add(Me.ApPoNL1, 1, 6)
        Me.TableActual.Controls.Add(Me.ApPoPSum, 4, 5)
        Me.TableActual.Controls.Add(Me.ApPoPL3, 3, 5)
        Me.TableActual.Controls.Add(Me.ApPoPL2, 2, 5)
        Me.TableActual.Controls.Add(Me.ApPoPL1, 1, 5)
        Me.TableActual.Controls.Add(Me.RePoNSum, 4, 4)
        Me.TableActual.Controls.Add(Me.RePoNL3, 3, 4)
        Me.TableActual.Controls.Add(Me.RePoNL2, 2, 4)
        Me.TableActual.Controls.Add(Me.RePoNL1, 1, 4)
        Me.TableActual.Controls.Add(Me.RePoPSum, 4, 3)
        Me.TableActual.Controls.Add(Me.RePoPL3, 3, 3)
        Me.TableActual.Controls.Add(Me.RePoPL2, 2, 3)
        Me.TableActual.Controls.Add(Me.RePoPL1, 1, 3)
        Me.TableActual.Controls.Add(Me.AcPoNSum, 4, 2)
        Me.TableActual.Controls.Add(Me.AcPoNL3, 3, 2)
        Me.TableActual.Controls.Add(Me.AcPoNL2, 2, 2)
        Me.TableActual.Controls.Add(Me.AcPoNL1, 1, 2)
        Me.TableActual.Controls.Add(Me.AcPoPSum, 4, 1)
        Me.TableActual.Controls.Add(Me.AcPoPL3, 3, 1)
        Me.TableActual.Controls.Add(Me.AcPoPL2, 2, 1)
        Me.TableActual.Controls.Add(Me.LabelAcPoP, 0, 1)
        Me.TableActual.Controls.Add(Me.LabelSum, 4, 0)
        Me.TableActual.Controls.Add(Me.LabelL3, 3, 0)
        Me.TableActual.Controls.Add(Me.LabelL2, 2, 0)
        Me.TableActual.Controls.Add(Me.LabelL1, 1, 0)
        Me.TableActual.Controls.Add(Me.LabelMeasurement, 0, 0)
        Me.TableActual.Controls.Add(Me.LabelAcPoN, 0, 2)
        Me.TableActual.Controls.Add(Me.LabelRePoP, 0, 3)
        Me.TableActual.Controls.Add(Me.LabelRePoN, 0, 4)
        Me.TableActual.Controls.Add(Me.LabelApPoP, 0, 5)
        Me.TableActual.Controls.Add(Me.LabelApPoN, 0, 6)
        Me.TableActual.Controls.Add(Me.LabelPoFa, 0, 7)
        Me.TableActual.Controls.Add(Me.LabelCurrent, 0, 8)
        Me.TableActual.Controls.Add(Me.LabelVoltage, 0, 9)
        Me.TableActual.Controls.Add(Me.LabelPhSh, 0, 10)
        Me.TableActual.Controls.Add(Me.LabelAnVol, 0, 11)
        Me.TableActual.Controls.Add(Me.LabelAcPoPN, 0, 12)
        Me.TableActual.Controls.Add(Me.LabelFreq, 0, 13)
        Me.TableActual.Controls.Add(Me.LabelAngL1L1, 1, 11)
        Me.TableActual.Controls.Add(Me.LabelAcPoPNL1, 1, 12)
        Me.TableActual.Controls.Add(Me.LabelAcPoPNL2, 2, 12)
        Me.TableActual.Controls.Add(Me.LabelAcPoPNL3, 3, 12)
        Me.TableActual.Controls.Add(Me.LabelFreqL1, 1, 13)
        Me.TableActual.Controls.Add(Me.LabelFreqL3, 3, 13)
        Me.TableActual.Controls.Add(Me.LabelFreqL2, 2, 13)
        Me.TableActual.Controls.Add(Me.LabelAngSum, 4, 11)
        Me.TableActual.Controls.Add(Me.LabelPhShSum, 4, 10)
        Me.TableActual.Controls.Add(Me.LabelVoltageSum, 4, 9)
        Me.TableActual.Controls.Add(Me.LabelCurSum, 4, 8)
        Me.TableActual.Controls.Add(Me.AcPoPL1, 1, 1)
        Me.TableActual.Location = New System.Drawing.Point(6, 19)
        Me.TableActual.Name = "TableActual"
        Me.TableActual.RowCount = 14
        Me.TableActual.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.TableActual.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableActual.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableActual.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableActual.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableActual.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableActual.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableActual.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableActual.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableActual.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableActual.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableActual.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableActual.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableActual.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableActual.Size = New System.Drawing.Size(353, 323)
        Me.TableActual.TabIndex = 2
        '
        'Frequency
        '
        Me.Frequency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Frequency.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frequency.Location = New System.Drawing.Point(299, 294)
        Me.Frequency.Margin = New System.Windows.Forms.Padding(0)
        Me.Frequency.Name = "Frequency"
        Me.Frequency.ReadOnly = True
        Me.Frequency.Size = New System.Drawing.Size(52, 20)
        Me.Frequency.TabIndex = 68
        Me.Frequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AcPoPNSum
        '
        Me.AcPoPNSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AcPoPNSum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcPoPNSum.Location = New System.Drawing.Point(299, 272)
        Me.AcPoPNSum.Margin = New System.Windows.Forms.Padding(0)
        Me.AcPoPNSum.Name = "AcPoPNSum"
        Me.AcPoPNSum.ReadOnly = True
        Me.AcPoPNSum.Size = New System.Drawing.Size(52, 20)
        Me.AcPoPNSum.TabIndex = 67
        Me.AcPoPNSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AngL3L1
        '
        Me.AngL3L1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AngL3L1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AngL3L1.Location = New System.Drawing.Point(246, 250)
        Me.AngL3L1.Margin = New System.Windows.Forms.Padding(0)
        Me.AngL3L1.Name = "AngL3L1"
        Me.AngL3L1.ReadOnly = True
        Me.AngL3L1.Size = New System.Drawing.Size(51, 20)
        Me.AngL3L1.TabIndex = 66
        Me.AngL3L1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AngL2L1
        '
        Me.AngL2L1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AngL2L1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AngL2L1.Location = New System.Drawing.Point(193, 250)
        Me.AngL2L1.Margin = New System.Windows.Forms.Padding(0)
        Me.AngL2L1.Name = "AngL2L1"
        Me.AngL2L1.ReadOnly = True
        Me.AngL2L1.Size = New System.Drawing.Size(51, 20)
        Me.AngL2L1.TabIndex = 65
        Me.AngL2L1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PhShL3
        '
        Me.PhShL3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PhShL3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PhShL3.Location = New System.Drawing.Point(246, 228)
        Me.PhShL3.Margin = New System.Windows.Forms.Padding(0)
        Me.PhShL3.Name = "PhShL3"
        Me.PhShL3.ReadOnly = True
        Me.PhShL3.Size = New System.Drawing.Size(51, 20)
        Me.PhShL3.TabIndex = 64
        Me.PhShL3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PhShL2
        '
        Me.PhShL2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PhShL2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PhShL2.Location = New System.Drawing.Point(193, 228)
        Me.PhShL2.Margin = New System.Windows.Forms.Padding(0)
        Me.PhShL2.Name = "PhShL2"
        Me.PhShL2.ReadOnly = True
        Me.PhShL2.Size = New System.Drawing.Size(51, 20)
        Me.PhShL2.TabIndex = 63
        Me.PhShL2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PhShL1
        '
        Me.PhShL1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PhShL1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PhShL1.Location = New System.Drawing.Point(140, 228)
        Me.PhShL1.Margin = New System.Windows.Forms.Padding(0)
        Me.PhShL1.Name = "PhShL1"
        Me.PhShL1.ReadOnly = True
        Me.PhShL1.Size = New System.Drawing.Size(51, 20)
        Me.PhShL1.TabIndex = 62
        Me.PhShL1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VolL3
        '
        Me.VolL3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VolL3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VolL3.Location = New System.Drawing.Point(246, 206)
        Me.VolL3.Margin = New System.Windows.Forms.Padding(0)
        Me.VolL3.Name = "VolL3"
        Me.VolL3.ReadOnly = True
        Me.VolL3.Size = New System.Drawing.Size(51, 20)
        Me.VolL3.TabIndex = 61
        Me.VolL3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VolL2
        '
        Me.VolL2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VolL2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VolL2.Location = New System.Drawing.Point(193, 206)
        Me.VolL2.Margin = New System.Windows.Forms.Padding(0)
        Me.VolL2.Name = "VolL2"
        Me.VolL2.ReadOnly = True
        Me.VolL2.Size = New System.Drawing.Size(51, 20)
        Me.VolL2.TabIndex = 60
        Me.VolL2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VolL1
        '
        Me.VolL1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VolL1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VolL1.Location = New System.Drawing.Point(140, 206)
        Me.VolL1.Margin = New System.Windows.Forms.Padding(0)
        Me.VolL1.Name = "VolL1"
        Me.VolL1.ReadOnly = True
        Me.VolL1.Size = New System.Drawing.Size(51, 20)
        Me.VolL1.TabIndex = 59
        Me.VolL1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CurL3
        '
        Me.CurL3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CurL3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CurL3.Location = New System.Drawing.Point(246, 184)
        Me.CurL3.Margin = New System.Windows.Forms.Padding(0)
        Me.CurL3.Name = "CurL3"
        Me.CurL3.ReadOnly = True
        Me.CurL3.Size = New System.Drawing.Size(51, 20)
        Me.CurL3.TabIndex = 58
        Me.CurL3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CurL2
        '
        Me.CurL2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CurL2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CurL2.Location = New System.Drawing.Point(193, 184)
        Me.CurL2.Margin = New System.Windows.Forms.Padding(0)
        Me.CurL2.Name = "CurL2"
        Me.CurL2.ReadOnly = True
        Me.CurL2.Size = New System.Drawing.Size(51, 20)
        Me.CurL2.TabIndex = 57
        Me.CurL2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CurL1
        '
        Me.CurL1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CurL1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CurL1.Location = New System.Drawing.Point(140, 184)
        Me.CurL1.Margin = New System.Windows.Forms.Padding(0)
        Me.CurL1.Name = "CurL1"
        Me.CurL1.ReadOnly = True
        Me.CurL1.Size = New System.Drawing.Size(51, 20)
        Me.CurL1.TabIndex = 56
        Me.CurL1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PoFaSum
        '
        Me.PoFaSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PoFaSum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PoFaSum.Location = New System.Drawing.Point(299, 162)
        Me.PoFaSum.Margin = New System.Windows.Forms.Padding(0)
        Me.PoFaSum.Name = "PoFaSum"
        Me.PoFaSum.ReadOnly = True
        Me.PoFaSum.Size = New System.Drawing.Size(52, 20)
        Me.PoFaSum.TabIndex = 55
        Me.PoFaSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PoFaL3
        '
        Me.PoFaL3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PoFaL3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PoFaL3.Location = New System.Drawing.Point(246, 162)
        Me.PoFaL3.Margin = New System.Windows.Forms.Padding(0)
        Me.PoFaL3.Name = "PoFaL3"
        Me.PoFaL3.ReadOnly = True
        Me.PoFaL3.Size = New System.Drawing.Size(51, 20)
        Me.PoFaL3.TabIndex = 54
        Me.PoFaL3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PoFaL2
        '
        Me.PoFaL2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PoFaL2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PoFaL2.Location = New System.Drawing.Point(193, 162)
        Me.PoFaL2.Margin = New System.Windows.Forms.Padding(0)
        Me.PoFaL2.Name = "PoFaL2"
        Me.PoFaL2.ReadOnly = True
        Me.PoFaL2.Size = New System.Drawing.Size(51, 20)
        Me.PoFaL2.TabIndex = 53
        Me.PoFaL2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PoFaL1
        '
        Me.PoFaL1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PoFaL1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PoFaL1.Location = New System.Drawing.Point(140, 162)
        Me.PoFaL1.Margin = New System.Windows.Forms.Padding(0)
        Me.PoFaL1.Name = "PoFaL1"
        Me.PoFaL1.ReadOnly = True
        Me.PoFaL1.Size = New System.Drawing.Size(51, 20)
        Me.PoFaL1.TabIndex = 52
        Me.PoFaL1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ApPoNSum
        '
        Me.ApPoNSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ApPoNSum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ApPoNSum.Location = New System.Drawing.Point(299, 140)
        Me.ApPoNSum.Margin = New System.Windows.Forms.Padding(0)
        Me.ApPoNSum.Name = "ApPoNSum"
        Me.ApPoNSum.ReadOnly = True
        Me.ApPoNSum.Size = New System.Drawing.Size(52, 20)
        Me.ApPoNSum.TabIndex = 51
        Me.ApPoNSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ApPoNL3
        '
        Me.ApPoNL3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ApPoNL3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ApPoNL3.Location = New System.Drawing.Point(246, 140)
        Me.ApPoNL3.Margin = New System.Windows.Forms.Padding(0)
        Me.ApPoNL3.Name = "ApPoNL3"
        Me.ApPoNL3.ReadOnly = True
        Me.ApPoNL3.Size = New System.Drawing.Size(51, 20)
        Me.ApPoNL3.TabIndex = 50
        Me.ApPoNL3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ApPoNL2
        '
        Me.ApPoNL2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ApPoNL2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ApPoNL2.Location = New System.Drawing.Point(193, 140)
        Me.ApPoNL2.Margin = New System.Windows.Forms.Padding(0)
        Me.ApPoNL2.Name = "ApPoNL2"
        Me.ApPoNL2.ReadOnly = True
        Me.ApPoNL2.Size = New System.Drawing.Size(51, 20)
        Me.ApPoNL2.TabIndex = 49
        Me.ApPoNL2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ApPoNL1
        '
        Me.ApPoNL1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ApPoNL1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ApPoNL1.Location = New System.Drawing.Point(140, 140)
        Me.ApPoNL1.Margin = New System.Windows.Forms.Padding(0)
        Me.ApPoNL1.Name = "ApPoNL1"
        Me.ApPoNL1.ReadOnly = True
        Me.ApPoNL1.Size = New System.Drawing.Size(51, 20)
        Me.ApPoNL1.TabIndex = 48
        Me.ApPoNL1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ApPoPSum
        '
        Me.ApPoPSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ApPoPSum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ApPoPSum.Location = New System.Drawing.Point(299, 118)
        Me.ApPoPSum.Margin = New System.Windows.Forms.Padding(0)
        Me.ApPoPSum.Name = "ApPoPSum"
        Me.ApPoPSum.ReadOnly = True
        Me.ApPoPSum.Size = New System.Drawing.Size(52, 20)
        Me.ApPoPSum.TabIndex = 47
        Me.ApPoPSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ApPoPL3
        '
        Me.ApPoPL3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ApPoPL3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ApPoPL3.Location = New System.Drawing.Point(246, 118)
        Me.ApPoPL3.Margin = New System.Windows.Forms.Padding(0)
        Me.ApPoPL3.Name = "ApPoPL3"
        Me.ApPoPL3.ReadOnly = True
        Me.ApPoPL3.Size = New System.Drawing.Size(51, 20)
        Me.ApPoPL3.TabIndex = 46
        Me.ApPoPL3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ApPoPL2
        '
        Me.ApPoPL2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ApPoPL2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ApPoPL2.Location = New System.Drawing.Point(193, 118)
        Me.ApPoPL2.Margin = New System.Windows.Forms.Padding(0)
        Me.ApPoPL2.Name = "ApPoPL2"
        Me.ApPoPL2.ReadOnly = True
        Me.ApPoPL2.Size = New System.Drawing.Size(51, 20)
        Me.ApPoPL2.TabIndex = 45
        Me.ApPoPL2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ApPoPL1
        '
        Me.ApPoPL1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ApPoPL1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ApPoPL1.Location = New System.Drawing.Point(140, 118)
        Me.ApPoPL1.Margin = New System.Windows.Forms.Padding(0)
        Me.ApPoPL1.Name = "ApPoPL1"
        Me.ApPoPL1.ReadOnly = True
        Me.ApPoPL1.Size = New System.Drawing.Size(51, 20)
        Me.ApPoPL1.TabIndex = 44
        Me.ApPoPL1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RePoNSum
        '
        Me.RePoNSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RePoNSum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RePoNSum.Location = New System.Drawing.Point(299, 96)
        Me.RePoNSum.Margin = New System.Windows.Forms.Padding(0)
        Me.RePoNSum.Name = "RePoNSum"
        Me.RePoNSum.ReadOnly = True
        Me.RePoNSum.Size = New System.Drawing.Size(52, 20)
        Me.RePoNSum.TabIndex = 43
        Me.RePoNSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RePoNL3
        '
        Me.RePoNL3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RePoNL3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RePoNL3.Location = New System.Drawing.Point(246, 96)
        Me.RePoNL3.Margin = New System.Windows.Forms.Padding(0)
        Me.RePoNL3.Name = "RePoNL3"
        Me.RePoNL3.ReadOnly = True
        Me.RePoNL3.Size = New System.Drawing.Size(51, 20)
        Me.RePoNL3.TabIndex = 42
        Me.RePoNL3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RePoNL2
        '
        Me.RePoNL2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RePoNL2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RePoNL2.Location = New System.Drawing.Point(193, 96)
        Me.RePoNL2.Margin = New System.Windows.Forms.Padding(0)
        Me.RePoNL2.Name = "RePoNL2"
        Me.RePoNL2.ReadOnly = True
        Me.RePoNL2.Size = New System.Drawing.Size(51, 20)
        Me.RePoNL2.TabIndex = 41
        Me.RePoNL2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RePoNL1
        '
        Me.RePoNL1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RePoNL1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RePoNL1.Location = New System.Drawing.Point(140, 96)
        Me.RePoNL1.Margin = New System.Windows.Forms.Padding(0)
        Me.RePoNL1.Name = "RePoNL1"
        Me.RePoNL1.ReadOnly = True
        Me.RePoNL1.Size = New System.Drawing.Size(51, 20)
        Me.RePoNL1.TabIndex = 40
        Me.RePoNL1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RePoPSum
        '
        Me.RePoPSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RePoPSum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RePoPSum.Location = New System.Drawing.Point(299, 74)
        Me.RePoPSum.Margin = New System.Windows.Forms.Padding(0)
        Me.RePoPSum.Name = "RePoPSum"
        Me.RePoPSum.ReadOnly = True
        Me.RePoPSum.Size = New System.Drawing.Size(52, 20)
        Me.RePoPSum.TabIndex = 39
        Me.RePoPSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RePoPL3
        '
        Me.RePoPL3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RePoPL3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RePoPL3.Location = New System.Drawing.Point(246, 74)
        Me.RePoPL3.Margin = New System.Windows.Forms.Padding(0)
        Me.RePoPL3.Name = "RePoPL3"
        Me.RePoPL3.ReadOnly = True
        Me.RePoPL3.Size = New System.Drawing.Size(51, 20)
        Me.RePoPL3.TabIndex = 38
        Me.RePoPL3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RePoPL2
        '
        Me.RePoPL2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RePoPL2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RePoPL2.Location = New System.Drawing.Point(193, 74)
        Me.RePoPL2.Margin = New System.Windows.Forms.Padding(0)
        Me.RePoPL2.Name = "RePoPL2"
        Me.RePoPL2.ReadOnly = True
        Me.RePoPL2.Size = New System.Drawing.Size(51, 20)
        Me.RePoPL2.TabIndex = 37
        Me.RePoPL2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RePoPL1
        '
        Me.RePoPL1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RePoPL1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RePoPL1.Location = New System.Drawing.Point(140, 74)
        Me.RePoPL1.Margin = New System.Windows.Forms.Padding(0)
        Me.RePoPL1.Name = "RePoPL1"
        Me.RePoPL1.ReadOnly = True
        Me.RePoPL1.Size = New System.Drawing.Size(51, 20)
        Me.RePoPL1.TabIndex = 36
        Me.RePoPL1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AcPoNSum
        '
        Me.AcPoNSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AcPoNSum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcPoNSum.Location = New System.Drawing.Point(299, 52)
        Me.AcPoNSum.Margin = New System.Windows.Forms.Padding(0)
        Me.AcPoNSum.Name = "AcPoNSum"
        Me.AcPoNSum.ReadOnly = True
        Me.AcPoNSum.Size = New System.Drawing.Size(52, 20)
        Me.AcPoNSum.TabIndex = 35
        Me.AcPoNSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AcPoNL3
        '
        Me.AcPoNL3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AcPoNL3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcPoNL3.Location = New System.Drawing.Point(246, 52)
        Me.AcPoNL3.Margin = New System.Windows.Forms.Padding(0)
        Me.AcPoNL3.Name = "AcPoNL3"
        Me.AcPoNL3.ReadOnly = True
        Me.AcPoNL3.Size = New System.Drawing.Size(51, 20)
        Me.AcPoNL3.TabIndex = 34
        Me.AcPoNL3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AcPoNL2
        '
        Me.AcPoNL2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AcPoNL2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcPoNL2.Location = New System.Drawing.Point(193, 52)
        Me.AcPoNL2.Margin = New System.Windows.Forms.Padding(0)
        Me.AcPoNL2.Name = "AcPoNL2"
        Me.AcPoNL2.ReadOnly = True
        Me.AcPoNL2.Size = New System.Drawing.Size(51, 20)
        Me.AcPoNL2.TabIndex = 33
        Me.AcPoNL2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AcPoNL1
        '
        Me.AcPoNL1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AcPoNL1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcPoNL1.Location = New System.Drawing.Point(140, 52)
        Me.AcPoNL1.Margin = New System.Windows.Forms.Padding(0)
        Me.AcPoNL1.Name = "AcPoNL1"
        Me.AcPoNL1.ReadOnly = True
        Me.AcPoNL1.Size = New System.Drawing.Size(51, 20)
        Me.AcPoNL1.TabIndex = 32
        Me.AcPoNL1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AcPoPSum
        '
        Me.AcPoPSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AcPoPSum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcPoPSum.Location = New System.Drawing.Point(299, 30)
        Me.AcPoPSum.Margin = New System.Windows.Forms.Padding(0)
        Me.AcPoPSum.Name = "AcPoPSum"
        Me.AcPoPSum.ReadOnly = True
        Me.AcPoPSum.Size = New System.Drawing.Size(52, 20)
        Me.AcPoPSum.TabIndex = 31
        Me.AcPoPSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AcPoPL3
        '
        Me.AcPoPL3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AcPoPL3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcPoPL3.Location = New System.Drawing.Point(246, 30)
        Me.AcPoPL3.Margin = New System.Windows.Forms.Padding(0)
        Me.AcPoPL3.Name = "AcPoPL3"
        Me.AcPoPL3.ReadOnly = True
        Me.AcPoPL3.Size = New System.Drawing.Size(51, 20)
        Me.AcPoPL3.TabIndex = 30
        Me.AcPoPL3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AcPoPL2
        '
        Me.AcPoPL2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AcPoPL2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcPoPL2.Location = New System.Drawing.Point(193, 30)
        Me.AcPoPL2.Margin = New System.Windows.Forms.Padding(0)
        Me.AcPoPL2.Name = "AcPoPL2"
        Me.AcPoPL2.ReadOnly = True
        Me.AcPoPL2.Size = New System.Drawing.Size(51, 20)
        Me.AcPoPL2.TabIndex = 29
        Me.AcPoPL2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelAcPoP
        '
        Me.LabelAcPoP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelAcPoP.AutoSize = True
        Me.LabelAcPoP.Location = New System.Drawing.Point(5, 30)
        Me.LabelAcPoP.Name = "LabelAcPoP"
        Me.LabelAcPoP.Size = New System.Drawing.Size(130, 20)
        Me.LabelAcPoP.TabIndex = 5
        Me.LabelAcPoP.Text = "Wirkleistung+ [W]"
        Me.LabelAcPoP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelSum
        '
        Me.LabelSum.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelSum.AutoSize = True
        Me.LabelSum.Location = New System.Drawing.Point(302, 2)
        Me.LabelSum.Name = "LabelSum"
        Me.LabelSum.Size = New System.Drawing.Size(46, 26)
        Me.LabelSum.TabIndex = 4
        Me.LabelSum.Text = "Gesamt"
        Me.LabelSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelL3
        '
        Me.LabelL3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelL3.AutoSize = True
        Me.LabelL3.Location = New System.Drawing.Point(249, 2)
        Me.LabelL3.Name = "LabelL3"
        Me.LabelL3.Size = New System.Drawing.Size(45, 26)
        Me.LabelL3.TabIndex = 3
        Me.LabelL3.Text = "L3"
        Me.LabelL3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelL2
        '
        Me.LabelL2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelL2.AutoSize = True
        Me.LabelL2.Location = New System.Drawing.Point(196, 2)
        Me.LabelL2.Name = "LabelL2"
        Me.LabelL2.Size = New System.Drawing.Size(45, 26)
        Me.LabelL2.TabIndex = 2
        Me.LabelL2.Text = "L2"
        Me.LabelL2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelL1
        '
        Me.LabelL1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelL1.AutoSize = True
        Me.LabelL1.Location = New System.Drawing.Point(143, 2)
        Me.LabelL1.Name = "LabelL1"
        Me.LabelL1.Size = New System.Drawing.Size(45, 26)
        Me.LabelL1.TabIndex = 1
        Me.LabelL1.Text = "L1"
        Me.LabelL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelMeasurement
        '
        Me.LabelMeasurement.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelMeasurement.AutoSize = True
        Me.LabelMeasurement.Location = New System.Drawing.Point(5, 2)
        Me.LabelMeasurement.Name = "LabelMeasurement"
        Me.LabelMeasurement.Size = New System.Drawing.Size(130, 26)
        Me.LabelMeasurement.TabIndex = 0
        Me.LabelMeasurement.Text = "Messgröße"
        Me.LabelMeasurement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelAcPoN
        '
        Me.LabelAcPoN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelAcPoN.AutoSize = True
        Me.LabelAcPoN.Location = New System.Drawing.Point(5, 52)
        Me.LabelAcPoN.Name = "LabelAcPoN"
        Me.LabelAcPoN.Size = New System.Drawing.Size(130, 20)
        Me.LabelAcPoN.TabIndex = 6
        Me.LabelAcPoN.Text = "Wirkleistung- [W]"
        Me.LabelAcPoN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelRePoP
        '
        Me.LabelRePoP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelRePoP.AutoSize = True
        Me.LabelRePoP.Location = New System.Drawing.Point(5, 74)
        Me.LabelRePoP.Name = "LabelRePoP"
        Me.LabelRePoP.Size = New System.Drawing.Size(130, 20)
        Me.LabelRePoP.TabIndex = 7
        Me.LabelRePoP.Text = "Blindleistung+ [var]"
        Me.LabelRePoP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelRePoN
        '
        Me.LabelRePoN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelRePoN.AutoSize = True
        Me.LabelRePoN.Location = New System.Drawing.Point(5, 96)
        Me.LabelRePoN.Name = "LabelRePoN"
        Me.LabelRePoN.Size = New System.Drawing.Size(130, 20)
        Me.LabelRePoN.TabIndex = 8
        Me.LabelRePoN.Text = "Blindleistung- [var]"
        Me.LabelRePoN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelApPoP
        '
        Me.LabelApPoP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelApPoP.AutoSize = True
        Me.LabelApPoP.Location = New System.Drawing.Point(5, 118)
        Me.LabelApPoP.Name = "LabelApPoP"
        Me.LabelApPoP.Size = New System.Drawing.Size(130, 20)
        Me.LabelApPoP.TabIndex = 9
        Me.LabelApPoP.Text = "Scheinleistung+ [VA]"
        Me.LabelApPoP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelApPoN
        '
        Me.LabelApPoN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelApPoN.AutoSize = True
        Me.LabelApPoN.Location = New System.Drawing.Point(5, 140)
        Me.LabelApPoN.Name = "LabelApPoN"
        Me.LabelApPoN.Size = New System.Drawing.Size(130, 20)
        Me.LabelApPoN.TabIndex = 10
        Me.LabelApPoN.Text = "Scheinleistung- [VA]"
        Me.LabelApPoN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelPoFa
        '
        Me.LabelPoFa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelPoFa.AutoSize = True
        Me.LabelPoFa.Location = New System.Drawing.Point(5, 162)
        Me.LabelPoFa.Name = "LabelPoFa"
        Me.LabelPoFa.Size = New System.Drawing.Size(130, 20)
        Me.LabelPoFa.TabIndex = 11
        Me.LabelPoFa.Text = "Leistungsfaktor"
        Me.LabelPoFa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelCurrent
        '
        Me.LabelCurrent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCurrent.AutoSize = True
        Me.LabelCurrent.Location = New System.Drawing.Point(5, 184)
        Me.LabelCurrent.Name = "LabelCurrent"
        Me.LabelCurrent.Size = New System.Drawing.Size(130, 20)
        Me.LabelCurrent.TabIndex = 12
        Me.LabelCurrent.Text = "Strom [A]"
        Me.LabelCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelVoltage
        '
        Me.LabelVoltage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelVoltage.AutoSize = True
        Me.LabelVoltage.Location = New System.Drawing.Point(5, 206)
        Me.LabelVoltage.Name = "LabelVoltage"
        Me.LabelVoltage.Size = New System.Drawing.Size(130, 20)
        Me.LabelVoltage.TabIndex = 13
        Me.LabelVoltage.Text = "Strangspannung [V]"
        Me.LabelVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelPhSh
        '
        Me.LabelPhSh.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelPhSh.AutoSize = True
        Me.LabelPhSh.Location = New System.Drawing.Point(5, 228)
        Me.LabelPhSh.Name = "LabelPhSh"
        Me.LabelPhSh.Size = New System.Drawing.Size(130, 20)
        Me.LabelPhSh.TabIndex = 14
        Me.LabelPhSh.Text = "Phasenverschiebung [°]"
        Me.LabelPhSh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelAnVol
        '
        Me.LabelAnVol.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelAnVol.AutoSize = True
        Me.LabelAnVol.Location = New System.Drawing.Point(5, 250)
        Me.LabelAnVol.Name = "LabelAnVol"
        Me.LabelAnVol.Size = New System.Drawing.Size(130, 20)
        Me.LabelAnVol.TabIndex = 15
        Me.LabelAnVol.Text = "Winkel U-Lx zu U-L1 [°]"
        Me.LabelAnVol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelAcPoPN
        '
        Me.LabelAcPoPN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelAcPoPN.AutoSize = True
        Me.LabelAcPoPN.Location = New System.Drawing.Point(5, 272)
        Me.LabelAcPoPN.Name = "LabelAcPoPN"
        Me.LabelAcPoPN.Size = New System.Drawing.Size(130, 20)
        Me.LabelAcPoPN.TabIndex = 16
        Me.LabelAcPoPN.Text = "Wirkleistung +/- [W]"
        Me.LabelAcPoPN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelFreq
        '
        Me.LabelFreq.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelFreq.AutoSize = True
        Me.LabelFreq.Location = New System.Drawing.Point(5, 294)
        Me.LabelFreq.Name = "LabelFreq"
        Me.LabelFreq.Size = New System.Drawing.Size(130, 27)
        Me.LabelFreq.TabIndex = 17
        Me.LabelFreq.Text = "Frequenz [Hz]"
        Me.LabelFreq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelAngL1L1
        '
        Me.LabelAngL1L1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelAngL1L1.AutoSize = True
        Me.LabelAngL1L1.Location = New System.Drawing.Point(143, 250)
        Me.LabelAngL1L1.Name = "LabelAngL1L1"
        Me.LabelAngL1L1.Size = New System.Drawing.Size(45, 20)
        Me.LabelAngL1L1.TabIndex = 18
        Me.LabelAngL1L1.Text = "-"
        Me.LabelAngL1L1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelAcPoPNL1
        '
        Me.LabelAcPoPNL1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelAcPoPNL1.AutoSize = True
        Me.LabelAcPoPNL1.Location = New System.Drawing.Point(143, 272)
        Me.LabelAcPoPNL1.Name = "LabelAcPoPNL1"
        Me.LabelAcPoPNL1.Size = New System.Drawing.Size(45, 20)
        Me.LabelAcPoPNL1.TabIndex = 19
        Me.LabelAcPoPNL1.Text = "-"
        Me.LabelAcPoPNL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelAcPoPNL2
        '
        Me.LabelAcPoPNL2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelAcPoPNL2.AutoSize = True
        Me.LabelAcPoPNL2.Location = New System.Drawing.Point(196, 272)
        Me.LabelAcPoPNL2.Name = "LabelAcPoPNL2"
        Me.LabelAcPoPNL2.Size = New System.Drawing.Size(45, 20)
        Me.LabelAcPoPNL2.TabIndex = 20
        Me.LabelAcPoPNL2.Text = "-"
        Me.LabelAcPoPNL2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelAcPoPNL3
        '
        Me.LabelAcPoPNL3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelAcPoPNL3.AutoSize = True
        Me.LabelAcPoPNL3.Location = New System.Drawing.Point(249, 272)
        Me.LabelAcPoPNL3.Name = "LabelAcPoPNL3"
        Me.LabelAcPoPNL3.Size = New System.Drawing.Size(45, 20)
        Me.LabelAcPoPNL3.TabIndex = 21
        Me.LabelAcPoPNL3.Text = "-"
        Me.LabelAcPoPNL3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelFreqL1
        '
        Me.LabelFreqL1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelFreqL1.AutoSize = True
        Me.LabelFreqL1.Location = New System.Drawing.Point(143, 294)
        Me.LabelFreqL1.Name = "LabelFreqL1"
        Me.LabelFreqL1.Size = New System.Drawing.Size(45, 27)
        Me.LabelFreqL1.TabIndex = 22
        Me.LabelFreqL1.Text = "-"
        Me.LabelFreqL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelFreqL3
        '
        Me.LabelFreqL3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelFreqL3.AutoSize = True
        Me.LabelFreqL3.Location = New System.Drawing.Point(249, 294)
        Me.LabelFreqL3.Name = "LabelFreqL3"
        Me.LabelFreqL3.Size = New System.Drawing.Size(45, 27)
        Me.LabelFreqL3.TabIndex = 24
        Me.LabelFreqL3.Text = "-"
        Me.LabelFreqL3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelFreqL2
        '
        Me.LabelFreqL2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelFreqL2.AutoSize = True
        Me.LabelFreqL2.Location = New System.Drawing.Point(196, 294)
        Me.LabelFreqL2.Name = "LabelFreqL2"
        Me.LabelFreqL2.Size = New System.Drawing.Size(45, 27)
        Me.LabelFreqL2.TabIndex = 23
        Me.LabelFreqL2.Text = "-"
        Me.LabelFreqL2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelAngSum
        '
        Me.LabelAngSum.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelAngSum.AutoSize = True
        Me.LabelAngSum.Location = New System.Drawing.Point(302, 250)
        Me.LabelAngSum.Name = "LabelAngSum"
        Me.LabelAngSum.Size = New System.Drawing.Size(46, 20)
        Me.LabelAngSum.TabIndex = 25
        Me.LabelAngSum.Text = "-"
        Me.LabelAngSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelPhShSum
        '
        Me.LabelPhShSum.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelPhShSum.AutoSize = True
        Me.LabelPhShSum.Location = New System.Drawing.Point(302, 228)
        Me.LabelPhShSum.Name = "LabelPhShSum"
        Me.LabelPhShSum.Size = New System.Drawing.Size(46, 20)
        Me.LabelPhShSum.TabIndex = 26
        Me.LabelPhShSum.Text = "-"
        Me.LabelPhShSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelVoltageSum
        '
        Me.LabelVoltageSum.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelVoltageSum.AutoSize = True
        Me.LabelVoltageSum.Location = New System.Drawing.Point(302, 206)
        Me.LabelVoltageSum.Name = "LabelVoltageSum"
        Me.LabelVoltageSum.Size = New System.Drawing.Size(46, 20)
        Me.LabelVoltageSum.TabIndex = 27
        Me.LabelVoltageSum.Text = "-"
        Me.LabelVoltageSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelCurSum
        '
        Me.LabelCurSum.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCurSum.AutoSize = True
        Me.LabelCurSum.Location = New System.Drawing.Point(302, 184)
        Me.LabelCurSum.Name = "LabelCurSum"
        Me.LabelCurSum.Size = New System.Drawing.Size(46, 20)
        Me.LabelCurSum.TabIndex = 28
        Me.LabelCurSum.Text = "-"
        Me.LabelCurSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AcPoPL1
        '
        Me.AcPoPL1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AcPoPL1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcPoPL1.Location = New System.Drawing.Point(140, 30)
        Me.AcPoPL1.Margin = New System.Windows.Forms.Padding(0)
        Me.AcPoPL1.Name = "AcPoPL1"
        Me.AcPoPL1.ReadOnly = True
        Me.AcPoPL1.Size = New System.Drawing.Size(51, 20)
        Me.AcPoPL1.TabIndex = 2
        Me.AcPoPL1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupEnergy
        '
        Me.GroupEnergy.Controls.Add(Me.TableEnergy)
        Me.GroupEnergy.Location = New System.Drawing.Point(12, 510)
        Me.GroupEnergy.Name = "GroupEnergy"
        Me.GroupEnergy.Size = New System.Drawing.Size(365, 100)
        Me.GroupEnergy.TabIndex = 2
        Me.GroupEnergy.TabStop = False
        Me.GroupEnergy.Text = "Zählerstände"
        '
        'TableEnergy
        '
        Me.TableEnergy.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.TableEnergy.ColumnCount = 4
        Me.TableEnergy.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableEnergy.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableEnergy.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableEnergy.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableEnergy.Controls.Add(Me.AcEnNT1, 0, 2)
        Me.TableEnergy.Controls.Add(Me.AcEnNT0, 0, 2)
        Me.TableEnergy.Controls.Add(Me.LabelMeasurementEn, 0, 0)
        Me.TableEnergy.Controls.Add(Me.LabelTariff0, 1, 0)
        Me.TableEnergy.Controls.Add(Me.LabelTariff1, 2, 0)
        Me.TableEnergy.Controls.Add(Me.LabelTariff3, 3, 0)
        Me.TableEnergy.Controls.Add(Me.LabelAcEnPo, 0, 1)
        Me.TableEnergy.Controls.Add(Me.AcEnPT2, 3, 1)
        Me.TableEnergy.Controls.Add(Me.AcEnPT0, 1, 1)
        Me.TableEnergy.Controls.Add(Me.AcEnPT1, 2, 1)
        Me.TableEnergy.Controls.Add(Me.AcEnNT2, 1, 2)
        Me.TableEnergy.Controls.Add(Me.LabelAcEnN, 0, 2)
        Me.TableEnergy.Location = New System.Drawing.Point(6, 19)
        Me.TableEnergy.Name = "TableEnergy"
        Me.TableEnergy.RowCount = 3
        Me.TableEnergy.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.TableEnergy.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableEnergy.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableEnergy.Size = New System.Drawing.Size(353, 75)
        Me.TableEnergy.TabIndex = 0
        '
        'AcEnNT1
        '
        Me.AcEnNT1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AcEnNT1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcEnNT1.Location = New System.Drawing.Point(211, 50)
        Me.AcEnNT1.Margin = New System.Windows.Forms.Padding(0)
        Me.AcEnNT1.Name = "AcEnNT1"
        Me.AcEnNT1.ReadOnly = True
        Me.AcEnNT1.Size = New System.Drawing.Size(68, 20)
        Me.AcEnNT1.TabIndex = 72
        Me.AcEnNT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AcEnNT0
        '
        Me.AcEnNT0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AcEnNT0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcEnNT0.Location = New System.Drawing.Point(141, 50)
        Me.AcEnNT0.Margin = New System.Windows.Forms.Padding(0)
        Me.AcEnNT0.Name = "AcEnNT0"
        Me.AcEnNT0.ReadOnly = True
        Me.AcEnNT0.Size = New System.Drawing.Size(68, 20)
        Me.AcEnNT0.TabIndex = 71
        Me.AcEnNT0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelMeasurementEn
        '
        Me.LabelMeasurementEn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelMeasurementEn.AutoSize = True
        Me.LabelMeasurementEn.Location = New System.Drawing.Point(5, 2)
        Me.LabelMeasurementEn.Name = "LabelMeasurementEn"
        Me.LabelMeasurementEn.Size = New System.Drawing.Size(131, 22)
        Me.LabelMeasurementEn.TabIndex = 1
        Me.LabelMeasurementEn.Text = "Messgröße [kWh]"
        Me.LabelMeasurementEn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTariff0
        '
        Me.LabelTariff0.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTariff0.AutoSize = True
        Me.LabelTariff0.Location = New System.Drawing.Point(144, 2)
        Me.LabelTariff0.Name = "LabelTariff0"
        Me.LabelTariff0.Size = New System.Drawing.Size(62, 22)
        Me.LabelTariff0.TabIndex = 2
        Me.LabelTariff0.Text = "Tariflos"
        Me.LabelTariff0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTariff1
        '
        Me.LabelTariff1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTariff1.AutoSize = True
        Me.LabelTariff1.Location = New System.Drawing.Point(214, 2)
        Me.LabelTariff1.Name = "LabelTariff1"
        Me.LabelTariff1.Size = New System.Drawing.Size(62, 22)
        Me.LabelTariff1.TabIndex = 3
        Me.LabelTariff1.Text = "Tarif 1"
        Me.LabelTariff1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTariff3
        '
        Me.LabelTariff3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTariff3.AutoSize = True
        Me.LabelTariff3.Location = New System.Drawing.Point(284, 2)
        Me.LabelTariff3.Name = "LabelTariff3"
        Me.LabelTariff3.Size = New System.Drawing.Size(64, 22)
        Me.LabelTariff3.TabIndex = 4
        Me.LabelTariff3.Text = "Tarif 2"
        Me.LabelTariff3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelAcEnPo
        '
        Me.LabelAcEnPo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelAcEnPo.AutoSize = True
        Me.LabelAcEnPo.Location = New System.Drawing.Point(5, 26)
        Me.LabelAcEnPo.Name = "LabelAcEnPo"
        Me.LabelAcEnPo.Size = New System.Drawing.Size(131, 22)
        Me.LabelAcEnPo.TabIndex = 6
        Me.LabelAcEnPo.Text = "Wirkenergie+ (1.8.0)"
        Me.LabelAcEnPo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AcEnPT2
        '
        Me.AcEnPT2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AcEnPT2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcEnPT2.Location = New System.Drawing.Point(281, 26)
        Me.AcEnPT2.Margin = New System.Windows.Forms.Padding(0)
        Me.AcEnPT2.Name = "AcEnPT2"
        Me.AcEnPT2.ReadOnly = True
        Me.AcEnPT2.Size = New System.Drawing.Size(70, 20)
        Me.AcEnPT2.TabIndex = 69
        Me.AcEnPT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AcEnPT0
        '
        Me.AcEnPT0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AcEnPT0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcEnPT0.Location = New System.Drawing.Point(141, 26)
        Me.AcEnPT0.Margin = New System.Windows.Forms.Padding(0)
        Me.AcEnPT0.Name = "AcEnPT0"
        Me.AcEnPT0.ReadOnly = True
        Me.AcEnPT0.Size = New System.Drawing.Size(68, 20)
        Me.AcEnPT0.TabIndex = 68
        Me.AcEnPT0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AcEnPT1
        '
        Me.AcEnPT1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AcEnPT1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcEnPT1.Location = New System.Drawing.Point(211, 26)
        Me.AcEnPT1.Margin = New System.Windows.Forms.Padding(0)
        Me.AcEnPT1.Name = "AcEnPT1"
        Me.AcEnPT1.ReadOnly = True
        Me.AcEnPT1.Size = New System.Drawing.Size(68, 20)
        Me.AcEnPT1.TabIndex = 67
        Me.AcEnPT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AcEnNT2
        '
        Me.AcEnNT2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AcEnNT2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcEnNT2.Location = New System.Drawing.Point(281, 50)
        Me.AcEnNT2.Margin = New System.Windows.Forms.Padding(0)
        Me.AcEnNT2.Name = "AcEnNT2"
        Me.AcEnNT2.ReadOnly = True
        Me.AcEnNT2.Size = New System.Drawing.Size(70, 20)
        Me.AcEnNT2.TabIndex = 70
        Me.AcEnNT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelAcEnN
        '
        Me.LabelAcEnN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelAcEnN.AutoSize = True
        Me.LabelAcEnN.Location = New System.Drawing.Point(5, 50)
        Me.LabelAcEnN.Name = "LabelAcEnN"
        Me.LabelAcEnN.Size = New System.Drawing.Size(131, 23)
        Me.LabelAcEnN.TabIndex = 8
        Me.LabelAcEnN.Text = "Wirkenergie- (2.8.0)"
        Me.LabelAcEnN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupSettings
        '
        Me.GroupSettings.Controls.Add(Me.GroupSettingsParam)
        Me.GroupSettings.Controls.Add(Me.SettingWrite)
        Me.GroupSettings.Controls.Add(Me.SettingRead)
        Me.GroupSettings.Enabled = False
        Me.GroupSettings.Location = New System.Drawing.Point(383, 321)
        Me.GroupSettings.Name = "GroupSettings"
        Me.GroupSettings.Size = New System.Drawing.Size(243, 267)
        Me.GroupSettings.TabIndex = 3
        Me.GroupSettings.TabStop = False
        Me.GroupSettings.Text = "Kennwerte/Einstellungen"
        '
        'GroupSettingsParam
        '
        Me.GroupSettingsParam.Controls.Add(Me.SettingAcPowCalc)
        Me.GroupSettingsParam.Controls.Add(Me.SettingMeasIntAuto)
        Me.GroupSettingsParam.Controls.Add(Me.SettingTimestamp)
        Me.GroupSettingsParam.Controls.Add(Me.SettingMeasInt)
        Me.GroupSettingsParam.Controls.Add(Me.LabelTimestamp)
        Me.GroupSettingsParam.Controls.Add(Me.SettingFWVer)
        Me.GroupSettingsParam.Controls.Add(Me.LabelFWVer)
        Me.GroupSettingsParam.Controls.Add(Me.LabelMeasInt)
        Me.GroupSettingsParam.Controls.Add(Me.LabelHWVer)
        Me.GroupSettingsParam.Controls.Add(Me.LabelManufacturerID)
        Me.GroupSettingsParam.Controls.Add(Me.SettingHWVer)
        Me.GroupSettingsParam.Controls.Add(Me.SettingManID)
        Me.GroupSettingsParam.Controls.Add(Me.SettingDevID)
        Me.GroupSettingsParam.Controls.Add(Me.LabelDeviceID)
        Me.GroupSettingsParam.Enabled = False
        Me.GroupSettingsParam.Location = New System.Drawing.Point(6, 19)
        Me.GroupSettingsParam.Name = "GroupSettingsParam"
        Me.GroupSettingsParam.Size = New System.Drawing.Size(231, 216)
        Me.GroupSettingsParam.TabIndex = 0
        Me.GroupSettingsParam.TabStop = False
        '
        'SettingAcPowCalc
        '
        Me.SettingAcPowCalc.AutoSize = True
        Me.SettingAcPowCalc.Location = New System.Drawing.Point(6, 193)
        Me.SettingAcPowCalc.Name = "SettingAcPowCalc"
        Me.SettingAcPowCalc.Size = New System.Drawing.Size(177, 17)
        Me.SettingAcPowCalc.TabIndex = 15
        Me.SettingAcPowCalc.Text = "Gesamtes P+ und P- berechnen"
        Me.SettingAcPowCalc.UseVisualStyleBackColor = True
        '
        'SettingMeasIntAuto
        '
        Me.SettingMeasIntAuto.AutoSize = True
        Me.SettingMeasIntAuto.Location = New System.Drawing.Point(6, 170)
        Me.SettingMeasIntAuto.Name = "SettingMeasIntAuto"
        Me.SettingMeasIntAuto.Size = New System.Drawing.Size(159, 17)
        Me.SettingMeasIntAuto.TabIndex = 14
        Me.SettingMeasIntAuto.Text = "Automatisches Messintervall"
        Me.SettingMeasIntAuto.UseVisualStyleBackColor = True
        '
        'SettingTimestamp
        '
        Me.SettingTimestamp.Location = New System.Drawing.Point(99, 144)
        Me.SettingTimestamp.Maximum = New Decimal(New Integer() {-1, 0, 0, 0})
        Me.SettingTimestamp.Name = "SettingTimestamp"
        Me.SettingTimestamp.Size = New System.Drawing.Size(126, 20)
        Me.SettingTimestamp.TabIndex = 24
        '
        'SettingMeasInt
        '
        Me.SettingMeasInt.Location = New System.Drawing.Point(99, 118)
        Me.SettingMeasInt.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.SettingMeasInt.Name = "SettingMeasInt"
        Me.SettingMeasInt.Size = New System.Drawing.Size(126, 20)
        Me.SettingMeasInt.TabIndex = 23
        '
        'LabelTimestamp
        '
        Me.LabelTimestamp.AutoSize = True
        Me.LabelTimestamp.Location = New System.Drawing.Point(32, 146)
        Me.LabelTimestamp.Name = "LabelTimestamp"
        Me.LabelTimestamp.Size = New System.Drawing.Size(61, 13)
        Me.LabelTimestamp.TabIndex = 17
        Me.LabelTimestamp.Text = "Zeitstempel"
        '
        'SettingFWVer
        '
        Me.SettingFWVer.Hexadecimal = True
        Me.SettingFWVer.Location = New System.Drawing.Point(99, 92)
        Me.SettingFWVer.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.SettingFWVer.Name = "SettingFWVer"
        Me.SettingFWVer.Size = New System.Drawing.Size(126, 20)
        Me.SettingFWVer.TabIndex = 22
        '
        'LabelFWVer
        '
        Me.LabelFWVer.AutoSize = True
        Me.LabelFWVer.Location = New System.Drawing.Point(10, 94)
        Me.LabelFWVer.Name = "LabelFWVer"
        Me.LabelFWVer.Size = New System.Drawing.Size(83, 13)
        Me.LabelFWVer.TabIndex = 10
        Me.LabelFWVer.Text = "Firmwareversion"
        '
        'LabelMeasInt
        '
        Me.LabelMeasInt.AutoSize = True
        Me.LabelMeasInt.Location = New System.Drawing.Point(25, 120)
        Me.LabelMeasInt.Name = "LabelMeasInt"
        Me.LabelMeasInt.Size = New System.Drawing.Size(68, 13)
        Me.LabelMeasInt.TabIndex = 12
        Me.LabelMeasInt.Text = "Messintervall"
        '
        'LabelHWVer
        '
        Me.LabelHWVer.AutoSize = True
        Me.LabelHWVer.Location = New System.Drawing.Point(6, 68)
        Me.LabelHWVer.Name = "LabelHWVer"
        Me.LabelHWVer.Size = New System.Drawing.Size(87, 13)
        Me.LabelHWVer.TabIndex = 8
        Me.LabelHWVer.Text = "Hardwareversion"
        '
        'LabelManufacturerID
        '
        Me.LabelManufacturerID.AutoSize = True
        Me.LabelManufacturerID.Location = New System.Drawing.Point(28, 16)
        Me.LabelManufacturerID.Name = "LabelManufacturerID"
        Me.LabelManufacturerID.Size = New System.Drawing.Size(65, 13)
        Me.LabelManufacturerID.TabIndex = 4
        Me.LabelManufacturerID.Text = "Hersteller-ID"
        '
        'SettingHWVer
        '
        Me.SettingHWVer.Hexadecimal = True
        Me.SettingHWVer.Location = New System.Drawing.Point(99, 66)
        Me.SettingHWVer.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.SettingHWVer.Name = "SettingHWVer"
        Me.SettingHWVer.Size = New System.Drawing.Size(126, 20)
        Me.SettingHWVer.TabIndex = 21
        '
        'SettingManID
        '
        Me.SettingManID.Hexadecimal = True
        Me.SettingManID.Location = New System.Drawing.Point(99, 14)
        Me.SettingManID.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.SettingManID.Name = "SettingManID"
        Me.SettingManID.Size = New System.Drawing.Size(126, 20)
        Me.SettingManID.TabIndex = 19
        '
        'SettingDevID
        '
        Me.SettingDevID.Hexadecimal = True
        Me.SettingDevID.Location = New System.Drawing.Point(99, 40)
        Me.SettingDevID.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.SettingDevID.Name = "SettingDevID"
        Me.SettingDevID.Size = New System.Drawing.Size(126, 20)
        Me.SettingDevID.TabIndex = 20
        '
        'LabelDeviceID
        '
        Me.LabelDeviceID.AutoSize = True
        Me.LabelDeviceID.Location = New System.Drawing.Point(40, 42)
        Me.LabelDeviceID.Name = "LabelDeviceID"
        Me.LabelDeviceID.Size = New System.Drawing.Size(53, 13)
        Me.LabelDeviceID.TabIndex = 5
        Me.LabelDeviceID.Text = "Geräte-ID"
        '
        'SettingWrite
        '
        Me.SettingWrite.Enabled = False
        Me.SettingWrite.Location = New System.Drawing.Point(174, 241)
        Me.SettingWrite.Name = "SettingWrite"
        Me.SettingWrite.Size = New System.Drawing.Size(63, 20)
        Me.SettingWrite.TabIndex = 10
        Me.SettingWrite.Text = "Schreiben"
        Me.SettingWrite.UseVisualStyleBackColor = True
        '
        'SettingRead
        '
        Me.SettingRead.Location = New System.Drawing.Point(6, 241)
        Me.SettingRead.Name = "SettingRead"
        Me.SettingRead.Size = New System.Drawing.Size(50, 20)
        Me.SettingRead.TabIndex = 18
        Me.SettingRead.Text = "Lesen"
        Me.SettingRead.UseVisualStyleBackColor = True
        '
        'GroupPin
        '
        Me.GroupPin.Controls.Add(Me.PinProgress)
        Me.GroupPin.Controls.Add(Me.PINNumber)
        Me.GroupPin.Controls.Add(Me.PINSend)
        Me.GroupPin.Enabled = False
        Me.GroupPin.Location = New System.Drawing.Point(383, 151)
        Me.GroupPin.Name = "GroupPin"
        Me.GroupPin.Size = New System.Drawing.Size(243, 74)
        Me.GroupPin.TabIndex = 4
        Me.GroupPin.TabStop = False
        Me.GroupPin.Text = "PIN"
        '
        'PinProgress
        '
        Me.PinProgress.Location = New System.Drawing.Point(6, 45)
        Me.PinProgress.Name = "PinProgress"
        Me.PinProgress.Size = New System.Drawing.Size(231, 23)
        Me.PinProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PinProgress.TabIndex = 20
        '
        'PINNumber
        '
        Me.PINNumber.Location = New System.Drawing.Point(6, 19)
        Me.PINNumber.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.PINNumber.Name = "PINNumber"
        Me.PINNumber.Size = New System.Drawing.Size(50, 20)
        Me.PINNumber.TabIndex = 10
        '
        'PINSend
        '
        Me.PINSend.Location = New System.Drawing.Point(62, 19)
        Me.PINSend.Name = "PINSend"
        Me.PINSend.Size = New System.Drawing.Size(175, 20)
        Me.PINSend.TabIndex = 19
        Me.PINSend.Text = "PIN senden"
        Me.PINSend.UseVisualStyleBackColor = True
        '
        'GroupExtra
        '
        Me.GroupExtra.Controls.Add(Me.ReadingHeadTimestamp)
        Me.GroupExtra.Controls.Add(Me.LabelTimestamp2)
        Me.GroupExtra.Controls.Add(Me.ReadingHeadData)
        Me.GroupExtra.Controls.Add(Me.LabelData)
        Me.GroupExtra.Controls.Add(Me.ReadingHeadTemperature)
        Me.GroupExtra.Controls.Add(Me.LabelTemperature)
        Me.GroupExtra.Controls.Add(Me.ServerID)
        Me.GroupExtra.Controls.Add(Me.LabelServerID)
        Me.GroupExtra.Controls.Add(Me.ReadingHeadID)
        Me.GroupExtra.Controls.Add(Me.LabelReadingHeadID)
        Me.GroupExtra.Location = New System.Drawing.Point(383, 231)
        Me.GroupExtra.Name = "GroupExtra"
        Me.GroupExtra.Size = New System.Drawing.Size(243, 84)
        Me.GroupExtra.TabIndex = 5
        Me.GroupExtra.TabStop = False
        Me.GroupExtra.Text = "Sonstiges"
        '
        'ReadingHeadTimestamp
        '
        Me.ReadingHeadTimestamp.AutoSize = True
        Me.ReadingHeadTimestamp.Location = New System.Drawing.Point(83, 68)
        Me.ReadingHeadTimestamp.Name = "ReadingHeadTimestamp"
        Me.ReadingHeadTimestamp.Size = New System.Drawing.Size(130, 13)
        Me.ReadingHeadTimestamp.TabIndex = 9
        Me.ReadingHeadTimestamp.Text = "TT.MM.YYYY HH:MM:SS"
        '
        'LabelTimestamp2
        '
        Me.LabelTimestamp2.AutoSize = True
        Me.LabelTimestamp2.Location = New System.Drawing.Point(6, 68)
        Me.LabelTimestamp2.Name = "LabelTimestamp2"
        Me.LabelTimestamp2.Size = New System.Drawing.Size(64, 13)
        Me.LabelTimestamp2.TabIndex = 8
        Me.LabelTimestamp2.Text = "Zeitstempel:"
        '
        'ReadingHeadData
        '
        Me.ReadingHeadData.AutoSize = True
        Me.ReadingHeadData.Location = New System.Drawing.Point(83, 55)
        Me.ReadingHeadData.Name = "ReadingHeadData"
        Me.ReadingHeadData.Size = New System.Drawing.Size(110, 13)
        Me.ReadingHeadData.TabIndex = 7
        Me.ReadingHeadData.Text = "Daten nicht abgefragt"
        '
        'LabelData
        '
        Me.LabelData.AutoSize = True
        Me.LabelData.Location = New System.Drawing.Point(6, 55)
        Me.LabelData.Name = "LabelData"
        Me.LabelData.Size = New System.Drawing.Size(39, 13)
        Me.LabelData.TabIndex = 6
        Me.LabelData.Text = "Daten:"
        '
        'ReadingHeadTemperature
        '
        Me.ReadingHeadTemperature.AutoSize = True
        Me.ReadingHeadTemperature.Location = New System.Drawing.Point(83, 42)
        Me.ReadingHeadTemperature.Name = "ReadingHeadTemperature"
        Me.ReadingHeadTemperature.Size = New System.Drawing.Size(24, 13)
        Me.ReadingHeadTemperature.TabIndex = 5
        Me.ReadingHeadTemperature.Text = "- °C"
        '
        'LabelTemperature
        '
        Me.LabelTemperature.AutoSize = True
        Me.LabelTemperature.Location = New System.Drawing.Point(6, 42)
        Me.LabelTemperature.Name = "LabelTemperature"
        Me.LabelTemperature.Size = New System.Drawing.Size(64, 13)
        Me.LabelTemperature.TabIndex = 4
        Me.LabelTemperature.Text = "Temperatur:"
        '
        'ServerID
        '
        Me.ServerID.AutoSize = True
        Me.ServerID.Location = New System.Drawing.Point(83, 29)
        Me.ServerID.Name = "ServerID"
        Me.ServerID.Size = New System.Drawing.Size(154, 13)
        Me.ServerID.TabIndex = 3
        Me.ServerID.Text = "00-00-00-00-00-00-00-00-00-00"
        '
        'LabelServerID
        '
        Me.LabelServerID.AutoSize = True
        Me.LabelServerID.Location = New System.Drawing.Point(6, 29)
        Me.LabelServerID.Name = "LabelServerID"
        Me.LabelServerID.Size = New System.Drawing.Size(58, 13)
        Me.LabelServerID.TabIndex = 2
        Me.LabelServerID.Text = "Server-ID: "
        '
        'ReadingHeadID
        '
        Me.ReadingHeadID.AutoSize = True
        Me.ReadingHeadID.Location = New System.Drawing.Point(83, 16)
        Me.ReadingHeadID.Name = "ReadingHeadID"
        Me.ReadingHeadID.Size = New System.Drawing.Size(154, 13)
        Me.ReadingHeadID.TabIndex = 1
        Me.ReadingHeadID.Text = "00-00-00-00-00-00-00-00-00-00"
        '
        'LabelReadingHeadID
        '
        Me.LabelReadingHeadID.AutoSize = True
        Me.LabelReadingHeadID.Location = New System.Drawing.Point(6, 16)
        Me.LabelReadingHeadID.Name = "LabelReadingHeadID"
        Me.LabelReadingHeadID.Size = New System.Drawing.Size(71, 13)
        Me.LabelReadingHeadID.TabIndex = 0
        Me.LabelReadingHeadID.Text = "Lesekopf-ID: "
        '
        'GroupLog
        '
        Me.GroupLog.Controls.Add(Me.LogFileOpen)
        Me.GroupLog.Controls.Add(Me.LogActive)
        Me.GroupLog.Controls.Add(Me.LogSearchPath)
        Me.GroupLog.Controls.Add(Me.LabelPath)
        Me.GroupLog.Controls.Add(Me.LogFilePath)
        Me.GroupLog.Location = New System.Drawing.Point(383, 87)
        Me.GroupLog.Name = "GroupLog"
        Me.GroupLog.Size = New System.Drawing.Size(243, 58)
        Me.GroupLog.TabIndex = 6
        Me.GroupLog.TabStop = False
        Me.GroupLog.Text = "Datenlogger"
        '
        'LogFileOpen
        '
        Me.LogFileOpen.Enabled = False
        Me.LogFileOpen.Location = New System.Drawing.Point(190, 32)
        Me.LogFileOpen.Name = "LogFileOpen"
        Me.LogFileOpen.Size = New System.Drawing.Size(47, 20)
        Me.LogFileOpen.TabIndex = 4
        Me.LogFileOpen.Text = "Öffnen"
        Me.LogFileOpen.UseVisualStyleBackColor = True
        '
        'LogActive
        '
        Me.LogActive.AutoSize = True
        Me.LogActive.Enabled = False
        Me.LogActive.Location = New System.Drawing.Point(149, 13)
        Me.LogActive.Name = "LogActive"
        Me.LogActive.Size = New System.Drawing.Size(88, 17)
        Me.LogActive.TabIndex = 3
        Me.LogActive.Text = "Loggen aktiv"
        Me.LogActive.UseVisualStyleBackColor = True
        '
        'LogSearchPath
        '
        Me.LogSearchPath.Location = New System.Drawing.Point(160, 32)
        Me.LogSearchPath.Name = "LogSearchPath"
        Me.LogSearchPath.Size = New System.Drawing.Size(24, 20)
        Me.LogSearchPath.TabIndex = 2
        Me.LogSearchPath.Text = "..."
        Me.LogSearchPath.UseVisualStyleBackColor = True
        '
        'LabelPath
        '
        Me.LabelPath.AutoSize = True
        Me.LabelPath.Location = New System.Drawing.Point(6, 16)
        Me.LabelPath.Name = "LabelPath"
        Me.LabelPath.Size = New System.Drawing.Size(53, 13)
        Me.LabelPath.TabIndex = 1
        Me.LabelPath.Text = "Dateipfad"
        '
        'LogFilePath
        '
        Me.LogFilePath.Location = New System.Drawing.Point(6, 32)
        Me.LogFilePath.Name = "LogFilePath"
        Me.LogFilePath.Size = New System.Drawing.Size(148, 20)
        Me.LogFilePath.TabIndex = 0
        '
        'GroupLogger
        '
        Me.GroupLogger.Controls.Add(Me.LoggerExport)
        Me.GroupLogger.Controls.Add(Me.LoggerClear)
        Me.GroupLogger.Controls.Add(Me.LoggerOutput)
        Me.GroupLogger.Location = New System.Drawing.Point(12, 616)
        Me.GroupLogger.Name = "GroupLogger"
        Me.GroupLogger.Size = New System.Drawing.Size(614, 128)
        Me.GroupLogger.TabIndex = 7
        Me.GroupLogger.TabStop = False
        Me.GroupLogger.Text = "Ereignislogger"
        '
        'LoggerExport
        '
        Me.LoggerExport.Location = New System.Drawing.Point(70, 99)
        Me.LoggerExport.Name = "LoggerExport"
        Me.LoggerExport.Size = New System.Drawing.Size(45, 23)
        Me.LoggerExport.TabIndex = 13
        Me.LoggerExport.Text = "Export"
        Me.LoggerExport.UseVisualStyleBackColor = True
        '
        'LoggerClear
        '
        Me.LoggerClear.Location = New System.Drawing.Point(6, 99)
        Me.LoggerClear.Name = "LoggerClear"
        Me.LoggerClear.Size = New System.Drawing.Size(58, 23)
        Me.LoggerClear.TabIndex = 10
        Me.LoggerClear.Text = "Löschen"
        Me.LoggerClear.UseVisualStyleBackColor = True
        '
        'LoggerOutput
        '
        Me.LoggerOutput.Location = New System.Drawing.Point(7, 19)
        Me.LoggerOutput.Multiline = True
        Me.LoggerOutput.Name = "LoggerOutput"
        Me.LoggerOutput.ReadOnly = True
        Me.LoggerOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.LoggerOutput.Size = New System.Drawing.Size(601, 74)
        Me.LoggerOutput.TabIndex = 0
        '
        'LinkLabelAuthor
        '
        Me.LinkLabelAuthor.AutoSize = True
        Me.LinkLabelAuthor.Location = New System.Drawing.Point(465, 597)
        Me.LinkLabelAuthor.Name = "LinkLabelAuthor"
        Me.LinkLabelAuthor.Size = New System.Drawing.Size(111, 13)
        Me.LinkLabelAuthor.TabIndex = 12
        Me.LinkLabelAuthor.TabStop = True
        Me.LinkLabelAuthor.Text = "www.niklas-menke.de"
        '
        'LabelVer
        '
        Me.LabelVer.AutoSize = True
        Me.LabelVer.Location = New System.Drawing.Point(383, 597)
        Me.LabelVer.Name = "LabelVer"
        Me.LabelVer.Size = New System.Drawing.Size(72, 13)
        Me.LabelVer.TabIndex = 11
        Me.LabelVer.Text = "Version: 1.0.0"
        '
        'ComInt
        '
        Me.ComInt.Interval = 1000
        '
        'PinWait
        '
        '
        'GroupCommunication
        '
        Me.GroupCommunication.Controls.Add(Me.CommunicationProgress)
        Me.GroupCommunication.Controls.Add(Me.LabelInterval)
        Me.GroupCommunication.Controls.Add(Me.CommunicationIntervall)
        Me.GroupCommunication.Controls.Add(Me.CommunicationManual)
        Me.GroupCommunication.Controls.Add(Me.CommunicationStart)
        Me.GroupCommunication.Enabled = False
        Me.GroupCommunication.Location = New System.Drawing.Point(383, 12)
        Me.GroupCommunication.Name = "GroupCommunication"
        Me.GroupCommunication.Size = New System.Drawing.Size(243, 69)
        Me.GroupCommunication.TabIndex = 8
        Me.GroupCommunication.TabStop = False
        Me.GroupCommunication.Text = "Kommunikation"
        '
        'CommunicationProgress
        '
        Me.CommunicationProgress.Location = New System.Drawing.Point(6, 40)
        Me.CommunicationProgress.Name = "CommunicationProgress"
        Me.CommunicationProgress.Size = New System.Drawing.Size(231, 23)
        Me.CommunicationProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.CommunicationProgress.TabIndex = 21
        '
        'LinkLabelHelp
        '
        Me.LinkLabelHelp.AutoSize = True
        Me.LinkLabelHelp.Location = New System.Drawing.Point(582, 597)
        Me.LinkLabelHelp.Name = "LinkLabelHelp"
        Me.LinkLabelHelp.Size = New System.Drawing.Size(28, 13)
        Me.LinkLabelHelp.TabIndex = 13
        Me.LinkLabelHelp.TabStop = True
        Me.LinkLabelHelp.Text = "Hilfe"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 756)
        Me.Controls.Add(Me.LinkLabelHelp)
        Me.Controls.Add(Me.LinkLabelAuthor)
        Me.Controls.Add(Me.LabelVer)
        Me.Controls.Add(Me.GroupCommunication)
        Me.Controls.Add(Me.GroupLogger)
        Me.Controls.Add(Me.GroupLog)
        Me.Controls.Add(Me.GroupExtra)
        Me.Controls.Add(Me.GroupPin)
        Me.Controls.Add(Me.GroupSettings)
        Me.Controls.Add(Me.GroupEnergy)
        Me.Controls.Add(Me.GroupActual)
        Me.Controls.Add(Me.GroupConnection)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Moderne Messeinrichtung Modbus RTU"
        Me.GroupConnection.ResumeLayout(False)
        Me.GroupConnection.PerformLayout()
        Me.GroupTCP.ResumeLayout(False)
        Me.GroupTCP.PerformLayout()
        CType(Me.TCPPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupReadingHead.ResumeLayout(False)
        Me.GroupReadingHead.PerformLayout()
        CType(Me.ReadingHeadAddress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupRTU.ResumeLayout(False)
        Me.GroupRTU.PerformLayout()
        Me.GroupSerial.ResumeLayout(False)
        Me.GroupSerial.PerformLayout()
        CType(Me.CommunicationIntervall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupActual.ResumeLayout(False)
        Me.TableActual.ResumeLayout(False)
        Me.TableActual.PerformLayout()
        Me.GroupEnergy.ResumeLayout(False)
        Me.TableEnergy.ResumeLayout(False)
        Me.TableEnergy.PerformLayout()
        Me.GroupSettings.ResumeLayout(False)
        Me.GroupSettingsParam.ResumeLayout(False)
        Me.GroupSettingsParam.PerformLayout()
        CType(Me.SettingTimestamp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SettingMeasInt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SettingFWVer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SettingHWVer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SettingManID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SettingDevID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPin.ResumeLayout(False)
        CType(Me.PINNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupExtra.ResumeLayout(False)
        Me.GroupExtra.PerformLayout()
        Me.GroupLog.ResumeLayout(False)
        Me.GroupLog.PerformLayout()
        Me.GroupLogger.ResumeLayout(False)
        Me.GroupLogger.PerformLayout()
        Me.GroupCommunication.ResumeLayout(False)
        Me.GroupCommunication.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupConnection As GroupBox
    Friend WithEvents LabelTRUPort As Label
    Friend WithEvents RTUPort As ComboBox
    Friend WithEvents GroupRTU As GroupBox
    Friend WithEvents GroupReadingHead As GroupBox
    Friend WithEvents CommunicationManual As Button
    Friend WithEvents CommunicationStart As Button
    Friend WithEvents CommunicationIntervall As NumericUpDown
    Friend WithEvents LabelInterval As Label
    Friend WithEvents GroupSerial As GroupBox
    Friend WithEvents LabelParity As Label
    Friend WithEvents SerialParity As ComboBox
    Friend WithEvents SerialStopbits As ComboBox
    Friend WithEvents LabelStopbits As Label
    Friend WithEvents ReadingHeadVersion As ComboBox
    Friend WithEvents ReadingHeadAddress As NumericUpDown
    Friend WithEvents LabelVersion As Label
    Friend WithEvents LabelAddress As Label
    Friend WithEvents GroupActual As GroupBox
    Friend WithEvents TableActual As TableLayoutPanel
    Friend WithEvents LabelAcPoP As Label
    Friend WithEvents LabelSum As Label
    Friend WithEvents LabelL3 As Label
    Friend WithEvents LabelL2 As Label
    Friend WithEvents LabelL1 As Label
    Friend WithEvents LabelMeasurement As Label
    Friend WithEvents LabelAcPoN As Label
    Friend WithEvents LabelRePoP As Label
    Friend WithEvents LabelRePoN As Label
    Friend WithEvents LabelApPoP As Label
    Friend WithEvents LabelApPoN As Label
    Friend WithEvents LabelPoFa As Label
    Friend WithEvents LabelCurrent As Label
    Friend WithEvents LabelVoltage As Label
    Friend WithEvents LabelPhSh As Label
    Friend WithEvents LabelAnVol As Label
    Friend WithEvents LabelAcPoPN As Label
    Friend WithEvents LabelFreq As Label
    Friend WithEvents LabelAngL1L1 As Label
    Friend WithEvents LabelAcPoPNL1 As Label
    Friend WithEvents LabelAcPoPNL2 As Label
    Friend WithEvents LabelAcPoPNL3 As Label
    Friend WithEvents LabelFreqL1 As Label
    Friend WithEvents LabelFreqL3 As Label
    Friend WithEvents LabelFreqL2 As Label
    Friend WithEvents LabelAngSum As Label
    Friend WithEvents LabelPhShSum As Label
    Friend WithEvents LabelVoltageSum As Label
    Friend WithEvents LabelCurSum As Label
    Friend WithEvents Frequency As TextBox
    Friend WithEvents AcPoPNSum As TextBox
    Friend WithEvents AngL3L1 As TextBox
    Friend WithEvents AngL2L1 As TextBox
    Friend WithEvents PhShL3 As TextBox
    Friend WithEvents PhShL2 As TextBox
    Friend WithEvents PhShL1 As TextBox
    Friend WithEvents VolL3 As TextBox
    Friend WithEvents VolL2 As TextBox
    Friend WithEvents VolL1 As TextBox
    Friend WithEvents CurL3 As TextBox
    Friend WithEvents CurL2 As TextBox
    Friend WithEvents CurL1 As TextBox
    Friend WithEvents PoFaSum As TextBox
    Friend WithEvents PoFaL3 As TextBox
    Friend WithEvents PoFaL2 As TextBox
    Friend WithEvents PoFaL1 As TextBox
    Friend WithEvents ApPoNSum As TextBox
    Friend WithEvents ApPoNL3 As TextBox
    Friend WithEvents ApPoNL2 As TextBox
    Friend WithEvents ApPoNL1 As TextBox
    Friend WithEvents ApPoPSum As TextBox
    Friend WithEvents ApPoPL3 As TextBox
    Friend WithEvents ApPoPL2 As TextBox
    Friend WithEvents ApPoPL1 As TextBox
    Friend WithEvents RePoNSum As TextBox
    Friend WithEvents RePoNL3 As TextBox
    Friend WithEvents RePoNL2 As TextBox
    Friend WithEvents RePoNL1 As TextBox
    Friend WithEvents RePoPSum As TextBox
    Friend WithEvents RePoPL3 As TextBox
    Friend WithEvents RePoPL2 As TextBox
    Friend WithEvents RePoPL1 As TextBox
    Friend WithEvents AcPoNSum As TextBox
    Friend WithEvents AcPoNL3 As TextBox
    Friend WithEvents AcPoNL2 As TextBox
    Friend WithEvents AcPoNL1 As TextBox
    Friend WithEvents AcPoPSum As TextBox
    Friend WithEvents AcPoPL3 As TextBox
    Friend WithEvents AcPoPL2 As TextBox
    Friend WithEvents AcPoPL1 As TextBox
    Friend WithEvents GroupEnergy As GroupBox
    Friend WithEvents TableEnergy As TableLayoutPanel
    Friend WithEvents AcEnNT1 As TextBox
    Friend WithEvents AcEnNT0 As TextBox
    Friend WithEvents LabelMeasurementEn As Label
    Friend WithEvents LabelTariff0 As Label
    Friend WithEvents LabelTariff1 As Label
    Friend WithEvents LabelTariff3 As Label
    Friend WithEvents LabelAcEnPo As Label
    Friend WithEvents AcEnPT2 As TextBox
    Friend WithEvents AcEnPT0 As TextBox
    Friend WithEvents AcEnPT1 As TextBox
    Friend WithEvents AcEnNT2 As TextBox
    Friend WithEvents LabelAcEnN As Label
    Friend WithEvents GroupSettings As GroupBox
    Friend WithEvents SettingWrite As Button
    Friend WithEvents LabelTimestamp As Label
    Friend WithEvents SettingRead As Button
    Friend WithEvents SettingAcPowCalc As CheckBox
    Friend WithEvents SettingMeasIntAuto As CheckBox
    Friend WithEvents LabelMeasInt As Label
    Friend WithEvents LabelFWVer As Label
    Friend WithEvents LabelHWVer As Label
    Friend WithEvents LabelDeviceID As Label
    Friend WithEvents LabelManufacturerID As Label
    Friend WithEvents GroupPin As GroupBox
    Friend WithEvents PINSend As Button
    Friend WithEvents GroupExtra As GroupBox
    Friend WithEvents GroupLog As GroupBox
    Friend WithEvents ConnectionConnect As Button
    Friend WithEvents LabelBaud As Label
    Friend WithEvents SerialBaud As ComboBox
    Friend WithEvents GroupLogger As GroupBox
    Friend WithEvents LoggerOutput As TextBox
    Friend WithEvents LoggerClear As Button
    Friend WithEvents LinkLabelAuthor As LinkLabel
    Friend WithEvents LabelVer As Label
    Friend WithEvents ComInt As Timer
    Friend WithEvents LoggerExport As Button
    Friend WithEvents PINNumber As NumericUpDown
    Friend WithEvents SettingTimestamp As NumericUpDown
    Friend WithEvents SettingMeasInt As NumericUpDown
    Friend WithEvents SettingFWVer As NumericUpDown
    Friend WithEvents SettingHWVer As NumericUpDown
    Friend WithEvents SettingDevID As NumericUpDown
    Friend WithEvents SettingManID As NumericUpDown
    Friend WithEvents GroupSettingsParam As GroupBox
    Friend WithEvents ReadingHeadTemperature As Label
    Friend WithEvents LabelTemperature As Label
    Friend WithEvents ServerID As Label
    Friend WithEvents LabelServerID As Label
    Friend WithEvents ReadingHeadID As Label
    Friend WithEvents LabelReadingHeadID As Label
    Friend WithEvents ReadingHeadData As Label
    Friend WithEvents LabelData As Label
    Friend WithEvents ReadingHeadTimestamp As Label
    Friend WithEvents LabelTimestamp2 As Label
    Friend WithEvents PinProgress As ProgressBar
    Friend WithEvents PinWait As Timer
    Friend WithEvents LogFileOpen As Button
    Friend WithEvents LogActive As CheckBox
    Friend WithEvents LogSearchPath As Button
    Friend WithEvents LabelPath As Label
    Friend WithEvents LogFilePath As TextBox
    Friend WithEvents GroupTCP As GroupBox
    Friend WithEvents TCPActive As CheckBox
    Friend WithEvents LabelTCPPort As Label
    Friend WithEvents LabelTCPIP As Label
    Friend WithEvents TCPIPAddress As TextBox
    Friend WithEvents GroupCommunication As GroupBox
    Friend WithEvents TCPPort As NumericUpDown
    Friend WithEvents CommunicationProgress As ProgressBar
    Friend WithEvents LinkLabelHelp As LinkLabel
End Class
