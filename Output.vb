Public Class Output
    Private _board As BoardInterface
    Private _number As Byte
    Public Sub New(board As BoardInterface, outputNumber As Byte)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _board = board
        _number = outputNumber
        gbMain.Text = "Output #" & outputNumber.ToString
    End Sub
    Public Sub setIntensityValue(val As Byte)
        tbIntensity.Value = val
        setButton(tbIntensity.Value)
    End Sub

    Private Sub btnOnOff_Click(sender As Object, e As EventArgs) Handles btnOnOff.Click
        _board.setOutputValue(_number, 255)
    End Sub

    Private Sub tbIntensity_Scroll(sender As Object, e As EventArgs) Handles tbIntensity.Scroll
        setButton(tbIntensity.Value)
        _board.setOutputValue(_number, tbIntensity.Value)
    End Sub
    Private Sub setButton(val As Integer)
        If val > 0 Then
            btnOnOff.Text = "On"
            btnOnOff.BackColor = Color.DarkGreen
        Else
            btnOnOff.Text = "Off"
            btnOnOff.BackColor = Color.Red
        End If
    End Sub
End Class
