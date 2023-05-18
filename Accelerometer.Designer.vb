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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pbAxis = New System.Windows.Forms.PictureBox()
        CType(Me.pbAxis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(754, 566)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 50)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pbAxis
        '
        Me.pbAxis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbAxis.Location = New System.Drawing.Point(139, 31)
        Me.pbAxis.Name = "pbAxis"
        Me.pbAxis.Size = New System.Drawing.Size(533, 536)
        Me.pbAxis.TabIndex = 1
        Me.pbAxis.TabStop = False
        '
        'Accelerometer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 628)
        Me.Controls.Add(Me.pbAxis)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Accelerometer"
        Me.Text = "Accelerometer"
        CType(Me.pbAxis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents pbAxis As PictureBox
End Class
