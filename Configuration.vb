Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization

Public Class Configuration
    Private _config As BoardConfiguration
    Private _board As BoardInterface
    Private _userControlList As New List(Of AdjustmentSlider)
    Sub New(board As BoardInterface, config As BoardConfiguration)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _board = board
        _config = config
    End Sub
    Private Sub Configuration_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.SuspendLayout()
        tpMainOutputs.SuspendLayout()


        For i As Integer = 0 To 30
            Dim userControl As New AdjustmentSlider(i, _config, _board)
            userControl.Location = New Point(1, i * 110)
            tpMainOutputs.Controls.Add(userControl)
            _userControlList.Add(userControl)
        Next
        '_userControlList.Item(31).Visible = False

        For i As Integer = 31 To 46
            Dim userControl As New AdjustmentSlider(i, _config, _board)
            userControl.Location = New Point(1, (i - 31) * 110)
            tpExpansion1.Controls.Add(userControl)
            _userControlList.Add(userControl)
        Next
        tpExpansion1.Cursor = Cursors.Default

        For i As Integer = 47 To 62
            Dim userControl As New AdjustmentSlider(i, _config, _board)
            userControl.Location = New Point(1, (i - 47) * 110)
            tpExpansion2.Controls.Add(userControl)
            _userControlList.Add(userControl)
        Next

        cbOutputTrigger1.SelectedItem = (_config.solenoidOutputMap(0)).ToString
        cbOutputTrigger2.SelectedItem = (_config.solenoidOutputMap(1)).ToString
        cbOutputTrigger3.SelectedItem = (_config.solenoidOutputMap(2)).ToString
        cbOutputTrigger4.SelectedItem = (_config.solenoidOutputMap(3)).ToString

        cbButtonTrigger1.SelectedItem = (_config.solenoidButtonMap(0)).ToString
        cbButtonTrigger2.SelectedItem = (_config.solenoidButtonMap(1)).ToString
        cbButtonTrigger3.SelectedItem = (_config.solenoidButtonMap(2)).ToString
        cbButtonTrigger4.SelectedItem = (_config.solenoidButtonMap(3)).ToString

        cbAccelEnabled.Checked = _config.accelerometer
        cbOrientation.SelectedItem = _config.getOrientationString
        tbPlungerMax.Text = _config.plungerMax.ToString
        tbPlungerMid.Text = _config.plungerMid.ToString
        tbPlungerMin.Text = _config.plungerMin.ToString
        cbMultiplier.SelectedItem = _config.getSensitivityString
        tbDeadZone.Text = _config.accelerometerDeadZone.ToString

        If _config.buttonOption = 1 Or _config.buttonOption = 3 Then
            cbPushOnMax.Checked = True
        End If
        If _config.buttonOption >= 2 Then
            cbPushOnMin.Checked = True
        End If
        tbTilt.Text = _config.accelerometerTilt.ToString
        tbMax.Text = _config.accelerometerMax.ToString
        If _config.orentation > 3 Then
            cbPinsFacingUp.Checked = True
        End If

        cbTiltButton.SelectedItem = (_config.tiltButton + 1).ToString
        If _config.shiftButton = 99 Then
            cbShiftButton.SelectedItem = "0"
        Else
            cbShiftButton.SelectedItem = (_config.shiftButton + 1).ToString
        End If

        cbLaunchButton.SelectedItem = (_config.plungerLaunchButton + 1).ToString
        If _config.nightModeButton > 23 Then
            cbNightMode.SelectedItem = (_config.nightModeButton - 24 + 1).ToString
            rbNightModePush.Checked = True
        Else
            cbNightMode.SelectedItem = (_config.nightModeButton + 1).ToString
            rbNightModeToggle.Checked = True
        End If

        cbAverageReadings.SelectedItem = (_config.plungerAverageRead).ToString

        Me.ResumeLayout()
        tpMainOutputs.ResumeLayout()
        Try
            AddHandler _board.BoardChanged, AddressOf _board_BoardChanged
            _board.enableAdminFunction(ADMIN.OUTPUTS)
        Catch ex As Exception
            MessageBox.Show("error while setting output mode, check that board is connected.")
        End Try

    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            _board.enableAdminFunction(ADMIN.OFF)
            _config.solenoidOutputMap(0) = CByte(cbOutputTrigger1.SelectedItem)
            _config.solenoidOutputMap(1) = CByte(cbOutputTrigger2.SelectedItem)
            _config.solenoidOutputMap(2) = CByte(cbOutputTrigger3.SelectedItem)
            _config.solenoidOutputMap(3) = CByte(cbOutputTrigger4.SelectedItem)


            _config.solenoidButtonMap(0) = CByte(cbButtonTrigger1.SelectedItem)
            _config.solenoidButtonMap(1) = CByte(cbButtonTrigger2.SelectedItem)
            _config.solenoidButtonMap(2) = CByte(cbButtonTrigger3.SelectedItem)
            _config.solenoidButtonMap(3) = CByte(cbButtonTrigger4.SelectedItem)


            _config.accelerometer = CByte(cbAccelEnabled.Checked)
            _config.setOrientationString(cbOrientation.SelectedItem, cbPinsFacingUp.Checked)
            _config.plungerMax = CShort(tbPlungerMax.Text)
            _config.plungerMid = CShort(tbPlungerMid.Text)
            _config.plungerMin = CShort(tbPlungerMin.Text)
            _config.accelerometerDeadZone = CShort(tbDeadZone.Text)
            _config.setSensitivityString(cbMultiplier.SelectedItem)
            Dim buttonOption As Byte = 0
            If cbPushOnMax.Checked And cbPushOnMin.Checked Then
                buttonOption = 3
            ElseIf cbPushOnMax.Checked Then
                buttonOption = 1
            ElseIf cbPushOnMin.Checked Then
                buttonOption = 2
            End If
            _config.buttonOption = buttonOption
            _config.accelerometerTilt = CShort(tbTilt.Text)
            _config.accelerometerMax = CShort(tbMax.Text)

            'Byte plungerAverageRead = 10;
            'Byte nightModeButton = 21;
            'Byte plungerLaunchButton = 23;
            'Byte tiltButton = 22;
            If cbShiftButton.SelectedItem = 0 Then
                _config.shiftButton = 99
            Else
                _config.shiftButton = cbShiftButton.SelectedItem - 1
            End If

            _config.tiltButton = cbTiltButton.SelectedItem - 1
            _config.plungerAverageRead = cbAverageReadings.SelectedItem
            _config.plungerLaunchButton = cbLaunchButton.SelectedItem - 1
            If rbNightModePush.Checked Then
                _config.nightModeButton = cbNightMode.SelectedItem - 1 + 24
            Else
                _config.nightModeButton = cbNightMode.SelectedItem - 1
            End If


            _board.setConfig(_config)
        Catch ex As Exception
            MessageBox.Show("error saving configuration. Check that board is connected.")
        End Try

    End Sub

    Private Sub _board_BoardChanged(sender As Object, e As BoardChangedArgs)
        Try
            If e.type = MESSAGE_TYPE.RESPONSE Then
                If e.message = "Save Config Success" Then
                    btnSaveConfig.Enabled = True
                End If
                MessageBox.Show(e.message)
                _board.enableAdminFunction(ADMIN.OUTPUTS)
            End If
            If e.type = MESSAGE_TYPE.OUTPUTS Then
                For i As Integer = 0 To 62
                    _userControlList.Item(i).setIntensityValue(e.outputs(i))
                Next
            End If
        Catch ex As Exception

        End Try




    End Sub

    Private Sub btnSaveConfig_Click(sender As Object, e As EventArgs) Handles btnSaveConfig.Click
        Try
            _board.saveConfigToEeprom()
        Catch ex As Exception
            MessageBox.Show("error saving to eeprom")
        End Try

    End Sub

    Private Sub tpGeneralSettings_Click(sender As Object, e As EventArgs) Handles tpGeneralSettings.Click

    End Sub

    Private Sub Configuration_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            _board.enableAdminFunction(ADMIN.OFF)
            RemoveHandler _board.BoardChanged, AddressOf _board_BoardChanged
        Catch ex As Exception
            MessageBox.Show("error while exiting admin mode")
        End Try

    End Sub

End Class