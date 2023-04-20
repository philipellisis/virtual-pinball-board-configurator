Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class AdjustmentSlider

    Public maxValue As Byte
    Public minValue As Byte
    Public time As Byte
    Public specialOption As Byte
    Public Sub New(outputNumber As Byte, maxValue As Byte, minValue As Byte, time As Byte, specialOption As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For i As Integer = 0 To 255
            cbMilliseconds.Items.Add(i * 100)
        Next
        gbMain.Text = "Output #" & (outputNumber + 1).ToString
        Me.maxValue = maxValue
        Me.minValue = minValue
        Me.time = time
        Me.specialOption = specialOption
        tbMaxValue.Value = maxValue
        tbOffValue.Value = minValue

        If specialOption = 0 Then
            cbCatagory.SelectedItem = "Normal"
        ElseIf specialOption = 1 Then
            cbCatagory.SelectedItem = "Noisy"
        ElseIf specialOption = 2 Then
            cbCatagory.SelectedItem = "RGB"
        End If
        cbCatagory.SelectedItem = specialOption
        cbMilliseconds.SelectedItem = time * 100
        lblMinValue.Text = tbOffValue.Value
        lblMaxValue.Text = tbMaxValue.Value

    End Sub

    Private Sub tbMaxValue_Scroll(sender As Object, e As EventArgs) Handles tbMaxValue.Scroll
        Me.maxValue = tbMaxValue.Value
        lblMaxValue.Text = tbMaxValue.Value
    End Sub

    Private Sub tbOffValue_Scroll(sender As Object, e As EventArgs) Handles tbOffValue.Scroll
        Me.minValue = tbOffValue.Value
        lblMinValue.Text = tbOffValue.Value
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
