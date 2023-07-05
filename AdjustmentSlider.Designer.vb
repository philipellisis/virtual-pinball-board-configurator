<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdjustmentSlider
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
        Me.gbMain = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbOffValue = New System.Windows.Forms.TrackBar()
        Me.lblMinValue = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbMaxValue = New System.Windows.Forms.TrackBar()
        Me.lblMaxValue = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbCatagory = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbMilliseconds = New System.Windows.Forms.ComboBox()
        Me.btnOnOff = New System.Windows.Forms.Button()
        Me.gbMain.SuspendLayout()
        CType(Me.tbOffValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMaxValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbMain
        '
        Me.gbMain.Controls.Add(Me.btnOnOff)
        Me.gbMain.Controls.Add(Me.Label5)
        Me.gbMain.Controls.Add(Me.tbOffValue)
        Me.gbMain.Controls.Add(Me.lblMinValue)
        Me.gbMain.Controls.Add(Me.Label1)
        Me.gbMain.Controls.Add(Me.tbMaxValue)
        Me.gbMain.Controls.Add(Me.lblMaxValue)
        Me.gbMain.Controls.Add(Me.Label4)
        Me.gbMain.Controls.Add(Me.cbCatagory)
        Me.gbMain.Controls.Add(Me.Label3)
        Me.gbMain.Controls.Add(Me.Label2)
        Me.gbMain.Controls.Add(Me.cbMilliseconds)
        Me.gbMain.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMain.Location = New System.Drawing.Point(3, 3)
        Me.gbMain.Name = "gbMain"
        Me.gbMain.Size = New System.Drawing.Size(1108, 153)
        Me.gbMain.TabIndex = 0
        Me.gbMain.TabStop = False
        Me.gbMain.Text = "Output #1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(344, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Timed Off Value"
        '
        'tbOffValue
        '
        Me.tbOffValue.LargeChange = 20
        Me.tbOffValue.Location = New System.Drawing.Point(340, 65)
        Me.tbOffValue.Maximum = 255
        Me.tbOffValue.Name = "tbOffValue"
        Me.tbOffValue.Size = New System.Drawing.Size(264, 69)
        Me.tbOffValue.SmallChange = 5
        Me.tbOffValue.TabIndex = 0
        '
        'lblMinValue
        '
        Me.lblMinValue.AutoSize = True
        Me.lblMinValue.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinValue.Location = New System.Drawing.Point(610, 84)
        Me.lblMinValue.Name = "lblMinValue"
        Me.lblMinValue.Size = New System.Drawing.Size(51, 29)
        Me.lblMinValue.TabIndex = 2
        Me.lblMinValue.Text = "255"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Max Output Value"
        '
        'tbMaxValue
        '
        Me.tbMaxValue.LargeChange = 20
        Me.tbMaxValue.Location = New System.Drawing.Point(12, 65)
        Me.tbMaxValue.Maximum = 255
        Me.tbMaxValue.Name = "tbMaxValue"
        Me.tbMaxValue.Size = New System.Drawing.Size(265, 69)
        Me.tbMaxValue.SmallChange = 5
        Me.tbMaxValue.TabIndex = 0
        '
        'lblMaxValue
        '
        Me.lblMaxValue.AutoSize = True
        Me.lblMaxValue.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxValue.Location = New System.Drawing.Point(283, 84)
        Me.lblMaxValue.Name = "lblMaxValue"
        Me.lblMaxValue.Size = New System.Drawing.Size(51, 29)
        Me.lblMaxValue.TabIndex = 2
        Me.lblMaxValue.Text = "255"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(685, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 25)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Toy Catagory"
        '
        'cbCatagory
        '
        Me.cbCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCatagory.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCatagory.FormattingEnabled = True
        Me.cbCatagory.Items.AddRange(New Object() {"Normal", "Noisy", "RGB"})
        Me.cbCatagory.Location = New System.Drawing.Point(829, 110)
        Me.cbCatagory.Name = "cbCatagory"
        Me.cbCatagory.Size = New System.Drawing.Size(98, 33)
        Me.cbCatagory.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(933, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "ms"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(686, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Set Value after"
        '
        'cbMilliseconds
        '
        Me.cbMilliseconds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMilliseconds.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMilliseconds.FormattingEnabled = True
        Me.cbMilliseconds.Location = New System.Drawing.Point(829, 62)
        Me.cbMilliseconds.Name = "cbMilliseconds"
        Me.cbMilliseconds.Size = New System.Drawing.Size(98, 33)
        Me.cbMilliseconds.TabIndex = 12
        '
        'btnOnOff
        '
        Me.btnOnOff.BackColor = System.Drawing.Color.Red
        Me.btnOnOff.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOnOff.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnOnOff.Location = New System.Drawing.Point(988, 56)
        Me.btnOnOff.Name = "btnOnOff"
        Me.btnOnOff.Size = New System.Drawing.Size(75, 40)
        Me.btnOnOff.TabIndex = 19
        Me.btnOnOff.Text = "Off"
        Me.btnOnOff.UseVisualStyleBackColor = False
        '
        'AdjustmentSlider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gbMain)
        Me.Name = "AdjustmentSlider"
        Me.Size = New System.Drawing.Size(1114, 166)
        Me.gbMain.ResumeLayout(False)
        Me.gbMain.PerformLayout()
        CType(Me.tbOffValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMaxValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbMain As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbCatagory As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbMilliseconds As ComboBox
    Friend WithEvents tbOffValue As TrackBar
    Friend WithEvents lblMinValue As Label
    Friend WithEvents tbMaxValue As TrackBar
    Friend WithEvents lblMaxValue As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnOnOff As Button
End Class
