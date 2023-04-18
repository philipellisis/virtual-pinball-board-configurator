<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Output
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
        Me.tbIntensity = New System.Windows.Forms.TrackBar()
        Me.btnOnOff = New System.Windows.Forms.Button()
        Me.gbMain = New System.Windows.Forms.GroupBox()
        Me.lblValue = New System.Windows.Forms.Label()
        CType(Me.tbIntensity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbIntensity
        '
        Me.tbIntensity.LargeChange = 20
        Me.tbIntensity.Location = New System.Drawing.Point(6, 29)
        Me.tbIntensity.Maximum = 255
        Me.tbIntensity.Name = "tbIntensity"
        Me.tbIntensity.Size = New System.Drawing.Size(491, 69)
        Me.tbIntensity.SmallChange = 5
        Me.tbIntensity.TabIndex = 0
        '
        'btnOnOff
        '
        Me.btnOnOff.BackColor = System.Drawing.Color.Red
        Me.btnOnOff.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOnOff.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnOnOff.Location = New System.Drawing.Point(512, 54)
        Me.btnOnOff.Name = "btnOnOff"
        Me.btnOnOff.Size = New System.Drawing.Size(75, 40)
        Me.btnOnOff.TabIndex = 1
        Me.btnOnOff.Text = "Off"
        Me.btnOnOff.UseVisualStyleBackColor = False
        '
        'gbMain
        '
        Me.gbMain.Controls.Add(Me.lblValue)
        Me.gbMain.Controls.Add(Me.tbIntensity)
        Me.gbMain.Controls.Add(Me.btnOnOff)
        Me.gbMain.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMain.Location = New System.Drawing.Point(3, 3)
        Me.gbMain.Name = "gbMain"
        Me.gbMain.Size = New System.Drawing.Size(603, 100)
        Me.gbMain.TabIndex = 2
        Me.gbMain.TabStop = False
        Me.gbMain.Text = "Ouput #1"
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValue.Location = New System.Drawing.Point(521, 22)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(51, 29)
        Me.lblValue.TabIndex = 3
        Me.lblValue.Text = "255"
        '
        'Output
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gbMain)
        Me.Name = "Output"
        Me.Size = New System.Drawing.Size(619, 114)
        CType(Me.tbIntensity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMain.ResumeLayout(False)
        Me.gbMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbIntensity As TrackBar
    Friend WithEvents btnOnOff As Button
    Friend WithEvents gbMain As GroupBox
    Friend WithEvents lblValue As Label
End Class
