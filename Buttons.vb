

Imports System.Text


Public Class Buttons

    Private _userControlList As New List(Of ucButton)
    Private _board As BoardInterface
    Private _config As BoardConfiguration
    Private buttonArray() = {7, 6, 5, 8, 25, 26, 27, 28, 29, 30, 32, 31, 7, 7, 7, 33, 34, 7, 3, 4, 1, 2, 7, 24, 7, 7}
    Private steamConfig As String = "030047518f0e00000792000000000000,Clev Soft PinOne,crc:5147,platform:Windows,a:b5,b:b7,x:b6,y:b4,dpleft:b24,dpright:b25,dpup:b26,dpdown:b27,leftx:a0,lefty:a1,righty:a2,leftshoulder:b2,lefttrigger:b3,rightshoulder:b0,righttrigger:b1,back:b28,start:b8,steam:1,"
    Public Structure XYCoordinates
        Public XY1 As Point ' Using Point to represent a pair of X and Y coordinates.
        Public XY2 As Point
        Public name As String

        Public Sub New(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer, name As String)
            Me.XY1 = New Point(x1, y1)
            Me.XY2 = New Point(x2, y2)
            Me.name = name
        End Sub
    End Structure
    Dim controlStickCoordinates As New Dictionary(Of String, XYCoordinates)

    Private Sub fillcordinates()
        controlStickCoordinates.Add("cbLeftControl", New XYCoordinates(94, 62, 130, 99, "cbLeftControl"))
        controlStickCoordinates.Add("cbRightControl", New XYCoordinates(244, 125, 284, 162, "cbRightControl"))
        controlStickCoordinates.Add("cbUp", New XYCoordinates(157, 120, 172, 136, "cbUp"))
        controlStickCoordinates.Add("cbDown", New XYCoordinates(157, 159, 172, 173, "cbDown"))
        controlStickCoordinates.Add("cbLeft", New XYCoordinates(137, 138, 155, 154, "cbLeft"))
        controlStickCoordinates.Add("cbRight", New XYCoordinates(173, 140, 190, 155, "cbRight"))
        controlStickCoordinates.Add("cbX", New XYCoordinates(278, 72, 295, 94, "cbX"))
        controlStickCoordinates.Add("cbY", New XYCoordinates(304, 50, 323, 66, "cbY"))
        controlStickCoordinates.Add("cbA", New XYCoordinates(306, 98, 324, 118, "cbA"))
        controlStickCoordinates.Add("cbB", New XYCoordinates(328, 75, 350, 96, "cbB"))
        controlStickCoordinates.Add("cbStart", New XYCoordinates(234, 78, 250, 94, "cbStart"))
        controlStickCoordinates.Add("cbBack", New XYCoordinates(178, 78, 194, 94, "cbBack"))
        controlStickCoordinates.Add("cbXBox", New XYCoordinates(201, 29, 226, 58, "cbXBox"))
        controlStickCoordinates.Add("cbLSh", New XYCoordinates(280, 3, 340, 28, "cbLSh"))
        controlStickCoordinates.Add("cbRSh", New XYCoordinates(80, 3, 140, 28, "cbRSh"))

    End Sub

    Private Sub buildSteamSettings()
        Dim str As New StringBuilder
        str.Append("030047518f0e00000792000000000000,Clev Soft PinOne,crc:5147,platform:Windows,")
        If Not cbA.SelectedItem Is Nothing Then
            str.Append("a:b")
            str.Append((CInt(cbA.SelectedItem) - 1).ToString)
            str.Append(",")
        End If
        If Not cbB.SelectedItem Is Nothing Then
            str.Append("b:b")
            str.Append((CInt(cbB.SelectedItem) - 1).ToString)
            str.Append(",")
        End If
        If Not cbX.SelectedItem Is Nothing Then
            str.Append("x:b")
            str.Append((CInt(cbX.SelectedItem) - 1).ToString)
            str.Append(",")
        End If
        If Not cbY.SelectedItem Is Nothing Then
            str.Append("y:b")
            str.Append((CInt(cbY.SelectedItem) - 1).ToString)
            str.Append(",")
        End If
        If Not cbLeft.SelectedItem Is Nothing Then
            str.Append("dpleft:b")
            str.Append((CInt(cbLeft.SelectedItem) - 1).ToString)
            str.Append(",")
        End If
        If Not cbRight.SelectedItem Is Nothing Then
            str.Append("dpright:b")
            str.Append((CInt(cbRight.SelectedItem) - 1).ToString)
            str.Append(",")
        End If
        If Not cbUp.SelectedItem Is Nothing Then
            str.Append("dpup:b")
            str.Append((CInt(cbUp.SelectedItem) - 1).ToString)
            str.Append(",")
        End If
        If Not cbDown.SelectedItem Is Nothing Then
            str.Append("dpdown:b")
            str.Append((CInt(cbDown.SelectedItem) - 1).ToString)
            str.Append(",")
        End If
        If Not cbLeftControl.SelectedItem Is Nothing Then
            If cbLeftControl.SelectedItem = "Plunger" Then
                str.Append("lefty:a2,")
            ElseIf cbLeftControl.SelectedItem = "Nudge" Then
                str.Append("leftx:a0,lefty:a1,")
            End If
        End If
        If Not cbRightControl.SelectedItem Is Nothing Then
            If cbRightControl.SelectedItem = "Plunger" Then
                str.Append("righty:a2,")
            ElseIf cbRightControl.SelectedItem = "Nudge" Then
                str.Append("rightx:a0,righty:a1,")
            End If
        End If
        If Not cbLSh.SelectedItem Is Nothing Then
            str.Append("leftshoulder:b")
            str.Append((CInt(cbLSh.SelectedItem) - 1).ToString)
            str.Append(",")
        End If
        If Not cbLTrig.SelectedItem Is Nothing Then
            str.Append("lefttrigger:b")
            str.Append((CInt(cbLTrig.SelectedItem) - 1).ToString)
            str.Append(",")
        End If
        If Not cbRSh.SelectedItem Is Nothing Then
            str.Append("rightshoulder:b")
            str.Append((CInt(cbRSh.SelectedItem) - 1).ToString)
            str.Append(",")
        End If
        If Not cbRTrig.SelectedItem Is Nothing Then
            str.Append("righttrigger:b")
            str.Append((CInt(cbRTrig.SelectedItem) - 1).ToString)
            str.Append(",")
        End If
        If Not cbBack.SelectedItem Is Nothing Then
            str.Append("back:b")
            str.Append((CInt(cbBack.SelectedItem) - 1).ToString)
            str.Append(",")
        End If
        If Not cbStart.SelectedItem Is Nothing Then
            str.Append("start:b")
            str.Append((CInt(cbStart.SelectedItem) - 1).ToString)
            str.Append(",")
        End If

        If Not cbXBox.SelectedItem Is Nothing Then
            str.Append("guide:b")
            str.Append(cbXBox.SelectedItem)
            str.Append(",")
        End If
        str.Append("steam:1,")
        tbSteamSettings.Text = str.ToString
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


        cbLeftControl.SelectedItem = "Nudge"
        cbRightControl.SelectedItem = "Plunger"
        cbRTrig.SelectedItem = "2"
        cbRSh.SelectedItem = "1"
        cbLSh.SelectedItem = "3"
        cbLTrig.SelectedItem = "4"
        cbY.SelectedItem = "5"
        cbA.SelectedItem = "6"
        cbX.SelectedItem = "7"
        cbB.SelectedItem = "8"
        cbLeft.SelectedItem = "25"
        cbRight.SelectedItem = "26"
        cbUp.SelectedItem = "27"
        cbDown.SelectedItem = "28"
        cbStart.SelectedItem = "9"
        cbBack.SelectedItem = "29"

        buildSteamSettings()

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
                    If Not currentComboBox Is Nothing And e.buttons(i) > 0 Then
                        currentComboBox.SelectedItem = (i + 1).ToString()
                        buildSteamSettings()
                        lblPushButton.Visible = False
                        currentComboBox = Nothing
                    End If
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
            MessageBox.Show("Note that steam calibration settings are not saved to PinOne. Please ensure you have copied the settings for steam and saved them as your calibration in steam to ensure you do not lose any data")
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

    Private currentComboBox As ComboBox
    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        If currentMatch IsNot Nothing Then
            currentComboBox = FindComboBoxByName(gbXbox, currentMatch.Value.name)
            If Not currentComboBox Is Nothing Then
                lblPushButton.Visible = True
            End If
        End If
    End Sub

    Private Function FindComboBoxByName(container As Control, name As String) As Windows.Forms.ComboBox
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is Windows.Forms.ComboBox AndAlso ctrl.Name = name Then
                Return CType(ctrl, Windows.Forms.ComboBox)
            End If
        Next
        Return Nothing ' Return Nothing if no matching ComboBox is found
    End Function

    Private Sub cbUp_MouseMove(sender As Object, e As MouseEventArgs) Handles cbUp.MouseMove, cbDown.MouseMove, cbLeft.MouseMove, cbRight.MouseMove, cbLSh.MouseMove, cbRSh.MouseMove, cbA.MouseMove, cbB.MouseMove, cbX.MouseMove, cbY.MouseMove, cbBack.MouseMove, cbStart.MouseMove, cbXBox.MouseMove, cbRightControl.MouseMove, cbLeftControl.MouseMove

        Dim control As Windows.Forms.ComboBox = CType(sender, Windows.Forms.ComboBox) ' Cast sender to ComboBox
        Dim controlName As String = control.Name ' Get the name of the ComboBox

        ' Check if the dictionary contains the key based on controlName
        If controlStickCoordinates.ContainsKey(controlName) Then
            ' Access the item using controlName as the key
            Dim coordinates As XYCoordinates = controlStickCoordinates(controlName)
            currentMatch = coordinates
            PictureBox1.Invalidate() ' Invalidate the form to trigger a redraw

        Else
            ' Handle the case where the dictionary does not contain the key
            Console.WriteLine($"No coordinates found for {controlName}")
        End If

    End Sub


    Private Sub gbXbox_MouseMove(sender As Object, e As MouseEventArgs) Handles gbXbox.MouseMove
        currentMatch = Nothing
        PictureBox1.Invalidate() ' Invalidate the form to trigger a redraw

    End Sub

    Private Sub btnLTrig_Click(sender As Object, e As EventArgs) Handles btnLTrigger.Click
        currentComboBox = FindComboBoxByName(gbXbox, "cbLTrig")
        If Not currentComboBox Is Nothing Then
            lblPushButton.Visible = True
        End If
    End Sub
    Private Sub btnRTrig_Click(sender As Object, e As EventArgs) Handles btnRTrigger.Click
        currentComboBox = FindComboBoxByName(gbXbox, "cbRTrig")
        If Not currentComboBox Is Nothing Then
            lblPushButton.Visible = True
        End If
    End Sub

    Private Sub cbUp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUp.SelectedIndexChanged, cbDown.SelectedIndexChanged, cbLeft.SelectedIndexChanged, cbRight.SelectedIndexChanged, cbLSh.SelectedIndexChanged, cbRSh.SelectedIndexChanged, cbA.SelectedIndexChanged, cbB.SelectedIndexChanged, cbX.SelectedIndexChanged, cbY.SelectedIndexChanged, cbBack.SelectedIndexChanged, cbStart.SelectedIndexChanged, cbXBox.SelectedIndexChanged, cbRightControl.SelectedIndexChanged, cbLeftControl.SelectedIndexChanged
        buildSteamSettings()
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Clipboard.SetText(tbSteamSettings.Text)
    End Sub

    Private Sub btnGetVDF_Click(sender As Object, e As EventArgs) Handles btnGetVDF.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "VDF Files (*.vdf)|*.vdf"
        openFileDialog.Title = "Select a VDF File"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            tbVDFFile.Text = openFileDialog.FileName
        End If
    End Sub

    Private Sub btnSaveVDF_Click(sender As Object, e As EventArgs) Handles btnSaveVDF.Click

        MessageBox.Show("Ensure that Steam is completely exited (not just minimized) before proceeding or the changes will not take effect")

        If String.IsNullOrWhiteSpace(tbVDFFile.Text) Then
            MessageBox.Show("Please select a file first.")
            Return
        End If
        Dim filePath As String = tbVDFFile.Text
        Dim appendString As String = tbSteamSettings.Text

        ' Check if the file exists
        If Not System.IO.File.Exists(filePath) Then
            MessageBox.Show("File does not exist.")
            Return
        End If

        ' Read all lines of the file
        Dim lines As List(Of String) = System.IO.File.ReadAllLines(filePath).ToList()

        ' Create a new list to store the modified lines
        Dim modifiedLines As New List(Of String)()

        ' Modify lines containing the specific string
        For Each line As String In lines
            If Not line.Contains("Clev Soft PinOne") Then
                modifiedLines.Add(line)
            End If

            If line.Contains("SDL_GamepadBind") Then
                modifiedLines.Add(tbSteamSettings.Text)
            End If
        Next

        ' Write the modified lines back to the file
        System.IO.File.WriteAllLines(filePath, modifiedLines)
        MessageBox.Show("File updated successfully.")
    End Sub
End Class