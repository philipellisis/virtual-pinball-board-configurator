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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Outputs))
        Me.tcMain = New System.Windows.Forms.TabControl()
        Me.tpMain = New System.Windows.Forms.TabPage()
        Me.tpExp1 = New System.Windows.Forms.TabPage()
        Me.tpExp2 = New System.Windows.Forms.TabPage()
        Me.tbIntensity = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.tpButtons = New System.Windows.Forms.TabPage()
        Me.tcMain.SuspendLayout()
        CType(Me.tbIntensity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcMain
        '
        Me.tcMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcMain.Controls.Add(Me.tpMain)
        Me.tcMain.Controls.Add(Me.tpButtons)
        Me.tcMain.Controls.Add(Me.tpExp1)
        Me.tcMain.Controls.Add(Me.tpExp2)
        Me.tcMain.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcMain.Location = New System.Drawing.Point(12, 128)
        Me.tcMain.Name = "tcMain"
        Me.tcMain.SelectedIndex = 0
        Me.tcMain.Size = New System.Drawing.Size(1068, 813)
        Me.tcMain.TabIndex = 0
        '
        'tpMain
        '
        Me.tpMain.AutoScroll = True
        Me.tpMain.Location = New System.Drawing.Point(4, 34)
        Me.tpMain.Name = "tpMain"
        Me.tpMain.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMain.Size = New System.Drawing.Size(1060, 775)
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
        Me.tpExp1.Size = New System.Drawing.Size(1060, 775)
        Me.tpExp1.TabIndex = 1
        Me.tpExp1.Text = "Expansion Board #1"
        Me.tpExp1.UseVisualStyleBackColor = True
        '
        'tpExp2
        '
        Me.tpExp2.AutoScroll = True
        Me.tpExp2.Location = New System.Drawing.Point(4, 34)
        Me.tpExp2.Name = "tpExp2"
        Me.tpExp2.Size = New System.Drawing.Size(1060, 775)
        Me.tpExp2.TabIndex = 2
        Me.tpExp2.Text = "Expansion Board #2"
        Me.tpExp2.UseVisualStyleBackColor = True
        '
        'tbIntensity
        '
        Me.tbIntensity.LargeChange = 1
        Me.tbIntensity.Location = New System.Drawing.Point(16, 53)
        Me.tbIntensity.Maximum = 63
        Me.tbIntensity.Name = "tbIntensity"
        Me.tbIntensity.Size = New System.Drawing.Size(981, 69)
        Me.tbIntensity.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Auto Turn Output On"
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValue.Location = New System.Drawing.Point(1003, 62)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(26, 29)
        Me.lblValue.TabIndex = 4
        Me.lblValue.Text = "0"
        '
        'tpButtons
        '
        Me.tpButtons.AutoScroll = True
        Me.tpButtons.Location = New System.Drawing.Point(4, 34)
        Me.tpButtons.Name = "tpButtons"
        Me.tpButtons.Size = New System.Drawing.Size(1060, 775)
        Me.tpButtons.TabIndex = 3
        Me.tpButtons.Text = "Buttons"
        '
        'Outputs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1092, 953)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbIntensity)
        Me.Controls.Add(Me.tcMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Outputs"
        Me.Text = "Outputs"
        Me.tcMain.ResumeLayout(False)
        CType(Me.tbIntensity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tcMain As TabControl
    Friend WithEvents tpMain As TabPage
    Friend WithEvents tpExp1 As TabPage
    Friend WithEvents tpExp2 As TabPage
    Friend WithEvents tbIntensity As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents lblValue As Label
    Friend WithEvents tpButtons As TabPage
End Class
