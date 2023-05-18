<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Outputs
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
        Me.tcMain = New System.Windows.Forms.TabControl()
        Me.tpMain = New System.Windows.Forms.TabPage()
        Me.tpExp1 = New System.Windows.Forms.TabPage()
        Me.tpExp2 = New System.Windows.Forms.TabPage()
        Me.tcMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcMain
        '
        Me.tcMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcMain.Controls.Add(Me.tpMain)
        Me.tcMain.Controls.Add(Me.tpExp1)
        Me.tcMain.Controls.Add(Me.tpExp2)
        Me.tcMain.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcMain.Location = New System.Drawing.Point(12, 12)
        Me.tcMain.Name = "tcMain"
        Me.tcMain.SelectedIndex = 0
        Me.tcMain.Size = New System.Drawing.Size(1068, 504)
        Me.tcMain.TabIndex = 0
        '
        'tpMain
        '
        Me.tpMain.AutoScroll = True
        Me.tpMain.Location = New System.Drawing.Point(4, 34)
        Me.tpMain.Name = "tpMain"
        Me.tpMain.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMain.Size = New System.Drawing.Size(1060, 466)
        Me.tpMain.TabIndex = 0
        Me.tpMain.Text = "Main Outputs"
        Me.tpMain.UseVisualStyleBackColor = True
        '
        'tpExp1
        '
        Me.tpExp1.AutoScroll = True
        Me.tpExp1.Location = New System.Drawing.Point(4, 34)
        Me.tpExp1.Name = "tpExp1"
        Me.tpExp1.Padding = New System.Windows.Forms.Padding(3)
        Me.tpExp1.Size = New System.Drawing.Size(1060, 466)
        Me.tpExp1.TabIndex = 1
        Me.tpExp1.Text = "Expansion Board #1"
        Me.tpExp1.UseVisualStyleBackColor = True
        '
        'tpExp2
        '
        Me.tpExp2.AutoScroll = True
        Me.tpExp2.Location = New System.Drawing.Point(4, 34)
        Me.tpExp2.Name = "tpExp2"
        Me.tpExp2.Size = New System.Drawing.Size(1060, 466)
        Me.tpExp2.TabIndex = 2
        Me.tpExp2.Text = "Expansion Board #2"
        Me.tpExp2.UseVisualStyleBackColor = True
        '
        'Outputs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1092, 528)
        Me.Controls.Add(Me.tcMain)
        Me.Name = "Outputs"
        Me.Text = "Outputs"
        Me.tcMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcMain As TabControl
    Friend WithEvents tpMain As TabPage
    Friend WithEvents tpExp1 As TabPage
    Friend WithEvents tpExp2 As TabPage
End Class
