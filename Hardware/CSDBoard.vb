Public Class CSDBoard
    Implements BoardInterface


    Public Sub setOutputValue(output As Integer, value As Integer) Implements BoardInterface.setOutputValue
        Throw New NotImplementedException()
    End Sub

    Public Sub setOutputMaxOnTime(output As Integer, valueInMS As Integer) Implements BoardInterface.setOutputMaxOnTime
        Throw New NotImplementedException()
    End Sub

    Public Sub setFlipperLogic(output As Integer, holdValue As Integer, highOutputTime As Integer) Implements BoardInterface.setFlipperLogic
        Throw New NotImplementedException()
    End Sub

    Public Sub setMaxOutputValue(output As Integer, maxValue As Integer) Implements BoardInterface.setMaxOutputValue
        Throw New NotImplementedException()
    End Sub

    Public Function getOutputValue(output As Integer) As Integer Implements BoardInterface.getOutputValue
        Throw New NotImplementedException()
    End Function

    Public Function getButtonState(Input As Integer) As Boolean Implements BoardInterface.getButtonState
        Throw New NotImplementedException()
    End Function

    Public Function getPlungerValue() As Integer Implements BoardInterface.getPlungerValue
        Throw New NotImplementedException()
    End Function

    Public Function getNudgeValue() As Point Implements BoardInterface.getNudgeValue
        Throw New NotImplementedException()
    End Function

    Public Function setPlungerMinMax(max As Integer, min As Integer) As Object Implements BoardInterface.setPlungerMinMax
        Throw New NotImplementedException()
    End Function

    Public Function setOrientation(orientation As ORIENTATION) As Object Implements BoardInterface.setOrientation
        Throw New NotImplementedException()
    End Function

    Public Function setLeftFlipperButton(button As Integer) As Object Implements BoardInterface.setLeftFlipperButton
        Throw New NotImplementedException()
    End Function

    Public Function setRightFlipperButton(button As Integer) As Object Implements BoardInterface.setRightFlipperButton
        Throw New NotImplementedException()
    End Function
End Class
