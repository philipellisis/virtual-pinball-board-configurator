Public Class Configuration
    Private _config As BoardConfiguration
    Private Sub Configuration_Load(sender As Object, e As EventArgs) Handles Me.Load
        For i As Integer = 0 To 16
            Dim userControl As New AdjustmentSlider(_config.maxOutputState(i), _config.turnOffState(i), _config.maxOutputTime(i), _config.toySpecialOption(i))
            userControl.Location = New Point(1, i * 75)
            tpMainOutputs.Controls.Add(userControl)
        Next
        For i As Integer = 17 To 31
            Dim userControl As New AdjustmentSlider(_config.maxOutputState(i), _config.turnOffState(i), _config.maxOutputTime(i), _config.toySpecialOption(i))
            userControl.Location = New Point(1, i * 75)
            tpMainOutputs.Controls.Add(userControl)
        Next
    End Sub
End Class