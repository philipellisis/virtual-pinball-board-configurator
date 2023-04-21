Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class AdjustmentSlider


    Private _config As BoardConfiguration
    Private outputNumber As Byte
    Public Sub New(outputNumber As Byte, config As BoardConfiguration)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For i As Integer = 0 To 255
            cbMilliseconds.Items.Add(i * 100)
        Next
        Me.outputNumber = outputNumber
        _config = config
        gbMain.Text = "Output #" & (outputNumber + 1).ToString

        tbMaxValue.Value = _config.maxOutputState(outputNumber)
        tbOffValue.Value = _config.turnOffState(outputNumber)

        If _config.toySpecialOption(outputNumber) = 0 Then
            cbCatagory.SelectedItem = "Normal"
        ElseIf _config.toySpecialOption(outputNumber) = 1 Then
            cbCatagory.SelectedItem = "Noisy"
        ElseIf _config.toySpecialOption(outputNumber) = 2 Then
            cbCatagory.SelectedItem = "RGB"
        End If
        cbCatagory.SelectedItem = _config.toySpecialOption(outputNumber)
        cbMilliseconds.SelectedItem = _config.maxOutputTime(outputNumber) * 100
        lblMinValue.Text = tbOffValue.Value
        lblMaxValue.Text = tbMaxValue.Value

    End Sub

    Private Sub tbMaxValue_Scroll(sender As Object, e As EventArgs) Handles tbMaxValue.Scroll
        _config.maxOutputState(outputNumber) = tbMaxValue.Value
        lblMaxValue.Text = tbMaxValue.Value
    End Sub

    Private Sub tbOffValue_Scroll(sender As Object, e As EventArgs) Handles tbOffValue.Scroll
        _config.turnOffState(outputNumber) = tbOffValue.Value
        lblMinValue.Text = tbOffValue.Value
    End Sub

    Private Sub cbMilliseconds_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMilliseconds.SelectedIndexChanged
        _config.maxOutputTime(outputNumber) = CInt(cbMilliseconds.SelectedItem) / 100
    End Sub

    Private Sub cbCatagory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCatagory.SelectedIndexChanged
        If cbCatagory.SelectedItem = "Normal" Then
            _config.toySpecialOption(outputNumber) = 0
        ElseIf cbCatagory.SelectedItem = "Noisy" Then
            _config.toySpecialOption(outputNumber) = 1
        ElseIf cbCatagory.SelectedItem = "RGB" Then
            _config.toySpecialOption(outputNumber) = 2
        End If
    End Sub
End Class
