<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnOutputs = New System.Windows.Forms.Button()
        Me.btnInputs = New System.Windows.Forms.Button()
        Me.btnPlunger = New System.Windows.Forms.Button()
        Me.btnAccel = New System.Windows.Forms.Button()
        Me.gbMenu = New System.Windows.Forms.GroupBox()
        Me.btnSaveConfig = New System.Windows.Forms.Button()
        Me.btnRetrieve = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.cbSimulation = New System.Windows.Forms.CheckBox()
        Me.btnUpdateFirmware = New System.Windows.Forms.Button()
        Me.cbComPort = New System.Windows.Forms.ComboBox()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateFirmwareWithoutResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoftwareResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrComPort = New System.Windows.Forms.Timer(Me.components)
        Me.InstallXinputFirmwareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstallXinputFirmwareWithoutResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbMenu.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSettings
        '
        Me.btnSettings.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.Location = New System.Drawing.Point(8, 38)
        Me.btnSettings.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(224, 163)
        Me.btnSettings.TabIndex = 0
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.Location = New System.Drawing.Point(14, 504)
        Me.btnConnect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(224, 85)
        Me.btnConnect.TabIndex = 3
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnOutputs
        '
        Me.btnOutputs.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOutputs.Location = New System.Drawing.Point(238, 211)
        Me.btnOutputs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOutputs.Name = "btnOutputs"
        Me.btnOutputs.Size = New System.Drawing.Size(224, 163)
        Me.btnOutputs.TabIndex = 4
        Me.btnOutputs.Text = "Outputs"
        Me.btnOutputs.UseVisualStyleBackColor = True
        '
        'btnInputs
        '
        Me.btnInputs.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInputs.Location = New System.Drawing.Point(471, 38)
        Me.btnInputs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnInputs.Name = "btnInputs"
        Me.btnInputs.Size = New System.Drawing.Size(224, 163)
        Me.btnInputs.TabIndex = 5
        Me.btnInputs.Text = "Inputs"
        Me.btnInputs.UseVisualStyleBackColor = True
        '
        'btnPlunger
        '
        Me.btnPlunger.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlunger.Location = New System.Drawing.Point(8, 211)
        Me.btnPlunger.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPlunger.Name = "btnPlunger"
        Me.btnPlunger.Size = New System.Drawing.Size(224, 163)
        Me.btnPlunger.TabIndex = 6
        Me.btnPlunger.Text = "Plunger"
        Me.btnPlunger.UseVisualStyleBackColor = True
        '
        'btnAccel
        '
        Me.btnAccel.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccel.Location = New System.Drawing.Point(238, 38)
        Me.btnAccel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAccel.Name = "btnAccel"
        Me.btnAccel.Size = New System.Drawing.Size(224, 163)
        Me.btnAccel.TabIndex = 7
        Me.btnAccel.Text = "Accelerometer"
        Me.btnAccel.UseVisualStyleBackColor = True
        '
        'gbMenu
        '
        Me.gbMenu.Controls.Add(Me.btnSaveConfig)
        Me.gbMenu.Controls.Add(Me.btnRetrieve)
        Me.gbMenu.Controls.Add(Me.btnBackup)
        Me.gbMenu.Controls.Add(Me.btnInputs)
        Me.gbMenu.Controls.Add(Me.btnOutputs)
        Me.gbMenu.Controls.Add(Me.btnSettings)
        Me.gbMenu.Controls.Add(Me.btnAccel)
        Me.gbMenu.Controls.Add(Me.btnPlunger)
        Me.gbMenu.Enabled = False
        Me.gbMenu.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMenu.Location = New System.Drawing.Point(12, 50)
        Me.gbMenu.Name = "gbMenu"
        Me.gbMenu.Size = New System.Drawing.Size(734, 408)
        Me.gbMenu.TabIndex = 8
        Me.gbMenu.TabStop = False
        Me.gbMenu.Text = "Menu"
        '
        'btnSaveConfig
        '
        Me.btnSaveConfig.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveConfig.Location = New System.Drawing.Point(585, 296)
        Me.btnSaveConfig.Name = "btnSaveConfig"
        Me.btnSaveConfig.Size = New System.Drawing.Size(109, 78)
        Me.btnSaveConfig.TabIndex = 10
        Me.btnSaveConfig.Text = "Save Config"
        Me.btnSaveConfig.UseVisualStyleBackColor = True
        '
        'btnRetrieve
        '
        Me.btnRetrieve.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetrieve.Location = New System.Drawing.Point(474, 295)
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.Size = New System.Drawing.Size(109, 78)
        Me.btnRetrieve.TabIndex = 9
        Me.btnRetrieve.Text = "Get Backup"
        Me.btnRetrieve.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.Location = New System.Drawing.Point(474, 209)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(220, 80)
        Me.btnBackup.TabIndex = 8
        Me.btnBackup.Text = "Backup Config"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'cbSimulation
        '
        Me.cbSimulation.AutoSize = True
        Me.cbSimulation.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSimulation.Location = New System.Drawing.Point(20, 463)
        Me.cbSimulation.Name = "cbSimulation"
        Me.cbSimulation.Size = New System.Drawing.Size(145, 33)
        Me.cbSimulation.TabIndex = 9
        Me.cbSimulation.Text = "Simulation"
        Me.cbSimulation.UseVisualStyleBackColor = True
        Me.cbSimulation.Visible = False
        '
        'btnUpdateFirmware
        '
        Me.btnUpdateFirmware.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateFirmware.Location = New System.Drawing.Point(482, 504)
        Me.btnUpdateFirmware.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdateFirmware.Name = "btnUpdateFirmware"
        Me.btnUpdateFirmware.Size = New System.Drawing.Size(224, 85)
        Me.btnUpdateFirmware.TabIndex = 10
        Me.btnUpdateFirmware.Text = "Update Firmware"
        Me.btnUpdateFirmware.UseVisualStyleBackColor = True
        '
        'cbComPort
        '
        Me.cbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbComPort.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbComPort.FormattingEnabled = True
        Me.cbComPort.Location = New System.Drawing.Point(713, 551)
        Me.cbComPort.Name = "cbComPort"
        Me.cbComPort.Size = New System.Drawing.Size(102, 33)
        Me.cbComPort.TabIndex = 24
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValue.Location = New System.Drawing.Point(713, 519)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(100, 29)
        Me.lblValue.TabIndex = 25
        Me.lblValue.Text = "COM Port"
        '
        'btnAbout
        '
        Me.btnAbout.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(246, 506)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(104, 83)
        Me.btnAbout.TabIndex = 11
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(827, 33)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(164, 34)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateFirmwareWithoutResetToolStripMenuItem, Me.InstallXinputFirmwareWithoutResetToolStripMenuItem, Me.InstallXinputFirmwareToolStripMenuItem, Me.SoftwareResetToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(107, 29)
        Me.FileToolStripMenuItem.Text = "Advanced"
        '
        'UpdateFirmwareWithoutResetToolStripMenuItem
        '
        Me.UpdateFirmwareWithoutResetToolStripMenuItem.Name = "UpdateFirmwareWithoutResetToolStripMenuItem"
        Me.UpdateFirmwareWithoutResetToolStripMenuItem.Size = New System.Drawing.Size(445, 34)
        Me.UpdateFirmwareWithoutResetToolStripMenuItem.Text = "Update Firmware With Reset Button"
        '
        'SoftwareResetToolStripMenuItem
        '
        Me.SoftwareResetToolStripMenuItem.Name = "SoftwareResetToolStripMenuItem"
        Me.SoftwareResetToolStripMenuItem.Size = New System.Drawing.Size(445, 34)
        Me.SoftwareResetToolStripMenuItem.Text = "Software Reset"
        '
        'tmrComPort
        '
        Me.tmrComPort.Interval = 1000
        '
        'InstallXinputFirmwareToolStripMenuItem
        '
        Me.InstallXinputFirmwareToolStripMenuItem.Name = "InstallXinputFirmwareToolStripMenuItem"
        Me.InstallXinputFirmwareToolStripMenuItem.Size = New System.Drawing.Size(445, 34)
        Me.InstallXinputFirmwareToolStripMenuItem.Text = "Install x-input Firmware"
        '
        'InstallXinputFirmwareWithoutResetToolStripMenuItem
        '
        Me.InstallXinputFirmwareWithoutResetToolStripMenuItem.Name = "InstallXinputFirmwareWithoutResetToolStripMenuItem"
        Me.InstallXinputFirmwareWithoutResetToolStripMenuItem.Size = New System.Drawing.Size(445, 34)
        Me.InstallXinputFirmwareWithoutResetToolStripMenuItem.Text = "Install x-input Firmware With Reset Button"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 611)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.cbComPort)
        Me.Controls.Add(Me.btnUpdateFirmware)
        Me.Controls.Add(Me.cbSimulation)
        Me.Controls.Add(Me.gbMenu)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainWindow"
        Me.Text = "CSD Configuration Tool"
        Me.gbMenu.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSettings As Button
    Friend WithEvents btnConnect As Button
    Friend WithEvents btnOutputs As Button
    Friend WithEvents btnInputs As Button
    Friend WithEvents btnPlunger As Button
    Friend WithEvents btnAccel As Button
    Friend WithEvents gbMenu As GroupBox
    Friend WithEvents cbSimulation As CheckBox
    Friend WithEvents btnUpdateFirmware As Button
    Friend WithEvents btnRetrieve As Button
    Friend WithEvents btnBackup As Button
    Friend WithEvents cbComPort As ComboBox
    Friend WithEvents lblValue As Label
    Friend WithEvents btnSaveConfig As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateFirmwareWithoutResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoftwareResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tmrComPort As Timer
    Friend WithEvents InstallXinputFirmwareToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstallXinputFirmwareWithoutResetToolStripMenuItem As ToolStripMenuItem
End Class
