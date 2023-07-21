Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization

Public Class Configuration
    Private _config As BoardConfiguration
    Private WithEvents _board As BoardInterface
    Private _userControlList As New List(Of AdjustmentSlider)
    Sub New(board As BoardInterface, config As BoardConfiguration)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _board = board
        _config = config
    End Sub
    Private Sub Configuration_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.SuspendLayout()
        tpMainOutputs.SuspendLayout()

        For i As Integer = 0 To 30
            Dim userControl As New AdjustmentSlider(i, _config, _board)
            userControl.Location = New Point(1, i * 110)
            tpMainOutputs.Controls.Add(userControl)
            _userControlList.Add(userControl)
        Next
        '_userControlList.Item(31).Visible = False

        For i As Integer = 31 To 46
            Dim userControl As New AdjustmentSlider(i, _config, _board)
            userControl.Location = New Point(1, (i - 31) * 110)
            tpExpansion1.Controls.Add(userControl)
            _userControlList.Add(userControl)
        Next
        tpExpansion1.Cursor = Cursors.Default

        For i As Integer = 47 To 62
            Dim userControl As New AdjustmentSlider(i, _config, _board)
            userControl.Location = New Point(1, (i - 47) * 110)
            tpExpansion2.Controls.Add(userControl)
            _userControlList.Add(userControl)
        Next

        cbOutputTrigger1.SelectedItem = (_config.solenoidOutputMap(0)).ToString
        cbOutputTrigger2.SelectedItem = (_config.solenoidOutputMap(1)).ToString
        cbOutputTrigger3.SelectedItem = (_config.solenoidOutputMap(2)).ToString
        cbOutputTrigger4.SelectedItem = (_config.solenoidOutputMap(3)).ToString

        cbButtonTrigger1.SelectedItem = (_config.solenoidButtonMap(0)).ToString
        cbButtonTrigger2.SelectedItem = (_config.solenoidButtonMap(1)).ToString
        cbButtonTrigger3.SelectedItem = (_config.solenoidButtonMap(2)).ToString
        cbButtonTrigger4.SelectedItem = (_config.solenoidButtonMap(3)).ToString

        cbAccelEnabled.Checked = _config.accelerometer
        cbOrientation.SelectedItem = _config.getOrientationString
        tbPlungerMax.Text = _config.plungerMax.ToString
        tbPlungerMid.Text = _config.plungerMid.ToString
        tbPlungerMin.Text = _config.plungerMin.ToString
        tbMultiplier.Text = _config.accelerometerMultiplier.ToString
        tbDeadZone.Text = _config.accelerometerDeadZone.ToString

        If _config.buttonOption = 1 Or _config.buttonOption = 3 Then
            cbPushOnMax.Checked = True
        End If
        If _config.buttonOption >= 2 Then
            cbPushOnMin.Checked = True
        End If
        tbTilt.Text = _config.accelerometerTilt.ToString
        tbMax.Text = _config.accelerometerMax.ToString
        If _config.orentation > 3 Then
            cbPinsFacingUp.Checked = True
        End If

        Me.ResumeLayout()
        tpMainOutputs.ResumeLayout()
        Try
            _board.enableAdminFunction(ADMIN.OUTPUTS)
        Catch ex As Exception
            MessageBox.Show("error while setting output mode, check that board is connected.")
        End Try

    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            _board.enableAdminFunction(ADMIN.OFF)
            _config.solenoidOutputMap(0) = CByte(cbOutputTrigger1.SelectedItem)
            _config.solenoidOutputMap(1) = CByte(cbOutputTrigger2.SelectedItem)
            _config.solenoidOutputMap(2) = CByte(cbOutputTrigger3.SelectedItem)
            _config.solenoidOutputMap(3) = CByte(cbOutputTrigger4.SelectedItem)


            _config.solenoidButtonMap(0) = CByte(cbButtonTrigger1.SelectedItem)
            _config.solenoidButtonMap(1) = CByte(cbButtonTrigger2.SelectedItem)
            _config.solenoidButtonMap(2) = CByte(cbButtonTrigger3.SelectedItem)
            _config.solenoidButtonMap(3) = CByte(cbButtonTrigger4.SelectedItem)


            _config.accelerometer = CByte(cbAccelEnabled.Checked)
            _config.setOrientationString(cbOrientation.SelectedItem, cbPinsFacingUp.Checked)
            _config.plungerMax = CShort(tbPlungerMax.Text)
            _config.plungerMid = CShort(tbPlungerMid.Text)
            _config.plungerMin = CShort(tbPlungerMin.Text)
            _config.accelerometerDeadZone = CShort(tbDeadZone.Text)
            _config.accelerometerMultiplier = CShort(tbMultiplier.Text)
            Dim buttonOption As Byte = 0
            If cbPushOnMax.Checked And cbPushOnMin.Checked Then
                buttonOption = 3
            ElseIf cbPushOnMax.Checked Then
                buttonOption = 1
            ElseIf cbPushOnMin.Checked Then
                buttonOption = 2
            End If
            _config.buttonOption = buttonOption
            _config.accelerometerTilt = CShort(tbTilt.Text)
            _config.accelerometerMax = CShort(tbMax.Text)
            _board.setConfig(_config)
        Catch ex As Exception
            MessageBox.Show("error saving configuration. Check that board is connected.")
        End Try

    End Sub

    Private Sub _board_BoardChanged(sender As Object, e As BoardChangedArgs) Handles _board.BoardChanged
        Try
            If e.type = MESSAGE_TYPE.RESPONSE Then
                If e.message = "SAVE CONFIG SUCCESS" Then
                    btnSaveConfig.Enabled = True
                End If
                MessageBox.Show(e.message)
                _board.enableAdminFunction(ADMIN.OUTPUTS)
            End If
            If e.type = MESSAGE_TYPE.OUTPUTS Then
                For i As Integer = 0 To 62
                    _userControlList.Item(i).setIntensityValue(e.outputs(i))
                Next
            End If
        Catch ex As Exception

        End Try




    End Sub

    Private Sub btnSaveConfig_Click(sender As Object, e As EventArgs) Handles btnSaveConfig.Click
        Try
            _board.saveConfigToEeprom()
        Catch ex As Exception
            MessageBox.Show("error saving to eeprom")
        End Try

    End Sub

    Private Sub tpGeneralSettings_Click(sender As Object, e As EventArgs) Handles tpGeneralSettings.Click

    End Sub

    Private Sub Configuration_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            _board.enableAdminFunction(ADMIN.OFF)
        Catch ex As Exception
            MessageBox.Show("error while exiting admin mode")
        End Try

    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(BoardConfiguration))
        Dim file As New System.IO.StreamWriter(
            "c:\temp\backup.xml")
        writer.Serialize(file, _config)
        file.Close()
    End Sub

    Private Sub btnRetrieve_Click(sender As Object, e As EventArgs) Handles btnRetrieve.Click
        Dim xmldoc As New XmlDocument
        xmldoc.Load("c:\temp\backup.xml")
        Dim allText As String = xmldoc.InnerXml

        Using currentStringReader As New StringReader(allText)
            Dim xml As New XmlSerializer(GetType(BoardConfiguration))
            Dim board As BoardConfiguration = TryCast(xml.Deserialize(currentStringReader), BoardConfiguration)
            If board.accelerometer Then
                board = board
            End If
        End Using
    End Sub
End Class