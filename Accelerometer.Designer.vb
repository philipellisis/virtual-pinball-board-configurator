<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accelerometer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accelerometer))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.pbAxis = New System.Windows.Forms.PictureBox()
        Me.btnDeadZone = New System.Windows.Forms.Button()
        Me.lblX = New System.Windows.Forms.Label()
        Me.tbX = New System.Windows.Forms.TextBox()
        Me.tbY = New System.Windows.Forms.TextBox()
        Me.lblY = New System.Windows.Forms.Label()
        Me.tbDeadZone = New System.Windows.Forms.TextBox()
        Me.lblDeadZone = New System.Windows.Forms.Label()
        Me.lblMultiplier = New System.Windows.Forms.Label()
        Me.ttHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.tbYRaw = New System.Windows.Forms.TextBox()
        Me.lblYRaw = New System.Windows.Forms.Label()
        Me.tbXRaw = New System.Windows.Forms.TextBox()
        Me.lblXRaw = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cbOrientation = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbTilt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTilt = New System.Windows.Forms.Button()
        Me.btnToggleOutput = New System.Windows.Forms.Button()
        Me.cbOutputNumber = New System.Windows.Forms.ComboBox()
        Me.tbMax = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbMultiplier = New System.Windows.Forms.ComboBox()
        Me.cbPinsFacingUp = New System.Windows.Forms.CheckBox()
        Me.cbTiltButton = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbSideMounted = New System.Windows.Forms.CheckBox()
        Me.cbTiltSuppress = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbMaxY = New System.Windows.Forms.TextBox()
        Me.tbTiltY = New System.Windows.Forms.TextBox()
        CType(Me.pbAxis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(938, 831)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(106, 49)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "Exit"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'pbAxis
        '
        Me.pbAxis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbAxis.Location = New System.Drawing.Point(140, 31)
        Me.pbAxis.Name = "pbAxis"
        Me.pbAxis.Size = New System.Drawing.Size(534, 536)
        Me.pbAxis.TabIndex = 1
        Me.pbAxis.TabStop = False
        '
        'btnDeadZone
        '
        Me.btnDeadZone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeadZone.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeadZone.Location = New System.Drawing.Point(814, 28)
        Me.btnDeadZone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDeadZone.Name = "btnDeadZone"
        Me.btnDeadZone.Size = New System.Drawing.Size(220, 71)
        Me.btnDeadZone.TabIndex = 2
        Me.btnDeadZone.Text = "Record Dead Zone"
        Me.btnDeadZone.UseVisualStyleBackColor = True
        '
        'lblX
        '
        Me.lblX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblX.AutoSize = True
        Me.lblX.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX.Location = New System.Drawing.Point(852, 395)
        Me.lblX.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(22, 25)
        Me.lblX.TabIndex = 3
        Me.lblX.Text = "X"
        '
        'tbX
        '
        Me.tbX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbX.Enabled = False
        Me.tbX.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbX.Location = New System.Drawing.Point(880, 388)
        Me.tbX.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbX.Name = "tbX"
        Me.tbX.Size = New System.Drawing.Size(148, 31)
        Me.tbX.TabIndex = 4
        '
        'tbY
        '
        Me.tbY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbY.Enabled = False
        Me.tbY.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbY.Location = New System.Drawing.Point(880, 432)
        Me.tbY.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbY.Name = "tbY"
        Me.tbY.Size = New System.Drawing.Size(148, 31)
        Me.tbY.TabIndex = 6
        '
        'lblY
        '
        Me.lblY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblY.AutoSize = True
        Me.lblY.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblY.Location = New System.Drawing.Point(850, 442)
        Me.lblY.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(21, 25)
        Me.lblY.TabIndex = 5
        Me.lblY.Text = "Y"
        '
        'tbDeadZone
        '
        Me.tbDeadZone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDeadZone.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDeadZone.Location = New System.Drawing.Point(880, 265)
        Me.tbDeadZone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbDeadZone.Name = "tbDeadZone"
        Me.tbDeadZone.Size = New System.Drawing.Size(148, 31)
        Me.tbDeadZone.TabIndex = 8
        '
        'lblDeadZone
        '
        Me.lblDeadZone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDeadZone.AutoSize = True
        Me.lblDeadZone.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeadZone.Location = New System.Drawing.Point(778, 269)
        Me.lblDeadZone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDeadZone.Name = "lblDeadZone"
        Me.lblDeadZone.Size = New System.Drawing.Size(95, 25)
        Me.lblDeadZone.TabIndex = 7
        Me.lblDeadZone.Text = "Dead Zone"
        '
        'lblMultiplier
        '
        Me.lblMultiplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMultiplier.AutoSize = True
        Me.lblMultiplier.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMultiplier.Location = New System.Drawing.Point(726, 580)
        Me.lblMultiplier.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMultiplier.Name = "lblMultiplier"
        Me.lblMultiplier.Size = New System.Drawing.Size(96, 25)
        Me.lblMultiplier.TabIndex = 9
        Me.lblMultiplier.Text = "Sensitivity"
        '
        'tbYRaw
        '
        Me.tbYRaw.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbYRaw.Enabled = False
        Me.tbYRaw.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbYRaw.Location = New System.Drawing.Point(880, 522)
        Me.tbYRaw.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbYRaw.Name = "tbYRaw"
        Me.tbYRaw.Size = New System.Drawing.Size(148, 31)
        Me.tbYRaw.TabIndex = 14
        '
        'lblYRaw
        '
        Me.lblYRaw.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblYRaw.AutoSize = True
        Me.lblYRaw.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYRaw.Location = New System.Drawing.Point(814, 529)
        Me.lblYRaw.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYRaw.Name = "lblYRaw"
        Me.lblYRaw.Size = New System.Drawing.Size(59, 25)
        Me.lblYRaw.TabIndex = 13
        Me.lblYRaw.Text = "Y Raw"
        '
        'tbXRaw
        '
        Me.tbXRaw.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbXRaw.Enabled = False
        Me.tbXRaw.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbXRaw.Location = New System.Drawing.Point(880, 475)
        Me.tbXRaw.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbXRaw.Name = "tbXRaw"
        Me.tbXRaw.Size = New System.Drawing.Size(148, 31)
        Me.tbXRaw.TabIndex = 12
        '
        'lblXRaw
        '
        Me.lblXRaw.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblXRaw.AutoSize = True
        Me.lblXRaw.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXRaw.Location = New System.Drawing.Point(816, 485)
        Me.lblXRaw.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblXRaw.Name = "lblXRaw"
        Me.lblXRaw.Size = New System.Drawing.Size(60, 25)
        Me.lblXRaw.TabIndex = 11
        Me.lblXRaw.Text = "X Raw"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(752, 831)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(171, 49)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save Config"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cbOrientation
        '
        Me.cbOrientation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOrientation.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOrientation.FormattingEnabled = True
        Me.cbOrientation.Items.AddRange(New Object() {"USB Facing Back", "USB Facing Right", "USB Facing Left", "USB Facing Front"})
        Me.cbOrientation.Location = New System.Drawing.Point(830, 617)
        Me.cbOrientation.Name = "cbOrientation"
        Me.cbOrientation.Size = New System.Drawing.Size(202, 33)
        Me.cbOrientation.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(662, 620)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(161, 25)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Device Orientation"
        '
        'tbTilt
        '
        Me.tbTilt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTilt.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTilt.Location = New System.Drawing.Point(880, 303)
        Me.tbTilt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbTilt.Name = "tbTilt"
        Me.tbTilt.Size = New System.Drawing.Size(64, 31)
        Me.tbTilt.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(778, 308)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 25)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Tilt"
        '
        'btnTilt
        '
        Me.btnTilt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTilt.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTilt.Location = New System.Drawing.Point(814, 105)
        Me.btnTilt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTilt.Name = "btnTilt"
        Me.btnTilt.Size = New System.Drawing.Size(220, 71)
        Me.btnTilt.TabIndex = 31
        Me.btnTilt.Text = "Record Tilt Value"
        Me.btnTilt.UseVisualStyleBackColor = True
        '
        'btnToggleOutput
        '
        Me.btnToggleOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnToggleOutput.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToggleOutput.Location = New System.Drawing.Point(140, 585)
        Me.btnToggleOutput.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnToggleOutput.Name = "btnToggleOutput"
        Me.btnToggleOutput.Size = New System.Drawing.Size(220, 71)
        Me.btnToggleOutput.TabIndex = 32
        Me.btnToggleOutput.Text = "Toggle Output On"
        Me.btnToggleOutput.UseVisualStyleBackColor = True
        '
        'cbOutputNumber
        '
        Me.cbOutputNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbOutputNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOutputNumber.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOutputNumber.FormattingEnabled = True
        Me.cbOutputNumber.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63"})
        Me.cbOutputNumber.Location = New System.Drawing.Point(368, 606)
        Me.cbOutputNumber.Name = "cbOutputNumber"
        Me.cbOutputNumber.Size = New System.Drawing.Size(151, 33)
        Me.cbOutputNumber.TabIndex = 33
        '
        'tbMax
        '
        Me.tbMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMax.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMax.Location = New System.Drawing.Point(880, 345)
        Me.tbMax.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbMax.Name = "tbMax"
        Me.tbMax.Size = New System.Drawing.Size(64, 31)
        Me.tbMax.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(778, 349)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 25)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Max"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(814, 180)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(220, 71)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Record Max Value"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbMultiplier
        '
        Me.cbMultiplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbMultiplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMultiplier.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMultiplier.FormattingEnabled = True
        Me.cbMultiplier.Items.AddRange(New Object() {"2G (Most Sensitive)", "4G", "8G", "16G (Least Sensitive)"})
        Me.cbMultiplier.Location = New System.Drawing.Point(830, 572)
        Me.cbMultiplier.Name = "cbMultiplier"
        Me.cbMultiplier.Size = New System.Drawing.Size(200, 33)
        Me.cbMultiplier.TabIndex = 37
        '
        'cbPinsFacingUp
        '
        Me.cbPinsFacingUp.AutoSize = True
        Me.cbPinsFacingUp.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPinsFacingUp.Location = New System.Drawing.Point(872, 662)
        Me.cbPinsFacingUp.Name = "cbPinsFacingUp"
        Me.cbPinsFacingUp.Size = New System.Drawing.Size(154, 29)
        Me.cbPinsFacingUp.TabIndex = 39
        Me.cbPinsFacingUp.Text = "Pins Facing Up"
        Me.cbPinsFacingUp.UseVisualStyleBackColor = True
        '
        'cbTiltButton
        '
        Me.cbTiltButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTiltButton.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTiltButton.FormattingEnabled = True
        Me.cbTiltButton.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.cbTiltButton.Location = New System.Drawing.Point(953, 736)
        Me.cbTiltButton.Name = "cbTiltButton"
        Me.cbTiltButton.Size = New System.Drawing.Size(76, 33)
        Me.cbTiltButton.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(850, 740)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 25)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Tilt Button"
        '
        'cbSideMounted
        '
        Me.cbSideMounted.AutoSize = True
        Me.cbSideMounted.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSideMounted.Location = New System.Drawing.Point(872, 697)
        Me.cbSideMounted.Name = "cbSideMounted"
        Me.cbSideMounted.Size = New System.Drawing.Size(171, 29)
        Me.cbSideMounted.TabIndex = 42
        Me.cbSideMounted.Text = "Mounted on Side"
        Me.cbSideMounted.UseVisualStyleBackColor = True
        '
        'cbTiltSuppress
        '
        Me.cbTiltSuppress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTiltSuppress.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTiltSuppress.FormattingEnabled = True
        Me.cbTiltSuppress.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "211", "212", "213", "214", "215", "216", "217", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242", "243", "244", "245", "246", "247", "248", "249", "250", "251", "252", "253", "254", "255"})
        Me.cbTiltSuppress.Location = New System.Drawing.Point(952, 775)
        Me.cbTiltSuppress.Name = "cbTiltSuppress"
        Me.cbTiltSuppress.Size = New System.Drawing.Size(76, 33)
        Me.cbTiltSuppress.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(803, 783)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 25)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Tilt Suppression"
        '
        'tbMaxY
        '
        Me.tbMaxY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMaxY.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMaxY.Location = New System.Drawing.Point(962, 346)
        Me.tbMaxY.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbMaxY.Name = "tbMaxY"
        Me.tbMaxY.Size = New System.Drawing.Size(64, 31)
        Me.tbMaxY.TabIndex = 45
        '
        'tbTiltY
        '
        Me.tbTiltY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTiltY.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTiltY.Location = New System.Drawing.Point(962, 302)
        Me.tbTiltY.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbTiltY.Name = "tbTiltY"
        Me.tbTiltY.Size = New System.Drawing.Size(64, 31)
        Me.tbTiltY.TabIndex = 46
        '
        'Accelerometer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 898)
        Me.Controls.Add(Me.tbTiltY)
        Me.Controls.Add(Me.tbMaxY)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbTiltSuppress)
        Me.Controls.Add(Me.cbSideMounted)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbTiltButton)
        Me.Controls.Add(Me.cbPinsFacingUp)
        Me.Controls.Add(Me.cbMultiplier)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbMax)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbOutputNumber)
        Me.Controls.Add(Me.btnToggleOutput)
        Me.Controls.Add(Me.btnTilt)
        Me.Controls.Add(Me.tbTilt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbOrientation)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tbYRaw)
        Me.Controls.Add(Me.lblYRaw)
        Me.Controls.Add(Me.tbXRaw)
        Me.Controls.Add(Me.lblXRaw)
        Me.Controls.Add(Me.lblMultiplier)
        Me.Controls.Add(Me.tbDeadZone)
        Me.Controls.Add(Me.lblDeadZone)
        Me.Controls.Add(Me.tbY)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.tbX)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.btnDeadZone)
        Me.Controls.Add(Me.pbAxis)
        Me.Controls.Add(Me.btnOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Accelerometer"
        Me.Text = "Accelerometer"
        CType(Me.pbAxis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOK As Button
    Friend WithEvents pbAxis As PictureBox
    Friend WithEvents btnDeadZone As Button
    Friend WithEvents lblX As Label
    Friend WithEvents tbX As TextBox
    Friend WithEvents tbY As TextBox
    Friend WithEvents lblY As Label
    Friend WithEvents tbDeadZone As TextBox
    Friend WithEvents lblDeadZone As Label
    Friend WithEvents lblMultiplier As Label
    Friend WithEvents ttHelp As ToolTip
    Friend WithEvents tbYRaw As TextBox
    Friend WithEvents lblYRaw As Label
    Friend WithEvents tbXRaw As TextBox
    Friend WithEvents lblXRaw As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents cbOrientation As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents tbTilt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTilt As Button
    Friend WithEvents btnToggleOutput As Button
    Friend WithEvents cbOutputNumber As ComboBox
    Friend WithEvents tbMax As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cbMultiplier As ComboBox
    Friend WithEvents cbPinsFacingUp As CheckBox
    Friend WithEvents cbTiltButton As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbSideMounted As CheckBox
    Friend WithEvents cbTiltSuppress As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbMaxY As TextBox
    Friend WithEvents tbTiltY As TextBox
End Class
