

Public Class Buttons

    Private _userControlList As New List(Of ucButton)
    Private _board As BoardInterface
    Private _config As BoardConfiguration
    Private buttonArray() = {7, 6, 5, 8, 25, 26, 27, 28, 29, 30, 32, 31, 7, 7, 7, 33, 34, 7, 3, 4, 1, 2, 7, 24, 7, 7}
    Private steamConfig As String = "030047518f0e00000692000000000000,Clev Soft PinOne,crc:5147,platform:Windows,a:b6,b:b5,x:b4,y:b7,dpleft:b24,dpright:b25,dpup:b26,dpdown:b27,leftx:a0,lefty:~a1,righty:a2,leftshoulder:b2,lefttrigger:b3,rightshoulder:b0,righttrigger:b1,start:b23,steam:1,"
    Public Structure XYCoordinates
        Public XY1 As Point ' Using Point to represent a pair of X and Y coordinates.
        Public XY2 As Point

        Public Sub New(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer)
            Me.XY1 = New Point(x1, y1)
            Me.XY2 = New Point(x2, y2)
        End Sub
    End Structure
    Dim controlStickCoordinates As New Dictionary(Of String, XYCoordinates)

    Private Sub fillcordinates()
        controlStickCoordinates.Add("Left Control Stick", New XYCoordinates(94, 62, 130, 99))
        controlStickCoordinates.Add("Right Control Stick", New XYCoordinates(244, 125, 284, 162))
        controlStickCoordinates.Add("Dpad Up", New XYCoordinates(157, 120, 172, 136))
        controlStickCoordinates.Add("Dpad Down", New XYCoordinates(157, 159, 172, 173))
        controlStickCoordinates.Add("Dpad Left", New XYCoordinates(137, 138, 155, 154))
        controlStickCoordinates.Add("Dpad Right", New XYCoordinates(173, 140, 190, 155))
        controlStickCoordinates.Add("X", New XYCoordinates(278, 72, 295, 94))
        controlStickCoordinates.Add("Y", New XYCoordinates(304, 50, 323, 66))
        controlStickCoordinates.Add("A", New XYCoordinates(306, 98, 324, 118))
        controlStickCoordinates.Add("B", New XYCoordinates(328, 75, 350, 96))
        controlStickCoordinates.Add("Start", New XYCoordinates(234, 78, 250, 94))
        controlStickCoordinates.Add("Back", New XYCoordinates(178, 78, 194, 94))
        controlStickCoordinates.Add("Xbox", New XYCoordinates(201, 29, 226, 58))
        controlStickCoordinates.Add("R-Shoulder", New XYCoordinates(280, 3, 340, 28))
        controlStickCoordinates.Add("L-Shoulder", New XYCoordinates(80, 3, 140, 28))

    End Sub
    Public Sub New(board As BoardInterface, config As BoardConfiguration)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _board = board
        _config = config
    End Sub
    Private Sub Buttons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillcordinates()

        For i As Integer = 0 To 31
            Dim userControl As New ucButton(i, _config)
            userControl.Location = New Point(1, i * 33 + 40)
            Me.Controls.Add(userControl)
            _userControlList.Add(userControl)
        Next

        cbButtonDebounceTime.SelectedItem = (_config.buttonDebounceCounter).ToString

        If _config.disableButtonPressWhenKeyboardEnabled = True Then
            cbDisableJoystick.Checked = True
        Else
            cbDisableJoystick.Checked = False
        End If

        'For i As Integer = 0 To 5
        '    Dim userControl As New ucButton(i + 6)
        '    userControl.Location = New Point(60, i * 25 + 50)
        '    Me.Controls.Add(userControl)
        '    _userControlList.Add(userControl)
        'Next
        'For i As Integer = 0 To 5
        '    Dim userControl As New ucButton(i + 12)
        '    userControl.Location = New Point(120, i * 25 + 50)
        '    Me.Controls.Add(userControl)
        '    _userControlList.Add(userControl)
        'Next
        'For i As Integer = 0 To 5
        '    Dim userControl As New ucButton(i + 18)
        '    userControl.Location = New Point(180, i * 25 + 50)
        '    Me.Controls.Add(userControl)
        '    _userControlList.Add(userControl)
        'Next
        Try
            _board.enableAdminFunction(ADMIN.BUTTONS)
        Catch ex As Exception
            MessageBox.Show("Unable to set to button mode")
        End Try
        AddHandler _board.BoardChanged, AddressOf _board_BoardChanged
        Me.KeyPreview = True

    End Sub
    Private Sub _board_BoardChanged(sender As Object, e As BoardChangedArgs)
        Try
            If e.type = MESSAGE_TYPE.BUTTONS Then
                For i As Integer = 0 To 31
                    _userControlList.Item(i).setButtonValue(e.buttons(i))
                Next
            End If
            If e.type = MESSAGE_TYPE.RESPONSE Then
                MessageBox.Show(e.message)
                _board.enableAdminFunction(ADMIN.BUTTONS)
            End If
        Catch ex As Exception

        End Try


    End Sub



    Private Sub Outputs_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            _board.enableAdminFunction(ADMIN.OFF)
            RemoveHandler _board.BoardChanged, AddressOf _board_BoardChanged
        Catch ex As Exception
            MessageBox.Show("Unable to set turn off button mode, maybe board is disconnected?")
        End Try

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs)
        sendButton(0)
    End Sub
    Private Sub sendButton(value As Integer)
        Try
            _board.setButtonValue(value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs)
        sendButton(1)
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs)
        sendButton(2)
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs)
        sendButton(3)
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs)
        sendButton(4)
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs)
        sendButton(5)
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs)
        sendButton(6)
    End Sub

    Private Sub bnt8_Click(sender As Object, e As EventArgs)
        sendButton(7)
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs)
        sendButton(8)
    End Sub

    Private Sub bnt24_Click(sender As Object, e As EventArgs)
        sendButton(_config.plungerLaunchButton)
    End Sub

    Private Sub btn25_Click(sender As Object, e As EventArgs)
        sendButton(24)
    End Sub

    Private Sub btn26_Click(sender As Object, e As EventArgs)
        sendButton(25)
    End Sub

    Private Sub btn27_Click(sender As Object, e As EventArgs)
        sendButton(26)
    End Sub

    Private Sub bnt28_Click(sender As Object, e As EventArgs)
        sendButton(27)
    End Sub

    Private Sub btn31_Click(sender As Object, e As EventArgs)
        sendButton(30)
    End Sub

    Private Sub btn32_Click(sender As Object, e As EventArgs)
        sendButton(31)
    End Sub

    Private Sub btn30_Click(sender As Object, e As EventArgs)
        sendButton(29)
    End Sub

    Private Sub btn29_Click(sender As Object, e As EventArgs)
        sendButton(28)
    End Sub

    Private Sub btn34_Click(sender As Object, e As EventArgs)
        sendButton(33)
    End Sub

    Private Sub btn33_Click(sender As Object, e As EventArgs)
        sendButton(32)
    End Sub


    Private Sub Buttons_KeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles MyBase.PreviewKeyDown
        For Each control In _userControlList
            control.setKeyDown(e.KeyCode)
        Next
    End Sub
    Protected Overrides Function ProcessDialogKey(keyData As Keys) As Boolean
        For Each control In _userControlList
            control.setKeyDown(keyData)
        Next
        Return MyBase.ProcessDialogKey(keyData)
    End Function

    Private Sub btnSendCalibration_Click(sender As Object, e As EventArgs) Handles btnSendCalibration.Click
        Try
            If cbDisableJoystick.Checked = True Then
                _config.disableButtonPressWhenKeyboardEnabled = True
            Else
                _config.disableButtonPressWhenKeyboardEnabled = False
            End If
            _config.buttonDebounceCounter = cbButtonDebounceTime.SelectedItem
            _board.setConfig(_config)
        Catch ex As Exception
            MessageBox.Show("Error while saving plunger values, check to ensure board is connected")
        End Try

    End Sub

    Private currentMatch As XYCoordinates? = Nothing
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Console.WriteLine("x: " & e.X & " y: " & e.Y)
        Dim foundMatch As Boolean = False

        For Each kvp As KeyValuePair(Of String, XYCoordinates) In controlStickCoordinates
            With kvp.Value
                If e.X >= .XY1.X AndAlso e.X <= .XY2.X AndAlso e.Y >= .XY1.Y AndAlso e.Y <= .XY2.Y Then
                    If Not currentMatch.Equals(kvp.Value) Then
                        currentMatch = kvp.Value
                        PictureBox1.Invalidate() ' Invalidate the form to trigger a redraw
                    End If
                    Me.Cursor = Cursors.Hand
                    foundMatch = True
                    Exit For
                End If
            End With
        Next

        If Not foundMatch Then
            If currentMatch IsNot Nothing Then
                currentMatch = Nothing
                PictureBox1.Invalidate() ' Invalidate to remove the ellipse if moving out of a matching area
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        If currentMatch IsNot Nothing Then
            With currentMatch.Value
                ' Define a semi-transparent light blue color for the fill
                Dim fillColor As Color = Color.FromArgb(128, 173, 216, 230) ' Alpha set to 128 for semi-transparency

                ' Optionally, define a pen for the outline if desired
                Dim outlineColor As Color = Color.FromArgb(128, 173, 216, 230) ' Opaque color for the outline
                Using fillBrush As New SolidBrush(fillColor), outlinePen As New Pen(outlineColor, 2)
                    ' Fill the ellipse with the semi-transparent brush
                    e.Graphics.FillEllipse(fillBrush, .XY1.X, .XY1.Y, .XY2.X - .XY1.X, .XY2.Y - .XY1.Y)

                    ' Draw the ellipse outline
                    e.Graphics.DrawEllipse(outlinePen, .XY1.X, .XY1.Y, .XY2.X - .XY1.X, .XY2.Y - .XY1.Y)
                End Using
            End With
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        If currentMatch IsNot Nothing Then

        End If
    End Sub
End Class