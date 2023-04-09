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
        Me.SuspendLayout()
        '
        'rbButton
        '
        Me.rbButton.AutoSize = True
        Me.rbButton.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbButton.Location = New System.Drawing.Point(3, 3)
        Me.rbButton.Name = "rbButton"
        Me.rbButton.Size = New System.Drawing.Size(62, 33)
        Me.rbButton.TabIndex = 0
        Me.rbButton.TabStop = True
        Me.rbButton.Text = "22"
        Me.rbButton.UseVisualStyleBackColor = True
        '
        'ucButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rbButton)
        Me.Name = "ucButton"
        Me.Size = New System.Drawing.Size(75, 43)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbButton As RadioButton
End Class
