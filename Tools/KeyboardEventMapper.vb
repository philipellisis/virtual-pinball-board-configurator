Imports System.Runtime.InteropServices

Public Class KeyboardEventMapper
    <DllImport("user32.dll")>
    Public Shared Function GetAsyncKeyState(ByVal vKey As System.Windows.Forms.Keys) As Short
    End Function
    Const VK_BACK = &H8&
    Const VK_TAB = &H9&
    Const VK_RETURN = &HD&
    Const VK_PAUSE = &H13&
    Const VK_CAPITAL = &H14&
    Const VK_ESCAPE = &H1B&
    Const VK_SPACE = &H20&
    Const VK_PRIOR = &H21&
    Const VK_NEXT = &H22&
    Const VK_END = &H23&
    Const VK_HOME = &H24&
    Const VK_LEFT = &H25&
    Const VK_UP = &H26&
    Const VK_RIGHT = &H27&
    Const VK_DOWN = &H28&
    Const VK_SNAPSHOT = &H2C&
    Const VK_INSERT = &H2D&
    Const VK_DELETE = &H2E&
    Const VK_0 = &H30&
    Const VK_1 = &H31&
    Const VK_2 = &H32&
    Const VK_3 = &H33&
    Const VK_4 = &H34&
    Const VK_5 = &H35&
    Const VK_6 = &H36&
    Const VK_7 = &H37&
    Const VK_8 = &H38&
    Const VK_9 = &H39&
    Const VK_A = &H41&
    Const VK_B = &H42&
    Const VK_C = &H43&
    Const VK_D = &H44&
    Const VK_E = &H45&
    Const VK_F = &H46&
    Const VK_G = &H47&
    Const VK_H = &H48&
    Const VK_I = &H49&
    Const VK_J = &H4A&
    Const VK_K = &H4B&
    Const VK_L = &H4C&
    Const VK_M = &H4D&
    Const VK_N = &H4E&
    Const VK_O = &H4F&
    Const VK_P = &H50&
    Const VK_Q = &H51&
    Const VK_R = &H52&
    Const VK_S = &H53&
    Const VK_T = &H54&
    Const VK_U = &H55&
    Const VK_V = &H56&
    Const VK_W = &H57&
    Const VK_X = &H58&
    Const VK_Y = &H59&
    Const VK_Z = &H5A&
    Const VK_LWIN = &H5B&
    Const VK_RWIN = &H5C&
    Const VK_NUMPAD0 = &H60&
    Const VK_NUMPAD1 = &H61&
    Const VK_NUMPAD2 = &H62&
    Const VK_NUMPAD3 = &H63&
    Const VK_NUMPAD4 = &H64&
    Const VK_NUMPAD5 = &H65&
    Const VK_NUMPAD6 = &H66&
    Const VK_NUMPAD7 = &H67&
    Const VK_NUMPAD8 = &H68&
    Const VK_NUMPAD9 = &H69&
    Const VK_MULTIPLY = &H6A&
    Const VK_ADD = &H6B&
    Const VK_SEPARATOR = &H6C&
    Const VK_SUBTRACT = &H6D&
    Const VK_DECIMAL = &H6E&
    Const VK_DIVIDE = &H6F&
    Const VK_F1 = &H70&
    Const VK_F2 = &H71&
    Const VK_F3 = &H72&
    Const VK_F4 = &H73&
    Const VK_F5 = &H74&
    Const VK_F6 = &H75&
    Const VK_F7 = &H76&
    Const VK_F8 = &H77&
    Const VK_F9 = &H78&
    Const VK_F10 = &H79&
    Const VK_F11 = &H7A&
    Const VK_F12 = &H7B&
    Const VK_F13 = &H7C&
    Const VK_F14 = &H7D&
    Const VK_F15 = &H7E&
    Const VK_F16 = &H7F&
    Const VK_F17 = &H80&
    Const VK_F18 = &H81&
    Const VK_F19 = &H82&
    Const VK_F20 = &H83&
    Const VK_F21 = &H84&
    Const VK_F22 = &H85&
    Const VK_F23 = &H86&
    Const VK_F24 = &H87&
    Const VK_NUMLOCK = &H90&
    Const VK_SCROLL = &H91&
    Const VK_LSHIFT = &HA0&
    Const VK_RSHIFT = &HA1&
    Const VK_LCONTROL = &HA2&
    Const VK_RCONTROL = &HA3&
    Const VK_LMENU = &HA4&
    Const VK_RMENU = &HA5&



    Public Shared Function getKeyboardPressNumber(originalNumber As Keys) As Byte
        If (GetAsyncKeyState(VK_BACK) And &H8000) Then Return 178
        If (GetAsyncKeyState(VK_TAB) And &H8000) Then Return 179
        If (GetAsyncKeyState(VK_RETURN) And &H8000) Then Return 176
        If (GetAsyncKeyState(VK_PAUSE) And &H8000) Then Return 208
        If (GetAsyncKeyState(VK_CAPITAL) And &H8000) Then Return 193
        If (GetAsyncKeyState(VK_ESCAPE) And &H8000) Then Return 177
        If (GetAsyncKeyState(VK_SPACE) And &H8000) Then Return 32
        If (GetAsyncKeyState(VK_PRIOR) And &H8000) Then Return 211
        If (GetAsyncKeyState(VK_NEXT) And &H8000) Then Return 214
        If (GetAsyncKeyState(VK_END) And &H8000) Then Return 213
        If (GetAsyncKeyState(VK_HOME) And &H8000) Then Return 210
        If (GetAsyncKeyState(VK_LEFT) And &H8000) Then Return 216
        If (GetAsyncKeyState(VK_UP) And &H8000) Then Return 218
        If (GetAsyncKeyState(VK_RIGHT) And &H8000) Then Return 215
        If (GetAsyncKeyState(VK_DOWN) And &H8000) Then Return 217
        If (GetAsyncKeyState(VK_SNAPSHOT) And &H8000) Then Return 206
        If (GetAsyncKeyState(VK_INSERT) And &H8000) Then Return 209
        If (GetAsyncKeyState(VK_DELETE) And &H8000) Then Return 212
        If (GetAsyncKeyState(VK_0) And &H8000) Then Return 48
        If (GetAsyncKeyState(VK_1) And &H8000) Then Return 49
        If (GetAsyncKeyState(VK_2) And &H8000) Then Return 50
        If (GetAsyncKeyState(VK_3) And &H8000) Then Return 51
        If (GetAsyncKeyState(VK_4) And &H8000) Then Return 52
        If (GetAsyncKeyState(VK_5) And &H8000) Then Return 53
        If (GetAsyncKeyState(VK_6) And &H8000) Then Return 54
        If (GetAsyncKeyState(VK_7) And &H8000) Then Return 55
        If (GetAsyncKeyState(VK_8) And &H8000) Then Return 56
        If (GetAsyncKeyState(VK_9) And &H8000) Then Return 57
        If (GetAsyncKeyState(VK_A) And &H8000) Then Return 65
        If (GetAsyncKeyState(VK_B) And &H8000) Then Return 66
        If (GetAsyncKeyState(VK_C) And &H8000) Then Return 67
        If (GetAsyncKeyState(VK_D) And &H8000) Then Return 68
        If (GetAsyncKeyState(VK_E) And &H8000) Then Return 69
        If (GetAsyncKeyState(VK_F) And &H8000) Then Return 70
        If (GetAsyncKeyState(VK_G) And &H8000) Then Return 71
        If (GetAsyncKeyState(VK_H) And &H8000) Then Return 72
        If (GetAsyncKeyState(VK_I) And &H8000) Then Return 73
        If (GetAsyncKeyState(VK_J) And &H8000) Then Return 74
        If (GetAsyncKeyState(VK_K) And &H8000) Then Return 75
        If (GetAsyncKeyState(VK_L) And &H8000) Then Return 76
        If (GetAsyncKeyState(VK_M) And &H8000) Then Return 77
        If (GetAsyncKeyState(VK_N) And &H8000) Then Return 78
        If (GetAsyncKeyState(VK_O) And &H8000) Then Return 79
        If (GetAsyncKeyState(VK_P) And &H8000) Then Return 80
        If (GetAsyncKeyState(VK_Q) And &H8000) Then Return 81
        If (GetAsyncKeyState(VK_R) And &H8000) Then Return 82
        If (GetAsyncKeyState(VK_S) And &H8000) Then Return 83
        If (GetAsyncKeyState(VK_T) And &H8000) Then Return 84
        If (GetAsyncKeyState(VK_U) And &H8000) Then Return 85
        If (GetAsyncKeyState(VK_V) And &H8000) Then Return 86
        If (GetAsyncKeyState(VK_W) And &H8000) Then Return 87
        If (GetAsyncKeyState(VK_X) And &H8000) Then Return 88
        If (GetAsyncKeyState(VK_Y) And &H8000) Then Return 89
        If (GetAsyncKeyState(VK_Z) And &H8000) Then Return 90
        If (GetAsyncKeyState(VK_LWIN) And &H8000) Then Return 131
        If (GetAsyncKeyState(VK_RWIN) And &H8000) Then Return 135
        If (GetAsyncKeyState(VK_NUMPAD0) And &H8000) Then Return 234
        If (GetAsyncKeyState(VK_NUMPAD1) And &H8000) Then Return 225
        If (GetAsyncKeyState(VK_NUMPAD2) And &H8000) Then Return 226
        If (GetAsyncKeyState(VK_NUMPAD3) And &H8000) Then Return 227
        If (GetAsyncKeyState(VK_NUMPAD4) And &H8000) Then Return 228
        If (GetAsyncKeyState(VK_NUMPAD5) And &H8000) Then Return 229
        If (GetAsyncKeyState(VK_NUMPAD6) And &H8000) Then Return 230
        If (GetAsyncKeyState(VK_NUMPAD7) And &H8000) Then Return 231
        If (GetAsyncKeyState(VK_NUMPAD8) And &H8000) Then Return 232
        If (GetAsyncKeyState(VK_NUMPAD9) And &H8000) Then Return 233
        If (GetAsyncKeyState(VK_MULTIPLY) And &H8000) Then Return 221
        If (GetAsyncKeyState(VK_ADD) And &H8000) Then Return 223
        If (GetAsyncKeyState(VK_SEPARATOR) And &H8000) Then Return 224
        If (GetAsyncKeyState(VK_SUBTRACT) And &H8000) Then Return 222
        If (GetAsyncKeyState(VK_DECIMAL) And &H8000) Then Return 235
        If (GetAsyncKeyState(VK_DIVIDE) And &H8000) Then Return 220
        If (GetAsyncKeyState(VK_F1) And &H8000) Then Return 194
        If (GetAsyncKeyState(VK_F2) And &H8000) Then Return 195
        If (GetAsyncKeyState(VK_F3) And &H8000) Then Return 196
        If (GetAsyncKeyState(VK_F4) And &H8000) Then Return 197
        If (GetAsyncKeyState(VK_F5) And &H8000) Then Return 198
        If (GetAsyncKeyState(VK_F6) And &H8000) Then Return 199
        If (GetAsyncKeyState(VK_F7) And &H8000) Then Return 200
        If (GetAsyncKeyState(VK_F8) And &H8000) Then Return 201
        If (GetAsyncKeyState(VK_F9) And &H8000) Then Return 202
        If (GetAsyncKeyState(VK_F10) And &H8000) Then Return 203
        If (GetAsyncKeyState(VK_F11) And &H8000) Then Return 204
        If (GetAsyncKeyState(VK_F12) And &H8000) Then Return 205
        If (GetAsyncKeyState(VK_F13) And &H8000) Then Return 240
        If (GetAsyncKeyState(VK_F14) And &H8000) Then Return 241
        If (GetAsyncKeyState(VK_F15) And &H8000) Then Return 242
        If (GetAsyncKeyState(VK_F16) And &H8000) Then Return 243
        If (GetAsyncKeyState(VK_F17) And &H8000) Then Return 244
        If (GetAsyncKeyState(VK_F18) And &H8000) Then Return 245
        If (GetAsyncKeyState(VK_F19) And &H8000) Then Return 246
        If (GetAsyncKeyState(VK_F20) And &H8000) Then Return 247
        If (GetAsyncKeyState(VK_F21) And &H8000) Then Return 248
        If (GetAsyncKeyState(VK_F22) And &H8000) Then Return 249
        If (GetAsyncKeyState(VK_F23) And &H8000) Then Return 250
        If (GetAsyncKeyState(VK_F24) And &H8000) Then Return 251
        If (GetAsyncKeyState(VK_NUMLOCK) And &H8000) Then Return 219
        If (GetAsyncKeyState(VK_SCROLL) And &H8000) Then Return 207
        If (GetAsyncKeyState(VK_LSHIFT) And &H8000) Then Return 129
        If (GetAsyncKeyState(VK_RSHIFT) And &H8000) Then Return 133
        If (GetAsyncKeyState(VK_LCONTROL) And &H8000) Then Return 128
        If (GetAsyncKeyState(VK_RCONTROL) And &H8000) Then Return 132
        If (GetAsyncKeyState(VK_LMENU) And &H8000) Then Return 130
        If (GetAsyncKeyState(VK_RMENU) And &H8000) Then Return 134
        Return CByte(originalNumber.ToString)
    End Function

    Public Shared Function NumberToText(number As Byte) As String
        If number = 178 Then Return "BACKSPACE key"
        If number = 179 Then Return "TAB key"
        If number = 176 Then Return "ENTER key"
        If number = 208 Then Return "PAUSE key"
        If number = 193 Then Return "CAPS LOCK key"
        If number = 177 Then Return "ESC key"
        If number = 32 Then Return "SPACEBAR"
        If number = 211 Then Return "PAGE UP key"
        If number = 214 Then Return "PAGE DOWN key"
        If number = 213 Then Return "END key"
        If number = 210 Then Return "HOME key"
        If number = 216 Then Return "LEFT ARROW key"
        If number = 218 Then Return "UP ARROW key"
        If number = 215 Then Return "RIGHT ARROW key"
        If number = 217 Then Return "DOWN ARROW key"
        If number = 206 Then Return "PRINT SCREEN key"
        If number = 209 Then Return "INS key"
        If number = 212 Then Return "DEL key"
        If number = 44 Then Return ", key"
        If number = 45 Then Return "- key"
        If number = 46 Then Return ". key"
        If number = 47 Then Return "/ key"
        If number = 48 Then Return "0 key"
        If number = 49 Then Return "1 key"
        If number = 50 Then Return "2 key"
        If number = 51 Then Return "3 key"
        If number = 52 Then Return "4 key"
        If number = 53 Then Return "5 key"
        If number = 54 Then Return "6 key"
        If number = 55 Then Return "7 key"
        If number = 56 Then Return "8 key"
        If number = 57 Then Return "9 key"
        If number = 59 Then Return "; key"
        If number = 61 Then Return "= key"
        If number = 65 Then Return "A key"
        If number = 66 Then Return "B key"
        If number = 67 Then Return "C key"
        If number = 68 Then Return "D key"
        If number = 69 Then Return "E key"
        If number = 70 Then Return "F key"
        If number = 71 Then Return "G key"
        If number = 72 Then Return "H key"
        If number = 73 Then Return "I key"
        If number = 74 Then Return "J key"
        If number = 75 Then Return "K key"
        If number = 76 Then Return "L key"
        If number = 77 Then Return "M key"
        If number = 78 Then Return "N key"
        If number = 79 Then Return "O key"
        If number = 80 Then Return "P key"
        If number = 81 Then Return "Q key"
        If number = 82 Then Return "R key"
        If number = 83 Then Return "S key"
        If number = 84 Then Return "T key"
        If number = 85 Then Return "U key"
        If number = 86 Then Return "V key"
        If number = 87 Then Return "W key"
        If number = 88 Then Return "X key"
        If number = 89 Then Return "Y key"
        If number = 90 Then Return "Z key"
        If number = 91 Then Return "[ key"
        If number = 92 Then Return "\ key"
        If number = 93 Then Return "] key"
        If number = 96 Then Return "` key"
        If number = 131 Then Return "Left Windows key"
        If number = 135 Then Return "Right Windows key"
        If number = 234 Then Return "Numeric keypad 0 key"
        If number = 225 Then Return "Numeric keypad 1 key"
        If number = 226 Then Return "Numeric keypad 2 key"
        If number = 227 Then Return "Numeric keypad 3 key"
        If number = 228 Then Return "Numeric keypad 4 key"
        If number = 229 Then Return "Numeric keypad 5 key"
        If number = 230 Then Return "Numeric keypad 6 key"
        If number = 231 Then Return "Numeric keypad 7 key"
        If number = 232 Then Return "Numeric keypad 8 key"
        If number = 233 Then Return "Numeric keypad 9 key"
        If number = 221 Then Return "Multiply key"
        If number = 223 Then Return "Add key"
        If number = 224 Then Return "Separator key"
        If number = 222 Then Return "Subtract key"
        If number = 235 Then Return "Decimal key"
        If number = 220 Then Return "Divide key"
        If number = 194 Then Return "F1 key"
        If number = 195 Then Return "F2 key"
        If number = 196 Then Return "F3 key"
        If number = 197 Then Return "F4 key"
        If number = 198 Then Return "F5 key"
        If number = 199 Then Return "F6 key"
        If number = 200 Then Return "F7 key"
        If number = 201 Then Return "F8 key"
        If number = 202 Then Return "F9 key"
        If number = 203 Then Return "F10 key"
        If number = 204 Then Return "F11 key"
        If number = 205 Then Return "F12 key"
        If number = 240 Then Return "F13 key"
        If number = 241 Then Return "F14 key"
        If number = 242 Then Return "F15 key"
        If number = 243 Then Return "F16 key"
        If number = 244 Then Return "F17 key"
        If number = 245 Then Return "F18 key"
        If number = 246 Then Return "F19 key"
        If number = 247 Then Return "F20 key"
        If number = 248 Then Return "F21 key"
        If number = 249 Then Return "F22 key"
        If number = 250 Then Return "F23 key"
        If number = 251 Then Return "F24 key"
        If number = 219 Then Return "NUM LOCK key"
        If number = 207 Then Return "SCROLL LOCK key"
        If number = 129 Then Return "Left SHIFT key"
        If number = 133 Then Return "Right SHIFT key"
        If number = 128 Then Return "Left CONTROL key"
        If number = 132 Then Return "Right CONTROL key"
        If number = 130 Then Return "Left ALT key"
        If number = 134 Then Return "Right ALT key"
        If number = 0 Then Return "None"
        Return number.ToString()
    End Function
End Class
