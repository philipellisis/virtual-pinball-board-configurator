<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Configuration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configuration))
        Me.tbMain = New System.Windows.Forms.TabControl()
        Me.tpGeneralSettings = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbShiftButton = New System.Windows.Forms.ComboBox()
        Me.rbNightModePush = New System.Windows.Forms.RadioButton()
        Me.rbNightModeToggle = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbNightMode = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbSideMounted = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbTiltButton = New System.Windows.Forms.ComboBox()
        Me.cbMultiplier = New System.Windows.Forms.ComboBox()
        Me.lblMultiplier = New System.Windows.Forms.Label()
        Me.cbPinsFacingUp = New System.Windows.Forms.CheckBox()
        Me.tbMax = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbTilt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbDeadZone = New System.Windows.Forms.TextBox()
        Me.lblDeadZone = New System.Windows.Forms.Label()
        Me.cbAccelEnabled = New System.Windows.Forms.CheckBox()
        Me.cbOrientation = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbOutputTrigger4 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbButtonTrigger4 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbOutputTrigger3 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbButtonTrigger3 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbOutputTrigger2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbButtonTrigger2 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbOutputTrigger1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbButtonTrigger1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbPlungerEnabled = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbAverageReadings = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbLaunchButton = New System.Windows.Forms.ComboBox()
        Me.cbPushOnMax = New System.Windows.Forms.CheckBox()
        Me.cbPushOnMin = New System.Windows.Forms.CheckBox()
        Me.tbPlungerMid = New System.Windows.Forms.TextBox()
        Me.tbPlungerMax = New System.Windows.Forms.TextBox()
        Me.tbPlungerMin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tpMainOutputs = New System.Windows.Forms.TabPage()
        Me.tpExpansion1 = New System.Windows.Forms.TabPage()
        Me.tpExpansion2 = New System.Windows.Forms.TabPage()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbTiltSuppress = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cbAttractEnable = New System.Windows.Forms.CheckBox()
        Me.tbMain.SuspendLayout()
        Me.tpGeneralSettings.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbMain
        '
        Me.tbMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMain.Controls.Add(Me.tpGeneralSettings)
        Me.tbMain.Controls.Add(Me.tpMainOutputs)
        Me.tbMain.Controls.Add(Me.tpExpansion1)
        Me.tbMain.Controls.Add(Me.tpExpansion2)
        Me.tbMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbMain.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMain.HotTrack = True
        Me.tbMain.Location = New System.Drawing.Point(0, 60)
        Me.tbMain.Name = "tbMain"
        Me.tbMain.SelectedIndex = 0
        Me.tbMain.Size = New System.Drawing.Size(1228, 777)
        Me.tbMain.TabIndex = 0
        '
        'tpGeneralSettings
        '
        Me.tpGeneralSettings.AutoScroll = True
        Me.tpGeneralSettings.BackColor = System.Drawing.SystemColors.Control
        Me.tpGeneralSettings.Controls.Add(Me.GroupBox5)
        Me.tpGeneralSettings.Controls.Add(Me.GroupBox4)
        Me.tpGeneralSettings.Controls.Add(Me.GroupBox3)
        Me.tpGeneralSettings.Controls.Add(Me.GroupBox2)
        Me.tpGeneralSettings.Controls.Add(Me.GroupBox1)
        Me.tpGeneralSettings.Location = New System.Drawing.Point(4, 34)
        Me.tpGeneralSettings.Name = "tpGeneralSettings"
        Me.tpGeneralSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tpGeneralSettings.Size = New System.Drawing.Size(1220, 739)
        Me.tpGeneralSettings.TabIndex = 0
        Me.tpGeneralSettings.Text = "Main Settings"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.cbShiftButton)
        Me.GroupBox4.Controls.Add(Me.rbNightModePush)
        Me.GroupBox4.Controls.Add(Me.rbNightModeToggle)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.cbNightMode)
        Me.GroupBox4.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(10, 407)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(320, 303)
        Me.GroupBox4.TabIndex = 50
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Buttons"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(79, 236)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(106, 25)
        Me.Label19.TabIndex = 55
        Me.Label19.Text = "Shift Button"
        '
        'cbShiftButton
        '
        Me.cbShiftButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbShiftButton.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbShiftButton.FormattingEnabled = True
        Me.cbShiftButton.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.cbShiftButton.Location = New System.Drawing.Point(200, 232)
        Me.cbShiftButton.Name = "cbShiftButton"
        Me.cbShiftButton.Size = New System.Drawing.Size(76, 33)
        Me.cbShiftButton.TabIndex = 54
        '
        'rbNightModePush
        '
        Me.rbNightModePush.AutoSize = True
        Me.rbNightModePush.Location = New System.Drawing.Point(8, 157)
        Me.rbNightModePush.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbNightModePush.Name = "rbNightModePush"
        Me.rbNightModePush.Size = New System.Drawing.Size(268, 33)
        Me.rbNightModePush.TabIndex = 53
        Me.rbNightModePush.TabStop = True
        Me.rbNightModePush.Text = "Night Mode Push Button"
        Me.rbNightModePush.UseVisualStyleBackColor = True
        '
        'rbNightModeToggle
        '
        Me.rbNightModeToggle.AutoSize = True
        Me.rbNightModeToggle.Location = New System.Drawing.Point(8, 111)
        Me.rbNightModeToggle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbNightModeToggle.Name = "rbNightModeToggle"
        Me.rbNightModeToggle.Size = New System.Drawing.Size(284, 33)
        Me.rbNightModeToggle.TabIndex = 52
        Me.rbNightModeToggle.TabStop = True
        Me.rbNightModeToggle.Text = "Night Mode Toggle Button"
        Me.rbNightModeToggle.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(10, 63)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(159, 25)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "Night Mode Button"
        '
        'cbNightMode
        '
        Me.cbNightMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNightMode.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNightMode.FormattingEnabled = True
        Me.cbNightMode.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.cbNightMode.Location = New System.Drawing.Point(195, 58)
        Me.cbNightMode.Name = "cbNightMode"
        Me.cbNightMode.Size = New System.Drawing.Size(76, 33)
        Me.cbNightMode.TabIndex = 50
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.cbTiltSuppress)
        Me.GroupBox3.Controls.Add(Me.cbSideMounted)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.cbTiltButton)
        Me.GroupBox3.Controls.Add(Me.cbMultiplier)
        Me.GroupBox3.Controls.Add(Me.lblMultiplier)
        Me.GroupBox3.Controls.Add(Me.cbPinsFacingUp)
        Me.GroupBox3.Controls.Add(Me.tbMax)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.tbTilt)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.tbDeadZone)
        Me.GroupBox3.Controls.Add(Me.lblDeadZone)
        Me.GroupBox3.Controls.Add(Me.cbAccelEnabled)
        Me.GroupBox3.Controls.Add(Me.cbOrientation)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(393, 232)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(388, 478)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Accelerometer"
        '
        'cbSideMounted
        '
        Me.cbSideMounted.AutoSize = True
        Me.cbSideMounted.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSideMounted.Location = New System.Drawing.Point(207, 140)
        Me.cbSideMounted.Name = "cbSideMounted"
        Me.cbSideMounted.Size = New System.Drawing.Size(171, 29)
        Me.cbSideMounted.TabIndex = 45
        Me.cbSideMounted.Text = "Mounted on Side"
        Me.cbSideMounted.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 385)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 25)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Tilt Button"
        '
        'cbTiltButton
        '
        Me.cbTiltButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTiltButton.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTiltButton.FormattingEnabled = True
        Me.cbTiltButton.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.cbTiltButton.Location = New System.Drawing.Point(159, 382)
        Me.cbTiltButton.Name = "cbTiltButton"
        Me.cbTiltButton.Size = New System.Drawing.Size(76, 33)
        Me.cbTiltButton.TabIndex = 43
        '
        'cbMultiplier
        '
        Me.cbMultiplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbMultiplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMultiplier.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMultiplier.FormattingEnabled = True
        Me.cbMultiplier.Items.AddRange(New Object() {"2G (Most Sensitive)", "4G", "8G", "16G (Least Sensitive)"})
        Me.cbMultiplier.Location = New System.Drawing.Point(164, 182)
        Me.cbMultiplier.Name = "cbMultiplier"
        Me.cbMultiplier.Size = New System.Drawing.Size(200, 33)
        Me.cbMultiplier.TabIndex = 42
        '
        'lblMultiplier
        '
        Me.lblMultiplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMultiplier.AutoSize = True
        Me.lblMultiplier.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMultiplier.Location = New System.Drawing.Point(12, 189)
        Me.lblMultiplier.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMultiplier.Name = "lblMultiplier"
        Me.lblMultiplier.Size = New System.Drawing.Size(96, 25)
        Me.lblMultiplier.TabIndex = 41
        Me.lblMultiplier.Text = "Sensitivity"
        '
        'cbPinsFacingUp
        '
        Me.cbPinsFacingUp.AutoSize = True
        Me.cbPinsFacingUp.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPinsFacingUp.Location = New System.Drawing.Point(38, 140)
        Me.cbPinsFacingUp.Name = "cbPinsFacingUp"
        Me.cbPinsFacingUp.Size = New System.Drawing.Size(154, 29)
        Me.cbPinsFacingUp.TabIndex = 40
        Me.cbPinsFacingUp.Text = "Pins Facing Up"
        Me.cbPinsFacingUp.UseVisualStyleBackColor = True
        '
        'tbMax
        '
        Me.tbMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMax.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMax.Location = New System.Drawing.Point(161, 326)
        Me.tbMax.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbMax.Name = "tbMax"
        Me.tbMax.Size = New System.Drawing.Size(148, 31)
        Me.tbMax.TabIndex = 35
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 331)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 25)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Max"
        '
        'tbTilt
        '
        Me.tbTilt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTilt.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTilt.Location = New System.Drawing.Point(161, 278)
        Me.tbTilt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbTilt.Name = "tbTilt"
        Me.tbTilt.Size = New System.Drawing.Size(148, 31)
        Me.tbTilt.TabIndex = 33
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 283)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 25)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Tilt"
        '
        'tbDeadZone
        '
        Me.tbDeadZone.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDeadZone.Location = New System.Drawing.Point(161, 232)
        Me.tbDeadZone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbDeadZone.Name = "tbDeadZone"
        Me.tbDeadZone.Size = New System.Drawing.Size(148, 31)
        Me.tbDeadZone.TabIndex = 29
        '
        'lblDeadZone
        '
        Me.lblDeadZone.AutoSize = True
        Me.lblDeadZone.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeadZone.Location = New System.Drawing.Point(8, 237)
        Me.lblDeadZone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDeadZone.Name = "lblDeadZone"
        Me.lblDeadZone.Size = New System.Drawing.Size(95, 25)
        Me.lblDeadZone.TabIndex = 28
        Me.lblDeadZone.Text = "Dead Zone"
        '
        'cbAccelEnabled
        '
        Me.cbAccelEnabled.AutoSize = True
        Me.cbAccelEnabled.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAccelEnabled.Location = New System.Drawing.Point(10, 49)
        Me.cbAccelEnabled.Name = "cbAccelEnabled"
        Me.cbAccelEnabled.Size = New System.Drawing.Size(225, 29)
        Me.cbAccelEnabled.TabIndex = 27
        Me.cbAccelEnabled.Text = "Accelerometer Enabled"
        Me.cbAccelEnabled.UseVisualStyleBackColor = True
        '
        'cbOrientation
        '
        Me.cbOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOrientation.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOrientation.FormattingEnabled = True
        Me.cbOrientation.Items.AddRange(New Object() {"USB Facing Back", "USB Facing Right", "USB Facing Left", "USB Facing Front"})
        Me.cbOrientation.Location = New System.Drawing.Point(172, 95)
        Me.cbOrientation.Name = "cbOrientation"
        Me.cbOrientation.Size = New System.Drawing.Size(196, 33)
        Me.cbOrientation.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(161, 25)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Device Orientation"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbOutputTrigger4)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cbButtonTrigger4)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cbOutputTrigger3)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cbButtonTrigger3)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cbOutputTrigger2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cbButtonTrigger2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cbOutputTrigger1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cbButtonTrigger1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(393, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(432, 217)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Button Triggers"
        '
        'cbOutputTrigger4
        '
        Me.cbOutputTrigger4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOutputTrigger4.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOutputTrigger4.FormattingEnabled = True
        Me.cbOutputTrigger4.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63"})
        Me.cbOutputTrigger4.Location = New System.Drawing.Point(302, 165)
        Me.cbOutputTrigger4.Name = "cbOutputTrigger4"
        Me.cbOutputTrigger4.Size = New System.Drawing.Size(76, 33)
        Me.cbOutputTrigger4.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(159, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 25)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Triggers Output"
        '
        'cbButtonTrigger4
        '
        Me.cbButtonTrigger4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbButtonTrigger4.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbButtonTrigger4.FormattingEnabled = True
        Me.cbButtonTrigger4.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.cbButtonTrigger4.Location = New System.Drawing.Point(76, 165)
        Me.cbButtonTrigger4.Name = "cbButtonTrigger4"
        Me.cbButtonTrigger4.Size = New System.Drawing.Size(76, 33)
        Me.cbButtonTrigger4.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 171)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 25)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Button"
        '
        'cbOutputTrigger3
        '
        Me.cbOutputTrigger3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOutputTrigger3.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOutputTrigger3.FormattingEnabled = True
        Me.cbOutputTrigger3.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63"})
        Me.cbOutputTrigger3.Location = New System.Drawing.Point(302, 125)
        Me.cbOutputTrigger3.Name = "cbOutputTrigger3"
        Me.cbOutputTrigger3.Size = New System.Drawing.Size(76, 33)
        Me.cbOutputTrigger3.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(159, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 25)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Triggers Output"
        '
        'cbButtonTrigger3
        '
        Me.cbButtonTrigger3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbButtonTrigger3.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbButtonTrigger3.FormattingEnabled = True
        Me.cbButtonTrigger3.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.cbButtonTrigger3.Location = New System.Drawing.Point(76, 125)
        Me.cbButtonTrigger3.Name = "cbButtonTrigger3"
        Me.cbButtonTrigger3.Size = New System.Drawing.Size(76, 33)
        Me.cbButtonTrigger3.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 25)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Button"
        '
        'cbOutputTrigger2
        '
        Me.cbOutputTrigger2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOutputTrigger2.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOutputTrigger2.FormattingEnabled = True
        Me.cbOutputTrigger2.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63"})
        Me.cbOutputTrigger2.Location = New System.Drawing.Point(302, 82)
        Me.cbOutputTrigger2.Name = "cbOutputTrigger2"
        Me.cbOutputTrigger2.Size = New System.Drawing.Size(76, 33)
        Me.cbOutputTrigger2.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(159, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Triggers Output"
        '
        'cbButtonTrigger2
        '
        Me.cbButtonTrigger2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbButtonTrigger2.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbButtonTrigger2.FormattingEnabled = True
        Me.cbButtonTrigger2.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.cbButtonTrigger2.Location = New System.Drawing.Point(76, 82)
        Me.cbButtonTrigger2.Name = "cbButtonTrigger2"
        Me.cbButtonTrigger2.Size = New System.Drawing.Size(76, 33)
        Me.cbButtonTrigger2.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 25)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Button"
        '
        'cbOutputTrigger1
        '
        Me.cbOutputTrigger1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOutputTrigger1.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOutputTrigger1.FormattingEnabled = True
        Me.cbOutputTrigger1.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63"})
        Me.cbOutputTrigger1.Location = New System.Drawing.Point(302, 38)
        Me.cbOutputTrigger1.Name = "cbOutputTrigger1"
        Me.cbOutputTrigger1.Size = New System.Drawing.Size(76, 33)
        Me.cbOutputTrigger1.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(159, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Triggers Output"
        '
        'cbButtonTrigger1
        '
        Me.cbButtonTrigger1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbButtonTrigger1.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbButtonTrigger1.FormattingEnabled = True
        Me.cbButtonTrigger1.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.cbButtonTrigger1.Location = New System.Drawing.Point(76, 38)
        Me.cbButtonTrigger1.Name = "cbButtonTrigger1"
        Me.cbButtonTrigger1.Size = New System.Drawing.Size(76, 33)
        Me.cbButtonTrigger1.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Button"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbPlungerEnabled)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cbAverageReadings)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.cbLaunchButton)
        Me.GroupBox1.Controls.Add(Me.cbPushOnMax)
        Me.GroupBox1.Controls.Add(Me.cbPushOnMin)
        Me.GroupBox1.Controls.Add(Me.tbPlungerMid)
        Me.GroupBox1.Controls.Add(Me.tbPlungerMax)
        Me.GroupBox1.Controls.Add(Me.tbPlungerMin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 384)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Plunger"
        '
        'cbPlungerEnabled
        '
        Me.cbPlungerEnabled.AutoSize = True
        Me.cbPlungerEnabled.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPlungerEnabled.Location = New System.Drawing.Point(11, 36)
        Me.cbPlungerEnabled.Name = "cbPlungerEnabled"
        Me.cbPlungerEnabled.Size = New System.Drawing.Size(167, 29)
        Me.cbPlungerEnabled.TabIndex = 50
        Me.cbPlungerEnabled.Text = "Plunger Enabled"
        Me.cbPlungerEnabled.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(18, 341)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(157, 25)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "Average Readings"
        '
        'cbAverageReadings
        '
        Me.cbAverageReadings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAverageReadings.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAverageReadings.FormattingEnabled = True
        Me.cbAverageReadings.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "211", "212", "213", "214", "215", "216", "217", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242", "243", "244", "245", "246", "247", "248", "249", "250", "251", "252", "253", "254", "255"})
        Me.cbAverageReadings.Location = New System.Drawing.Point(190, 336)
        Me.cbAverageReadings.Name = "cbAverageReadings"
        Me.cbAverageReadings.Size = New System.Drawing.Size(76, 33)
        Me.cbAverageReadings.TabIndex = 48
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(51, 296)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(127, 25)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "Launch Button"
        '
        'cbLaunchButton
        '
        Me.cbLaunchButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLaunchButton.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLaunchButton.FormattingEnabled = True
        Me.cbLaunchButton.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.cbLaunchButton.Location = New System.Drawing.Point(190, 291)
        Me.cbLaunchButton.Name = "cbLaunchButton"
        Me.cbLaunchButton.Size = New System.Drawing.Size(76, 33)
        Me.cbLaunchButton.TabIndex = 46
        '
        'cbPushOnMax
        '
        Me.cbPushOnMax.AutoSize = True
        Me.cbPushOnMax.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPushOnMax.Location = New System.Drawing.Point(10, 239)
        Me.cbPushOnMax.Name = "cbPushOnMax"
        Me.cbPushOnMax.Size = New System.Drawing.Size(196, 29)
        Me.cbPushOnMax.TabIndex = 31
        Me.cbPushOnMax.Text = "Push Button On Max"
        Me.cbPushOnMax.UseVisualStyleBackColor = True
        '
        'cbPushOnMin
        '
        Me.cbPushOnMin.AutoSize = True
        Me.cbPushOnMin.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPushOnMin.Location = New System.Drawing.Point(10, 204)
        Me.cbPushOnMin.Name = "cbPushOnMin"
        Me.cbPushOnMin.Size = New System.Drawing.Size(192, 29)
        Me.cbPushOnMin.TabIndex = 30
        Me.cbPushOnMin.Text = "Push Button On Min"
        Me.cbPushOnMin.UseVisualStyleBackColor = True
        '
        'tbPlungerMid
        '
        Me.tbPlungerMid.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPlungerMid.Location = New System.Drawing.Point(186, 158)
        Me.tbPlungerMid.Name = "tbPlungerMid"
        Me.tbPlungerMid.Size = New System.Drawing.Size(100, 32)
        Me.tbPlungerMid.TabIndex = 5
        '
        'tbPlungerMax
        '
        Me.tbPlungerMax.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPlungerMax.Location = New System.Drawing.Point(186, 115)
        Me.tbPlungerMax.Name = "tbPlungerMax"
        Me.tbPlungerMax.Size = New System.Drawing.Size(100, 32)
        Me.tbPlungerMax.TabIndex = 4
        '
        'tbPlungerMin
        '
        Me.tbPlungerMin.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPlungerMin.Location = New System.Drawing.Point(186, 73)
        Me.tbPlungerMin.Name = "tbPlungerMin"
        Me.tbPlungerMin.Size = New System.Drawing.Size(100, 32)
        Me.tbPlungerMin.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Plunger MidPoint"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Plunger Maximum"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Plunger Minimum"
        '
        'tpMainOutputs
        '
        Me.tpMainOutputs.AutoScroll = True
        Me.tpMainOutputs.BackColor = System.Drawing.SystemColors.Control
        Me.tpMainOutputs.Location = New System.Drawing.Point(4, 34)
        Me.tpMainOutputs.Name = "tpMainOutputs"
        Me.tpMainOutputs.Size = New System.Drawing.Size(1220, 739)
        Me.tpMainOutputs.TabIndex = 4
        Me.tpMainOutputs.Text = "Main Outputs"
        '
        'tpExpansion1
        '
        Me.tpExpansion1.AutoScroll = True
        Me.tpExpansion1.BackColor = System.Drawing.SystemColors.Control
        Me.tpExpansion1.Location = New System.Drawing.Point(4, 34)
        Me.tpExpansion1.Name = "tpExpansion1"
        Me.tpExpansion1.Size = New System.Drawing.Size(1220, 739)
        Me.tpExpansion1.TabIndex = 2
        Me.tpExpansion1.Text = "Expansion Board #1"
        '
        'tpExpansion2
        '
        Me.tpExpansion2.AutoScroll = True
        Me.tpExpansion2.BackColor = System.Drawing.SystemColors.Control
        Me.tpExpansion2.Location = New System.Drawing.Point(4, 34)
        Me.tpExpansion2.Name = "tpExpansion2"
        Me.tpExpansion2.Size = New System.Drawing.Size(1220, 739)
        Me.tpExpansion2.TabIndex = 3
        Me.tpExpansion2.Text = "Expansion Board #2"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(996, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(220, 49)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save Config"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(12, 435)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(141, 25)
        Me.Label20.TabIndex = 47
        Me.Label20.Text = "Tilt Suppression"
        '
        'cbTiltSuppress
        '
        Me.cbTiltSuppress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTiltSuppress.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTiltSuppress.FormattingEnabled = True
        Me.cbTiltSuppress.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "211", "212", "213", "214", "215", "216", "217", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242", "243", "244", "245", "246", "247", "248", "249", "250", "251", "252", "253", "254", "255"})
        Me.cbTiltSuppress.Location = New System.Drawing.Point(161, 427)
        Me.cbTiltSuppress.Name = "cbTiltSuppress"
        Me.cbTiltSuppress.Size = New System.Drawing.Size(76, 33)
        Me.cbTiltSuppress.TabIndex = 46
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cbAttractEnable)
        Me.GroupBox5.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(840, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(314, 217)
        Me.GroupBox5.TabIndex = 28
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Other Settings"
        '
        'cbAttractEnable
        '
        Me.cbAttractEnable.AutoSize = True
        Me.cbAttractEnable.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAttractEnable.Location = New System.Drawing.Point(18, 40)
        Me.cbAttractEnable.Name = "cbAttractEnable"
        Me.cbAttractEnable.Size = New System.Drawing.Size(183, 29)
        Me.cbAttractEnable.TabIndex = 51
        Me.cbAttractEnable.Text = "Light Show Attract"
        Me.cbAttractEnable.UseVisualStyleBackColor = True
        '
        'Configuration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1228, 849)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tbMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Configuration"
        Me.Text = "Configuration"
        Me.tbMain.ResumeLayout(False)
        Me.tpGeneralSettings.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbMain As TabControl
    Friend WithEvents tpGeneralSettings As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbPlungerMid As TextBox
    Friend WithEvents tbPlungerMax As TextBox
    Friend WithEvents tbPlungerMin As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tpExpansion1 As TabPage
    Friend WithEvents tpExpansion2 As TabPage
    Friend WithEvents cbOutputTrigger4 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbButtonTrigger4 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbOutputTrigger3 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbButtonTrigger3 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbOutputTrigger2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbButtonTrigger2 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbOutputTrigger1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbButtonTrigger1 As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbAccelEnabled As CheckBox
    Friend WithEvents cbOrientation As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents tpMainOutputs As TabPage
    Friend WithEvents tbDeadZone As TextBox
    Friend WithEvents lblDeadZone As Label
    Friend WithEvents cbPushOnMax As CheckBox
    Friend WithEvents cbPushOnMin As CheckBox
    Friend WithEvents tbTilt As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tbMax As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbPinsFacingUp As CheckBox
    Friend WithEvents cbMultiplier As ComboBox
    Friend WithEvents lblMultiplier As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cbAverageReadings As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cbLaunchButton As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cbTiltButton As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents cbNightMode As ComboBox
    Friend WithEvents rbNightModePush As RadioButton
    Friend WithEvents rbNightModeToggle As RadioButton
    Friend WithEvents Label19 As Label
    Friend WithEvents cbShiftButton As ComboBox
    Friend WithEvents cbSideMounted As CheckBox
    Friend WithEvents cbPlungerEnabled As CheckBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cbTiltSuppress As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents cbAttractEnable As CheckBox
End Class
