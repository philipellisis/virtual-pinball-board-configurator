﻿Imports System.Globalization
Imports System.Runtime.InteropServices.WindowsRuntime

Public Enum ORIENTATION
    UP
    DOWN
    LEFT
    RIGHT
End Enum

Public Enum ADMIN
    BUTTONS = 1
    OUTPUTS = 2
    PLUNGER = 3
    ACCEL = 4
    SEND_CONFIG = 5
    GET_CONFIG = 6
    SET_PLUNGER = 7
    OFF = 255
    CONNECT = 8
    SAVE_CONFIG = 9
    SET_ACCEL = 10
    GET_VERSION = 11
    RESET = 12
End Enum

Public Enum MESSAGE_TYPE
    DEBUG = 0
    OUTPUTS = 1
    PLUNGER = 2
    ACCEL = 3
    CONFIG = 4
    BUTTONS = 5
    RESPONSE = 6
    VERSION = 7
End Enum

Public Class BoardConfiguration
    Public toySpecialOption(63) As Byte
    Public turnOffState(63) As Byte
    Public maxOutputState(63) As Byte
    Public maxOutputTime(63) As Byte
    Public plungerMax As Int16
    Public plungerMin As Int16
    Public plungerMid As Int16
    Public solenoidButtonMap(4) As Byte
    Public solenoidOutputMap(4) As Byte
    Public orentation As Byte
    Public accelerometer As Boolean
    Public accelerometerMultiplier As Byte
    Public accelerometerDeadZone As Int16
    Public buttonOption As Byte
    Public accelerometerTilt As Int16
    Public accelerometerMax As Int16
    Public accelerometerTiltY As Int16
    Public accelerometerMaxY As Int16
    Public plungerAverageRead As Byte
    Public nightModeButton As Byte
    Public plungerLaunchButton As Byte
    Public tiltButton As Byte
    Public shiftButton As Byte
    Public buttonKeys(32) As Byte
    Public disableAccelOnPlungerMove As Boolean
    Public enablePlungerQuickRelease As Boolean
    Public disablePlungerWhenNotInUse As Boolean
    Public disableButtonPressWhenKeyboardEnabled As Boolean
    Public buttonKeyDebounce(24) As Byte
    Public buttonDebounceCounter As Byte
    Public enablePlunger As Byte
    Public tiltSuppression As Byte
    Public enableLightShowAttract As Byte





    Public Sub copyValues(board As BoardConfiguration)
        Array.Copy(board.toySpecialOption, toySpecialOption, 63)
        Array.Copy(board.turnOffState, turnOffState, 63)
        Array.Copy(board.maxOutputState, maxOutputState, 63)
        Array.Copy(board.maxOutputTime, maxOutputTime, 63)
        plungerMax = board.plungerMax
        plungerMin = board.plungerMin
        plungerMid = board.plungerMid
        Array.Copy(board.solenoidButtonMap, solenoidButtonMap, 4)
        Array.Copy(board.solenoidOutputMap, solenoidOutputMap, 4)
        orentation = board.orentation
        accelerometer = board.accelerometer
        accelerometerMultiplier = board.accelerometerMultiplier
        accelerometerDeadZone = board.accelerometerDeadZone
        buttonOption = board.buttonOption
        accelerometerTilt = board.accelerometerTilt
        accelerometerMax = board.accelerometerMax
        accelerometerTiltY = board.accelerometerTiltY
        accelerometerMaxY = board.accelerometerMaxY
        plungerAverageRead = board.plungerAverageRead
        nightModeButton = board.nightModeButton
        plungerLaunchButton = board.plungerLaunchButton
        tiltButton = board.tiltButton
        shiftButton = board.shiftButton
        Array.Copy(board.buttonKeys, buttonKeys, 32)
        disableAccelOnPlungerMove = board.disableAccelOnPlungerMove
        enablePlungerQuickRelease = board.enablePlungerQuickRelease
        disablePlungerWhenNotInUse = board.disablePlungerWhenNotInUse
        disableButtonPressWhenKeyboardEnabled = board.disableButtonPressWhenKeyboardEnabled

        Array.Copy(board.buttonKeyDebounce, buttonKeyDebounce, 24)
        buttonDebounceCounter = board.buttonDebounceCounter
        enablePlunger = board.enablePlunger
        tiltSuppression = board.tiltSuppression
        enableLightShowAttract = board.enableLightShowAttract
    End Sub
    Public Function getOrientationString() As String
        Dim tempOrientation = orentation
        If tempOrientation > 7 Then
            tempOrientation -= 8
        End If
        If tempOrientation > 3 Then
            tempOrientation -= 4
        End If
        If tempOrientation = 0 Then
            Return "USB Facing Back"
        End If
        If tempOrientation = 1 Then
            Return "USB Facing Right"
        End If
        If tempOrientation = 2 Then
            Return "USB Facing Front"
        End If
        If tempOrientation = 3 Then
            Return "USB Facing Left"
        End If
        Return ""
    End Function
    Public Sub setOrientationString(orientation As String, pins As Boolean, sideMounted As Boolean)
        Me.orentation = getIntegerFromOrientationString(orientation, pins, sideMounted)
    End Sub
    Public Function getIntegerFromOrientationString(orientation As String, pins As Boolean, sideMounted As Boolean) As Integer
        Dim returnValue As Byte
        If orientation = "USB Facing Back" Then
            returnValue = 0
        End If
        If orientation = "USB Facing Right" Then
            returnValue = 1
        End If
        If orientation = "USB Facing Left" Then
            returnValue = 3
        End If
        If orientation = "USB Facing Front" Then
            returnValue = 2
        End If
        If pins Then
            returnValue += 4
        End If
        If sideMounted Then
            returnValue += 8
        End If
        Return returnValue
    End Function

    Public Sub setSensitivityString(sensitivity As String)
        Me.accelerometerMultiplier = getIntegerFromSensitivityString(sensitivity)
    End Sub
    Public Function getIntegerFromSensitivityString(sensitivity As String) As Integer
        If sensitivity = "2G (Most Sensitive)" Then Return 0
        If sensitivity = "4G" Then Return 1
        If sensitivity = "8G" Then Return 2
        If sensitivity = "16G (Least Sensitive)" Then Return 3
    End Function
    Public Function getSensitivityString() As String
        If accelerometerMultiplier = 0 Then
            Return "2G (Most Sensitive)"
        End If
        If accelerometerMultiplier = 1 Then
            Return "4G"
        End If
        If accelerometerMultiplier = 2 Then
            Return "8G"
        End If
        If accelerometerMultiplier = 3 Then
            Return "16G (Least Sensitive)"
        End If
        Return ""
    End Function

    Public Function toConfigBytes(config As BoardConfiguration) As Byte()
        Dim configString(349) As Byte
        For i = 0 To 62
            configString(i) = config.toySpecialOption(i)
            configString(i + 63) = config.turnOffState(i)
            configString(i + 126) = config.maxOutputState(i)
            configString(i + 189) = config.maxOutputTime(i)
        Next
        Dim result As Byte() = BitConverter.GetBytes(config.plungerMax)
        Dim result2 As Byte() = BitConverter.GetBytes(config.plungerMin)
        Dim result3 As Byte() = BitConverter.GetBytes(config.plungerMid)
        configString(252) = result(1)
        configString(253) = result(0)
        configString(254) = result2(1)
        configString(255) = result2(0)
        configString(256) = result3(1)
        configString(257) = result3(0)

        For i = 0 To 3
            configString(i + 258) = config.solenoidButtonMap(i)
            configString(i + 262) = config.solenoidOutputMap(i)
        Next

        configString(266) = config.orentation
        configString(267) = config.accelerometer
        configString(268) = config.accelerometerMultiplier
        Dim result5 As Byte() = BitConverter.GetBytes(config.accelerometerDeadZone)
        configString(269) = result5(1)
        configString(270) = result5(0)
        configString(271) = buttonOption
        Dim result6 As Byte() = BitConverter.GetBytes(config.accelerometerTilt)
        configString(272) = result6(1)
        configString(273) = result6(0)
        Dim result7 As Byte() = BitConverter.GetBytes(config.accelerometerMax)
        configString(274) = result7(1)
        configString(275) = result7(0)
        configString(276) = config.plungerAverageRead
        configString(277) = config.nightModeButton
        configString(278) = config.plungerLaunchButton
        configString(279) = config.tiltButton
        configString(280) = config.shiftButton
        For i = 0 To 31
            configString(i + 281) = config.buttonKeys(i)
        Next

        configString(313) = config.disableAccelOnPlungerMove
        configString(314) = config.enablePlungerQuickRelease
        configString(315) = config.disablePlungerWhenNotInUse
        configString(316) = config.disableButtonPressWhenKeyboardEnabled
        Dim result8 As Byte() = BitConverter.GetBytes(config.accelerometerTiltY)
        configString(317) = result8(1)
        configString(318) = result8(0)
        Dim result9 As Byte() = BitConverter.GetBytes(config.accelerometerMaxY)
        configString(319) = result9(1)
        configString(320) = result9(0)

        For i = 0 To 23
            configString(i + 321) = config.buttonKeyDebounce(i)
        Next

        configString(345) = config.buttonDebounceCounter
        configString(346) = config.enablePlunger
        configString(347) = config.tiltSuppression
        configString(348) = config.enableLightShowAttract
        configString(349) = 42

        Return configString
    End Function
    Public Shared Function stringToConfig(str As String) As BoardConfiguration
        Dim config As New BoardConfiguration
        Try
            Dim configString = str.Split(",")
            Console.WriteLine("configString length is " & configString.Length)
            For i = 0 To 62
                config.toySpecialOption(i) = CByte(configString(i))
                config.turnOffState(i) = CByte(configString(i + 63))
                config.maxOutputState(i) = CByte(configString(i + 126))
                config.maxOutputTime(i) = CByte(configString(i + 189))
            Next
            config.plungerMax = CInt(configString(252))
            config.plungerMin = CInt(configString(253))
            config.plungerMid = CInt(configString(254))

            For i = 0 To 3
                config.solenoidButtonMap(i) = CByte(configString(i + 255))
                config.solenoidOutputMap(i) = CByte(configString(i + 259))
            Next

            config.orentation = CByte(configString(263))
            config.accelerometer = CBool(configString(264))
            config.accelerometerMultiplier = CByte(configString(265))
            config.accelerometerDeadZone = CInt(configString(266))
            config.buttonOption = CByte(configString(267))
            config.accelerometerTilt = CInt(configString(268))
            config.accelerometerMax = CInt(configString(269))

            config.plungerAverageRead = CByte(configString(270))
            config.nightModeButton = CByte(configString(271))
            If config.nightModeButton > 47 Then config.nightModeButton = 23
            config.plungerLaunchButton = CByte(configString(272))
            config.tiltButton = CByte(configString(273))
            If config.tiltButton > 28 Then config.tiltButton = 22
            config.shiftButton = CByte(configString(274))

            If config.shiftButton > 28 And config.shiftButton <> 99 Then config.shiftButton = 2
            For i = 0 To 31
                config.buttonKeys(i) = CByte(configString(i + 275))
                If config.buttonKeys(i) = 255 Then config.buttonKeys(i) = 0
            Next

            config.disableAccelOnPlungerMove = CByte(configString(307))
            config.enablePlungerQuickRelease = CByte(configString(308))
            config.disablePlungerWhenNotInUse = CByte(configString(309))
            config.disableButtonPressWhenKeyboardEnabled = CByte(configString(310))
            config.accelerometerTiltY = CInt(configString(311))
            config.accelerometerMaxY = CInt(configString(312))

            For i = 0 To 23
                config.buttonKeyDebounce(i) = CByte(configString(i + 313))
                If config.buttonKeyDebounce(i) = 255 Then config.buttonKeyDebounce(i) = 0
            Next

            config.buttonDebounceCounter = CByte(configString(337))
            If config.buttonDebounceCounter = 255 Then config.buttonDebounceCounter = 0
            config.enablePlunger = CBool(configString(338))
            config.tiltSuppression = CByte(configString(339))
            config.enableLightShowAttract = CBool(configString(340))

            If configString(341) <> "E" Then
                Throw New Exception("error in config string returned!")
            End If


        Catch ex As Exception
            Console.WriteLine("unable to convert data to configuration: " & ex.Message)
            Throw New Exception("error while getting config. Maybe the PinOne is not at the right version? Update firmware and try again.")
        End Try

        Return config
    End Function
End Class

Public Class BoardChangedArgs
    Public message As String
    Public outputs As Byte()
    Public buttons As Byte()
    Public version As Integer() = {0, 0, 0}
    Public plunger As Integer
    Public accel As PointF
    Public accelActual As Point
    Public config As BoardConfiguration
    Public type As MESSAGE_TYPE
    Public Sub New(message As String, status As MESSAGE_TYPE)
        Me.message = message
        Me.type = status
        Select Case status
            Case MESSAGE_TYPE.OUTPUTS
                Try
                    Dim outputValues As String() = message.Split(",")
                    ReDim outputs(outputValues.Length)
                    For i As Integer = 0 To outputValues.Length - 1
                        outputs(i) = CByte(outputValues(i))
                    Next
                Catch ex As Exception
                    Me.type = MESSAGE_TYPE.DEBUG
                End Try
            Case MESSAGE_TYPE.BUTTONS
                Try
                    Dim outputValues As String() = message.Split(",")
                    ReDim buttons(outputValues.Length)
                    For i As Integer = 0 To outputValues.Length - 1
                        buttons(i) = CByte(outputValues(i))
                    Next
                Catch ex As Exception
                    Me.type = MESSAGE_TYPE.DEBUG
                End Try
            Case MESSAGE_TYPE.PLUNGER
                Try
                    plunger = CInt(message)
                Catch ex As Exception
                    Me.type = MESSAGE_TYPE.DEBUG
                End Try
            Case MESSAGE_TYPE.ACCEL
                Try
                    Dim splitMessage = Split(message, ",")
                    accel = New Drawing.PointF(Convert.ToDouble(splitMessage(0), CultureInfo.InvariantCulture), Convert.ToDouble(splitMessage(1), CultureInfo.InvariantCulture))
                    accelActual = New Drawing.Point(CInt(splitMessage(2)), CInt(splitMessage(3)))
                Catch ex As Exception
                    Me.type = MESSAGE_TYPE.DEBUG
                End Try
            Case MESSAGE_TYPE.CONFIG
                Try
                    config = BoardConfiguration.stringToConfig(message)
                Catch ex As Exception
                    Me.type = MESSAGE_TYPE.DEBUG
                    Me.message = "Config Error"
                End Try
            Case MESSAGE_TYPE.VERSION
                Dim versionString As String() = message.Split(".")
                version(0) = CInt(versionString(0))
                version(1) = CInt(versionString(1))
                version(2) = CInt(versionString(2))
            Case Else

        End Select


    End Sub
End Class
Public Class BoardCompletedArgs
    Public message As String
    Public status As String
    Public Sub New(message As String, status As String)
        Me.message = message
        Me.status = status
    End Sub
End Class
Public Interface BoardInterface
    Event BoardChanged As EventHandler(Of BoardChangedArgs)
    Event BoardDisconnected As EventHandler(Of BoardCompletedArgs)
    Sub setOutputValue(output As Integer, value As Integer)

    Sub setButtonValue(button As Integer)

    Sub enableAdminFunction(admin As ADMIN)

    Sub setPlungerMinMax(max As UShort, min As UShort, mid As UShort, buttonOption As Byte, plungerAverageRead As Byte, plungerLaunchButton As Byte)

    Sub setAccelerometerValues(multiplier As Byte, deadZone As UShort, orientation As Byte, tilt As UShort, max As UShort, tiltButton As Byte)
    Sub setConfig(config As BoardConfiguration)
    Function saveConfigToEeprom()
    Sub connect(port As String)

    Sub disconnect()

    Function setBootloader(port As String) As String

    Sub sendRaw(value As Byte())

End Interface
