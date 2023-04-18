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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbCatagory = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbMilliseconds = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbOffValue = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbMax = New System.Windows.Forms.GroupBox()
        Me.tbMaxValue = New System.Windows.Forms.TrackBar()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.gbMain.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.tbOffValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMax.SuspendLayout()
        CType(Me.tbMaxValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbMain
        '
        Me.gbMain.Controls.Add(Me.Label4)
        Me.gbMain.Controls.Add(Me.cbCatagory)
        Me.gbMain.Controls.Add(Me.Label3)
        Me.gbMain.Controls.Add(Me.Label2)
        Me.gbMain.Controls.Add(Me.cbMilliseconds)
        Me.gbMain.Controls.Add(Me.GroupBox2)
        Me.gbMain.Controls.Add(Me.gbMax)
        Me.gbMain.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMain.Location = New System.Drawing.Point(3, 3)
        Me.gbMain.Name = "gbMain"
        Me.gbMain.Size = New System.Drawing.Size(634, 356)
        Me.gbMain.TabIndex = 0
        Me.gbMain.TabStop = False
        Me.gbMain.Text = "Output #1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 315)
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
        Me.cbCatagory.Location = New System.Drawing.Point(156, 312)
        Me.cbCatagory.Name = "cbCatagory"
        Me.cbCatagory.Size = New System.Drawing.Size(121, 33)
        Me.cbCatagory.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(278, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Milliseconds"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 157)
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
        Me.cbMilliseconds.Location = New System.Drawing.Point(151, 154)
        Me.cbMilliseconds.Name = "cbMilliseconds"
        Me.cbMilliseconds.Size = New System.Drawing.Size(121, 33)
        Me.cbMilliseconds.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbOffValue)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 205)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(572, 101)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Timed Off Value"
        '
        'tbOffValue
        '
        Me.tbOffValue.LargeChange = 20
        Me.tbOffValue.Location = New System.Drawing.Point(6, 25)
        Me.tbOffValue.Maximum = 255
        Me.tbOffValue.Name = "tbOffValue"
        Me.tbOffValue.Size = New System.Drawing.Size(491, 69)
        Me.tbOffValue.SmallChange = 5
        Me.tbOffValue.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(503, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "255"
        '
        'gbMax
        '
        Me.gbMax.Controls.Add(Me.tbMaxValue)
        Me.gbMax.Controls.Add(Me.lblValue)
        Me.gbMax.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMax.Location = New System.Drawing.Point(6, 50)
        Me.gbMax.Name = "gbMax"
        Me.gbMax.Size = New System.Drawing.Size(572, 98)
        Me.gbMax.TabIndex = 10
        Me.gbMax.TabStop = False
        Me.gbMax.Text = "Max Output Value"
        '
        'tbMaxValue
        '
        Me.tbMaxValue.LargeChange = 20
        Me.tbMaxValue.Location = New System.Drawing.Point(6, 25)
        Me.tbMaxValue.Maximum = 255
        Me.tbMaxValue.Name = "tbMaxValue"
        Me.tbMaxValue.Size = New System.Drawing.Size(491, 69)
        Me.tbMaxValue.SmallChange = 5
        Me.tbMaxValue.TabIndex = 0
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValue.Location = New System.Drawing.Point(503, 39)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(51, 29)
        Me.lblValue.TabIndex = 2
        Me.lblValue.Text = "255"
        '
        'AdjustmentSlider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gbMain)
        Me.Name = "AdjustmentSlider"
        Me.Size = New System.Drawing.Size(640, 362)
        Me.gbMain.ResumeLayout(False)
        Me.gbMain.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.tbOffValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMax.ResumeLayout(False)
        Me.gbMax.PerformLayout()
        CType(Me.tbMaxValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbMain As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbCatagory As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbMilliseconds As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbOffValue As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents gbMax As GroupBox
    Friend WithEvents tbMaxValue As TrackBar
    Friend WithEvents lblValue As Label
End Class
