Public Class ucButton
    Private keyListen As Boolean = False
    Private _config As BoardConfiguration
    Private _inputNumber As Byte
    Public Sub New(inputNumber As Byte, config As BoardConfiguration)

        ' This call is required by the designer.
        InitializeComponent()

        _config = config
        _inputNumber = inputNumber
        tbKeyboard.Text = KeyboardEventMapper.NumberToText(config.buttonKeys(_inputNumber))

        ' Add any initialization after the InitializeComponent() call.
        rbButton.Text = (inputNumber + 1).ToString
    End Sub

    Public Sub setButtonValue(value As Byte)
        If value = 0 Then
            rbButton.Checked = False
        Else
            rbButton.Checked = True
        End If
    End Sub
    Public Function getkeyValue() As Byte
        Return CByte(tbKeyboard.Text)
    End Function

    Public Sub setKeyDown(keyCode As Keys)
        If keyListen Then
            Try
                _config.buttonKeys(_inputNumber) = KeyboardEventMapper.getKeyboardPressNumber(keyCode)
                tbKeyboard.Text = KeyboardEventMapper.NumberToText(_config.buttonKeys(_inputNumber))
            Catch ex As Exception
                tbKeyboard.Text = "None"
                _config.buttonKeys(_inputNumber) = 0

            End Try
            btnAssign.Text = "Assign Key"
            btnAssign.Enabled = True
            keyListen = False
        End If
    End Sub


    Protected Overrides Function ProcessDialogKey(keyData As Keys) As Boolean
        If keyListen Then
            setKeyDown(keyData)
            Return False
        End If
        Return MyBase.ProcessDialogKey(keyData)
    End Function

    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        keyListen = True
        btnAssign.Text = "Listening..."
        btnAssign.Enabled = False
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        tbKeyboard.Text = "None"
        _config.buttonKeys(_inputNumber) = 0
    End Sub
End Class
