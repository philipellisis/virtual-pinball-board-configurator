

Public Class Buttons

    Private _userControlList As New List(Of ucButton)
    Private _board As BoardInterface
    Private _config As BoardConfiguration
    Private buttonArray() = {7, 6, 5, 8, 25, 26, 27, 28, 29, 30, 32, 31, 7, 7, 7, 33, 34, 7, 3, 4, 1, 2, 7, 24, 7, 7}
    Private steamConfig As String = "030047518f0e00000692000000000000,Clev Soft PinOne,crc:5147,platform:Windows,a:b6,b:b5,x:b4,y:b7,dpleft:b24,dpright:b25,dpup:b26,dpdown:b27,leftx:a0,lefty:~a1,righty:a2,leftshoulder:b2,lefttrigger:b3,rightshoulder:b0,righttrigger:b1,start:b23,steam:1,"
    Public Sub New(board As BoardInterface, config As BoardConfiguration)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _board = board
        _config = config
    End Sub
    Private Sub Buttons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 27
            Dim userControl As New ucButton(i, _config)
            userControl.Location = New Point(1, i * 33 + 40)
            Me.Controls.Add(userControl)
            _userControlList.Add(userControl)
        Next

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
                For i As Integer = 0 To 23
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

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        sendButton(0)
    End Sub
    Private Sub sendButton(value As Integer)
        Try
            _board.setButtonValue(value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        sendButton(1)
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        sendButton(2)
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        sendButton(3)
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        sendButton(4)
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        sendButton(5)
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        sendButton(6)
    End Sub

    Private Sub bnt8_Click(sender As Object, e As EventArgs) Handles bnt8.Click
        sendButton(7)
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        sendButton(8)
    End Sub

    Private Sub bnt24_Click(sender As Object, e As EventArgs) Handles bnt24.Click
        sendButton(_config.plungerLaunchButton)
    End Sub

    Private Sub btn25_Click(sender As Object, e As EventArgs) Handles btn25.Click
        sendButton(24)
    End Sub

    Private Sub btn26_Click(sender As Object, e As EventArgs) Handles btn26.Click
        sendButton(25)
    End Sub

    Private Sub btn27_Click(sender As Object, e As EventArgs) Handles btn27.Click
        sendButton(26)
    End Sub

    Private Sub bnt28_Click(sender As Object, e As EventArgs) Handles bnt28.Click
        sendButton(27)
    End Sub

    Private Sub btn31_Click(sender As Object, e As EventArgs) Handles btn31.Click
        sendButton(30)
    End Sub

    Private Sub btn32_Click(sender As Object, e As EventArgs) Handles btn32.Click
        sendButton(31)
    End Sub

    Private Sub btn30_Click(sender As Object, e As EventArgs) Handles btn30.Click
        sendButton(29)
    End Sub

    Private Sub btn29_Click(sender As Object, e As EventArgs) Handles btn29.Click
        sendButton(28)
    End Sub

    Private Sub btn34_Click(sender As Object, e As EventArgs) Handles btn34.Click
        sendButton(33)
    End Sub

    Private Sub btn33_Click(sender As Object, e As EventArgs) Handles btn33.Click
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
            _board.setConfig(_config)
        Catch ex As Exception
            MessageBox.Show("Error while saving plunger values, check to ensure board is connected")
        End Try

    End Sub
End Class