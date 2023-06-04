Public Class Accelerometer
    Dim currentPoint As New Drawing.Point(0, 0)
    Dim center As Integer
    Dim maxSize As Integer = 250
    Private deadZone As Integer = 0
    Private recordDeadZone As Boolean = False
    Private WithEvents _board As BoardInterface
    Private _config As BoardConfiguration

    Public Sub New(board As BoardInterface, config As BoardConfiguration)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _board = board
        _config = config
    End Sub

    Private Sub Accelerometer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _board.enableAdminFunction(ADMIN.ACCEL)
        pbAxis.Size = New Drawing.Size(pbAxis.Size.Width, pbAxis.Size.Width)
        maxSize = pbAxis.Size.Width / 2
        center = maxSize
        tbDeadZone.Text = _config.accelerometerDeadZone
        tbMultiplier.Text = _config.accelerometerMultiplier
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
            tbXRaw.Text = currentPoint.X
            tbYRaw.Text = currentPoint.Y
            tbX.Text = currentPoint.X * CUShort(tbMultiplier.Text)
            tbY.Text = currentPoint.Y * CUShort(tbMultiplier.Text)
            currentPoint.X = currentPoint.X / maxSize * center
            currentPoint.Y = currentPoint.Y / maxSize * center
            pbAxis.Invalidate()

            If recordDeadZone Then
                If currentPoint.X > deadZone Then
                    tbDeadZone.Text = currentPoint.X
                    deadZone = currentPoint.X
                End If
                If currentPoint.Y > deadZone Then
                    tbDeadZone.Text = currentPoint.Y
                    deadZone = currentPoint.Y
                End If
            End If
        End If
    End Sub

    Private Sub Accelerometer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _board.enableAdminFunction(ADMIN.OFF)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub btnDeadZone_Click(sender As Object, e As EventArgs) Handles btnDeadZone.Click
        recordDeadZone = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        _board.setAccelerometerValues(CUShort(tbMultiplier.Text), CUShort(tbDeadZone.Text))
    End Sub
End Class