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
        CType(Me.pbAxis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(625, 517)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(71, 32)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "Exit"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'pbAxis
        '
        Me.pbAxis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbAxis.Location = New System.Drawing.Point(93, 20)
        Me.pbAxis.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbAxis.Name = "pbAxis"
        Me.pbAxis.Size = New System.Drawing.Size(357, 350)
        Me.pbAxis.TabIndex = 1
        Me.pbAxis.TabStop = False
        '
        'btnDeadZone
        '
        Me.btnDeadZone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeadZone.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeadZone.Location = New System.Drawing.Point(543, 18)
        Me.btnDeadZone.Name = "btnDeadZone"
        Me.btnDeadZone.Size = New System.Drawing.Size(147, 46)
        Me.btnDeadZone.TabIndex = 2
        Me.btnDeadZone.Text = "Record Dead Zone"
        Me.btnDeadZone.UseVisualStyleBackColor = True
        '
        'lblX
        '
        Me.lblX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblX.AutoSize = True
        Me.lblX.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX.Location = New System.Drawing.Point(568, 257)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(13, 17)
        Me.lblX.TabIndex = 3
        Me.lblX.Text = "X"
        '
        'tbX
        '
        Me.tbX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbX.Enabled = False
        Me.tbX.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbX.Location = New System.Drawing.Point(587, 252)
        Me.tbX.Name = "tbX"
        Me.tbX.Size = New System.Drawing.Size(100, 23)
        Me.tbX.TabIndex = 4
        '
        'tbY
        '
        Me.tbY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbY.Enabled = False
        Me.tbY.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbY.Location = New System.Drawing.Point(587, 281)
        Me.tbY.Name = "tbY"
        Me.tbY.Size = New System.Drawing.Size(100, 23)
        Me.tbY.TabIndex = 6
        '
        'lblY
        '
        Me.lblY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblY.AutoSize = True
        Me.lblY.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblY.Location = New System.Drawing.Point(567, 287)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(14, 17)
        Me.lblY.TabIndex = 5
        Me.lblY.Text = "Y"
        '
        'tbDeadZone
        '
        Me.tbDeadZone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDeadZone.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDeadZone.Location = New System.Drawing.Point(587, 172)
        Me.tbDeadZone.Name = "tbDeadZone"
        Me.tbDeadZone.Size = New System.Drawing.Size(100, 23)
        Me.tbDeadZone.TabIndex = 8
        '
        'lblDeadZone
        '
        Me.lblDeadZone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDeadZone.AutoSize = True
        Me.lblDeadZone.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeadZone.Location = New System.Drawing.Point(519, 175)
        Me.lblDeadZone.Name = "lblDeadZone"
        Me.lblDeadZone.Size = New System.Drawing.Size(64, 17)
        Me.lblDeadZone.TabIndex = 7
        Me.lblDeadZone.Text = "Dead Zone"
        '
        'lblMultiplier
        '
        Me.lblMultiplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMultiplier.AutoSize = True
        Me.lblMultiplier.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMultiplier.Location = New System.Drawing.Point(484, 377)
        Me.lblMultiplier.Name = "lblMultiplier"
        Me.lblMultiplier.Size = New System.Drawing.Size(66, 17)
        Me.lblMultiplier.TabIndex = 9
        Me.lblMultiplier.Text = "Sensitivity"
        '
        'tbYRaw
        '
        Me.tbYRaw.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbYRaw.Enabled = False
        Me.tbYRaw.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbYRaw.Location = New System.Drawing.Point(587, 339)
        Me.tbYRaw.Name = "tbYRaw"
        Me.tbYRaw.Size = New System.Drawing.Size(100, 23)
        Me.tbYRaw.TabIndex = 14
        '
        'lblYRaw
        '
        Me.lblYRaw.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblYRaw.AutoSize = True
        Me.lblYRaw.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYRaw.Location = New System.Drawing.Point(543, 344)
        Me.lblYRaw.Name = "lblYRaw"
        Me.lblYRaw.Size = New System.Drawing.Size(39, 17)
        Me.lblYRaw.TabIndex = 13
        Me.lblYRaw.Text = "Y Raw"
        '
        'tbXRaw
        '
        Me.tbXRaw.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbXRaw.Enabled = False
        Me.tbXRaw.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbXRaw.Location = New System.Drawing.Point(587, 309)
        Me.tbXRaw.Name = "tbXRaw"
        Me.tbXRaw.Size = New System.Drawing.Size(100, 23)
        Me.tbXRaw.TabIndex = 12
        '
        'lblXRaw
        '
        Me.lblXRaw.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblXRaw.AutoSize = True
        Me.lblXRaw.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXRaw.Location = New System.Drawing.Point(544, 315)
        Me.lblXRaw.Name = "lblXRaw"
        Me.lblXRaw.Size = New System.Drawing.Size(38, 17)
        Me.lblXRaw.TabIndex = 11
        Me.lblXRaw.Text = "X Raw"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(501, 517)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(114, 32)
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
        Me.cbOrientation.Location = New System.Drawing.Point(553, 401)
        Me.cbOrientation.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbOrientation.Name = "cbOrientation"
        Me.cbOrientation.Size = New System.Drawing.Size(136, 25)
        Me.cbOrientation.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(441, 403)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 18)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Device Orientation"
        '
        'tbTilt
        '
        Me.tbTilt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTilt.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTilt.Location = New System.Drawing.Point(587, 197)
        Me.tbTilt.Name = "tbTilt"
        Me.tbTilt.Size = New System.Drawing.Size(100, 23)
        Me.tbTilt.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(519, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 17)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Tilt"
        '
        'btnTilt
        '
        Me.btnTilt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTilt.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTilt.Location = New System.Drawing.Point(543, 68)
        Me.btnTilt.Name = "btnTilt"
        Me.btnTilt.Size = New System.Drawing.Size(147, 46)
        Me.btnTilt.TabIndex = 31
        Me.btnTilt.Text = "Record Tilt Value"
        Me.btnTilt.UseVisualStyleBackColor = True
        '
        'btnToggleOutput
        '
        Me.btnToggleOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnToggleOutput.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToggleOutput.Location = New System.Drawing.Point(93, 380)
        Me.btnToggleOutput.Name = "btnToggleOutput"
        Me.btnToggleOutput.Size = New System.Drawing.Size(147, 46)
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
        Me.cbOutputNumber.Location = New System.Drawing.Point(245, 394)
        Me.cbOutputNumber.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbOutputNumber.Name = "cbOutputNumber"
        Me.cbOutputNumber.Size = New System.Drawing.Size(102, 25)
        Me.cbOutputNumber.TabIndex = 33
        '
        'tbMax
        '
        Me.tbMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMax.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMax.Location = New System.Drawing.Point(587, 224)
        Me.tbMax.Name = "tbMax"
        Me.tbMax.Size = New System.Drawing.Size(100, 23)
        Me.tbMax.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(519, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 17)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Max"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(543, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 46)
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
        Me.cbMultiplier.Location = New System.Drawing.Point(553, 372)
        Me.cbMultiplier.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbMultiplier.Name = "cbMultiplier"
        Me.cbMultiplier.Size = New System.Drawing.Size(135, 25)
        Me.cbMultiplier.TabIndex = 37
        '
        'cbPinsFacingUp
        '
        Me.cbPinsFacingUp.AutoSize = True
        Me.cbPinsFacingUp.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPinsFacingUp.Location = New System.Drawing.Point(581, 430)
        Me.cbPinsFacingUp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbPinsFacingUp.Name = "cbPinsFacingUp"
        Me.cbPinsFacingUp.Size = New System.Drawing.Size(109, 22)
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
        Me.cbTiltButton.Location = New System.Drawing.Point(635, 456)
        Me.cbTiltButton.Margin = New System.Windows.Forms.Padding(2)
        Me.cbTiltButton.Name = "cbTiltButton"
        Me.cbTiltButton.Size = New System.Drawing.Size(52, 25)
        Me.cbTiltButton.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(566, 459)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 18)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Tilt Button"
        '
        'Accelerometer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 560)
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
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
End Class
