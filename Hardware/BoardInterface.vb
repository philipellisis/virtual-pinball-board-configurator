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
End Enum

Public Enum MESSAGE_TYPE
    DEBUG = 0
    OUTPUTS = 1
    PLUNGER = 2
    ACCEL = 3
    CONFIG = 4
    BUTTONS = 5
End Enum

Public Class Configuration
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
End Class

Public Class BoardChangedArgs
    Public message As String
    Public outputs As Byte()
    Public buttons As Byte()
    Public plunger As Integer
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
    Sub setConfig(config As Configuration)
    Function getConfig() As Configuration
    Sub connect()

End Interface
