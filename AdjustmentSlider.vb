Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class AdjustmentSlider

    Public maxValue As Byte
    Public minValue As Byte
    Public time As Byte
    Public specialOption As Byte
    Public Sub New(maxValue As Byte, minValue As Byte, time As Byte, specialOption As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For i As Integer = 0 To 255
            cbMilliseconds.Items.Add(i * 100)
        Next
        Me.maxValue = maxValue
        Me.minValue = minValue
        Me.time = time
        Me.specialOption = specialOption
        tbMaxValue.Value = maxValue
        tbOffValue.Value = minValue
        cbCatagory.SelectedText = specialOption
        cbMilliseconds.SelectedText = time * 100
    End Sub

    Private Sub AdjustmentSlider_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
