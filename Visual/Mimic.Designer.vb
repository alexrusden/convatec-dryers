<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mimic
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mimic))
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label15 = New System.Windows.Forms.Label
    Me.Label16 = New System.Windows.Forms.Label
    Me.Label17 = New System.Windows.Forms.Label
    Me.Label18 = New System.Windows.Forms.Label
    Me.Label19 = New System.Windows.Forms.Label
    Me.Label20 = New System.Windows.Forms.Label
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    Me.Label32 = New System.Windows.Forms.Label
    Me.Label33 = New System.Windows.Forms.Label
    Me.Label34 = New System.Windows.Forms.Label
    Me.Label35 = New System.Windows.Forms.Label
    Me.Label36 = New System.Windows.Forms.Label
    Me.Label37 = New System.Windows.Forms.Label
    Me.Label38 = New System.Windows.Forms.Label
    Me.Label39 = New System.Windows.Forms.Label
    Me.Label40 = New System.Windows.Forms.Label
    Me.Label43 = New System.Windows.Forms.Label
    Me.Label44 = New System.Windows.Forms.Label
    Me.Label45 = New System.Windows.Forms.Label
    Me.Label46 = New System.Windows.Forms.Label
    Me.Label48 = New System.Windows.Forms.Label
    Me.Label42 = New System.Windows.Forms.Label
    Me.Label41 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.Button1 = New System.Windows.Forms.Button
    Me.Label31 = New System.Windows.Forms.Label
    Me.RevLabel = New System.Windows.Forms.Label
    Me.Label5 = New System.Windows.Forms.Label
    Me.Label49 = New System.Windows.Forms.Label
    Me.Label50 = New System.Windows.Forms.Label
    Me.Panel16 = New MimicControls.Panel
    Me.IO_PT1Pressure = New MimicControls.ValueLabel
    Me.Panel15 = New MimicControls.Panel
    Me.IO_PT2Pressure = New MimicControls.ValueLabel
    Me.Panel14 = New MimicControls.Panel
    Me.DifferentialPressure = New MimicControls.ValueLabel
    Me.Panel20 = New MimicControls.Panel
    Me.DisplayCKTemp = New MimicControls.ValueLabel
    Me.Panel19 = New MimicControls.Panel
    Me.DPSetPoint = New MimicControls.ValueLabel
    Me.IO_HeatExchangeDrain = New MimicControls.Valve
    Me.Panel21 = New MimicControls.Panel
    Me.IO_FanBearing2Temp = New MimicControls.ValueLabel
    Me.Panel18 = New MimicControls.Panel
    Me.IO_FanBearing1Temp = New MimicControls.ValueLabel
    Me.Panel17 = New MimicControls.Panel
    Me.FanCurrentDV = New MimicControls.ValueLabel
    Me.Lamp1 = New MimicControls.Lamp
    Me.Panel5 = New MimicControls.Panel
    Me.OpenLid_PB = New System.Windows.Forms.Button
    Me.StopLid_PB = New System.Windows.Forms.Button
    Me.CloseLid_PB = New System.Windows.Forms.Button
    Me.IO_TrapIsolationValve = New MimicControls.Valve
    Me.Panel12 = New MimicControls.Panel
    Me.PressureIsSafe = New MimicControls.Lamp
    Me.Label29 = New System.Windows.Forms.Label
    Me.PressIsSafeTimer = New MimicControls.Label
    Me.IO_FanDrain = New MimicControls.Valve
    Me.IO_FanSeal = New MimicControls.Output
    Me.IO_FanCoolerMotor = New MimicControls.Output
    Me.IO_FanRun = New MimicControls.Output
    Me.Panel11 = New MimicControls.Panel
    Me.IO_CoolingValve = New MimicControls.ValueLabel
    Me.Panel10 = New MimicControls.Panel
    Me.CoolSetting = New MimicControls.ValueLabel
    Me.Panel9 = New MimicControls.Panel
    Me.InletTempSetting = New MimicControls.ValueLabel
    Me.Lid6 = New MimicControls.PictureBox
    Me.Lid1 = New MimicControls.PictureBox
    Me.IO_KierWaterVent = New MimicControls.Valve
    Me.Panel4 = New MimicControls.Panel
    Me.IO_FanCurrent = New MimicControls.ValueLabel
    Me.Panel1 = New MimicControls.Panel
    Me.IO_FanSpeed = New MimicControls.ValueLabel
    Me.Panel3 = New MimicControls.Panel
    Me.OutletTempSetting = New MimicControls.ValueLabel
    Me.Panel2 = New MimicControls.Panel
    Me.IO_HeatingValve = New MimicControls.ValueLabel
    Me.Panel8 = New MimicControls.Panel
    Me.IO_OutletTemperature = New MimicControls.ValueLabel
    Me.Panel6 = New MimicControls.Panel
    Me.IO_InletTemperature = New MimicControls.ValueLabel
    Me.Panel7 = New MimicControls.Panel
    Me.IO_CondenserTemperature = New MimicControls.ValueLabel
    Me.Panel13 = New MimicControls.Panel
    Me.IO_PressureLidSeal = New MimicControls.Output
    Me.IO_VacuumLidSeal = New MimicControls.Output
    Me.Label30 = New System.Windows.Forms.Label
    Me.IO_UnlockShootBolt = New MimicControls.Output
    Me.IO_LidRingClose = New MimicControls.Output
    Me.IO_LidRingOpen = New MimicControls.Output
    Me.IO_LidClose = New MimicControls.Output
    Me.IO_LidOpen = New MimicControls.Output
    Me.Label28 = New System.Windows.Forms.Label
    Me.Label27 = New System.Windows.Forms.Label
    Me.Label8 = New System.Windows.Forms.Label
    Me.Label9 = New System.Windows.Forms.Label
    Me.Label26 = New System.Windows.Forms.Label
    Me.Label12 = New System.Windows.Forms.Label
    Me.Label10 = New System.Windows.Forms.Label
    Me.Label25 = New System.Windows.Forms.Label
    Me.Label13 = New System.Windows.Forms.Label
    Me.ShootBoltOut = New MimicControls.Lamp
    Me.Label24 = New System.Windows.Forms.Label
    Me.IO_LidIsClosed = New MimicControls.Lamp
    Me.IO_ShootBoltIn = New MimicControls.Lamp
    Me.Label23 = New System.Windows.Forms.Label
    Me.Label11 = New System.Windows.Forms.Label
    Me.IO_LidRingIsClosed = New MimicControls.Lamp
    Me.Label22 = New System.Windows.Forms.Label
    Me.Label7 = New System.Windows.Forms.Label
    Me.IO_LidRingIsOpen = New MimicControls.Lamp
    Me.Label21 = New System.Windows.Forms.Label
    Me.IO_LidIsOpen = New MimicControls.Lamp
    Me.Label6 = New System.Windows.Forms.Label
    Me.IO_KierEmptyLevel = New MimicControls.Lamp
    Me.IO_KierWaterFill = New MimicControls.Valve
    Me.FlowOutToIn = New MimicControls.Lamp
    Me.FlowInToOut = New MimicControls.Lamp
    Me.IO_CondenserDrain = New MimicControls.Valve
    Me.IO_KierFullLevel = New MimicControls.Lamp
    Me.IO_Depressurise = New MimicControls.Valve
    Me.IO_Pressurise = New MimicControls.Valve
    Me.IO_SumpDrain = New MimicControls.Valve
    Me.Lid3 = New MimicControls.PictureBox
    Me.Panel16.SuspendLayout()
    Me.Panel15.SuspendLayout()
    Me.Panel14.SuspendLayout()
    Me.Panel20.SuspendLayout()
    Me.Panel19.SuspendLayout()
    Me.Panel21.SuspendLayout()
    Me.Panel18.SuspendLayout()
    Me.Panel17.SuspendLayout()
    Me.Panel5.SuspendLayout()
    Me.Panel12.SuspendLayout()
    Me.Panel11.SuspendLayout()
    Me.Panel10.SuspendLayout()
    Me.Panel9.SuspendLayout()
    Me.Panel4.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.Panel3.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.Panel8.SuspendLayout()
    Me.Panel6.SuspendLayout()
    Me.Panel7.SuspendLayout()
    Me.Panel13.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.BackColor = System.Drawing.Color.Transparent
    Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.Color.Black
    Me.Label1.Location = New System.Drawing.Point(372, 323)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(25, 13)
    Me.Label1.TabIndex = 76
    Me.Label1.Text = "<>"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.ForeColor = System.Drawing.Color.Black
    Me.Label2.Location = New System.Drawing.Point(372, 333)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(25, 13)
    Me.Label2.TabIndex = 77
    Me.Label2.Text = "><"
    '
    'Label15
    '
    Me.Label15.AutoSize = True
    Me.Label15.BackColor = System.Drawing.Color.Transparent
    Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label15.ForeColor = System.Drawing.Color.White
    Me.Label15.Location = New System.Drawing.Point(360, 354)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(22, 13)
    Me.Label15.TabIndex = 93
    Me.Label15.Text = "D1"
    '
    'Label16
    '
    Me.Label16.AutoSize = True
    Me.Label16.BackColor = System.Drawing.Color.Transparent
    Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label16.ForeColor = System.Drawing.Color.White
    Me.Label16.Location = New System.Drawing.Point(283, 406)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(20, 13)
    Me.Label16.TabIndex = 95
    Me.Label16.Text = "F1"
    '
    'Label17
    '
    Me.Label17.AutoSize = True
    Me.Label17.BackColor = System.Drawing.Color.Transparent
    Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label17.ForeColor = System.Drawing.Color.White
    Me.Label17.Location = New System.Drawing.Point(443, 156)
    Me.Label17.Name = "Label17"
    Me.Label17.Size = New System.Drawing.Size(20, 13)
    Me.Label17.TabIndex = 96
    Me.Label17.Text = "L2"
    '
    'Label18
    '
    Me.Label18.AutoSize = True
    Me.Label18.BackColor = System.Drawing.Color.Transparent
    Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label18.ForeColor = System.Drawing.Color.White
    Me.Label18.Location = New System.Drawing.Point(461, 130)
    Me.Label18.Name = "Label18"
    Me.Label18.Size = New System.Drawing.Size(21, 13)
    Me.Label18.TabIndex = 97
    Me.Label18.Text = "V1"
    '
    'Label19
    '
    Me.Label19.AutoSize = True
    Me.Label19.BackColor = System.Drawing.Color.Transparent
    Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label19.ForeColor = System.Drawing.Color.White
    Me.Label19.Location = New System.Drawing.Point(629, 353)
    Me.Label19.Name = "Label19"
    Me.Label19.Size = New System.Drawing.Size(22, 13)
    Me.Label19.TabIndex = 98
    Me.Label19.Text = "D2"
    '
    'Label20
    '
    Me.Label20.AutoSize = True
    Me.Label20.BackColor = System.Drawing.Color.Transparent
    Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label20.ForeColor = System.Drawing.Color.White
    Me.Label20.Location = New System.Drawing.Point(477, 488)
    Me.Label20.Name = "Label20"
    Me.Label20.Size = New System.Drawing.Size(35, 13)
    Me.Label20.TabIndex = 99
    Me.Label20.Text = "NPV1"
    '
    'Timer1
    '
    Me.Timer1.Enabled = True
    Me.Timer1.Interval = 500
    '
    'Label32
    '
    Me.Label32.AutoSize = True
    Me.Label32.BackColor = System.Drawing.Color.Transparent
    Me.Label32.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label32.ForeColor = System.Drawing.Color.White
    Me.Label32.Location = New System.Drawing.Point(421, 488)
    Me.Label32.Name = "Label32"
    Me.Label32.Size = New System.Drawing.Size(36, 13)
    Me.Label32.TabIndex = 116
    Me.Label32.Text = "PRV1"
    '
    'Label33
    '
    Me.Label33.AutoSize = True
    Me.Label33.BackColor = System.Drawing.Color.Transparent
    Me.Label33.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label33.ForeColor = System.Drawing.Color.White
    Me.Label33.Location = New System.Drawing.Point(662, 388)
    Me.Label33.Name = "Label33"
    Me.Label33.Size = New System.Drawing.Size(55, 13)
    Me.Label33.TabIndex = 117
    Me.Label33.Text = "PT100/1"
    '
    'Label34
    '
    Me.Label34.AutoSize = True
    Me.Label34.BackColor = System.Drawing.Color.Transparent
    Me.Label34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label34.ForeColor = System.Drawing.Color.White
    Me.Label34.Location = New System.Drawing.Point(230, 301)
    Me.Label34.Name = "Label34"
    Me.Label34.Size = New System.Drawing.Size(55, 13)
    Me.Label34.TabIndex = 118
    Me.Label34.Text = "PT100/2"
    '
    'Label35
    '
    Me.Label35.AutoSize = True
    Me.Label35.BackColor = System.Drawing.Color.Transparent
    Me.Label35.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label35.ForeColor = System.Drawing.Color.White
    Me.Label35.Location = New System.Drawing.Point(498, 302)
    Me.Label35.Name = "Label35"
    Me.Label35.Size = New System.Drawing.Size(55, 13)
    Me.Label35.TabIndex = 119
    Me.Label35.Text = "PT100/3"
    '
    'Label36
    '
    Me.Label36.AutoSize = True
    Me.Label36.BackColor = System.Drawing.Color.Transparent
    Me.Label36.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label36.ForeColor = System.Drawing.Color.White
    Me.Label36.Location = New System.Drawing.Point(228, 325)
    Me.Label36.Name = "Label36"
    Me.Label36.Size = New System.Drawing.Size(58, 13)
    Me.Label36.TabIndex = 130
    Me.Label36.Text = "Set Point"
    '
    'Label37
    '
    Me.Label37.AutoSize = True
    Me.Label37.BackColor = System.Drawing.Color.Transparent
    Me.Label37.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label37.ForeColor = System.Drawing.Color.White
    Me.Label37.Location = New System.Drawing.Point(497, 326)
    Me.Label37.Name = "Label37"
    Me.Label37.Size = New System.Drawing.Size(58, 13)
    Me.Label37.TabIndex = 131
    Me.Label37.Text = "Set Point"
    '
    'Label38
    '
    Me.Label38.AutoSize = True
    Me.Label38.BackColor = System.Drawing.Color.Transparent
    Me.Label38.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label38.ForeColor = System.Drawing.Color.White
    Me.Label38.Location = New System.Drawing.Point(659, 408)
    Me.Label38.Name = "Label38"
    Me.Label38.Size = New System.Drawing.Size(58, 13)
    Me.Label38.TabIndex = 132
    Me.Label38.Text = "Set Point"
    '
    'Label39
    '
    Me.Label39.AutoSize = True
    Me.Label39.BackColor = System.Drawing.Color.Transparent
    Me.Label39.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label39.ForeColor = System.Drawing.Color.White
    Me.Label39.Location = New System.Drawing.Point(197, 448)
    Me.Label39.Name = "Label39"
    Me.Label39.Size = New System.Drawing.Size(20, 13)
    Me.Label39.TabIndex = 137
    Me.Label39.Text = "F2"
    '
    'Label40
    '
    Me.Label40.AutoSize = True
    Me.Label40.BackColor = System.Drawing.Color.Transparent
    Me.Label40.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label40.ForeColor = System.Drawing.Color.White
    Me.Label40.Location = New System.Drawing.Point(329, 487)
    Me.Label40.Name = "Label40"
    Me.Label40.Size = New System.Drawing.Size(22, 13)
    Me.Label40.TabIndex = 138
    Me.Label40.Text = "D3"
    '
    'Label43
    '
    Me.Label43.AutoSize = True
    Me.Label43.BackColor = System.Drawing.Color.Transparent
    Me.Label43.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label43.ForeColor = System.Drawing.Color.White
    Me.Label43.Location = New System.Drawing.Point(334, 408)
    Me.Label43.Name = "Label43"
    Me.Label43.Size = New System.Drawing.Size(35, 13)
    Me.Label43.TabIndex = 139
    Me.Label43.Text = "NPV2"
    '
    'Label44
    '
    Me.Label44.AutoSize = True
    Me.Label44.BackColor = System.Drawing.Color.Transparent
    Me.Label44.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label44.ForeColor = System.Drawing.Color.White
    Me.Label44.Location = New System.Drawing.Point(63, 344)
    Me.Label44.Name = "Label44"
    Me.Label44.Size = New System.Drawing.Size(29, 13)
    Me.Label44.TabIndex = 140
    Me.Label44.Text = "HV1"
    '
    'Label45
    '
    Me.Label45.AutoSize = True
    Me.Label45.BackColor = System.Drawing.Color.Transparent
    Me.Label45.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label45.ForeColor = System.Drawing.Color.White
    Me.Label45.Location = New System.Drawing.Point(684, 257)
    Me.Label45.Name = "Label45"
    Me.Label45.Size = New System.Drawing.Size(28, 13)
    Me.Label45.TabIndex = 141
    Me.Label45.Text = "CV1"
    '
    'Label46
    '
    Me.Label46.AutoSize = True
    Me.Label46.BackColor = System.Drawing.Color.Transparent
    Me.Label46.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label46.ForeColor = System.Drawing.Color.White
    Me.Label46.Location = New System.Drawing.Point(134, 487)
    Me.Label46.Name = "Label46"
    Me.Label46.Size = New System.Drawing.Size(21, 13)
    Me.Label46.TabIndex = 142
    Me.Label46.Text = "V2"
    '
    'Label48
    '
    Me.Label48.AutoSize = True
    Me.Label48.BackColor = System.Drawing.Color.Transparent
    Me.Label48.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label48.ForeColor = System.Drawing.Color.White
    Me.Label48.Location = New System.Drawing.Point(519, 448)
    Me.Label48.Name = "Label48"
    Me.Label48.Size = New System.Drawing.Size(20, 13)
    Me.Label48.TabIndex = 145
    Me.Label48.Text = "L1"
    '
    'Label42
    '
    Me.Label42.AutoSize = True
    Me.Label42.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.Label42.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label42.ForeColor = System.Drawing.Color.White
    Me.Label42.Location = New System.Drawing.Point(531, 233)
    Me.Label42.Name = "Label42"
    Me.Label42.Size = New System.Drawing.Size(77, 11)
    Me.Label42.TabIndex = 121
    Me.Label42.Text = "PT 2 Pressure"
    '
    'Label41
    '
    Me.Label41.AutoSize = True
    Me.Label41.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.Label41.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label41.ForeColor = System.Drawing.Color.White
    Me.Label41.Location = New System.Drawing.Point(532, 192)
    Me.Label41.Name = "Label41"
    Me.Label41.Size = New System.Drawing.Size(77, 11)
    Me.Label41.TabIndex = 120
    Me.Label41.Text = "PT 1 Pressure"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.Label3.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.ForeColor = System.Drawing.Color.White
    Me.Label3.Location = New System.Drawing.Point(531, 213)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(65, 11)
    Me.Label3.TabIndex = 118
    Me.Label3.Text = "Differential "
    '
    'Button1
    '
    Me.Button1.BackColor = System.Drawing.SystemColors.ButtonShadow
    Me.Button1.Location = New System.Drawing.Point(592, 469)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(59, 50)
    Me.Button1.TabIndex = 114
    Me.Button1.Text = "Close Lid"
    Me.Button1.UseVisualStyleBackColor = False
    Me.Button1.Visible = False
    '
    'Label31
    '
    Me.Label31.AutoSize = True
    Me.Label31.BackColor = System.Drawing.Color.Transparent
    Me.Label31.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label31.ForeColor = System.Drawing.Color.White
    Me.Label31.Location = New System.Drawing.Point(690, 353)
    Me.Label31.Name = "Label31"
    Me.Label31.Size = New System.Drawing.Size(21, 13)
    Me.Label31.TabIndex = 150
    Me.Label31.Text = "V3"
    '
    'RevLabel
    '
    Me.RevLabel.AutoSize = True
    Me.RevLabel.BackColor = System.Drawing.Color.Transparent
    Me.RevLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.RevLabel.Location = New System.Drawing.Point(417, 328)
    Me.RevLabel.Name = "RevLabel"
    Me.RevLabel.Size = New System.Drawing.Size(37, 12)
    Me.RevLabel.TabIndex = 151
    Me.RevLabel.Text = "Label49"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.ForeColor = System.Drawing.Color.White
    Me.Label5.Location = New System.Drawing.Point(531, 261)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(58, 13)
    Me.Label5.TabIndex = 157
    Me.Label5.Text = "Set Point"
    Me.Label5.Visible = False
    '
    'Label49
    '
    Me.Label49.AutoSize = True
    Me.Label49.BackColor = System.Drawing.Color.Transparent
    Me.Label49.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label49.ForeColor = System.Drawing.Color.White
    Me.Label49.Location = New System.Drawing.Point(171, 352)
    Me.Label49.Name = "Label49"
    Me.Label49.Size = New System.Drawing.Size(22, 13)
    Me.Label49.TabIndex = 160
    Me.Label49.Text = "D4"
    '
    'Label50
    '
    Me.Label50.AutoSize = True
    Me.Label50.BackColor = System.Drawing.Color.Transparent
    Me.Label50.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label50.ForeColor = System.Drawing.Color.White
    Me.Label50.Location = New System.Drawing.Point(63, 360)
    Me.Label50.Name = "Label50"
    Me.Label50.Size = New System.Drawing.Size(21, 13)
    Me.Label50.TabIndex = 161
    Me.Label50.Text = "SP"
    '
    'Panel16
    '
    Me.Panel16.BackColor = System.Drawing.Color.LightGray
    Me.Panel16.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel16.Controls.Add(Me.IO_PT1Pressure)
    Me.Panel16.Location = New System.Drawing.Point(447, 188)
    Me.Panel16.Name = "Panel16"
    Me.Panel16.Size = New System.Drawing.Size(82, 22)
    Me.Panel16.TabIndex = 121
    '
    'IO_PT1Pressure
    '
    Me.IO_PT1Pressure.AutoSize = False
    Me.IO_PT1Pressure.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.IO_PT1Pressure.ForeColor = System.Drawing.Color.Black
    Me.IO_PT1Pressure.Format = "0 mBar"
    Me.IO_PT1Pressure.Location = New System.Drawing.Point(4, 4)
    Me.IO_PT1Pressure.Name = "IO_PT1Pressure"
    Me.IO_PT1Pressure.Size = New System.Drawing.Size(74, 13)
    Me.IO_PT1Pressure.TabIndex = 58
    Me.IO_PT1Pressure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Panel15
    '
    Me.Panel15.BackColor = System.Drawing.Color.LightGray
    Me.Panel15.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel15.Controls.Add(Me.IO_PT2Pressure)
    Me.Panel15.Location = New System.Drawing.Point(447, 229)
    Me.Panel15.Name = "Panel15"
    Me.Panel15.Size = New System.Drawing.Size(82, 22)
    Me.Panel15.TabIndex = 120
    '
    'IO_PT2Pressure
    '
    Me.IO_PT2Pressure.AutoSize = False
    Me.IO_PT2Pressure.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.IO_PT2Pressure.ForeColor = System.Drawing.Color.Black
    Me.IO_PT2Pressure.Format = "0 mBar"
    Me.IO_PT2Pressure.Location = New System.Drawing.Point(2, 3)
    Me.IO_PT2Pressure.Name = "IO_PT2Pressure"
    Me.IO_PT2Pressure.Size = New System.Drawing.Size(78, 15)
    Me.IO_PT2Pressure.TabIndex = 58
    Me.IO_PT2Pressure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Panel14
    '
    Me.Panel14.BackColor = System.Drawing.Color.LightGray
    Me.Panel14.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel14.Controls.Add(Me.DifferentialPressure)
    Me.Panel14.Location = New System.Drawing.Point(447, 208)
    Me.Panel14.Name = "Panel14"
    Me.Panel14.Size = New System.Drawing.Size(82, 22)
    Me.Panel14.TabIndex = 148
    '
    'DifferentialPressure
    '
    Me.DifferentialPressure.AutoSize = False
    Me.DifferentialPressure.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.DifferentialPressure.ForeColor = System.Drawing.Color.Black
    Me.DifferentialPressure.Format = "0 mBar"
    Me.DifferentialPressure.Location = New System.Drawing.Point(8, 4)
    Me.DifferentialPressure.Name = "DifferentialPressure"
    Me.DifferentialPressure.Size = New System.Drawing.Size(67, 11)
    Me.DifferentialPressure.TabIndex = 119
    Me.DifferentialPressure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Panel20
    '
    Me.Panel20.BackColor = System.Drawing.Color.LightGray
    Me.Panel20.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel20.Controls.Add(Me.DisplayCKTemp)
    Me.Panel20.Location = New System.Drawing.Point(93, 358)
    Me.Panel20.Name = "Panel20"
    Me.Panel20.Size = New System.Drawing.Size(51, 18)
    Me.Panel20.TabIndex = 122
    '
    'DisplayCKTemp
    '
    Me.DisplayCKTemp.AutoSize = False
    Me.DisplayCKTemp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.DisplayCKTemp.ForeColor = System.Drawing.Color.Black
    Me.DisplayCKTemp.Format = "0%"
    Me.DisplayCKTemp.Location = New System.Drawing.Point(5, 2)
    Me.DisplayCKTemp.Name = "DisplayCKTemp"
    Me.DisplayCKTemp.NumberScale = 10000
    Me.DisplayCKTemp.Size = New System.Drawing.Size(41, 13)
    Me.DisplayCKTemp.TabIndex = 59
    Me.DisplayCKTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Panel19
    '
    Me.Panel19.BackColor = System.Drawing.Color.LightGray
    Me.Panel19.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel19.Controls.Add(Me.DPSetPoint)
    Me.Panel19.Location = New System.Drawing.Point(447, 259)
    Me.Panel19.Name = "Panel19"
    Me.Panel19.Size = New System.Drawing.Size(82, 22)
    Me.Panel19.TabIndex = 122
    Me.Panel19.Visible = False
    '
    'DPSetPoint
    '
    Me.DPSetPoint.AutoSize = False
    Me.DPSetPoint.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.DPSetPoint.ForeColor = System.Drawing.Color.Black
    Me.DPSetPoint.Format = "0 mBar"
    Me.DPSetPoint.Location = New System.Drawing.Point(4, 4)
    Me.DPSetPoint.Name = "DPSetPoint"
    Me.DPSetPoint.Size = New System.Drawing.Size(74, 13)
    Me.DPSetPoint.TabIndex = 58
    Me.DPSetPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'IO_HeatExchangeDrain
    '
    Me.IO_HeatExchangeDrain.Location = New System.Drawing.Point(155, 352)
    Me.IO_HeatExchangeDrain.Name = "IO_HeatExchangeDrain"
    Me.IO_HeatExchangeDrain.OffColor = System.Drawing.Color.Red
    Me.IO_HeatExchangeDrain.Orientation = System.Windows.Forms.Orientation.Vertical
    Me.IO_HeatExchangeDrain.Size = New System.Drawing.Size(14, 14)
    Me.IO_HeatExchangeDrain.TabIndex = 159
    '
    'Panel21
    '
    Me.Panel21.BackColor = System.Drawing.Color.LightGray
    Me.Panel21.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel21.Controls.Add(Me.IO_FanBearing2Temp)
    Me.Panel21.Location = New System.Drawing.Point(190, 508)
    Me.Panel21.Name = "Panel21"
    Me.Panel21.Size = New System.Drawing.Size(51, 18)
    Me.Panel21.TabIndex = 123
    '
    'IO_FanBearing2Temp
    '
    Me.IO_FanBearing2Temp.AutoSize = False
    Me.IO_FanBearing2Temp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.IO_FanBearing2Temp.ForeColor = System.Drawing.Color.Black
    Me.IO_FanBearing2Temp.Format = "0.0C"
    Me.IO_FanBearing2Temp.Location = New System.Drawing.Point(5, 1)
    Me.IO_FanBearing2Temp.Name = "IO_FanBearing2Temp"
    Me.IO_FanBearing2Temp.NumberScale = 10
    Me.IO_FanBearing2Temp.Size = New System.Drawing.Size(42, 13)
    Me.IO_FanBearing2Temp.TabIndex = 159
    Me.IO_FanBearing2Temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Panel18
    '
    Me.Panel18.BackColor = System.Drawing.Color.LightGray
    Me.Panel18.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel18.Controls.Add(Me.IO_FanBearing1Temp)
    Me.Panel18.Location = New System.Drawing.Point(190, 492)
    Me.Panel18.Name = "Panel18"
    Me.Panel18.Size = New System.Drawing.Size(51, 18)
    Me.Panel18.TabIndex = 122
    '
    'IO_FanBearing1Temp
    '
    Me.IO_FanBearing1Temp.AutoSize = False
    Me.IO_FanBearing1Temp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.IO_FanBearing1Temp.ForeColor = System.Drawing.Color.Black
    Me.IO_FanBearing1Temp.Format = "0.0C"
    Me.IO_FanBearing1Temp.Location = New System.Drawing.Point(4, 2)
    Me.IO_FanBearing1Temp.Name = "IO_FanBearing1Temp"
    Me.IO_FanBearing1Temp.NumberScale = 10
    Me.IO_FanBearing1Temp.Size = New System.Drawing.Size(42, 13)
    Me.IO_FanBearing1Temp.TabIndex = 60
    Me.IO_FanBearing1Temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Panel17
    '
    Me.Panel17.BackColor = System.Drawing.Color.LightGray
    Me.Panel17.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel17.Controls.Add(Me.FanCurrentDV)
    Me.Panel17.Location = New System.Drawing.Point(239, 508)
    Me.Panel17.Name = "Panel17"
    Me.Panel17.Size = New System.Drawing.Size(70, 18)
    Me.Panel17.TabIndex = 125
    '
    'FanCurrentDV
    '
    Me.FanCurrentDV.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FanCurrentDV.ForeColor = System.Drawing.Color.Black
    Me.FanCurrentDV.Format = "0.00 Amp"
    Me.FanCurrentDV.ImeMode = System.Windows.Forms.ImeMode.[On]
    Me.FanCurrentDV.Location = New System.Drawing.Point(8, 1)
    Me.FanCurrentDV.Name = "FanCurrentDV"
    Me.FanCurrentDV.NumberScale = 10
    Me.FanCurrentDV.Size = New System.Drawing.Size(60, 13)
    Me.FanCurrentDV.TabIndex = 60
    '
    'Lamp1
    '
    Me.Lamp1.Location = New System.Drawing.Point(676, 489)
    Me.Lamp1.Name = "Lamp1"
    Me.Lamp1.Size = New System.Drawing.Size(12, 12)
    Me.Lamp1.TabIndex = 149
    Me.Lamp1.Visible = False
    '
    'Panel5
    '
    Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.Panel5.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel5.Controls.Add(Me.OpenLid_PB)
    Me.Panel5.Controls.Add(Me.StopLid_PB)
    Me.Panel5.Controls.Add(Me.CloseLid_PB)
    Me.Panel5.Location = New System.Drawing.Point(16, 5)
    Me.Panel5.Name = "Panel5"
    Me.Panel5.Size = New System.Drawing.Size(212, 77)
    Me.Panel5.TabIndex = 125
    '
    'OpenLid_PB
    '
    Me.OpenLid_PB.BackColor = System.Drawing.SystemColors.ButtonShadow
    Me.OpenLid_PB.Location = New System.Drawing.Point(6, 5)
    Me.OpenLid_PB.Name = "OpenLid_PB"
    Me.OpenLid_PB.Size = New System.Drawing.Size(99, 32)
    Me.OpenLid_PB.TabIndex = 111
    Me.OpenLid_PB.Text = "Open Lid"
    Me.OpenLid_PB.UseVisualStyleBackColor = False
    '
    'StopLid_PB
    '
    Me.StopLid_PB.BackColor = System.Drawing.SystemColors.ButtonShadow
    Me.StopLid_PB.Location = New System.Drawing.Point(5, 39)
    Me.StopLid_PB.Name = "StopLid_PB"
    Me.StopLid_PB.Size = New System.Drawing.Size(202, 34)
    Me.StopLid_PB.TabIndex = 112
    Me.StopLid_PB.Text = "Stop"
    Me.StopLid_PB.UseVisualStyleBackColor = False
    '
    'CloseLid_PB
    '
    Me.CloseLid_PB.BackColor = System.Drawing.SystemColors.ButtonShadow
    Me.CloseLid_PB.Location = New System.Drawing.Point(107, 5)
    Me.CloseLid_PB.Name = "CloseLid_PB"
    Me.CloseLid_PB.Size = New System.Drawing.Size(99, 32)
    Me.CloseLid_PB.TabIndex = 113
    Me.CloseLid_PB.Text = "Close Lid"
    Me.CloseLid_PB.UseVisualStyleBackColor = False
    '
    'IO_TrapIsolationValve
    '
    Me.IO_TrapIsolationValve.Location = New System.Drawing.Point(674, 353)
    Me.IO_TrapIsolationValve.Name = "IO_TrapIsolationValve"
    Me.IO_TrapIsolationValve.OffColor = System.Drawing.Color.Red
    Me.IO_TrapIsolationValve.Orientation = System.Windows.Forms.Orientation.Vertical
    Me.IO_TrapIsolationValve.Size = New System.Drawing.Size(14, 14)
    Me.IO_TrapIsolationValve.TabIndex = 146
    '
    'Panel12
    '
    Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.Panel12.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel12.Controls.Add(Me.PressureIsSafe)
    Me.Panel12.Controls.Add(Me.Label29)
    Me.Panel12.Controls.Add(Me.PressIsSafeTimer)
    Me.Panel12.Location = New System.Drawing.Point(16, 254)
    Me.Panel12.Name = "Panel12"
    Me.Panel12.Size = New System.Drawing.Size(212, 22)
    Me.Panel12.TabIndex = 119
    '
    'PressureIsSafe
    '
    Me.PressureIsSafe.Location = New System.Drawing.Point(162, 4)
    Me.PressureIsSafe.Name = "PressureIsSafe"
    Me.PressureIsSafe.OffColor = System.Drawing.Color.White
    Me.PressureIsSafe.OnColor = System.Drawing.Color.LawnGreen
    Me.PressureIsSafe.Size = New System.Drawing.Size(15, 15)
    Me.PressureIsSafe.TabIndex = 103
    '
    'Label29
    '
    Me.Label29.AutoSize = True
    Me.Label29.BackColor = System.Drawing.Color.Transparent
    Me.Label29.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label29.ForeColor = System.Drawing.Color.White
    Me.Label29.Location = New System.Drawing.Point(54, 4)
    Me.Label29.Name = "Label29"
    Me.Label29.Size = New System.Drawing.Size(85, 13)
    Me.Label29.TabIndex = 102
    Me.Label29.Text = "Pressure Safe"
    '
    'PressIsSafeTimer
    '
    Me.PressIsSafeTimer.ForeColor = System.Drawing.Color.White
    Me.PressIsSafeTimer.Location = New System.Drawing.Point(12, 4)
    Me.PressIsSafeTimer.Name = "PressIsSafeTimer"
    Me.PressIsSafeTimer.Size = New System.Drawing.Size(45, 13)
    Me.PressIsSafeTimer.TabIndex = 117
    Me.PressIsSafeTimer.Text = "Label32"
    '
    'IO_FanDrain
    '
    Me.IO_FanDrain.Location = New System.Drawing.Point(312, 488)
    Me.IO_FanDrain.Name = "IO_FanDrain"
    Me.IO_FanDrain.OffColor = System.Drawing.Color.Red
    Me.IO_FanDrain.Orientation = System.Windows.Forms.Orientation.Vertical
    Me.IO_FanDrain.Size = New System.Drawing.Size(14, 14)
    Me.IO_FanDrain.TabIndex = 136
    '
    'IO_FanSeal
    '
    Me.IO_FanSeal.ForeColor = System.Drawing.Color.Lime
    Me.IO_FanSeal.Location = New System.Drawing.Point(315, 411)
    Me.IO_FanSeal.Name = "IO_FanSeal"
    Me.IO_FanSeal.Size = New System.Drawing.Size(5, 43)
    Me.IO_FanSeal.TabIndex = 135
    '
    'IO_FanCoolerMotor
    '
    Me.IO_FanCoolerMotor.Location = New System.Drawing.Point(186, 450)
    Me.IO_FanCoolerMotor.Name = "IO_FanCoolerMotor"
    Me.IO_FanCoolerMotor.Size = New System.Drawing.Size(12, 12)
    Me.IO_FanCoolerMotor.TabIndex = 134
    '
    'IO_FanRun
    '
    Me.IO_FanRun.Location = New System.Drawing.Point(268, 408)
    Me.IO_FanRun.Name = "IO_FanRun"
    Me.IO_FanRun.Size = New System.Drawing.Size(12, 12)
    Me.IO_FanRun.TabIndex = 133
    '
    'Panel11
    '
    Me.Panel11.BackColor = System.Drawing.Color.LightGray
    Me.Panel11.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel11.Controls.Add(Me.IO_CoolingValve)
    Me.Panel11.Location = New System.Drawing.Point(631, 256)
    Me.Panel11.Name = "Panel11"
    Me.Panel11.Size = New System.Drawing.Size(51, 18)
    Me.Panel11.TabIndex = 122
    '
    'IO_CoolingValve
    '
    Me.IO_CoolingValve.AutoSize = False
    Me.IO_CoolingValve.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.IO_CoolingValve.ForeColor = System.Drawing.Color.Black
    Me.IO_CoolingValve.Format = "0%"
    Me.IO_CoolingValve.Location = New System.Drawing.Point(5, 2)
    Me.IO_CoolingValve.Name = "IO_CoolingValve"
    Me.IO_CoolingValve.NumberScale = 1000
    Me.IO_CoolingValve.Size = New System.Drawing.Size(40, 13)
    Me.IO_CoolingValve.TabIndex = 59
    Me.IO_CoolingValve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Panel10
    '
    Me.Panel10.BackColor = System.Drawing.Color.LightGray
    Me.Panel10.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel10.Controls.Add(Me.CoolSetting)
    Me.Panel10.Location = New System.Drawing.Point(718, 404)
    Me.Panel10.Name = "Panel10"
    Me.Panel10.Size = New System.Drawing.Size(51, 22)
    Me.Panel10.TabIndex = 119
    '
    'CoolSetting
    '
    Me.CoolSetting.AutoSize = False
    Me.CoolSetting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.CoolSetting.ForeColor = System.Drawing.Color.Black
    Me.CoolSetting.Format = "0.0C"
    Me.CoolSetting.Location = New System.Drawing.Point(4, 4)
    Me.CoolSetting.Name = "CoolSetting"
    Me.CoolSetting.Size = New System.Drawing.Size(42, 13)
    Me.CoolSetting.TabIndex = 60
    Me.CoolSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Panel9
    '
    Me.Panel9.BackColor = System.Drawing.Color.LightGray
    Me.Panel9.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel9.Controls.Add(Me.InletTempSetting)
    Me.Panel9.Location = New System.Drawing.Point(287, 319)
    Me.Panel9.Name = "Panel9"
    Me.Panel9.Size = New System.Drawing.Size(51, 22)
    Me.Panel9.TabIndex = 120
    '
    'InletTempSetting
    '
    Me.InletTempSetting.AutoSize = False
    Me.InletTempSetting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.InletTempSetting.ForeColor = System.Drawing.Color.Black
    Me.InletTempSetting.Format = "0.0C"
    Me.InletTempSetting.Location = New System.Drawing.Point(3, 4)
    Me.InletTempSetting.Name = "InletTempSetting"
    Me.InletTempSetting.Size = New System.Drawing.Size(42, 13)
    Me.InletTempSetting.TabIndex = 60
    Me.InletTempSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Lid6
    '
    Me.Lid6.Image = CType(resources.GetObject("Lid6.Image"), Picture)
    Me.Lid6.Location = New System.Drawing.Point(310, 12)
    Me.Lid6.Name = "Lid6"
    Me.Lid6.Size = New System.Drawing.Size(37, 246)
    Me.Lid6.TabIndex = 128
    '
    'Lid1
    '
    Me.Lid1.Image = CType(resources.GetObject("Lid1.Image"), Picture)
    Me.Lid1.Location = New System.Drawing.Point(276, 104)
    Me.Lid1.Name = "Lid1"
    Me.Lid1.Size = New System.Drawing.Size(168, 152)
    Me.Lid1.TabIndex = 127
    '
    'IO_KierWaterVent
    '
    Me.IO_KierWaterVent.Location = New System.Drawing.Point(465, 148)
    Me.IO_KierWaterVent.Name = "IO_KierWaterVent"
    Me.IO_KierWaterVent.OffColor = System.Drawing.Color.Red
    Me.IO_KierWaterVent.Size = New System.Drawing.Size(14, 14)
    Me.IO_KierWaterVent.TabIndex = 65
    '
    'Panel4
    '
    Me.Panel4.BackColor = System.Drawing.Color.LightGray
    Me.Panel4.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel4.Controls.Add(Me.IO_FanCurrent)
    Me.Panel4.Location = New System.Drawing.Point(239, 492)
    Me.Panel4.Name = "Panel4"
    Me.Panel4.Size = New System.Drawing.Size(70, 18)
    Me.Panel4.TabIndex = 124
    '
    'IO_FanCurrent
    '
    Me.IO_FanCurrent.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.IO_FanCurrent.ForeColor = System.Drawing.Color.Black
    Me.IO_FanCurrent.Format = "0.00 Amp"
    Me.IO_FanCurrent.ImeMode = System.Windows.Forms.ImeMode.[On]
    Me.IO_FanCurrent.Location = New System.Drawing.Point(8, 2)
    Me.IO_FanCurrent.Name = "IO_FanCurrent"
    Me.IO_FanCurrent.NumberScale = 10
    Me.IO_FanCurrent.Size = New System.Drawing.Size(60, 13)
    Me.IO_FanCurrent.TabIndex = 60
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.Color.LightGray
    Me.Panel1.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel1.Controls.Add(Me.IO_FanSpeed)
    Me.Panel1.Location = New System.Drawing.Point(239, 476)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(70, 18)
    Me.Panel1.TabIndex = 123
    '
    'IO_FanSpeed
    '
    Me.IO_FanSpeed.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.IO_FanSpeed.ForeColor = System.Drawing.Color.Black
    Me.IO_FanSpeed.Format = "0%"
    Me.IO_FanSpeed.Location = New System.Drawing.Point(22, 2)
    Me.IO_FanSpeed.Name = "IO_FanSpeed"
    Me.IO_FanSpeed.NumberScale = 1000
    Me.IO_FanSpeed.Size = New System.Drawing.Size(27, 13)
    Me.IO_FanSpeed.TabIndex = 59
    '
    'Panel3
    '
    Me.Panel3.BackColor = System.Drawing.Color.LightGray
    Me.Panel3.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel3.Controls.Add(Me.OutletTempSetting)
    Me.Panel3.Location = New System.Drawing.Point(447, 320)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(51, 22)
    Me.Panel3.TabIndex = 122
    '
    'OutletTempSetting
    '
    Me.OutletTempSetting.AutoSize = False
    Me.OutletTempSetting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.OutletTempSetting.ForeColor = System.Drawing.Color.Black
    Me.OutletTempSetting.Format = "0.0C"
    Me.OutletTempSetting.Location = New System.Drawing.Point(4, 4)
    Me.OutletTempSetting.Name = "OutletTempSetting"
    Me.OutletTempSetting.Size = New System.Drawing.Size(42, 13)
    Me.OutletTempSetting.TabIndex = 61
    Me.OutletTempSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Panel2
    '
    Me.Panel2.BackColor = System.Drawing.Color.LightGray
    Me.Panel2.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel2.Controls.Add(Me.IO_HeatingValve)
    Me.Panel2.Location = New System.Drawing.Point(93, 342)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(51, 18)
    Me.Panel2.TabIndex = 121
    '
    'IO_HeatingValve
    '
    Me.IO_HeatingValve.AutoSize = False
    Me.IO_HeatingValve.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.IO_HeatingValve.ForeColor = System.Drawing.Color.Black
    Me.IO_HeatingValve.Format = "0%"
    Me.IO_HeatingValve.Location = New System.Drawing.Point(5, 2)
    Me.IO_HeatingValve.Name = "IO_HeatingValve"
    Me.IO_HeatingValve.NumberScale = 1000
    Me.IO_HeatingValve.Size = New System.Drawing.Size(41, 13)
    Me.IO_HeatingValve.TabIndex = 59
    Me.IO_HeatingValve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Panel8
    '
    Me.Panel8.BackColor = System.Drawing.Color.LightGray
    Me.Panel8.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel8.Controls.Add(Me.IO_OutletTemperature)
    Me.Panel8.Location = New System.Drawing.Point(447, 300)
    Me.Panel8.Name = "Panel8"
    Me.Panel8.Size = New System.Drawing.Size(51, 22)
    Me.Panel8.TabIndex = 120
    '
    'IO_OutletTemperature
    '
    Me.IO_OutletTemperature.AutoSize = False
    Me.IO_OutletTemperature.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.IO_OutletTemperature.ForeColor = System.Drawing.Color.Black
    Me.IO_OutletTemperature.Format = "0.0C"
    Me.IO_OutletTemperature.Location = New System.Drawing.Point(4, 4)
    Me.IO_OutletTemperature.Name = "IO_OutletTemperature"
    Me.IO_OutletTemperature.NumberScale = 10
    Me.IO_OutletTemperature.Size = New System.Drawing.Size(42, 13)
    Me.IO_OutletTemperature.TabIndex = 60
    Me.IO_OutletTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Panel6
    '
    Me.Panel6.BackColor = System.Drawing.Color.LightGray
    Me.Panel6.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel6.Controls.Add(Me.IO_InletTemperature)
    Me.Panel6.Location = New System.Drawing.Point(287, 299)
    Me.Panel6.Name = "Panel6"
    Me.Panel6.Size = New System.Drawing.Size(51, 22)
    Me.Panel6.TabIndex = 119
    '
    'IO_InletTemperature
    '
    Me.IO_InletTemperature.AutoSize = False
    Me.IO_InletTemperature.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.IO_InletTemperature.ForeColor = System.Drawing.Color.Black
    Me.IO_InletTemperature.Format = "0.0C"
    Me.IO_InletTemperature.Location = New System.Drawing.Point(4, 4)
    Me.IO_InletTemperature.Name = "IO_InletTemperature"
    Me.IO_InletTemperature.NumberScale = 10
    Me.IO_InletTemperature.Size = New System.Drawing.Size(42, 13)
    Me.IO_InletTemperature.TabIndex = 60
    Me.IO_InletTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Panel7
    '
    Me.Panel7.BackColor = System.Drawing.Color.LightGray
    Me.Panel7.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel7.Controls.Add(Me.IO_CondenserTemperature)
    Me.Panel7.Location = New System.Drawing.Point(718, 384)
    Me.Panel7.Name = "Panel7"
    Me.Panel7.Size = New System.Drawing.Size(51, 22)
    Me.Panel7.TabIndex = 118
    '
    'IO_CondenserTemperature
    '
    Me.IO_CondenserTemperature.AutoSize = False
    Me.IO_CondenserTemperature.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.IO_CondenserTemperature.ForeColor = System.Drawing.Color.Black
    Me.IO_CondenserTemperature.Format = "0.0C"
    Me.IO_CondenserTemperature.Location = New System.Drawing.Point(4, 4)
    Me.IO_CondenserTemperature.Name = "IO_CondenserTemperature"
    Me.IO_CondenserTemperature.NumberScale = 10
    Me.IO_CondenserTemperature.Size = New System.Drawing.Size(42, 13)
    Me.IO_CondenserTemperature.TabIndex = 60
    Me.IO_CondenserTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Panel13
    '
    Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.Panel13.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel13.Controls.Add(Me.IO_PressureLidSeal)
    Me.Panel13.Controls.Add(Me.IO_VacuumLidSeal)
    Me.Panel13.Controls.Add(Me.Label30)
    Me.Panel13.Controls.Add(Me.IO_UnlockShootBolt)
    Me.Panel13.Controls.Add(Me.IO_LidRingClose)
    Me.Panel13.Controls.Add(Me.IO_LidRingOpen)
    Me.Panel13.Controls.Add(Me.IO_LidClose)
    Me.Panel13.Controls.Add(Me.IO_LidOpen)
    Me.Panel13.Controls.Add(Me.Label28)
    Me.Panel13.Controls.Add(Me.Label27)
    Me.Panel13.Controls.Add(Me.Label8)
    Me.Panel13.Controls.Add(Me.Label9)
    Me.Panel13.Controls.Add(Me.Label26)
    Me.Panel13.Controls.Add(Me.Label12)
    Me.Panel13.Controls.Add(Me.Label10)
    Me.Panel13.Controls.Add(Me.Label25)
    Me.Panel13.Controls.Add(Me.Label13)
    Me.Panel13.Controls.Add(Me.ShootBoltOut)
    Me.Panel13.Controls.Add(Me.Label24)
    Me.Panel13.Controls.Add(Me.IO_LidIsClosed)
    Me.Panel13.Controls.Add(Me.IO_ShootBoltIn)
    Me.Panel13.Controls.Add(Me.Label23)
    Me.Panel13.Controls.Add(Me.Label11)
    Me.Panel13.Controls.Add(Me.IO_LidRingIsClosed)
    Me.Panel13.Controls.Add(Me.Label22)
    Me.Panel13.Controls.Add(Me.Label7)
    Me.Panel13.Controls.Add(Me.IO_LidRingIsOpen)
    Me.Panel13.Controls.Add(Me.Label21)
    Me.Panel13.Controls.Add(Me.IO_LidIsOpen)
    Me.Panel13.Controls.Add(Me.Label6)
    Me.Panel13.Location = New System.Drawing.Point(16, 80)
    Me.Panel13.Name = "Panel13"
    Me.Panel13.Size = New System.Drawing.Size(212, 176)
    Me.Panel13.TabIndex = 114
    '
    'IO_PressureLidSeal
    '
    Me.IO_PressureLidSeal.Location = New System.Drawing.Point(190, 157)
    Me.IO_PressureLidSeal.Name = "IO_PressureLidSeal"
    Me.IO_PressureLidSeal.Size = New System.Drawing.Size(12, 12)
    Me.IO_PressureLidSeal.TabIndex = 133
    '
    'IO_VacuumLidSeal
    '
    Me.IO_VacuumLidSeal.Location = New System.Drawing.Point(190, 137)
    Me.IO_VacuumLidSeal.Name = "IO_VacuumLidSeal"
    Me.IO_VacuumLidSeal.Size = New System.Drawing.Size(12, 12)
    Me.IO_VacuumLidSeal.TabIndex = 132
    '
    'Label30
    '
    Me.Label30.AutoSize = True
    Me.Label30.BackColor = System.Drawing.Color.Transparent
    Me.Label30.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label30.ForeColor = System.Drawing.Color.White
    Me.Label30.Location = New System.Drawing.Point(155, 4)
    Me.Label30.Name = "Label30"
    Me.Label30.Size = New System.Drawing.Size(55, 13)
    Me.Label30.TabIndex = 131
    Me.Label30.Text = "I/P : O/P"
    '
    'IO_UnlockShootBolt
    '
    Me.IO_UnlockShootBolt.Location = New System.Drawing.Point(190, 99)
    Me.IO_UnlockShootBolt.Name = "IO_UnlockShootBolt"
    Me.IO_UnlockShootBolt.Size = New System.Drawing.Size(12, 12)
    Me.IO_UnlockShootBolt.TabIndex = 130
    '
    'IO_LidRingClose
    '
    Me.IO_LidRingClose.Location = New System.Drawing.Point(190, 80)
    Me.IO_LidRingClose.Name = "IO_LidRingClose"
    Me.IO_LidRingClose.Size = New System.Drawing.Size(12, 12)
    Me.IO_LidRingClose.TabIndex = 129
    '
    'IO_LidRingOpen
    '
    Me.IO_LidRingOpen.Location = New System.Drawing.Point(190, 62)
    Me.IO_LidRingOpen.Name = "IO_LidRingOpen"
    Me.IO_LidRingOpen.Size = New System.Drawing.Size(12, 12)
    Me.IO_LidRingOpen.TabIndex = 128
    '
    'IO_LidClose
    '
    Me.IO_LidClose.Location = New System.Drawing.Point(190, 44)
    Me.IO_LidClose.Name = "IO_LidClose"
    Me.IO_LidClose.Size = New System.Drawing.Size(12, 12)
    Me.IO_LidClose.TabIndex = 127
    '
    'IO_LidOpen
    '
    Me.IO_LidOpen.Location = New System.Drawing.Point(190, 25)
    Me.IO_LidOpen.Name = "IO_LidOpen"
    Me.IO_LidOpen.Size = New System.Drawing.Size(12, 12)
    Me.IO_LidOpen.TabIndex = 126
    '
    'Label28
    '
    Me.Label28.AutoSize = True
    Me.Label28.BackColor = System.Drawing.Color.Transparent
    Me.Label28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label28.ForeColor = System.Drawing.Color.White
    Me.Label28.Location = New System.Drawing.Point(10, 118)
    Me.Label28.Name = "Label28"
    Me.Label28.Size = New System.Drawing.Size(31, 13)
    Me.Label28.TabIndex = 100
    Me.Label28.Text = "SB 1"
    '
    'Label27
    '
    Me.Label27.AutoSize = True
    Me.Label27.BackColor = System.Drawing.Color.Transparent
    Me.Label27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label27.ForeColor = System.Drawing.Color.White
    Me.Label27.Location = New System.Drawing.Point(11, 99)
    Me.Label27.Name = "Label27"
    Me.Label27.Size = New System.Drawing.Size(31, 13)
    Me.Label27.TabIndex = 99
    Me.Label27.Text = "SB 1"
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.BackColor = System.Drawing.Color.Transparent
    Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label8.ForeColor = System.Drawing.Color.White
    Me.Label8.Location = New System.Drawing.Point(53, 137)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(79, 13)
    Me.Label8.TabIndex = 92
    Me.Label8.Text = "Vacuum Seal"
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.BackColor = System.Drawing.Color.Transparent
    Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label9.ForeColor = System.Drawing.Color.White
    Me.Label9.Location = New System.Drawing.Point(53, 156)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(93, 13)
    Me.Label9.TabIndex = 90
    Me.Label9.Text = "Pressurise Seal"
    '
    'Label26
    '
    Me.Label26.AutoSize = True
    Me.Label26.BackColor = System.Drawing.Color.Transparent
    Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label26.ForeColor = System.Drawing.Color.White
    Me.Label26.Location = New System.Drawing.Point(10, 137)
    Me.Label26.Name = "Label26"
    Me.Label26.Size = New System.Drawing.Size(35, 13)
    Me.Label26.TabIndex = 98
    Me.Label26.Text = "2652"
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.BackColor = System.Drawing.Color.Transparent
    Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label12.ForeColor = System.Drawing.Color.White
    Me.Label12.Location = New System.Drawing.Point(53, 99)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(91, 13)
    Me.Label12.TabIndex = 88
    Me.Label12.Text = "Shoot Bolt Out "
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.BackColor = System.Drawing.Color.Transparent
    Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label10.ForeColor = System.Drawing.Color.White
    Me.Label10.Location = New System.Drawing.Point(53, 80)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(65, 13)
    Me.Label10.TabIndex = 88
    Me.Label10.Text = "Ring Close"
    '
    'Label25
    '
    Me.Label25.AutoSize = True
    Me.Label25.BackColor = System.Drawing.Color.Transparent
    Me.Label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label25.ForeColor = System.Drawing.Color.White
    Me.Label25.Location = New System.Drawing.Point(10, 156)
    Me.Label25.Name = "Label25"
    Me.Label25.Size = New System.Drawing.Size(35, 13)
    Me.Label25.TabIndex = 97
    Me.Label25.Text = "2659"
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.BackColor = System.Drawing.Color.Transparent
    Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label13.ForeColor = System.Drawing.Color.White
    Me.Label13.Location = New System.Drawing.Point(53, 118)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(80, 13)
    Me.Label13.TabIndex = 84
    Me.Label13.Text = "Shoot Bolt In"
    '
    'ShootBoltOut
    '
    Me.ShootBoltOut.Location = New System.Drawing.Point(162, 98)
    Me.ShootBoltOut.Name = "ShootBoltOut"
    Me.ShootBoltOut.OffColor = System.Drawing.Color.White
    Me.ShootBoltOut.OnColor = System.Drawing.Color.LawnGreen
    Me.ShootBoltOut.Size = New System.Drawing.Size(15, 15)
    Me.ShootBoltOut.TabIndex = 85
    '
    'Label24
    '
    Me.Label24.AutoSize = True
    Me.Label24.BackColor = System.Drawing.Color.Transparent
    Me.Label24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label24.ForeColor = System.Drawing.Color.White
    Me.Label24.Location = New System.Drawing.Point(10, 80)
    Me.Label24.Name = "Label24"
    Me.Label24.Size = New System.Drawing.Size(37, 13)
    Me.Label24.TabIndex = 96
    Me.Label24.Text = "CYL 2"
    '
    'IO_LidIsClosed
    '
    Me.IO_LidIsClosed.Location = New System.Drawing.Point(162, 42)
    Me.IO_LidIsClosed.Name = "IO_LidIsClosed"
    Me.IO_LidIsClosed.OffColor = System.Drawing.Color.White
    Me.IO_LidIsClosed.OnColor = System.Drawing.Color.LawnGreen
    Me.IO_LidIsClosed.Size = New System.Drawing.Size(15, 15)
    Me.IO_LidIsClosed.TabIndex = 85
    '
    'IO_ShootBoltIn
    '
    Me.IO_ShootBoltIn.Location = New System.Drawing.Point(162, 117)
    Me.IO_ShootBoltIn.Name = "IO_ShootBoltIn"
    Me.IO_ShootBoltIn.OffColor = System.Drawing.Color.White
    Me.IO_ShootBoltIn.OnColor = System.Drawing.Color.LawnGreen
    Me.IO_ShootBoltIn.Size = New System.Drawing.Size(15, 15)
    Me.IO_ShootBoltIn.TabIndex = 84
    '
    'Label23
    '
    Me.Label23.AutoSize = True
    Me.Label23.BackColor = System.Drawing.Color.Transparent
    Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label23.ForeColor = System.Drawing.Color.White
    Me.Label23.Location = New System.Drawing.Point(10, 61)
    Me.Label23.Name = "Label23"
    Me.Label23.Size = New System.Drawing.Size(37, 13)
    Me.Label23.TabIndex = 95
    Me.Label23.Text = "CYL 2"
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.BackColor = System.Drawing.Color.Transparent
    Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label11.ForeColor = System.Drawing.Color.White
    Me.Label11.Location = New System.Drawing.Point(53, 61)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(64, 13)
    Me.Label11.TabIndex = 84
    Me.Label11.Text = "Ring Open"
    '
    'IO_LidRingIsClosed
    '
    Me.IO_LidRingIsClosed.Location = New System.Drawing.Point(162, 79)
    Me.IO_LidRingIsClosed.Name = "IO_LidRingIsClosed"
    Me.IO_LidRingIsClosed.OffColor = System.Drawing.Color.White
    Me.IO_LidRingIsClosed.OnColor = System.Drawing.Color.LawnGreen
    Me.IO_LidRingIsClosed.Size = New System.Drawing.Size(15, 15)
    Me.IO_LidRingIsClosed.TabIndex = 85
    '
    'Label22
    '
    Me.Label22.AutoSize = True
    Me.Label22.BackColor = System.Drawing.Color.Transparent
    Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label22.ForeColor = System.Drawing.Color.White
    Me.Label22.Location = New System.Drawing.Point(10, 42)
    Me.Label22.Name = "Label22"
    Me.Label22.Size = New System.Drawing.Size(37, 13)
    Me.Label22.TabIndex = 94
    Me.Label22.Text = "CYL 1"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.BackColor = System.Drawing.Color.Transparent
    Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label7.ForeColor = System.Drawing.Color.White
    Me.Label7.Location = New System.Drawing.Point(53, 42)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(63, 13)
    Me.Label7.TabIndex = 88
    Me.Label7.Text = "Lid Closed"
    '
    'IO_LidRingIsOpen
    '
    Me.IO_LidRingIsOpen.Location = New System.Drawing.Point(162, 60)
    Me.IO_LidRingIsOpen.Name = "IO_LidRingIsOpen"
    Me.IO_LidRingIsOpen.OffColor = System.Drawing.Color.White
    Me.IO_LidRingIsOpen.OnColor = System.Drawing.Color.LawnGreen
    Me.IO_LidRingIsOpen.Size = New System.Drawing.Size(15, 15)
    Me.IO_LidRingIsOpen.TabIndex = 84
    '
    'Label21
    '
    Me.Label21.AutoSize = True
    Me.Label21.BackColor = System.Drawing.Color.Transparent
    Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label21.ForeColor = System.Drawing.Color.White
    Me.Label21.Location = New System.Drawing.Point(10, 23)
    Me.Label21.Name = "Label21"
    Me.Label21.Size = New System.Drawing.Size(37, 13)
    Me.Label21.TabIndex = 93
    Me.Label21.Text = "CYL 1"
    '
    'IO_LidIsOpen
    '
    Me.IO_LidIsOpen.Location = New System.Drawing.Point(162, 23)
    Me.IO_LidIsOpen.Name = "IO_LidIsOpen"
    Me.IO_LidIsOpen.OffColor = System.Drawing.Color.White
    Me.IO_LidIsOpen.OnColor = System.Drawing.Color.LawnGreen
    Me.IO_LidIsOpen.Size = New System.Drawing.Size(15, 15)
    Me.IO_LidIsOpen.TabIndex = 84
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.BackColor = System.Drawing.Color.Transparent
    Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.ForeColor = System.Drawing.Color.White
    Me.Label6.Location = New System.Drawing.Point(53, 23)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(55, 13)
    Me.Label6.TabIndex = 84
    Me.Label6.Text = "Lid Open"
    '
    'IO_KierEmptyLevel
    '
    Me.IO_KierEmptyLevel.Location = New System.Drawing.Point(522, 430)
    Me.IO_KierEmptyLevel.Name = "IO_KierEmptyLevel"
    Me.IO_KierEmptyLevel.OffColor = System.Drawing.Color.White
    Me.IO_KierEmptyLevel.OnColor = System.Drawing.Color.LawnGreen
    Me.IO_KierEmptyLevel.Size = New System.Drawing.Size(15, 15)
    Me.IO_KierEmptyLevel.TabIndex = 94
    '
    'IO_KierWaterFill
    '
    Me.IO_KierWaterFill.Location = New System.Drawing.Point(155, 488)
    Me.IO_KierWaterFill.Name = "IO_KierWaterFill"
    Me.IO_KierWaterFill.OffColor = System.Drawing.Color.Red
    Me.IO_KierWaterFill.Orientation = System.Windows.Forms.Orientation.Vertical
    Me.IO_KierWaterFill.Size = New System.Drawing.Size(14, 14)
    Me.IO_KierWaterFill.TabIndex = 73
    '
    'FlowOutToIn
    '
    Me.FlowOutToIn.Location = New System.Drawing.Point(401, 334)
    Me.FlowOutToIn.Name = "FlowOutToIn"
    Me.FlowOutToIn.OffColor = System.Drawing.Color.White
    Me.FlowOutToIn.OnColor = System.Drawing.Color.LawnGreen
    Me.FlowOutToIn.Size = New System.Drawing.Size(10, 10)
    Me.FlowOutToIn.TabIndex = 72
    '
    'FlowInToOut
    '
    Me.FlowInToOut.Location = New System.Drawing.Point(401, 324)
    Me.FlowInToOut.Name = "FlowInToOut"
    Me.FlowInToOut.OffColor = System.Drawing.Color.White
    Me.FlowInToOut.OnColor = System.Drawing.Color.LawnGreen
    Me.FlowInToOut.Size = New System.Drawing.Size(10, 10)
    Me.FlowInToOut.TabIndex = 71
    '
    'IO_CondenserDrain
    '
    Me.IO_CondenserDrain.Location = New System.Drawing.Point(614, 353)
    Me.IO_CondenserDrain.Name = "IO_CondenserDrain"
    Me.IO_CondenserDrain.OffColor = System.Drawing.Color.Red
    Me.IO_CondenserDrain.Orientation = System.Windows.Forms.Orientation.Vertical
    Me.IO_CondenserDrain.Size = New System.Drawing.Size(14, 14)
    Me.IO_CondenserDrain.TabIndex = 70
    '
    'IO_KierFullLevel
    '
    Me.IO_KierFullLevel.Location = New System.Drawing.Point(430, 158)
    Me.IO_KierFullLevel.Name = "IO_KierFullLevel"
    Me.IO_KierFullLevel.Size = New System.Drawing.Size(10, 10)
    Me.IO_KierFullLevel.TabIndex = 63
    '
    'IO_Depressurise
    '
    Me.IO_Depressurise.Location = New System.Drawing.Point(405, 488)
    Me.IO_Depressurise.Name = "IO_Depressurise"
    Me.IO_Depressurise.OffColor = System.Drawing.Color.Red
    Me.IO_Depressurise.Orientation = System.Windows.Forms.Orientation.Vertical
    Me.IO_Depressurise.Size = New System.Drawing.Size(14, 14)
    Me.IO_Depressurise.TabIndex = 69
    '
    'IO_Pressurise
    '
    Me.IO_Pressurise.Location = New System.Drawing.Point(460, 488)
    Me.IO_Pressurise.Name = "IO_Pressurise"
    Me.IO_Pressurise.OffColor = System.Drawing.Color.Red
    Me.IO_Pressurise.Orientation = System.Windows.Forms.Orientation.Vertical
    Me.IO_Pressurise.Size = New System.Drawing.Size(14, 14)
    Me.IO_Pressurise.TabIndex = 68
    '
    'IO_SumpDrain
    '
    Me.IO_SumpDrain.Location = New System.Drawing.Point(385, 355)
    Me.IO_SumpDrain.Name = "IO_SumpDrain"
    Me.IO_SumpDrain.OffColor = System.Drawing.Color.Red
    Me.IO_SumpDrain.Orientation = System.Windows.Forms.Orientation.Vertical
    Me.IO_SumpDrain.Size = New System.Drawing.Size(14, 14)
    Me.IO_SumpDrain.TabIndex = 66
    '
    'Lid3
    '
    Me.Lid3.Image = CType(resources.GetObject("Lid3.Image"), Picture)
    Me.Lid3.Location = New System.Drawing.Point(274, 66)
    Me.Lid3.Name = "Lid3"
    Me.Lid3.Size = New System.Drawing.Size(168, 191)
    Me.Lid3.TabIndex = 129
    '
    'Mimic
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
    Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.Controls.Add(Me.Panel16)
    Me.Controls.Add(Me.Panel15)
    Me.Controls.Add(Me.Panel14)
    Me.Controls.Add(Me.Label50)
    Me.Controls.Add(Me.Panel20)
    Me.Controls.Add(Me.Label42)
    Me.Controls.Add(Me.Panel19)
    Me.Controls.Add(Me.Label41)
    Me.Controls.Add(Me.Label49)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.IO_HeatExchangeDrain)
    Me.Controls.Add(Me.Panel21)
    Me.Controls.Add(Me.Panel18)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Panel17)
    Me.Controls.Add(Me.Label31)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.Lamp1)
    Me.Controls.Add(Me.Panel5)
    Me.Controls.Add(Me.IO_TrapIsolationValve)
    Me.Controls.Add(Me.Panel12)
    Me.Controls.Add(Me.Label48)
    Me.Controls.Add(Me.Label46)
    Me.Controls.Add(Me.Label45)
    Me.Controls.Add(Me.Label44)
    Me.Controls.Add(Me.Label43)
    Me.Controls.Add(Me.Label40)
    Me.Controls.Add(Me.Label39)
    Me.Controls.Add(Me.IO_FanDrain)
    Me.Controls.Add(Me.IO_FanSeal)
    Me.Controls.Add(Me.IO_FanCoolerMotor)
    Me.Controls.Add(Me.IO_FanRun)
    Me.Controls.Add(Me.Panel11)
    Me.Controls.Add(Me.Label38)
    Me.Controls.Add(Me.Panel10)
    Me.Controls.Add(Me.Label37)
    Me.Controls.Add(Me.Label36)
    Me.Controls.Add(Me.Panel9)
    Me.Controls.Add(Me.Lid6)
    Me.Controls.Add(Me.Lid1)
    Me.Controls.Add(Me.IO_KierWaterVent)
    Me.Controls.Add(Me.Panel4)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.Panel3)
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.Panel8)
    Me.Controls.Add(Me.Panel6)
    Me.Controls.Add(Me.Panel7)
    Me.Controls.Add(Me.Label35)
    Me.Controls.Add(Me.Label34)
    Me.Controls.Add(Me.Label33)
    Me.Controls.Add(Me.Label32)
    Me.Controls.Add(Me.Panel13)
    Me.Controls.Add(Me.Label20)
    Me.Controls.Add(Me.Label19)
    Me.Controls.Add(Me.Label18)
    Me.Controls.Add(Me.Label17)
    Me.Controls.Add(Me.Label16)
    Me.Controls.Add(Me.IO_KierEmptyLevel)
    Me.Controls.Add(Me.Label15)
    Me.Controls.Add(Me.IO_KierWaterFill)
    Me.Controls.Add(Me.FlowOutToIn)
    Me.Controls.Add(Me.FlowInToOut)
    Me.Controls.Add(Me.IO_CondenserDrain)
    Me.Controls.Add(Me.IO_KierFullLevel)
    Me.Controls.Add(Me.IO_Depressurise)
    Me.Controls.Add(Me.IO_Pressurise)
    Me.Controls.Add(Me.IO_SumpDrain)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Lid3)
    Me.Controls.Add(Me.RevLabel)
    Me.Name = "Mimic"
    Me.Size = New System.Drawing.Size(800, 535)
    Me.Panel16.ResumeLayout(False)
    Me.Panel15.ResumeLayout(False)
    Me.Panel14.ResumeLayout(False)
    Me.Panel20.ResumeLayout(False)
    Me.Panel19.ResumeLayout(False)
    Me.Panel21.ResumeLayout(False)
    Me.Panel18.ResumeLayout(False)
    Me.Panel17.ResumeLayout(False)
    Me.Panel17.PerformLayout()
    Me.Panel5.ResumeLayout(False)
    Me.Panel12.ResumeLayout(False)
    Me.Panel12.PerformLayout()
    Me.Panel11.ResumeLayout(False)
    Me.Panel10.ResumeLayout(False)
    Me.Panel9.ResumeLayout(False)
    Me.Panel4.ResumeLayout(False)
    Me.Panel4.PerformLayout()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.Panel3.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.Panel8.ResumeLayout(False)
    Me.Panel6.ResumeLayout(False)
    Me.Panel7.ResumeLayout(False)
    Me.Panel13.ResumeLayout(False)
    Me.Panel13.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents IO_HeatingValve As MimicControls.ValueLabel
  Friend WithEvents IO_KierFullLevel As MimicControls.Lamp
  Friend WithEvents IO_KierWaterVent As MimicControls.Valve
  Friend WithEvents IO_SumpDrain As MimicControls.Valve
  Friend WithEvents IO_Pressurise As MimicControls.Valve
  Friend WithEvents IO_Depressurise As MimicControls.Valve
  Friend WithEvents IO_CondenserDrain As MimicControls.Valve
  Friend WithEvents FlowInToOut As MimicControls.Lamp
  Friend WithEvents FlowOutToIn As MimicControls.Lamp
  Friend WithEvents IO_KierWaterFill As MimicControls.Valve
  Friend WithEvents IO_CondenserTemperature As MimicControls.ValueLabel
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents IO_PT1Pressure As MimicControls.ValueLabel
  Friend WithEvents IO_PT2Pressure As MimicControls.ValueLabel
  Friend WithEvents IO_FanCurrent As MimicControls.ValueLabel
  Friend WithEvents IO_LidIsOpen As MimicControls.Lamp
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents IO_LidIsClosed As MimicControls.Lamp
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents IO_LidRingIsClosed As MimicControls.Lamp
  Friend WithEvents IO_LidRingIsOpen As MimicControls.Lamp
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents ShootBoltOut As MimicControls.Lamp
  Friend WithEvents IO_ShootBoltIn As MimicControls.Lamp
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents IO_KierEmptyLevel As MimicControls.Lamp
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents Label17 As System.Windows.Forms.Label
  Friend WithEvents Label18 As System.Windows.Forms.Label
  Friend WithEvents Label19 As System.Windows.Forms.Label
  Friend WithEvents Label20 As System.Windows.Forms.Label
  Friend WithEvents Timer1 As System.Windows.Forms.Timer
  Friend WithEvents OpenLid_PB As System.Windows.Forms.Button
  Friend WithEvents StopLid_PB As System.Windows.Forms.Button
  Friend WithEvents CloseLid_PB As System.Windows.Forms.Button
  Friend WithEvents Panel13 As MimicControls.Panel
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents Label22 As System.Windows.Forms.Label
  Friend WithEvents Label21 As System.Windows.Forms.Label
  Friend WithEvents Label28 As System.Windows.Forms.Label
  Friend WithEvents Label27 As System.Windows.Forms.Label
  Friend WithEvents Label26 As System.Windows.Forms.Label
  Friend WithEvents Label25 As System.Windows.Forms.Label
  Friend WithEvents Label24 As System.Windows.Forms.Label
  Friend WithEvents Label23 As System.Windows.Forms.Label
  Friend WithEvents PressIsSafeTimer As MimicControls.Label
  Friend WithEvents Label32 As System.Windows.Forms.Label
  Friend WithEvents Label33 As System.Windows.Forms.Label
  Friend WithEvents Label34 As System.Windows.Forms.Label
  Friend WithEvents Label35 As System.Windows.Forms.Label
  Friend WithEvents Panel7 As MimicControls.Panel
  Friend WithEvents Panel6 As MimicControls.Panel
  Friend WithEvents IO_InletTemperature As MimicControls.ValueLabel
  Friend WithEvents Panel8 As MimicControls.Panel
  Friend WithEvents IO_OutletTemperature As MimicControls.ValueLabel
  Friend WithEvents Panel2 As MimicControls.Panel
  Friend WithEvents Panel3 As MimicControls.Panel
  Friend WithEvents Panel1 As MimicControls.Panel
  Friend WithEvents IO_FanSpeed As MimicControls.ValueLabel
  Friend WithEvents Panel4 As MimicControls.Panel
  Friend WithEvents Panel5 As MimicControls.Panel
  Friend WithEvents IO_LidOpen As MimicControls.Output
  Friend WithEvents IO_UnlockShootBolt As MimicControls.Output
  Friend WithEvents IO_LidRingClose As MimicControls.Output
  Friend WithEvents IO_LidRingOpen As MimicControls.Output
  Friend WithEvents IO_LidClose As MimicControls.Output
  Friend WithEvents Lid1 As MimicControls.PictureBox
  Friend WithEvents Lid6 As MimicControls.PictureBox
  Friend WithEvents Lid3 As MimicControls.PictureBox
  Friend WithEvents Panel9 As MimicControls.Panel
  Friend WithEvents InletTempSetting As MimicControls.ValueLabel
  Friend WithEvents Label36 As System.Windows.Forms.Label
  Friend WithEvents Label37 As System.Windows.Forms.Label
  Friend WithEvents Panel10 As MimicControls.Panel
  Friend WithEvents CoolSetting As MimicControls.ValueLabel
  Friend WithEvents Label38 As System.Windows.Forms.Label
  Friend WithEvents OutletTempSetting As MimicControls.ValueLabel
  Friend WithEvents Panel11 As MimicControls.Panel
  Friend WithEvents IO_CoolingValve As MimicControls.ValueLabel
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents DifferentialPressure As MimicControls.ValueLabel
  Friend WithEvents IO_FanRun As MimicControls.Output
  Friend WithEvents IO_FanCoolerMotor As MimicControls.Output
  Friend WithEvents IO_FanSeal As MimicControls.Output
  Friend WithEvents IO_FanDrain As MimicControls.Valve
  Friend WithEvents Label39 As System.Windows.Forms.Label
  Friend WithEvents Label40 As System.Windows.Forms.Label
  Friend WithEvents Label42 As System.Windows.Forms.Label
  Friend WithEvents Label41 As System.Windows.Forms.Label
  Friend WithEvents Label43 As System.Windows.Forms.Label
  Friend WithEvents Label44 As System.Windows.Forms.Label
  Friend WithEvents Label45 As System.Windows.Forms.Label
  Friend WithEvents Label46 As System.Windows.Forms.Label
  Friend WithEvents Label48 As System.Windows.Forms.Label
  Friend WithEvents Panel12 As MimicControls.Panel
  Friend WithEvents PressureIsSafe As MimicControls.Lamp
  Friend WithEvents Label29 As System.Windows.Forms.Label
  Friend WithEvents Panel15 As MimicControls.Panel
  Friend WithEvents Panel16 As MimicControls.Panel
  Friend WithEvents IO_TrapIsolationValve As MimicControls.Valve
  Friend WithEvents Label30 As System.Windows.Forms.Label
  Friend WithEvents Panel14 As MimicControls.Panel
  Friend WithEvents Lamp1 As MimicControls.Lamp
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents Label31 As System.Windows.Forms.Label
  Friend WithEvents RevLabel As System.Windows.Forms.Label
  Friend WithEvents IO_PressureLidSeal As MimicControls.Output
  Friend WithEvents IO_VacuumLidSeal As MimicControls.Output
  Friend WithEvents Panel17 As MimicControls.Panel
  Friend WithEvents FanCurrentDV As MimicControls.ValueLabel
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Panel19 As MimicControls.Panel
  Friend WithEvents DPSetPoint As MimicControls.ValueLabel
  Friend WithEvents Panel18 As MimicControls.Panel
  Friend WithEvents IO_FanBearing1Temp As MimicControls.ValueLabel
  Friend WithEvents Panel21 As MimicControls.Panel
  Friend WithEvents IO_FanBearing2Temp As MimicControls.ValueLabel
  Friend WithEvents IO_HeatExchangeDrain As MimicControls.Valve
  Friend WithEvents Label49 As System.Windows.Forms.Label
  Friend WithEvents Panel20 As MimicControls.Panel
  Friend WithEvents DisplayCKTemp As MimicControls.ValueLabel
  Friend WithEvents Label50 As System.Windows.Forms.Label

End Class
