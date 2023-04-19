Public Class Configuration
    Private _config As BoardConfiguration
    Private _board As BoardInterface
    Sub New(board As BoardInterface, config As BoardConfiguration)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _board = board
        _config = config
    End Sub
    Private Sub Configuration_Load(sender As Object, e As EventArgs) Handles Me.Load
        For i As Integer = 0 To 15
            Dim userControl As New AdjustmentSlider(_config.maxOutputState(i), _config.turnOffState(i), _config.maxOutputTime(i), _config.toySpecialOption(i))
            userControl.Location = New Point(1, i * 75)
            tpMainOutputs.Controls.Add(userControl)
        Next
        For i As Integer = 16 To 30
            Dim userControl As New AdjustmentSlider(_config.maxOutputState(i), _config.turnOffState(i), _config.maxOutputTime(i), _config.toySpecialOption(i))
            userControl.Location = New Point(300, (i - 16) * 75)
            tpMainOutputs.Controls.Add(userControl)
        Next

        For i As Integer = 31 To 46
            Dim userControl As New AdjustmentSlider(_config.maxOutputState(i), _config.turnOffState(i), _config.maxOutputTime(i), _config.toySpecialOption(i))
            userControl.Location = New Point(1, (i - 31) * 75)
            tpExpansion1.Controls.Add(userControl)
        Next

        For i As Integer = 47 To 62
            Dim userControl As New AdjustmentSlider(_config.maxOutputState(i), _config.turnOffState(i), _config.maxOutputTime(i), _config.toySpecialOption(i))
            userControl.Location = New Point(1, (i - 47) * 75)
            tpExpansion2.Controls.Add(userControl)
        Next

        cbOutputTrigger1.SelectedText = _config.solenoidOutputMap(0)
        cbOutputTrigger2.SelectedText = _config.solenoidOutputMap(1)
        cbOutputTrigger3.SelectedText = _config.solenoidOutputMap(2)
        cbOutputTrigger4.SelectedText = _config.solenoidOutputMap(3)

        cbButtonTrigger1.SelectedText = _config.solenoidButtonMap(0)
        cbButtonTrigger2.SelectedText = _config.solenoidButtonMap(1)
        cbButtonTrigger3.SelectedText = _config.solenoidButtonMap(2)
        cbButtonTrigger4.SelectedText = _config.solenoidButtonMap(3)

        cbAccelEnabled.Checked = _config.accelerometer
        cbOrientation.SelectedText = _config.getOrientationString

    End Sub

    Private Sub tpGeneralSettings_Click(sender As Object, e As EventArgs) Handles tpGeneralSettings.Click

    End Sub
End Class