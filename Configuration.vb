Public Class Configuration
    Private _config As BoardConfiguration
    Private WithEvents _board As BoardInterface
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
            Dim userControl As New AdjustmentSlider(i, _config)
            userControl.Location = New Point(1, i * 110)
            tpMainOutputs.Controls.Add(userControl)
        Next

        For i As Integer = 31 To 46
            Dim userControl As New AdjustmentSlider(i, _config)
            userControl.Location = New Point(1, (i - 31) * 110)
            tpExpansion1.Controls.Add(userControl)
        Next
        tpExpansion1.Cursor = Cursors.Default

        For i As Integer = 47 To 62
            Dim userControl As New AdjustmentSlider(i, _config)
            userControl.Location = New Point(1, (i - 47) * 110)
            tpExpansion2.Controls.Add(userControl)
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
        Me.ResumeLayout()
        tpMainOutputs.ResumeLayout()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        _config.solenoidOutputMap(0) = CByte(cbOutputTrigger1.SelectedItem)
        _config.solenoidOutputMap(1) = CByte(cbOutputTrigger2.SelectedItem)
        _config.solenoidOutputMap(2) = CByte(cbOutputTrigger3.SelectedItem)
        _config.solenoidOutputMap(3) = CByte(cbOutputTrigger4.SelectedItem)


        _config.solenoidButtonMap(0) = CByte(cbButtonTrigger1.SelectedItem)
        _config.solenoidButtonMap(1) = CByte(cbButtonTrigger2.SelectedItem)
        _config.solenoidButtonMap(2) = CByte(cbButtonTrigger3.SelectedItem)
        _config.solenoidButtonMap(3) = CByte(cbButtonTrigger4.SelectedItem)


        _config.accelerometer = CByte(cbAccelEnabled.Checked)
        _config.setOrientationString(cbOrientation.SelectedItem)
        _config.plungerMax = CShort(tbPlungerMax.Text)
        _config.plungerMid = CShort(tbPlungerMid.Text)
        _config.plungerMin = CShort(tbPlungerMin.Text)

        _board.setConfig(_config)
    End Sub

    Private Sub _board_BoardChanged(sender As Object, e As BoardChangedArgs) Handles _board.BoardChanged

        If e.type = MESSAGE_TYPE.RESPONSE Then
            If e.message = "SAVE CONFIG SUCCESS" Then
                btnSaveConfig.Enabled = True
            End If
            MessageBox.Show(e.message)
        End If


    End Sub

    Private Sub btnSaveConfig_Click(sender As Object, e As EventArgs) Handles btnSaveConfig.Click
        _board.saveConfigToEeprom()
    End Sub
End Class