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
End Enum

Public Enum MESSAGE_TYPE
    DEBUG = 0
    OUTPUTS = 1
    PLUNGER = 2
    ACCEL = 3
    CONFIG = 4
    BUTTONS = 5
    RESPONSE = 6
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
    Public Function getOrientationString() As String
        If orentation = 0 Then
            Return "USB Facing Back"
        End If
        If orentation = 1 Then
            Return "USB Facing Right"
        End If
        If orentation = 2 Then
            Return "USB Facing Left"
        End If
        If orentation = 3 Then
            Return "USB Facing Front"
        End If
    End Function
    Public Function setOrientationString(orientation As String)
        If orientation = "USB Facing Back" Then
            Me.orentation = 0
        End If
        If orientation = "USB Facing Right" Then
            Me.orentation = 1
        End If
        If orientation = "USB Facing Left" Then
            Me.orentation = 2
        End If
        If orientation = "USB Facing Front" Then
            Me.orentation = 3
        End If
    End Function

    Public Function toConfigBytes(config As BoardConfiguration) As Byte()
        Dim configString(267) As Byte
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
        Return configString
    End Function
    Public Shared Function stringToConfig(str As String) As BoardConfiguration
        Dim config As New BoardConfiguration
        Try
            Dim configString = str.Split(",")
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

        Catch ex As Exception
            Console.WriteLine("unable to convert data to configuration: " & ex.Message)
        End Try

        Return config
    End Function
End Class

Public Class BoardChangedArgs
    Public message As String
    Public outputs As Byte()
    Public buttons As Byte()
    Public plunger As Integer
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
            Case MESSAGE_TYPE.CONFIG
                Try
                    config = BoardConfiguration.stringToConfig(message)
                Catch ex As Exception
                    Me.type = MESSAGE_TYPE.DEBUG
                End Try
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

    Sub enableAdminFunction(admin As ADMIN)

    Sub setPlungerMinMax(max As UShort, min As UShort, mid As UShort)
    Sub setConfig(config As BoardConfiguration)
    Function saveConfigToEeprom()
    Sub connect()

End Interface
