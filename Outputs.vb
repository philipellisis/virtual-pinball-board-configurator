Public Class Outputs
    Private _userControlList As New List(Of Output)
    Public _board As BoardInterface
    Private outputOn As Integer = -1
    Public Sub New(board As BoardInterface)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _board = board
    End Sub

    Dim names As String() = {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "RGB Flippers Red", "RGB Flippers Green", "RGB Flippers Blue", "RGB Magna Right Red", "RGB Magna Right Green", "RGB Magna Right Blue", "RGB Magna Left Red", "RGB Magna Left Green", "RGB Magna Left Blue", "Button 5", "Button 6", "Button 7", "Button 8", "RGB Fire Red", "RGB Fire Green", "RGB Fire Blue", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}
    Private Sub Outputs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SuspendLayout()
        tpMain.SuspendLayout()



        For i As Integer = 0 To 14
            Dim userControl As New Output(_board, i, names(i))
            userControl.Location = New Point(1, i * 75)
            tpMain.Controls.Add(userControl)
            _userControlList.Add(userControl)
        Next

        For i As Integer = 0 To 15
            Dim userControl As New Output(_board, i + 15, names(i + 15))
            userControl.Location = New Point(1, i * 75)
            tpButtons.Controls.Add(userControl)
            _userControlList.Add(userControl)
        Next

        For i As Integer = 0 To 15
            Dim userControl As New Output(_board, i + 31, names(i + 31))
            userControl.Location = New Point(1, i * 75)
            tpExp1.Controls.Add(userControl)
            _userControlList.Add(userControl)
        Next
        For i As Integer = 0 To 15
            Dim userControl As New Output(_board, i + 47, "")
            userControl.Location = New Point(1, i * 75)
            tpExp2.Controls.Add(userControl)
            _userControlList.Add(userControl)
        Next
        _board.enableAdminFunction(ADMIN.OUTPUTS)
        Me.ResumeLayout()
        tpMain.ResumeLayout()
        AddHandler _board.BoardChanged, AddressOf _board_BoardChanged
    End Sub

    Private Sub _board_BoardChanged(sender As Object, e As BoardChangedArgs)
        Try
            If e.type = MESSAGE_TYPE.OUTPUTS Then
                For i As Integer = 0 To 62
                    _userControlList.Item(i).setIntensityValue(e.outputs(i))
                Next
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Outputs_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            _board.enableAdminFunction(ADMIN.OFF)
        Catch ex As Exception
            MessageBox.Show("error while communicating with PinOne")
        End Try

        RemoveHandler _board.BoardChanged, AddressOf _board_BoardChanged
    End Sub

    Private Sub tbIntensity_Scroll(sender As Object, e As EventArgs) Handles tbIntensity.Scroll
        lblValue.Text = tbIntensity.Value.ToString
        If tbIntensity.Value > 0 Then
            _board.setOutputValue(tbIntensity.Value - 1, 255)

        End If
        If outputOn >= 0 Then
            _board.setOutputValue(outputOn, 0)
        End If
        outputOn = tbIntensity.Value - 1

    End Sub
End Class