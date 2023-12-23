<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucButton
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
        Me.rbButton = New System.Windows.Forms.RadioButton()
        Me.btnAssign = New System.Windows.Forms.Button()
        Me.tbKeyboard = New System.Windows.Forms.TextBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.cbDebounce = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'rbButton
        '
        Me.rbButton.AutoSize = True
        Me.rbButton.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbButton.Location = New System.Drawing.Point(3, 9)
        Me.rbButton.Name = "rbButton"
        Me.rbButton.Size = New System.Drawing.Size(62, 33)
        Me.rbButton.TabIndex = 0
        Me.rbButton.TabStop = True
        Me.rbButton.Text = "22"
        Me.rbButton.UseVisualStyleBackColor = True
        '
        'btnAssign
        '
        Me.btnAssign.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssign.Location = New System.Drawing.Point(70, 8)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(148, 43)
        Me.btnAssign.TabIndex = 1
        Me.btnAssign.Text = "Assign Key"
        Me.btnAssign.UseVisualStyleBackColor = True
        '
        'tbKeyboard
        '
        Me.tbKeyboard.Enabled = False
        Me.tbKeyboard.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbKeyboard.Location = New System.Drawing.Point(225, 12)
        Me.tbKeyboard.Name = "tbKeyboard"
        Me.tbKeyboard.Size = New System.Drawing.Size(222, 32)
        Me.tbKeyboard.TabIndex = 2
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(454, 8)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(70, 43)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Del"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'cbDebounce
        '
        Me.cbDebounce.AutoSize = True
        Me.cbDebounce.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDebounce.Location = New System.Drawing.Point(530, 15)
        Me.cbDebounce.Name = "cbDebounce"
        Me.cbDebounce.Size = New System.Drawing.Size(119, 29)
        Me.cbDebounce.TabIndex = 44
        Me.cbDebounce.Text = "Debounce"
        Me.cbDebounce.UseVisualStyleBackColor = True
        '
        'ucButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cbDebounce)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.tbKeyboard)
        Me.Controls.Add(Me.btnAssign)
        Me.Controls.Add(Me.rbButton)
        Me.Name = "ucButton"
        Me.Size = New System.Drawing.Size(665, 57)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbButton As RadioButton
    Friend WithEvents btnAssign As Button
    Friend WithEvents tbKeyboard As TextBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents cbDebounce As CheckBox
End Class
