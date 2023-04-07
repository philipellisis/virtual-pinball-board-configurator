Public Class Outputs
    Private _userControlList As New List(Of Output)
    Private WithEvents _board As BoardInterface
    Public Sub New(board As BoardInterface)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _board = board
    End Sub
    Private Sub Outputs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 62
            Dim userControl As New Output(_board, i)
            userControl.Location = New Point(1, i * 75)
            Me.Controls.Add(userControl)
            _userControlList.Add(userControl)
        Next
        _board.enableAdminFunction(ADMIN.OUTPUTS)

    End Sub

    Private Sub _board_BoardChanged(sender As Object, e As BoardChangedArgs) Handles _board.BoardChanged
        If e.type = MESSAGE_TYPE.OUTPUTS Then
            Dim outputValues As String() = e.message.Split(",")
            For i As Integer = 0 To 62
                _userControlList.Item(i).setIntensityValue(CByte(outputValues(i)))
            Next
        End If

    End Sub

    Private Sub Outputs_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _board.enableAdminFunction(ADMIN.OFF)
    End Sub
End Class