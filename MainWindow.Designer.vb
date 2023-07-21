<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnOutputs = New System.Windows.Forms.Button()
        Me.btnInputs = New System.Windows.Forms.Button()
        Me.btnPlunger = New System.Windows.Forms.Button()
        Me.btnAccel = New System.Windows.Forms.Button()
        Me.gbMenu = New System.Windows.Forms.GroupBox()
        Me.cbSimulation = New System.Windows.Forms.CheckBox()
        Me.btnUpdateFirmware = New System.Windows.Forms.Button()
        Me.gbMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSettings
        '
        Me.btnSettings.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.Location = New System.Drawing.Point(7, 38)
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
        Me.btnConnect.Location = New System.Drawing.Point(13, 466)
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
        Me.btnOutputs.Location = New System.Drawing.Point(239, 211)
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
        Me.btnInputs.Location = New System.Drawing.Point(471, 211)
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
        Me.btnPlunger.Location = New System.Drawing.Point(7, 211)
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
        Me.btnAccel.Location = New System.Drawing.Point(239, 38)
        Me.btnAccel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAccel.Name = "btnAccel"
        Me.btnAccel.Size = New System.Drawing.Size(224, 163)
        Me.btnAccel.TabIndex = 7
        Me.btnAccel.Text = "Accelerometer"
        Me.btnAccel.UseVisualStyleBackColor = True
        '
        'gbMenu
        '
        Me.gbMenu.Controls.Add(Me.btnInputs)
        Me.gbMenu.Controls.Add(Me.btnOutputs)
        Me.gbMenu.Controls.Add(Me.btnSettings)
        Me.gbMenu.Controls.Add(Me.btnAccel)
        Me.gbMenu.Controls.Add(Me.btnPlunger)
        Me.gbMenu.Enabled = False
        Me.gbMenu.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMenu.Location = New System.Drawing.Point(12, 12)
        Me.gbMenu.Name = "gbMenu"
        Me.gbMenu.Size = New System.Drawing.Size(801, 407)
        Me.gbMenu.TabIndex = 8
        Me.gbMenu.TabStop = False
        Me.gbMenu.Text = "Menu"
        '
        'cbSimulation
        '
        Me.cbSimulation.AutoSize = True
        Me.cbSimulation.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSimulation.Location = New System.Drawing.Point(19, 425)
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
        Me.btnUpdateFirmware.Location = New System.Drawing.Point(589, 466)
        Me.btnUpdateFirmware.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdateFirmware.Name = "btnUpdateFirmware"
        Me.btnUpdateFirmware.Size = New System.Drawing.Size(224, 85)
        Me.btnUpdateFirmware.TabIndex = 10
        Me.btnUpdateFirmware.Text = "Update Firmware"
        Me.btnUpdateFirmware.UseVisualStyleBackColor = True
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 565)
        Me.Controls.Add(Me.btnUpdateFirmware)
        Me.Controls.Add(Me.cbSimulation)
        Me.Controls.Add(Me.gbMenu)
        Me.Controls.Add(Me.btnConnect)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainWindow"
        Me.Text = "CSD Configuration Tool"
        Me.gbMenu.ResumeLayout(False)
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
End Class
