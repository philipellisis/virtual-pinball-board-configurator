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
        CType(Me.pbAxis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(625, 386)
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
        Me.btnDeadZone.Location = New System.Drawing.Point(543, 20)
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
        Me.lblX.Location = New System.Drawing.Point(571, 136)
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
        Me.tbX.Location = New System.Drawing.Point(590, 130)
        Me.tbX.Name = "tbX"
        Me.tbX.Size = New System.Drawing.Size(100, 23)
        Me.tbX.TabIndex = 4
        '
        'tbY
        '
        Me.tbY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbY.Enabled = False
        Me.tbY.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbY.Location = New System.Drawing.Point(589, 159)
        Me.tbY.Name = "tbY"
        Me.tbY.Size = New System.Drawing.Size(100, 23)
        Me.tbY.TabIndex = 6
        '
        'lblY
        '
        Me.lblY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblY.AutoSize = True
        Me.lblY.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblY.Location = New System.Drawing.Point(570, 165)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(14, 17)
        Me.lblY.TabIndex = 5
        Me.lblY.Text = "Y"
        '
        'tbDeadZone
        '
        Me.tbDeadZone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDeadZone.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDeadZone.Location = New System.Drawing.Point(590, 72)
        Me.tbDeadZone.Name = "tbDeadZone"
        Me.tbDeadZone.Size = New System.Drawing.Size(100, 23)
        Me.tbDeadZone.TabIndex = 8
        '
        'lblDeadZone
        '
        Me.lblDeadZone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDeadZone.AutoSize = True
        Me.lblDeadZone.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeadZone.Location = New System.Drawing.Point(521, 78)
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
        Me.lblMultiplier.Location = New System.Drawing.Point(521, 107)
        Me.lblMultiplier.Name = "lblMultiplier"
        Me.lblMultiplier.Size = New System.Drawing.Size(63, 17)
        Me.lblMultiplier.TabIndex = 9
        Me.lblMultiplier.Text = "Multiplier"
        '
        'tbMultiplier
        '
        Me.tbMultiplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMultiplier.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMultiplier.Location = New System.Drawing.Point(589, 101)
        Me.tbMultiplier.Name = "tbMultiplier"
        Me.tbMultiplier.Size = New System.Drawing.Size(100, 23)
        Me.tbMultiplier.TabIndex = 10
        '
        'tbYRaw
        '
        Me.tbYRaw.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbYRaw.Enabled = False
        Me.tbYRaw.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbYRaw.Location = New System.Drawing.Point(589, 217)
        Me.tbYRaw.Name = "tbYRaw"
        Me.tbYRaw.Size = New System.Drawing.Size(100, 23)
        Me.tbYRaw.TabIndex = 14
        '
        'lblYRaw
        '
        Me.lblYRaw.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblYRaw.AutoSize = True
        Me.lblYRaw.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYRaw.Location = New System.Drawing.Point(545, 223)
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
        Me.tbXRaw.Location = New System.Drawing.Point(589, 188)
        Me.tbXRaw.Name = "tbXRaw"
        Me.tbXRaw.Size = New System.Drawing.Size(100, 23)
        Me.tbXRaw.TabIndex = 12
        '
        'lblXRaw
        '
        Me.lblXRaw.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblXRaw.AutoSize = True
        Me.lblXRaw.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXRaw.Location = New System.Drawing.Point(547, 194)
        Me.lblXRaw.Name = "lblXRaw"
        Me.lblXRaw.Size = New System.Drawing.Size(38, 17)
        Me.lblXRaw.TabIndex = 11
        Me.lblXRaw.Text = "X Raw"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(501, 386)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
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
        Me.cbOrientation.Location = New System.Drawing.Point(589, 245)
        Me.cbOrientation.Margin = New System.Windows.Forms.Padding(2)
        Me.cbOrientation.Name = "cbOrientation"
        Me.cbOrientation.Size = New System.Drawing.Size(102, 25)
        Me.cbOrientation.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(470, 248)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 18)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Device Orientation"
        '
        'Accelerometer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 429)
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
    Friend WithEvents tbMultiplier As TextBox
    Friend WithEvents ttHelp As ToolTip
    Friend WithEvents tbYRaw As TextBox
    Friend WithEvents lblYRaw As Label
    Friend WithEvents tbXRaw As TextBox
    Friend WithEvents lblXRaw As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents cbOrientation As ComboBox
    Friend WithEvents Label14 As Label
End Class
