Public Class FormUtils
    Public Shared Sub setFormColors(ByRef frm As Form)
        'Set the form background and foreground colors
        'for darker grey background use &HFF202020
        frm.BackColor = Color.FromArgb(&HFF102040)
        frm.ForeColor = Color.White
    End Sub
End Class
