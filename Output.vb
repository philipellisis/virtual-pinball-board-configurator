Imports System.Threading

Public Class Output
    Private _board As BoardInterface
    Private _number As Byte
    Private _delayRefresh As Boolean = False
    Private _intensityValue As Byte = 0
    Private trd As Thread = New Thread(AddressOf delayRefresh)
    Private trdCount As Integer = 5
    Public Sub New(board As BoardInterface, outputNumber As Byte)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _board = board
        _number = outputNumber
        gbMain.Text = "Output #" & (outputNumber + 1).ToString
    End Sub
    Public Sub setIntensityValue(val As Byte)
        If _delayRefresh = False Then
            tbIntensity.Value = val
            lblValue.Text = val.ToString
            setButton(tbIntensity.Value)
        End If

    End Sub

    Private Sub btnOnOff_Click(sender As Object, e As EventArgs) Handles btnOnOff.Click
        If tbIntensity.Value = 0 Then
            _board.setOutputValue(_number, 255)
        Else
            _board.setOutputValue(_number, 0)
        End If

    End Sub

    Private Sub tbIntensity_Scroll(sender As Object, e As EventArgs) Handles tbIntensity.Scroll
        _delayRefresh = True
        'setButton(tbIntensity.Value)
        _intensityValue = tbIntensity.Value
        lblValue.Text = _intensityValue
        If trd.IsAlive = False Then
            Console.WriteLine("starting new thread")
            trd = New Thread(AddressOf delayRefresh)
            trd.IsBackground = True
            trd.Start()
        Else
            trdCount = 5
            Console.WriteLine("making thread last longer")
        End If

    End Sub

    Sub delayRefresh()
        Do Until trdCount = 0
            Thread.Sleep(100)
            trdCount -= 1
        Loop
        trdCount = 5
        _board.setOutputValue(_number, _intensityValue)
        Thread.Sleep(500)
        _delayRefresh = False
    End Sub
    Private Sub setButton(val As Integer)
        If val > 0 Then
            btnOnOff.Text = "On"
            btnOnOff.BackColor = Color.DarkGreen
        Else
            btnOnOff.Text = "Off"
            btnOnOff.BackColor = Color.Red
        End If
    End Sub
End Class
