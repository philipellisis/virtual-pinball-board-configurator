<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuration
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
        Me.tbMain = New System.Windows.Forms.TabControl()
        Me.tpGeneralSettings = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbAccelEnabled = New System.Windows.Forms.CheckBox()
        Me.cbOrientation = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbOutputTrigger4 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbButtonTrigger4 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbOutputTrigger3 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbButtonTrigger3 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbOutputTrigger2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbButtonTrigger2 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbOutputTrigger1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbButtonTrigger1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbPlungerMid = New System.Windows.Forms.TextBox()
        Me.tbPlungerMax = New System.Windows.Forms.TextBox()
        Me.tbPlungerMin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tpMainOutputs = New System.Windows.Forms.TabPage()
        Me.tpExpansion1 = New System.Windows.Forms.TabPage()
        Me.tpExpansion2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbMain.SuspendLayout()
        Me.tpGeneralSettings.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbMain
        '
        Me.tbMain.Controls.Add(Me.tpGeneralSettings)
        Me.tbMain.Controls.Add(Me.tpMainOutputs)
        Me.tbMain.Controls.Add(Me.tpExpansion1)
        Me.tbMain.Controls.Add(Me.tpExpansion2)
        Me.tbMain.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMain.Location = New System.Drawing.Point(12, 12)
        Me.tbMain.Name = "tbMain"
        Me.tbMain.SelectedIndex = 0
        Me.tbMain.Size = New System.Drawing.Size(1095, 627)
        Me.tbMain.TabIndex = 0
        '
        'tpGeneralSettings
        '
        Me.tpGeneralSettings.AutoScroll = True
        Me.tpGeneralSettings.Controls.Add(Me.GroupBox3)
        Me.tpGeneralSettings.Controls.Add(Me.GroupBox2)
        Me.tpGeneralSettings.Controls.Add(Me.GroupBox1)
        Me.tpGeneralSettings.Location = New System.Drawing.Point(4, 34)
        Me.tpGeneralSettings.Name = "tpGeneralSettings"
        Me.tpGeneralSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tpGeneralSettings.Size = New System.Drawing.Size(1087, 589)
        Me.tpGeneralSettings.TabIndex = 0
        Me.tpGeneralSettings.Text = "Main Settings"
        Me.tpGeneralSettings.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbAccelEnabled)
        Me.GroupBox3.Controls.Add(Me.cbOrientation)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(15, 233)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(389, 151)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Accelerometer"
        '
        'cbAccelEnabled
        '
        Me.cbAccelEnabled.AutoSize = True
        Me.cbAccelEnabled.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAccelEnabled.Location = New System.Drawing.Point(11, 49)
        Me.cbAccelEnabled.Name = "cbAccelEnabled"
        Me.cbAccelEnabled.Size = New System.Drawing.Size(225, 29)
        Me.cbAccelEnabled.TabIndex = 27
        Me.cbAccelEnabled.Text = "Accelerometer Enabled"
        Me.cbAccelEnabled.UseVisualStyleBackColor = True
        '
        'cbOrientation
        '
        Me.cbOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOrientation.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOrientation.FormattingEnabled = True
        Me.cbOrientation.Items.AddRange(New Object() {"USB Facing Back", "USB Facing Right", "USB Facing Left", "USB Facing Front"})
        Me.cbOrientation.Location = New System.Drawing.Point(173, 95)
        Me.cbOrientation.Name = "cbOrientation"
        Me.cbOrientation.Size = New System.Drawing.Size(196, 33)
        Me.cbOrientation.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(161, 25)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Device Orientation"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbOutputTrigger4)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cbButtonTrigger4)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cbOutputTrigger3)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cbButtonTrigger3)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cbOutputTrigger2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cbButtonTrigger2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cbOutputTrigger1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cbButtonTrigger1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(393, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(432, 217)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Button Triggers"
        '
        'cbOutputTrigger4
        '
        Me.cbOutputTrigger4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOutputTrigger4.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOutputTrigger4.FormattingEnabled = True
        Me.cbOutputTrigger4.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63"})
        Me.cbOutputTrigger4.Location = New System.Drawing.Point(301, 164)
        Me.cbOutputTrigger4.Name = "cbOutputTrigger4"
        Me.cbOutputTrigger4.Size = New System.Drawing.Size(76, 33)
        Me.cbOutputTrigger4.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(159, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 25)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Triggers Output"
        '
        'cbButtonTrigger4
        '
        Me.cbButtonTrigger4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbButtonTrigger4.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbButtonTrigger4.FormattingEnabled = True
        Me.cbButtonTrigger4.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.cbButtonTrigger4.Location = New System.Drawing.Point(77, 164)
        Me.cbButtonTrigger4.Name = "cbButtonTrigger4"
        Me.cbButtonTrigger4.Size = New System.Drawing.Size(76, 33)
        Me.cbButtonTrigger4.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 171)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 25)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Button"
        '
        'cbOutputTrigger3
        '
        Me.cbOutputTrigger3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOutputTrigger3.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOutputTrigger3.FormattingEnabled = True
        Me.cbOutputTrigger3.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63"})
        Me.cbOutputTrigger3.Location = New System.Drawing.Point(301, 124)
        Me.cbOutputTrigger3.Name = "cbOutputTrigger3"
        Me.cbOutputTrigger3.Size = New System.Drawing.Size(76, 33)
        Me.cbOutputTrigger3.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(159, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 25)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Triggers Output"
        '
        'cbButtonTrigger3
        '
        Me.cbButtonTrigger3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbButtonTrigger3.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbButtonTrigger3.FormattingEnabled = True
        Me.cbButtonTrigger3.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.cbButtonTrigger3.Location = New System.Drawing.Point(77, 124)
        Me.cbButtonTrigger3.Name = "cbButtonTrigger3"
        Me.cbButtonTrigger3.Size = New System.Drawing.Size(76, 33)
        Me.cbButtonTrigger3.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 25)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Button"
        '
        'cbOutputTrigger2
        '
        Me.cbOutputTrigger2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOutputTrigger2.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOutputTrigger2.FormattingEnabled = True
        Me.cbOutputTrigger2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63"})
        Me.cbOutputTrigger2.Location = New System.Drawing.Point(301, 82)
        Me.cbOutputTrigger2.Name = "cbOutputTrigger2"
        Me.cbOutputTrigger2.Size = New System.Drawing.Size(76, 33)
        Me.cbOutputTrigger2.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(159, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Triggers Output"
        '
        'cbButtonTrigger2
        '
        Me.cbButtonTrigger2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbButtonTrigger2.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbButtonTrigger2.FormattingEnabled = True
        Me.cbButtonTrigger2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.cbButtonTrigger2.Location = New System.Drawing.Point(77, 82)
        Me.cbButtonTrigger2.Name = "cbButtonTrigger2"
        Me.cbButtonTrigger2.Size = New System.Drawing.Size(76, 33)
        Me.cbButtonTrigger2.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 25)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Button"
        '
        'cbOutputTrigger1
        '
        Me.cbOutputTrigger1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOutputTrigger1.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOutputTrigger1.FormattingEnabled = True
        Me.cbOutputTrigger1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63"})
        Me.cbOutputTrigger1.Location = New System.Drawing.Point(301, 39)
        Me.cbOutputTrigger1.Name = "cbOutputTrigger1"
        Me.cbOutputTrigger1.Size = New System.Drawing.Size(76, 33)
        Me.cbOutputTrigger1.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(159, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Triggers Output"
        '
        'cbButtonTrigger1
        '
        Me.cbButtonTrigger1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbButtonTrigger1.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbButtonTrigger1.FormattingEnabled = True
        Me.cbButtonTrigger1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.cbButtonTrigger1.Location = New System.Drawing.Point(77, 39)
        Me.cbButtonTrigger1.Name = "cbButtonTrigger1"
        Me.cbButtonTrigger1.Size = New System.Drawing.Size(76, 33)
        Me.cbButtonTrigger1.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Button"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbPlungerMid)
        Me.GroupBox1.Controls.Add(Me.tbPlungerMax)
        Me.GroupBox1.Controls.Add(Me.tbPlungerMin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 181)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Plunger"
        '
        'tbPlungerMid
        '
        Me.tbPlungerMid.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPlungerMid.Location = New System.Drawing.Point(186, 125)
        Me.tbPlungerMid.Name = "tbPlungerMid"
        Me.tbPlungerMid.Size = New System.Drawing.Size(100, 32)
        Me.tbPlungerMid.TabIndex = 5
        '
        'tbPlungerMax
        '
        Me.tbPlungerMax.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPlungerMax.Location = New System.Drawing.Point(186, 82)
        Me.tbPlungerMax.Name = "tbPlungerMax"
        Me.tbPlungerMax.Size = New System.Drawing.Size(100, 32)
        Me.tbPlungerMax.TabIndex = 4
        '
        'tbPlungerMin
        '
        Me.tbPlungerMin.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPlungerMin.Location = New System.Drawing.Point(186, 40)
        Me.tbPlungerMin.Name = "tbPlungerMin"
        Me.tbPlungerMin.Size = New System.Drawing.Size(100, 32)
        Me.tbPlungerMin.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Plunger MidPoint"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Plunger Maximum"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Plunger Minimum"
        '
        'tpMainOutputs
        '
        Me.tpMainOutputs.Location = New System.Drawing.Point(4, 34)
        Me.tpMainOutputs.Name = "tpMainOutputs"
        Me.tpMainOutputs.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMainOutputs.Size = New System.Drawing.Size(1087, 589)
        Me.tpMainOutputs.TabIndex = 1
        Me.tpMainOutputs.Text = "Main Outputs"
        Me.tpMainOutputs.UseVisualStyleBackColor = True
        '
        'tpExpansion1
        '
        Me.tpExpansion1.Location = New System.Drawing.Point(4, 34)
        Me.tpExpansion1.Name = "tpExpansion1"
        Me.tpExpansion1.Size = New System.Drawing.Size(1087, 589)
        Me.tpExpansion1.TabIndex = 2
        Me.tpExpansion1.Text = "Expansion Board #1"
        Me.tpExpansion1.UseVisualStyleBackColor = True
        '
        'tpExpansion2
        '
        Me.tpExpansion2.Location = New System.Drawing.Point(4, 34)
        Me.tpExpansion2.Name = "tpExpansion2"
        Me.tpExpansion2.Size = New System.Drawing.Size(1087, 589)
        Me.tpExpansion2.TabIndex = 3
        Me.tpExpansion2.Text = "Expansion Board #2"
        Me.tpExpansion2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(952, 645)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 49)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Save Config"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Configuration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 706)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbMain)
        Me.Name = "Configuration"
        Me.Text = "Configuration"
        Me.tbMain.ResumeLayout(False)
        Me.tpGeneralSettings.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbMain As TabControl
    Friend WithEvents tpGeneralSettings As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbPlungerMid As TextBox
    Friend WithEvents tbPlungerMax As TextBox
    Friend WithEvents tbPlungerMin As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tpMainOutputs As TabPage
    Friend WithEvents tpExpansion1 As TabPage
    Friend WithEvents tpExpansion2 As TabPage
    Friend WithEvents cbOutputTrigger4 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbButtonTrigger4 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbOutputTrigger3 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbButtonTrigger3 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbOutputTrigger2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbButtonTrigger2 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbOutputTrigger1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbButtonTrigger1 As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbAccelEnabled As CheckBox
    Friend WithEvents cbOrientation As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Button1 As Button
End Class
