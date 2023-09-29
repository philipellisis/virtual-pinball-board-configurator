Imports System.ComponentModel

Public Class Accelerometer
    Dim currentPoint As New Drawing.PointF(0, 0)
    Dim center As Integer
    Dim maxSize As Integer = 250
    Private deadZone As Integer = 0
    Private tilt As Integer = 0
    Private max As Integer = 0
    Private recordDeadZone As Boolean = False
    Private recordTilt As Boolean = False
    Private recordMax As Boolean = False
    Private outputOn As Boolean = False
    Private _board As BoardInterface
    Private _config As BoardConfiguration
    Dim multiplier As Integer = 100

    Public Sub New(board As BoardInterface, config As BoardConfiguration)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _board = board
        _config = config
    End Sub

    Private Sub Accelerometer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            AddHandler _board.BoardChanged, AddressOf _board_BoardChanged
            _board.enableAdminFunction(ADMIN.ACCEL)
            pbAxis.Size = New Drawing.Size(pbAxis.Size.Width, pbAxis.Size.Width)
            maxSize = pbAxis.Size.Width / 2
            center = maxSize
            tbDeadZone.Text = _config.accelerometerDeadZone
            cbMultiplier.SelectedItem = _config.getSensitivityString
            cbOrientation.SelectedItem = _config.getOrientationString
            cbTiltButton.SelectedItem = (_config.tiltButton + 1).ToString
            tbTilt.Text = _config.accelerometerTilt
            tbMax.Text = _config.accelerometerMax
            If _config.accelerometerDeadZone > maxSize Then
                maxSize = _config.accelerometerDeadZone + 40
            End If
            If _config.accelerometerTilt > maxSize Then
                maxSize = _config.accelerometerTilt + 40
            End If
            If _config.accelerometerMax > maxSize Then
                maxSize = _config.accelerometerMax + 40
            End If
            cbOutputNumber.SelectedItem = "1"
            If (_config.orentation > 3 And _config.orentation < 8) Or (_config.orentation > 11) Then
                cbPinsFacingUp.Checked = True
            End If
            If (_config.orentation > 7) Then
                cbSideMounted.Checked = True
            End If
        Catch ex As Exception
            MessageBox.Show("error initializing board, check to ensure board is connected.")
        End Try

    End Sub

    Private Sub pbAxis_Paint(sender As Object, e As PaintEventArgs) Handles pbAxis.Paint
        Try
            e.Graphics.TranslateTransform(center, center)
            Dim p As Pen = New Pen(Color.BlueViolet)
            Dim p2 As Pen = New Pen(Color.LightGray)
            Dim p3 As Pen = New Pen(Color.DarkGray)
            Dim p4 As Pen = New Pen(Color.Yellow)
            Dim p5 As Pen = New Pen(Color.Red)
            e.Graphics.DrawLine(p2, New Point(center, 0), New Point(-center, 0))
            e.Graphics.DrawLine(p2, New Point(0, center), New Point(0, -center))
            e.Graphics.DrawRectangle(p3, New Rectangle(New Point(-deadZone / maxSize * center, -deadZone / maxSize * center), New Size(deadZone * 2 / maxSize * center, deadZone * 2 / maxSize * center)))
            e.Graphics.DrawRectangle(p4, New Rectangle(New Point(-tilt / maxSize * center, -tilt / maxSize * center), New Size(tilt * 2 / maxSize * center, tilt * 2 / maxSize * center)))
            e.Graphics.DrawRectangle(p5, New Rectangle(New Point(-max / maxSize * center, -max / maxSize * center), New Size(max * 2 / maxSize * center, max * 2 / maxSize * center)))
            e.Graphics.DrawLine(p, New Point(currentPoint.X * multiplier - 10, currentPoint.Y * multiplier), New Point(currentPoint.X * multiplier + 10, currentPoint.Y * multiplier))
            e.Graphics.DrawLine(p, New Point(currentPoint.X * multiplier, currentPoint.Y * multiplier - 10), New Point(currentPoint.X * multiplier, currentPoint.Y * multiplier + 10))
        Catch ex As Exception

        End Try

    End Sub
    Private Sub _board_BoardChanged(sender As Object, e As BoardChangedArgs)
        Try
            If e.type = MESSAGE_TYPE.ACCEL Then
                currentPoint = e.accel

                'If (_config -> ORIENTATION == Right) Then {
                '  xValue = -yValue;
                '  yValue = temp;
                '} else if (_config->orientation == FORWARD) {
                '  xValue = -xValue;
                '  yValue = -yValue;
                '} else if (_config->orientation == LEFT) {
                '  xValue = yValue;
                '  yValue = -temp;
                '} else if (_config->orientation == UP_BACK) {
                '  xValue = -xValue;
                '  yValue = yValue;
                '} else if (_config->orientation == UP_RIGHT) {
                '  xValue = -yValue;
                '  yValue = -temp;
                '} else if (_config->orientation == UP_FORWARD) {
                '  xValue = xValue;
                '  yValue = -yValue;
                '} else if (_config->orientation == UP_LEFT) {
                '  xValue = -yValue;
                '  yValue = -temp;
                '}
                Dim orientation As Integer = _config.getIntegerFromOrientationString(cbOrientation.SelectedItem, cbPinsFacingUp.Checked, cbSideMounted.Checked)
                If orientation = 1 Or orientation = 9 Then
                    currentPoint.X = -e.accel.Y
                    currentPoint.Y = e.accel.X
                ElseIf orientation = 2 Or orientation = 10 Then
                    currentPoint.X = -e.accel.X
                    currentPoint.Y = -e.accel.Y
                ElseIf orientation = 3 Or orientation = 11 Then
                    currentPoint.X = e.accel.Y
                    currentPoint.Y = -e.accel.X
                ElseIf orientation = 4 Or orientation = 12 Then
                    currentPoint.X = -e.accel.X
                    currentPoint.Y = e.accel.Y
                ElseIf orientation = 5 Or orientation = 13 Then
                    currentPoint.X = -e.accel.Y
                    currentPoint.Y = -e.accel.X
                ElseIf orientation = 6 Or orientation = 14 Then
                    currentPoint.X = e.accel.X
                    currentPoint.Y = -e.accel.Y
                ElseIf orientation = 7 Or orientation = 15 Then
                    currentPoint.X = e.accel.Y
                    currentPoint.Y = e.accel.X
                End If


                If Math.Abs(currentPoint.X * multiplier) > maxSize Then
                    maxSize = Math.Abs(currentPoint.X * multiplier) + 40
                End If
                If Math.Abs(currentPoint.Y * multiplier) > maxSize Then
                    maxSize = Math.Abs(currentPoint.Y * multiplier) + 40
                End If
                tbXRaw.Text = currentPoint.X
                tbYRaw.Text = currentPoint.Y
                tbX.Text = e.accelActual.X
                tbY.Text = e.accelActual.Y

                If recordDeadZone Then
                    If currentPoint.X * multiplier > deadZone Then
                        tbDeadZone.Text = currentPoint.X * multiplier
                        deadZone = currentPoint.X * multiplier
                    End If
                    If currentPoint.Y * multiplier > deadZone Then
                        tbDeadZone.Text = currentPoint.Y * multiplier
                        deadZone = currentPoint.Y * multiplier
                    End If
                Else
                    deadZone = CUShort(tbDeadZone.Text)
                End If

                If recordTilt Then
                    If currentPoint.X * multiplier > tilt Then
                        tbTilt.Text = currentPoint.X * multiplier
                        tilt = currentPoint.X * multiplier
                    End If
                    If currentPoint.Y * multiplier > tilt Then
                        tbTilt.Text = currentPoint.Y * multiplier
                        tilt = currentPoint.Y * multiplier
                    End If
                Else
                    tilt = CUShort(tbTilt.Text)
                End If

                If recordMax Then
                    If currentPoint.X * multiplier > max Then
                        tbMax.Text = currentPoint.X * multiplier
                        max = currentPoint.X * multiplier
                    End If
                    If currentPoint.Y * multiplier > max Then
                        tbMax.Text = currentPoint.Y * multiplier
                        max = currentPoint.Y * multiplier
                    End If
                Else
                    max = CUShort(tbMax.Text)
                End If

                currentPoint.X = currentPoint.X / maxSize * center
                currentPoint.Y = currentPoint.Y / maxSize * center
                pbAxis.Invalidate()


            ElseIf e.type = MESSAGE_TYPE.RESPONSE Then
                MessageBox.Show(e.message)
                _board.enableAdminFunction(ADMIN.ACCEL)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Accelerometer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            _board.enableAdminFunction(ADMIN.OFF)
        Catch ex As Exception
            MessageBox.Show("unable to turn off accelerometer mode. Maybe board is disconnected?")
        End Try

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
            tbDeadZone.Text = "0"
            deadZone = 0
            btnDeadZone.Text = "Stop Deadzone"
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            _config.setOrientationString(cbOrientation.SelectedItem, cbPinsFacingUp.Checked, cbSideMounted.Checked)
            _config.setSensitivityString(cbMultiplier.SelectedItem)
            _config.accelerometerDeadZone = CUShort(tbDeadZone.Text)
            _config.accelerometerTilt = CUShort(tbTilt.Text)
            _config.accelerometerMax = CUShort(tbMax.Text)
            _config.tiltButton = (cbTiltButton.SelectedItem - 1).ToString
            _board.setConfig(_config)
        Catch ex As Exception
            MessageBox.Show("error when saving data, maybe board is disconnected?")
        End Try
    End Sub

    Private Sub btnTilt_Click(sender As Object, e As EventArgs) Handles btnTilt.Click
        If recordTilt Then
            recordTilt = False
            btnTilt.Text = "Record Tilt Value"
        Else
            recordTilt = True
            tbTilt.Text = "0"
            tilt = 0
            btnTilt.Text = "Stop Tilt Value"
        End If
    End Sub

    Private Sub btnToggleOutput_Click(sender As Object, e As EventArgs) Handles btnToggleOutput.Click
        Try
            If outputOn Then
                outputOn = False
                btnToggleOutput.Text = "Toggle Output On"
                _board.setOutputValue(cbOutputNumber.SelectedItem - 1, 0)
                cbOutputNumber.Enabled = True
            Else
                outputOn = True
                _board.setOutputValue(cbOutputNumber.SelectedItem - 1, 255)
                btnToggleOutput.Text = "Toggle Output Off"
                cbOutputNumber.Enabled = False
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If recordMax Then
            recordMax = False
            Button1.Text = "Record Max Value"
        Else
            recordMax = True
            tbMax.Text = "0"
            max = 0
            Button1.Text = "Stop Max Value"
        End If
    End Sub

    Private Sub Accelerometer_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        RemoveHandler _board.BoardChanged, AddressOf _board_BoardChanged
    End Sub
End Class