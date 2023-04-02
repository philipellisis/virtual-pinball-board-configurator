Imports System.Drawing.Text
Imports System.Runtime.Remoting.Contexts
Imports System.Threading

Public Class DummyBoard

    Implements BoardInterface
    Private trd As Thread
    Private threadContinue As Boolean = False
    Private context As Threading.SynchronizationContext = Threading.SynchronizationContext.Current
    Public Sub setOutputValue(output As Integer, value As Integer) Implements BoardInterface.setOutputValue
        Throw New NotImplementedException()
    End Sub

    Public Sub enableAdminFunction(admin As ADMIN) Implements BoardInterface.enableAdminFunction
        If admin = ADMIN.OUTPUTS Then
            threadContinue = True
            trd = New Thread(AddressOf simulateOutputAdmin)
            trd.IsBackground = True
            trd.Start()

        End If
        If admin = ADMIN.OFF Then
            threadContinue = False
        End If
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

    Private Sub simulateOutputAdmin()
        While threadContinue = True
            Dim outputString As String = getRandomValue() & ","

            For i As Integer = 1 To 61
                outputString += "0,"
            Next
            outputString += "0"
            sendBoardChanged(New BoardChangedArgs(outputString, "Connected"))
            Threading.Thread.Sleep(300)
        End While

    End Sub
    Private Function getRandomValue() As String
        Return (CInt(Math.Ceiling(Rnd() * 255)) + 1).ToString
    End Function
End Class
