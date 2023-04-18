Public Class MainWindow
    'Private WithEvents arduino As RS232
    Private WithEvents Board As BoardInterface
    Private config As BoardConfiguration
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Try
            If cbSimulation.Checked = True Then
                Board = New DummyBoard
            Else
                Board = New CSDBoard
            End If
            Board.connect()
            gbMenu.Enabled = True
            Board.enableAdminFunction(ADMIN.SEND_CONFIG)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnOutputs_Click(sender As Object, e As EventArgs) Handles btnOutputs.Click
        Dim outputs As New Outputs(Board)
        outputs.ShowDialog()
    End Sub

    Private Sub btnInputs_Click(sender As Object, e As EventArgs) Handles btnInputs.Click
        Dim buttons As New Buttons(Board)
        buttons.ShowDialog()
    End Sub

    Private Sub btnPlunger_Click(sender As Object, e As EventArgs) Handles btnPlunger.Click
        Dim plunger As New Plunger(Board)
        plunger.ShowDialog()
    End Sub
    Private Sub Board_BoardChanged(sender As Object, e As BoardChangedArgs) Handles Board.BoardChanged
        If e.type = MESSAGE_TYPE.CONFIG Then
            config = e.config
        End If

    End Sub

End Class
