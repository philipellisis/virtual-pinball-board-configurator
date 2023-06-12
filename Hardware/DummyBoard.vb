Imports System.Drawing.Text
Imports System.Runtime.Remoting.Contexts
Imports System.Threading

Public Class DummyBoard

    Implements BoardInterface
    Private trd As Thread
    Private outputs As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Private inputs As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Private plunger As Integer = 0
    Private threadContinue As Boolean = False
    Private context As Threading.SynchronizationContext = Threading.SynchronizationContext.Current
    Public Sub setOutputValue(output As Integer, value As Integer) Implements BoardInterface.setOutputValue
        outputs(output) = value
    End Sub

    Public Sub enableAdminFunction(admin As ADMIN) Implements BoardInterface.enableAdminFunction
        If admin = ADMIN.OUTPUTS Then
            threadContinue = True
            trd = New Thread(AddressOf simulateOutputAdmin)
            trd.IsBackground = True
            trd.Start()

        End If
        If admin = ADMIN.BUTTONS Then
            threadContinue = True
            trd = New Thread(AddressOf simulateButtonAdmin)
            trd.IsBackground = True
            trd.Start()
        End If
        If admin = ADMIN.PLUNGER Then
            threadContinue = True
            trd = New Thread(AddressOf simulatePlungerAdmin)
            trd.IsBackground = True
            trd.Start()
        End If
        If admin = ADMIN.SEND_CONFIG Then
            trd = New Thread(AddressOf simulateConfigAdmin)
            trd.IsBackground = True
            trd.Start()
        End If
        If admin = ADMIN.OFF Then
            threadContinue = False
        End If
    End Sub

    Public Sub setPlungerMinMax(mmax As UShort, min As UShort, mid As UShort) Implements BoardInterface.setPlungerMinMax

    End Sub

    Public Sub setAccelerometerValues(multiplier As UShort, deadZone As UShort, orientation As Byte) Implements BoardInterface.setAccelerometerValues

    End Sub

    Public Sub setConfig(config As BoardConfiguration) Implements BoardInterface.setConfig
        Throw New NotImplementedException()
    End Sub

    Public Function saveConfigToEeprom() Implements BoardInterface.saveConfigToEeprom
        Throw New NotImplementedException()
    End Function

    Public Sub connect() Implements BoardInterface.connect

    End Sub
    Public Sub disconnect() Implements BoardInterface.disconnect

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
            Dim outputString As String = ""

            For i As Integer = 0 To 61
                outputString += outputs(i).ToString & ","
            Next
            outputString += outputs(62).ToString
            sendBoardChanged(New BoardChangedArgs(outputString, MESSAGE_TYPE.OUTPUTS))
            Threading.Thread.Sleep(300)
        End While

    End Sub

    Private Sub simulateConfigAdmin()
        Threading.Thread.Sleep(300)
        Dim outputString As String = ""

        For i As Integer = 0 To 62
            outputString += outputs(i).ToString & ","
        Next

        For i As Integer = 0 To 62
            outputString += outputs(i).ToString & ","
        Next

        For i As Integer = 0 To 62
            outputString += outputs(i).ToString & ","
        Next

        For i As Integer = 0 To 62
            outputString += outputs(i).ToString & ","
        Next
        outputString += "1000,"
        outputString += "100,"
        outputString += "200,"
        For i As Integer = 0 To 3
            outputString += outputs(i).ToString & ","
        Next
        For i As Integer = 0 To 3
            outputString += outputs(i).ToString & ","
        Next
        outputString += "1,"
        outputString += "1,END_CONFIG"
        sendBoardChanged(New BoardChangedArgs(outputString, MESSAGE_TYPE.CONFIG))
        Threading.Thread.Sleep(300)

    End Sub
    Private Sub simulateButtonAdmin()
        While threadContinue = True
            Dim outputString As String = ""

            For i As Integer = 0 To 22
                outputString += inputs(i).ToString & ","
            Next
            outputString += inputs(23).ToString
            sendBoardChanged(New BoardChangedArgs(outputString, MESSAGE_TYPE.BUTTONS))
            Threading.Thread.Sleep(300)
        End While

    End Sub
    Private Sub simulatePlungerAdmin()
        While threadContinue = True
            If plunger <= 975 Then
                plunger += 50
            Else
                plunger = 0
            End If

            sendBoardChanged(New BoardChangedArgs(plunger.ToString, MESSAGE_TYPE.PLUNGER))
            Threading.Thread.Sleep(100)
        End While

    End Sub
    Private Function getRandomValue() As String
        Return (CInt(Math.Ceiling(Rnd() * 255)) + 1).ToString
    End Function

    Public Sub sendRaw(value() As Byte) Implements BoardInterface.sendRaw

    End Sub

    Public Function setBootloader() As String Implements BoardInterface.setBootloader
        Return "COM1"
    End Function
End Class
