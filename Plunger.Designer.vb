<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Plunger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Plunger))
        Me.pbPlunger = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblMinValue = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblMaxValue = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblRestingPoint = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbPushOnMin = New System.Windows.Forms.CheckBox()
        Me.cbPushOnMax = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbPlunger
        '
        Me.pbPlunger.Location = New System.Drawing.Point(47, 49)
        Me.pbPlunger.MarqueeAnimationSpeed = 1
        Me.pbPlunger.Maximum = 1024
        Me.pbPlunger.Name = "pbPlunger"
        Me.pbPlunger.Size = New System.Drawing.Size(594, 47)
        Me.pbPlunger.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbPlunger.TabIndex = 0
        Me.pbPlunger.Value = 200
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblMinValue)
        Me.GroupBox1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(45, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(186, 73)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Minimum Value"
        '
        'lblMinValue
        '
        Me.lblMinValue.AutoSize = True
        Me.lblMinValue.Location = New System.Drawing.Point(119, 33)
        Me.lblMinValue.Name = "lblMinValue"
        Me.lblMinValue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMinValue.Size = New System.Drawing.Size(61, 29)
        Me.lblMinValue.TabIndex = 0
        Me.lblMinValue.Text = "1000"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblMaxValue)
        Me.GroupBox2.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(254, 123)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(186, 73)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Maximum Value"
        '
        'lblMaxValue
        '
        Me.lblMaxValue.AutoSize = True
        Me.lblMaxValue.Location = New System.Drawing.Point(119, 33)
        Me.lblMaxValue.Name = "lblMaxValue"
        Me.lblMaxValue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMaxValue.Size = New System.Drawing.Size(61, 29)
        Me.lblMaxValue.TabIndex = 1
        Me.lblMaxValue.Text = "1000"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblRestingPoint)
        Me.GroupBox3.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(466, 123)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(186, 73)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resting Point"
        '
        'lblRestingPoint
        '
        Me.lblRestingPoint.AutoSize = True
        Me.lblRestingPoint.Location = New System.Drawing.Point(114, 33)
        Me.lblRestingPoint.Name = "lblRestingPoint"
        Me.lblRestingPoint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRestingPoint.Size = New System.Drawing.Size(61, 29)
        Me.lblRestingPoint.TabIndex = 2
        Me.lblRestingPoint.Text = "1000"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(466, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 81)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Send Calibration Values"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbPushOnMin
        '
        Me.cbPushOnMin.AutoSize = True
        Me.cbPushOnMin.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPushOnMin.Location = New System.Drawing.Point(47, 220)
        Me.cbPushOnMin.Name = "cbPushOnMin"
        Me.cbPushOnMin.Size = New System.Drawing.Size(192, 29)
        Me.cbPushOnMin.TabIndex = 28
        Me.cbPushOnMin.Text = "Push Button On Min"
        Me.cbPushOnMin.UseVisualStyleBackColor = True
        '
        'cbPushOnMax
        '
        Me.cbPushOnMax.AutoSize = True
        Me.cbPushOnMax.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPushOnMax.Location = New System.Drawing.Point(47, 255)
        Me.cbPushOnMax.Name = "cbPushOnMax"
        Me.cbPushOnMax.Size = New System.Drawing.Size(196, 29)
        Me.cbPushOnMax.TabIndex = 29
        Me.cbPushOnMax.Text = "Push Button On Max"
        Me.cbPushOnMax.UseVisualStyleBackColor = True
        '
        'Plunger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 320)
        Me.Controls.Add(Me.cbPushOnMax)
        Me.Controls.Add(Me.cbPushOnMin)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbPlunger)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Plunger"
        Me.Text = "Plunger"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbPlunger As ProgressBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblMinValue As Label
    Friend WithEvents lblMaxValue As Label
    Friend WithEvents lblRestingPoint As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cbPushOnMin As CheckBox
    Friend WithEvents cbPushOnMax As CheckBox
End Class
