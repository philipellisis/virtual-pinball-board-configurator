Public Class Plunger
    Private WithEvents _board As BoardInterface
    Private _config As BoardConfiguration
    Private maxValue As UShort = 0
    Private minvalue As UShort = 1024
    Private tempRestingValue As UShort = 0
    Private restingValue As UShort = 0
    Private restingCount As UShort = 0
    Public Sub New(board As BoardInterface, config As BoardConfiguration)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _board = board
        _config = config
    End Sub
    Private Sub Plunger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _board.enableAdminFunction(ADMIN.PLUNGER)
    End Sub

    Private Sub _board_BoardChanged(sender As Object, e As BoardChangedArgs) Handles _board.BoardChanged
        If e.type = MESSAGE_TYPE.PLUNGER Then
            pbPlunger.Value = e.plunger + 1
            pbPlunger.Value = e.plunger
            If maxValue < e.plunger Then
                maxValue = e.plunger
                lblMaxValue.Text = e.plunger.ToString
            End If
            If minvalue > e.plunger Then
                minvalue = e.plunger
                lblMinValue.Text = e.plunger.ToString
            End If
            If tempRestingValue > e.plunger - 2 And tempRestingValue < e.plunger + 2 Then
                restingCount += 1
            Else
                tempRestingValue = e.plunger
                restingCount = 0
            End If

            If restingCount > 50 Then
                lblRestingPoint.Text = e.plunger.ToString
                restingValue = e.plunger
            End If
        End If
        If e.type = MESSAGE_TYPE.RESPONSE Then
            MessageBox.Show(e.message)
        End If


    End Sub
    Private Sub Outputs_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _board.enableAdminFunction(ADMIN.OFF)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _board.setPlungerMinMax(maxValue, minvalue, restingValue)
        _config.plungerMax = maxValue
        _config.plungerMin = minvalue
        _config.plungerMid = restingValue
    End Sub
End Class