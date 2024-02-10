<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Buttons
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Buttons))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSendCalibration = New System.Windows.Forms.Button()
        Me.cbDisableJoystick = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbButtonDebounceTime = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Button Status"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button4)
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Controls.Add(Me.PictureBox1)
        Me.GroupBox5.Location = New System.Drawing.Point(453, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(469, 426)
        Me.GroupBox5.TabIndex = 35
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Send Button Presses"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CSDControllerTool.My.Resources.AVRResources.xbox_controller
        Me.PictureBox1.InitialImage = Global.CSDControllerTool.My.Resources.AVRResources.xbox_controller
        Me.PictureBox1.Location = New System.Drawing.Point(24, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(428, 292)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnSendCalibration
        '
        Me.btnSendCalibration.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSendCalibration.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendCalibration.Location = New System.Drawing.Point(800, 443)
        Me.btnSendCalibration.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSendCalibration.Name = "btnSendCalibration"
        Me.btnSendCalibration.Size = New System.Drawing.Size(123, 53)
        Me.btnSendCalibration.TabIndex = 36
        Me.btnSendCalibration.Text = "Save Config"
        Me.btnSendCalibration.UseVisualStyleBackColor = True
        '
        'cbDisableJoystick
        '
        Me.cbDisableJoystick.AutoSize = True
        Me.cbDisableJoystick.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDisableJoystick.Location = New System.Drawing.Point(453, 452)
        Me.cbDisableJoystick.Margin = New System.Windows.Forms.Padding(2)
        Me.cbDisableJoystick.Name = "cbDisableJoystick"
        Me.cbDisableJoystick.Size = New System.Drawing.Size(237, 22)
        Me.cbDisableJoystick.TabIndex = 43
        Me.cbDisableJoystick.Text = "Disable joystick for keyboard buttons"
        Me.cbDisableJoystick.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(449, 480)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 18)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Debounce Time"
        '
        'cbButtonDebounceTime
        '
        Me.cbButtonDebounceTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbButtonDebounceTime.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbButtonDebounceTime.FormattingEnabled = True
        Me.cbButtonDebounceTime.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "211", "212", "213", "214", "215", "216", "217", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242", "243", "244", "245", "246", "247", "248", "249", "250", "251", "252", "253", "254", "255"})
        Me.cbButtonDebounceTime.Location = New System.Drawing.Point(550, 478)
        Me.cbButtonDebounceTime.Margin = New System.Windows.Forms.Padding(2)
        Me.cbButtonDebounceTime.Name = "cbButtonDebounceTime"
        Me.cbButtonDebounceTime.Size = New System.Drawing.Size(52, 25)
        Me.cbButtonDebounceTime.TabIndex = 46
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(24, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(69, 22)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "L-Trigger"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(383, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(69, 22)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "R-Trigger"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Buttons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(941, 517)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbButtonDebounceTime)
        Me.Controls.Add(Me.cbDisableJoystick)
        Me.Controls.Add(Me.btnSendCalibration)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Buttons"
        Me.Text = "Buttons"
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnSendCalibration As Button
    Friend WithEvents cbDisableJoystick As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbButtonDebounceTime As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
End Class
