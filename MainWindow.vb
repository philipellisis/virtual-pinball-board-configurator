Public Class MainWindow
    'Private WithEvents arduino As RS232
    Private WithEvents Board As BoardInterface
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnOutputs_Click(sender As Object, e As EventArgs) Handles btnOutputs.Click
        Dim outputs As New Outputs(Board)
        outputs.ShowDialog()
    End Sub

    'Private Sub arduino_RS232Changed(sender As Object, e As RS232ChangedArgs) Handles arduino.RS232Changed
    '    'TextBox1.Text = e.message
    'End Sub
    'Private Sub arduino_RS232Disconnected(sender As Object, e As RS232CompletedArgs) Handles arduino.RS232Completed
    '    MessageBox.Show("disconnected")
    'End Sub
End Class
