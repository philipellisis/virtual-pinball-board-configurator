Imports System.Runtime.Remoting.Contexts

Public Class CSDBoard
    Implements BoardInterface
    Private WithEvents CSDConnection As RS232
    Private context As Threading.SynchronizationContext = Threading.SynchronizationContext.Current
    Public Sub setOutputValue(output As Integer, value As Integer) Implements BoardInterface.setOutputValue
        Throw New NotImplementedException()
    End Sub

    Public Function getOutputValue() As Integer() Implements BoardInterface.getOutputValue
        Throw New NotImplementedException()
    End Function

    Public Function getButtonState() As Boolean() Implements BoardInterface.getButtonState
        Throw New NotImplementedException()
    End Function

    Public Function getPlungerValue() As Integer Implements BoardInterface.getPlungerValue
        Throw New NotImplementedException()
    End Function

    Public Function getNudgeValue() As Point Implements BoardInterface.getNudgeValue
        Throw New NotImplementedException()
    End Function

    Public Sub setPlungerMinMax(max As Integer, min As Integer) Implements BoardInterface.setPlungerMinMax
        Throw New NotImplementedException()
    End Sub

    Public Sub setConfig(config As Configuration) Implements BoardInterface.setConfig
        Throw New NotImplementedException()
    End Sub

    Public Function getConfig() As Configuration Implements BoardInterface.getConfig
        Throw New NotImplementedException()
    End Function

    Public Sub connect() Implements BoardInterface.connect
        For Each sp As String In My.Computer.Ports.SerialPortNames

            CSDConnection = New RS232(sp)
            Try
                CSDConnection.open()
                CSDConnection.send({0, 251, 0, 0, 0, 0, 0, 0, 0})
                Dim result As String = CSDConnection.read()
                If result = "CSD Board Connected" Then Return
            Catch ex As Exception

            End Try
        Next
        Throw New Exception("Unable to connect to any board")
    End Sub

    Private Sub OnBoardChanged(ByVal e As BoardChangedArgs)
        RaiseEvent BoardChanged(Me, e)
    End Sub
    Private Sub OnBoardDisconnected(ByVal e As BoardCompletedArgs)
        RaiseEvent BoardDisconnected(Me, e)
    End Sub
    Private Sub sendBoardChanged(e As BoardChangedArgs)
        If context Is Nothing Then
            OnBoardChanged(e)
        Else
            ThreadExtensions.ScSend(context, New Action(Of BoardChangedArgs)(AddressOf OnBoardChanged), e)
        End If
    End Sub

    Public Event BoardChanged As EventHandler(Of BoardChangedArgs) Implements BoardInterface.BoardChanged
    Public Event BoardDisconnected As EventHandler(Of BoardCompletedArgs) Implements BoardInterface.BoardDisconnected

    Private Sub sendBoardDisconnected(e As BoardCompletedArgs)
        If context Is Nothing Then
            OnBoardDisconnected(e)
        Else
            ThreadExtensions.ScSend(context, New Action(Of BoardCompletedArgs)(AddressOf OnBoardDisconnected), e)
        End If
    End Sub
End Class
