﻿Public Class Plunger
    Private _board As BoardInterface
    Private _config As BoardConfiguration
    Private maxValue As UShort = 0
    Private minvalue As UShort = 1024
    'Private tempRestingValue As UShort = 0
    Private restingValue As UShort = 0
    Private restingCount As UShort = 0
    Private plungerCalibrationState = 0
    Private calibrating As Boolean = False
    Private timer As New Stopwatch
    Public Sub New(board As BoardInterface, config As BoardConfiguration)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _board = board
        _config = config
    End Sub
    Private Sub Plunger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            AddHandler _board.BoardChanged, AddressOf _board_BoardChanged
            _board.enableAdminFunction(ADMIN.PLUNGER)
        Catch ex As Exception
            MessageBox.Show("Error entering plunger mode. Ensure board is connected")
        End Try

        lblMaxValue.Text = _config.plungerMax.ToString
        lblMinValue.Text = _config.plungerMin.ToString
        lblRestingPoint.Text = _config.plungerMid.ToString

        cbDisablePlungerNonMoving.Checked = _config.disablePlungerWhenNotInUse
        cbDisableAccel.Checked = _config.disableAccelOnPlungerMove
        cbPlungerQuickRelease.Checked = _config.enablePlungerQuickRelease

        If _config.buttonOption = 1 Or _config.buttonOption = 3 Then
            cbPushOnMax.Checked = True
        End If
        If _config.buttonOption >= 2 Then
            cbPushOnMin.Checked = True
        End If

        cbLaunchButton.SelectedItem = (_config.plungerLaunchButton + 1).ToString
        cbAverageReadings.SelectedItem = (_config.plungerAverageRead).ToString
        btnSendCalibration.Enabled = False
    End Sub

    Private Sub _board_BoardChanged(sender As Object, e As BoardChangedArgs)
        Try
            If e.type = MESSAGE_TYPE.PLUNGER Then
                pbPlunger.Value = e.plunger + 1
                pbPlunger.Value = e.plunger
                lblCurrent.Text = e.plunger.ToString
                If plungerCalibrationState = 1 Then
                    If maxValue < e.plunger Then
                        maxValue = e.plunger
                        lblMaxValue.Text = e.plunger.ToString
                    End If
                    If minvalue > e.plunger Then
                        minvalue = e.plunger
                        lblMinValue.Text = e.plunger.ToString
                    End If
                End If
                If plungerCalibrationState = 2 Then
                    If timer.ElapsedMilliseconds > 1000 Then
                        lblRestingPoint.Text = e.plunger.ToString
                        restingValue = e.plunger
                        plungerCalibrationState = 0
                        btnSendCalibration.Enabled = True
                        btnStartCalibration.Enabled = True
                        btnStartCalibration.Text = "Calibrate Plunger"
                        lblCalibration.Visible = False
                    End If
                End If
            End If
            If e.type = MESSAGE_TYPE.RESPONSE Then
                MessageBox.Show(e.message)
                _board.enableAdminFunction(ADMIN.PLUNGER)
            End If
        Catch ex As Exception

        End Try



    End Sub
    Private Sub Outputs_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            _board.enableAdminFunction(ADMIN.OFF)
            RemoveHandler _board.BoardChanged, AddressOf _board_BoardChanged
        Catch ex As Exception
            MessageBox.Show("Error exiting admin mode. Check to ensure board is connected")
        End Try

    End Sub

    Private Sub btnSendCalibration_Click(sender As Object, e As EventArgs) Handles btnSendCalibration.Click
        Try
            Dim buttonOption As Byte = 0
            If cbPushOnMax.Checked And cbPushOnMin.Checked Then
                buttonOption = 3
            ElseIf cbPushOnMax.Checked Then
                buttonOption = 1
            ElseIf cbPushOnMin.Checked Then
                buttonOption = 2
            End If

            _config.disablePlungerWhenNotInUse = cbDisablePlungerNonMoving.Checked
            _config.disableAccelOnPlungerMove = cbDisableAccel.Checked
            _config.enablePlungerQuickRelease = cbPlungerQuickRelease.Checked

            _config.plungerMax = CShort(lblMaxValue.Text)
            _config.plungerMin = CShort(lblMinValue.Text)
            _config.plungerMid = CShort(lblRestingPoint.Text)
            _config.buttonOption = buttonOption
            _config.plungerAverageRead = cbAverageReadings.SelectedItem
            _config.plungerLaunchButton = cbLaunchButton.SelectedItem - 1
            _board.setConfig(_config)
        Catch ex As Exception
            MessageBox.Show("Error while saving plunger values, check to ensure board is connected")
        End Try


    End Sub

    Private Sub btnStartCalibration_Click(sender As Object, e As EventArgs) Handles btnStartCalibration.Click
        If plungerCalibrationState = 0 Then
            btnStartCalibration.Text = "Complete"
            maxValue = 0
            minvalue = 1024
            plungerCalibrationState = 1
            btnSendCalibration.Enabled = False
            lblCalibration.Visible = True
        Else
            btnStartCalibration.Enabled = False
            plungerCalibrationState = 2
            timer.Restart()
        End If

    End Sub

    Private Sub formChanged(sender As Object, e As EventArgs) Handles cbLaunchButton.SelectedIndexChanged, cbAverageReadings.SelectedIndexChanged, cbDisableAccel.CheckedChanged, cbDisablePlungerNonMoving.CheckedChanged, cbPlungerQuickRelease.CheckedChanged, cbPushOnMax.CheckedChanged, cbPushOnMin.CheckedChanged
        btnSendCalibration.Enabled = True
    End Sub

    Private Sub lblCalibration_Click(sender As Object, e As EventArgs) Handles lblCalibration.Click

    End Sub
End Class