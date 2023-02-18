Public Enum ORIENTATION
    UP
    DOWN
    LEFT
    RIGHT
End Enum

Public Interface BoardInterface
    Sub setOutputValue(output As Integer, value As Integer)
    Function getOutputValue(output As Integer) As Integer
    Function getButtonState(Input As Integer) As Boolean
    Function getPlungerValue() As Integer
    Function getNudgeValue() As System.Drawing.Point
    Function setPlungerMinMax(max As Integer, min As Integer)
    Function setOrientation(orientation As ORIENTATION)
    Function setLeftFlipperButton(button As Integer)
    Function setRightFlipperButton(button As Integer)
    Sub setOutputMaxOnTime(output As Integer, valueInMS As Integer)
    Sub setFlipperLogic(output As Integer, holdValue As Integer, highOutputTime As Integer)
    Sub setMaxOutputValue(output As Integer, maxValue As Integer)
End Interface
