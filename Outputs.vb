Public Class Outputs
    Private _userControlList As New List(Of Output)
    Private WithEvents _board As BoardInterface
    Private outputOn As Integer = -1
    Public Sub New(board As BoardInterface)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _board = board
    End Sub
    Private Sub Outputs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SuspendLayout()
        tpMain.SuspendLayout()

        For i As Integer = 0 To 30
            Dim userControl As New Output(_board, i)
            userControl.Location = New Point(1, i * 75)
            tpMain.Controls.Add(userControl)
            _userControlList.Add(userControl)
        Next
        For i As Integer = 0 To 15
            Dim userControl As New Output(_board, i + 31)
            userControl.Location = New Point(1, i * 75)
            tpExp1.Controls.Add(userControl)
            _userControlList.Add(userControl)
        Next
        For i As Integer = 0 To 15
            Dim userControl As New Output(_board, i + 47)
            userControl.Location = New Point(1, i * 75)
            tpExp2.Controls.Add(userControl)
            _userControlList.Add(userControl)
        Next
        _board.enableAdminFunction(ADMIN.OUTPUTS)
        Me.ResumeLayout()
        tpMain.ResumeLayout()
    End Sub

    Private Sub _board_BoardChanged(sender As Object, e As BoardChangedArgs) Handles _board.BoardChanged
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
        _board.enableAdminFunction(ADMIN.OFF)
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