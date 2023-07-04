Public Class Accelerometer
    Dim currentPoint As New Drawing.PointF(0, 0)
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
        cbOrientation.SelectedItem = _config.getOrientationString
        tbTilt.Text = _config.accelerometerTilt
    End Sub

    Private Sub pbAxis_Paint(sender As Object, e As PaintEventArgs) Handles pbAxis.Paint
        Try
            e.Graphics.TranslateTransform(center, center)
            Dim p As Pen = New Pen(Color.BlueViolet)
            Dim p2 As Pen = New Pen(Color.LightGray)
            Dim p3 As Pen = New Pen(Color.Red)
            e.Graphics.DrawLine(p2, New Point(center, 0), New Point(-center, 0))
            e.Graphics.DrawLine(p2, New Point(0, center), New Point(0, -center))
            e.Graphics.DrawRectangle(p3, New Rectangle(New Point(-deadZone / maxSize * center, -deadZone / maxSize * center), New Size(deadZone * 2 / maxSize * center, deadZone * 2 / maxSize * center)))
            e.Graphics.DrawLine(p, New Point(currentPoint.X * CUShort(tbMultiplier.Text) - 10, currentPoint.Y * CUShort(tbMultiplier.Text)), New Point(currentPoint.X * CUShort(tbMultiplier.Text) + 10, currentPoint.Y * CUShort(tbMultiplier.Text)))
            e.Graphics.DrawLine(p, New Point(currentPoint.X * CUShort(tbMultiplier.Text), currentPoint.Y * CUShort(tbMultiplier.Text) - 10), New Point(currentPoint.X * CUShort(tbMultiplier.Text), currentPoint.Y * CUShort(tbMultiplier.Text) + 10))
        Catch ex As Exception

        End Try

    End Sub
    Private Sub _board_BoardChanged(sender As Object, e As BoardChangedArgs) Handles _board.BoardChanged
        Try
            If e.type = MESSAGE_TYPE.ACCEL Then
                currentPoint = e.accel
                If Math.Abs(currentPoint.X * CUShort(tbMultiplier.Text)) > maxSize Then
                    maxSize = Math.Abs(currentPoint.X * CUShort(tbMultiplier.Text))
                End If
                If Math.Abs(currentPoint.Y * CUShort(tbMultiplier.Text)) > maxSize Then
                    maxSize = Math.Abs(currentPoint.Y * CUShort(tbMultiplier.Text))
                End If
                tbXRaw.Text = currentPoint.X
                tbYRaw.Text = currentPoint.Y
                tbX.Text = e.accelActual.X
                tbY.Text = e.accelActual.Y

                If recordDeadZone Then
                    If currentPoint.X * CUShort(tbMultiplier.Text) > deadZone Then
                        tbDeadZone.Text = currentPoint.X * CUShort(tbMultiplier.Text)
                        deadZone = currentPoint.X * CUShort(tbMultiplier.Text)
                    End If
                    If currentPoint.Y * CUShort(tbMultiplier.Text) > deadZone Then
                        tbDeadZone.Text = currentPoint.Y * CUShort(tbMultiplier.Text)
                        deadZone = currentPoint.Y * CUShort(tbMultiplier.Text)
                    End If
                Else
                    deadZone = CUShort(tbDeadZone.Text)
                End If

                currentPoint.X = currentPoint.X / maxSize * center
                currentPoint.Y = currentPoint.Y / maxSize * center
                pbAxis.Invalidate()


            ElseIf e.type = MESSAGE_TYPE.RESPONSE Then
                MessageBox.Show(e.message)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Accelerometer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _board.enableAdminFunction(ADMIN.OFF)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub btnDeadZone_Click(sender As Object, e As EventArgs) Handles btnDeadZone.Click
        If recordDeadZone Then
            recordDeadZone = False
            btnDeadZone.Text = "Record Deadzone"
        Else
            recordDeadZone = True
            btnDeadZone.Text = "Stop Deadzone"
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        _config.setOrientationString(cbOrientation.SelectedItem)
        _config.accelerometerMultiplier = CUShort(tbMultiplier.Text)
        _config.accelerometerDeadZone = CUShort(tbDeadZone.Text)
        _config.accelerometerTilt = CUShort(tbTilt.Text)
        _board.setAccelerometerValues(_config.accelerometerMultiplier, _config.accelerometerDeadZone, _config.orentation, _config.accelerometerTilt)
    End Sub
End Class