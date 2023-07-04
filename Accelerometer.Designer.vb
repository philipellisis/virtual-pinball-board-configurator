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
        Me.tbMultiplier = New System.Windows.Forms.TextBox()
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
        CType(Me.pbAxis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(938, 594)
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
        Me.btnDeadZone.Location = New System.Drawing.Point(814, 31)
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
        Me.lblX.Location = New System.Drawing.Point(856, 253)
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
        Me.tbX.Location = New System.Drawing.Point(885, 244)
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
        Me.tbY.Location = New System.Drawing.Point(884, 289)
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
        Me.lblY.Location = New System.Drawing.Point(855, 298)
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
        Me.tbDeadZone.Location = New System.Drawing.Point(885, 111)
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
        Me.lblDeadZone.Location = New System.Drawing.Point(782, 115)
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
        Me.lblMultiplier.Location = New System.Drawing.Point(782, 159)
        Me.lblMultiplier.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMultiplier.Name = "lblMultiplier"
        Me.lblMultiplier.Size = New System.Drawing.Size(89, 25)
        Me.lblMultiplier.TabIndex = 9
        Me.lblMultiplier.Text = "Multiplier"
        '
        'tbMultiplier
        '
        Me.tbMultiplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMultiplier.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMultiplier.Location = New System.Drawing.Point(884, 155)
        Me.tbMultiplier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbMultiplier.Name = "tbMultiplier"
        Me.tbMultiplier.Size = New System.Drawing.Size(148, 31)
        Me.tbMultiplier.TabIndex = 10
        '
        'tbYRaw
        '
        Me.tbYRaw.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbYRaw.Enabled = False
        Me.tbYRaw.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbYRaw.Location = New System.Drawing.Point(884, 378)
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
        Me.lblYRaw.Location = New System.Drawing.Point(818, 387)
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
        Me.tbXRaw.Location = New System.Drawing.Point(884, 333)
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
        Me.lblXRaw.Location = New System.Drawing.Point(820, 342)
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
        Me.btnSave.Location = New System.Drawing.Point(752, 594)
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
        Me.cbOrientation.Location = New System.Drawing.Point(884, 421)
        Me.cbOrientation.Name = "cbOrientation"
        Me.cbOrientation.Size = New System.Drawing.Size(151, 33)
        Me.cbOrientation.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(705, 426)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(161, 25)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Device Orientation"
        '
        'tbTilt
        '
        Me.tbTilt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTilt.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTilt.Location = New System.Drawing.Point(884, 196)
        Me.tbTilt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbTilt.Name = "tbTilt"
        Me.tbTilt.Size = New System.Drawing.Size(148, 31)
        Me.tbTilt.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(782, 201)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 25)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Tilt"
        '
        'Accelerometer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 660)
        Me.Controls.Add(Me.tbTilt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbOrientation)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tbYRaw)
        Me.Controls.Add(Me.lblYRaw)
        Me.Controls.Add(Me.tbXRaw)
        Me.Controls.Add(Me.lblXRaw)
        Me.Controls.Add(Me.tbMultiplier)
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
    Friend WithEvents tbMultiplier As TextBox
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
End Class
