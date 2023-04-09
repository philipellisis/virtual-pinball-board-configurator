Public Class ucButton
    Public Sub New(inputNumber As Byte)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        rbButton.Text = inputNumber.ToString
    End Sub

    Public Sub setButtonValue(value As Byte)
        If value = 0 Then
            rbButton.Checked = False
        Else
            rbButton.Checked = True
        End If
    End Sub
End Class
