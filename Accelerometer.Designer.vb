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
        CType(Me.pbAxis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(584, 386)
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
        Me.btnDeadZone.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeadZone.Location = New System.Drawing.Point(507, 20)
        Me.btnDeadZone.Name = "btnDeadZone"
        Me.btnDeadZone.Size = New System.Drawing.Size(147, 46)
        Me.btnDeadZone.TabIndex = 2
        Me.btnDeadZone.Text = "Record Dead Zone"
        Me.btnDeadZone.UseVisualStyleBackColor = True
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX.Location = New System.Drawing.Point(561, 169)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(13, 17)
        Me.lblX.TabIndex = 3
        Me.lblX.Text = "X"
        '
        'tbX
        '
        Me.tbX.Enabled = False
        Me.tbX.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbX.Location = New System.Drawing.Point(555, 185)
        Me.tbX.Name = "tbX"
        Me.tbX.Size = New System.Drawing.Size(100, 23)
        Me.tbX.TabIndex = 4
        '
        'tbY
        '
        Me.tbY.Enabled = False
        Me.tbY.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbY.Location = New System.Drawing.Point(554, 237)
        Me.tbY.Name = "tbY"
        Me.tbY.Size = New System.Drawing.Size(100, 23)
        Me.tbY.TabIndex = 6
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblY.Location = New System.Drawing.Point(560, 221)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(14, 17)
        Me.lblY.TabIndex = 5
        Me.lblY.Text = "Y"
        '
        'tbDeadZone
        '
        Me.tbDeadZone.Enabled = False
        Me.tbDeadZone.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDeadZone.Location = New System.Drawing.Point(554, 89)
        Me.tbDeadZone.Name = "tbDeadZone"
        Me.tbDeadZone.Size = New System.Drawing.Size(100, 23)
        Me.tbDeadZone.TabIndex = 8
        '
        'lblDeadZone
        '
        Me.lblDeadZone.AutoSize = True
        Me.lblDeadZone.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeadZone.Location = New System.Drawing.Point(560, 73)
        Me.lblDeadZone.Name = "lblDeadZone"
        Me.lblDeadZone.Size = New System.Drawing.Size(64, 17)
        Me.lblDeadZone.TabIndex = 7
        Me.lblDeadZone.Text = "Dead Zone"
        '
        'lblMultiplier
        '
        Me.lblMultiplier.AutoSize = True
        Me.lblMultiplier.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMultiplier.Location = New System.Drawing.Point(560, 119)
        Me.lblMultiplier.Name = "lblMultiplier"
        Me.lblMultiplier.Size = New System.Drawing.Size(63, 17)
        Me.lblMultiplier.TabIndex = 9
        Me.lblMultiplier.Text = "Multiplier"
        '
        'tbMultiplier
        '
        Me.tbMultiplier.Enabled = False
        Me.tbMultiplier.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMultiplier.Location = New System.Drawing.Point(554, 139)
        Me.tbMultiplier.Name = "tbMultiplier"
        Me.tbMultiplier.Size = New System.Drawing.Size(100, 23)
        Me.tbMultiplier.TabIndex = 10
        '
        'tbYRaw
        '
        Me.tbYRaw.Enabled = False
        Me.tbYRaw.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbYRaw.Location = New System.Drawing.Point(555, 337)
        Me.tbYRaw.Name = "tbYRaw"
        Me.tbYRaw.Size = New System.Drawing.Size(100, 23)
        Me.tbYRaw.TabIndex = 14
        '
        'lblYRaw
        '
        Me.lblYRaw.AutoSize = True
        Me.lblYRaw.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYRaw.Location = New System.Drawing.Point(561, 321)
        Me.lblYRaw.Name = "lblYRaw"
        Me.lblYRaw.Size = New System.Drawing.Size(39, 17)
        Me.lblYRaw.TabIndex = 13
        Me.lblYRaw.Text = "Y Raw"
        '
        'tbXRaw
        '
        Me.tbXRaw.Enabled = False
        Me.tbXRaw.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbXRaw.Location = New System.Drawing.Point(556, 285)
        Me.tbXRaw.Name = "tbXRaw"
        Me.tbXRaw.Size = New System.Drawing.Size(100, 23)
        Me.tbXRaw.TabIndex = 12
        '
        'lblXRaw
        '
        Me.lblXRaw.AutoSize = True
        Me.lblXRaw.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXRaw.Location = New System.Drawing.Point(562, 269)
        Me.lblXRaw.Name = "lblXRaw"
        Me.lblXRaw.Size = New System.Drawing.Size(38, 17)
        Me.lblXRaw.TabIndex = 11
        Me.lblXRaw.Text = "X Raw"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(460, 386)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(114, 32)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save Config"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Accelerometer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 429)
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
End Class
