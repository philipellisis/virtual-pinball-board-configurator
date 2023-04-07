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
    Public type As MESSAGE_TYPE
    Public Sub New(message As String, status As MESSAGE_TYPE)
        Me.message = message
        Me.type = status
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
    Function getOutputValue() As Integer()
    Function getButtonState() As Boolean()
    Function getPlungerValue() As Integer
    Function getNudgeValue() As System.Drawing.Point
    Sub setPlungerMinMax(max As Integer, min As Integer)
    Sub setConfig(config As Configuration)
    Function getConfig() As Configuration
    Sub connect()

End Interface
