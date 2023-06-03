Public Class Accelerometer
    Dim currentPoint As New Drawing.Point(0, 0)
    Dim center As Integer
    Dim maxSize As Integer = 250
    Private WithEvents _board As BoardInterface

    Public Sub New(board As BoardInterface)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _board = board
    End Sub

    Private Sub Accelerometer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _board.enableAdminFunction(ADMIN.ACCEL)
        pbAxis.Size = New Drawing.Size(pbAxis.Size.Width, pbAxis.Size.Width)
        maxSize = pbAxis.Size.Width / 2
        center = maxSize
    End Sub

    Private Sub pbAxis_Paint(sender As Object, e As PaintEventArgs) Handles pbAxis.Paint
        e.Graphics.TranslateTransform(center, center)
        Dim p As Pen = New Pen(Color.BlueViolet)
        Dim p2 As Pen = New Pen(Color.LightGray)
        e.Graphics.DrawLine(p2, New Point(center, 0), New Point(-center, 0))
        e.Graphics.DrawLine(p2, New Point(0, center), New Point(0, -center))
        e.Graphics.DrawLine(p, New Point(currentPoint.X - 10, currentPoint.Y), New Point(currentPoint.X + 10, currentPoint.Y))
        e.Graphics.DrawLine(p, New Point(currentPoint.X, currentPoint.Y - 10), New Point(currentPoint.X, currentPoint.Y + 10))
    End Sub
    Private Sub _board_BoardChanged(sender As Object, e As BoardChangedArgs) Handles _board.BoardChanged
        If e.type = MESSAGE_TYPE.ACCEL Then
            currentPoint = e.accel
            If currentPoint.X > maxSize Then
                maxSize = currentPoint.X
            End If
            If currentPoint.Y > maxSize Then
                maxSize = currentPoint.Y
            End If
            currentPoint.X = currentPoint.X / maxSize * center
            currentPoint.Y = currentPoint.Y / maxSize * center
            pbAxis.Invalidate()
        End If
    End Sub

    Private Sub Accelerometer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _board.enableAdminFunction(ADMIN.OFF)
    End Sub
End Class