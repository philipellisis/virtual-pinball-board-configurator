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
    Const VK_OEM_1 = &HBA&
    Const VK_OEM_PLUS = &HBB&
    Const VK_OEM_COMMA = &HBC&
    Const VK_OEM_MINUS = &HBD&
    Const VK_OEM_PERIOD = &HBE&
    Const VK_OEM_2 = &HBF&
    Const VK_OEM_3 = &HC0&
    Const VK_OEM_4 = &HDB&
    Const VK_OEM_5 = &HDC&
    Const VK_OEM_6 = &HDD&
    Const VK_OEM_7 = &HDE&
    Const VK_VOLUME_MUTE = &HAD&
    Const VK_VOLUME_DOWN = &HAE&
    Const VK_VOLUME_UP = &HAF&





    Public Shared Function getKeyboardPressNumber(originalNumber As Keys) As Byte
        If (GetAsyncKeyState(VK_BACK) And &H8000) Then Return 42
        If (GetAsyncKeyState(VK_TAB) And &H8000) Then Return 43
        If (GetAsyncKeyState(VK_RETURN) And &H8000) Then Return 40
        If (GetAsyncKeyState(VK_PAUSE) And &H8000) Then Return &H48
        If (GetAsyncKeyState(VK_CAPITAL) And &H8000) Then Return 255
        If (GetAsyncKeyState(VK_ESCAPE) And &H8000) Then Return 41
        If (GetAsyncKeyState(VK_SPACE) And &H8000) Then Return 44
        If (GetAsyncKeyState(VK_PRIOR) And &H8000) Then Return &H4E
        If (GetAsyncKeyState(VK_NEXT) And &H8000) Then Return &H4B
        If (GetAsyncKeyState(VK_END) And &H8000) Then Return &H4D
        If (GetAsyncKeyState(VK_HOME) And &H8000) Then Return &H4A
        If (GetAsyncKeyState(VK_LEFT) And &H8000) Then Return &H50
        If (GetAsyncKeyState(VK_UP) And &H8000) Then Return &H52
        If (GetAsyncKeyState(VK_RIGHT) And &H8000) Then Return &H4F
        If (GetAsyncKeyState(VK_DOWN) And &H8000) Then Return &H51
        If (GetAsyncKeyState(VK_SNAPSHOT) And &H8000) Then Return 255
        If (GetAsyncKeyState(VK_INSERT) And &H8000) Then Return &H49
        If (GetAsyncKeyState(VK_DELETE) And &H8000) Then Return &H4C
        If (GetAsyncKeyState(VK_0) And &H8000) Then Return 39
        If (GetAsyncKeyState(VK_1) And &H8000) Then Return 30
        If (GetAsyncKeyState(VK_2) And &H8000) Then Return 31
        If (GetAsyncKeyState(VK_3) And &H8000) Then Return 32
        If (GetAsyncKeyState(VK_4) And &H8000) Then Return 33
        If (GetAsyncKeyState(VK_5) And &H8000) Then Return 34
        If (GetAsyncKeyState(VK_6) And &H8000) Then Return 35
        If (GetAsyncKeyState(VK_7) And &H8000) Then Return 36
        If (GetAsyncKeyState(VK_8) And &H8000) Then Return 37
        If (GetAsyncKeyState(VK_9) And &H8000) Then Return 38
        If (GetAsyncKeyState(VK_A) And &H8000) Then Return 4
        If (GetAsyncKeyState(VK_B) And &H8000) Then Return 5
        If (GetAsyncKeyState(VK_C) And &H8000) Then Return 6
        If (GetAsyncKeyState(VK_D) And &H8000) Then Return 7
        If (GetAsyncKeyState(VK_E) And &H8000) Then Return 8
        If (GetAsyncKeyState(VK_F) And &H8000) Then Return 9
        If (GetAsyncKeyState(VK_G) And &H8000) Then Return 10
        If (GetAsyncKeyState(VK_H) And &H8000) Then Return 11
        If (GetAsyncKeyState(VK_I) And &H8000) Then Return 12
        If (GetAsyncKeyState(VK_J) And &H8000) Then Return 13
        If (GetAsyncKeyState(VK_K) And &H8000) Then Return 14
        If (GetAsyncKeyState(VK_L) And &H8000) Then Return 15
        If (GetAsyncKeyState(VK_M) And &H8000) Then Return 16
        If (GetAsyncKeyState(VK_N) And &H8000) Then Return 17
        If (GetAsyncKeyState(VK_O) And &H8000) Then Return 18
        If (GetAsyncKeyState(VK_P) And &H8000) Then Return 19
        If (GetAsyncKeyState(VK_Q) And &H8000) Then Return 20
        If (GetAsyncKeyState(VK_R) And &H8000) Then Return 21
        If (GetAsyncKeyState(VK_S) And &H8000) Then Return 22
        If (GetAsyncKeyState(VK_T) And &H8000) Then Return 23
        If (GetAsyncKeyState(VK_U) And &H8000) Then Return 24
        If (GetAsyncKeyState(VK_V) And &H8000) Then Return 25
        If (GetAsyncKeyState(VK_W) And &H8000) Then Return 26
        If (GetAsyncKeyState(VK_X) And &H8000) Then Return 27
        If (GetAsyncKeyState(VK_Y) And &H8000) Then Return 28
        If (GetAsyncKeyState(VK_Z) And &H8000) Then Return 29
        If (GetAsyncKeyState(VK_LWIN) And &H8000) Then Return &HE3
        If (GetAsyncKeyState(VK_RWIN) And &H8000) Then Return &HE7
        If (GetAsyncKeyState(VK_NUMPAD0) And &H8000) Then Return &H62
        If (GetAsyncKeyState(VK_NUMPAD1) And &H8000) Then Return &H59
        If (GetAsyncKeyState(VK_NUMPAD2) And &H8000) Then Return &H5A
        If (GetAsyncKeyState(VK_NUMPAD3) And &H8000) Then Return &H5B
        If (GetAsyncKeyState(VK_NUMPAD4) And &H8000) Then Return &H5C
        If (GetAsyncKeyState(VK_NUMPAD5) And &H8000) Then Return &H5D
        If (GetAsyncKeyState(VK_NUMPAD6) And &H8000) Then Return &H5E
        If (GetAsyncKeyState(VK_NUMPAD7) And &H8000) Then Return &H5F
        If (GetAsyncKeyState(VK_NUMPAD8) And &H8000) Then Return &H60
        If (GetAsyncKeyState(VK_NUMPAD9) And &H8000) Then Return &H61
        If (GetAsyncKeyState(VK_MULTIPLY) And &H8000) Then Return &H55
        If (GetAsyncKeyState(VK_ADD) And &H8000) Then Return &H57
        If (GetAsyncKeyState(VK_SEPARATOR) And &H8000) Then Return 255
        If (GetAsyncKeyState(VK_SUBTRACT) And &H8000) Then Return &H56
        If (GetAsyncKeyState(VK_DECIMAL) And &H8000) Then Return &H63
        If (GetAsyncKeyState(VK_DIVIDE) And &H8000) Then Return &H54
        If (GetAsyncKeyState(VK_F1) And &H8000) Then Return &H3A
        If (GetAsyncKeyState(VK_F2) And &H8000) Then Return &H3B
        If (GetAsyncKeyState(VK_F3) And &H8000) Then Return &H3C
        If (GetAsyncKeyState(VK_F4) And &H8000) Then Return &H3D
        If (GetAsyncKeyState(VK_F5) And &H8000) Then Return &H3E
        If (GetAsyncKeyState(VK_F6) And &H8000) Then Return &H3F
        If (GetAsyncKeyState(VK_F7) And &H8000) Then Return &H40
        If (GetAsyncKeyState(VK_F8) And &H8000) Then Return &H41
        If (GetAsyncKeyState(VK_F9) And &H8000) Then Return &H42
        If (GetAsyncKeyState(VK_F10) And &H8000) Then Return &H43
        If (GetAsyncKeyState(VK_F11) And &H8000) Then Return &H44
        If (GetAsyncKeyState(VK_F12) And &H8000) Then Return &H45
        If (GetAsyncKeyState(VK_F13) And &H8000) Then Return &H68
        If (GetAsyncKeyState(VK_F14) And &H8000) Then Return &H69
        If (GetAsyncKeyState(VK_F15) And &H8000) Then Return &H6A
        If (GetAsyncKeyState(VK_F16) And &H8000) Then Return &H6B
        If (GetAsyncKeyState(VK_F17) And &H8000) Then Return &H6C
        If (GetAsyncKeyState(VK_F18) And &H8000) Then Return &H6D
        If (GetAsyncKeyState(VK_F19) And &H8000) Then Return &H6E
        If (GetAsyncKeyState(VK_F20) And &H8000) Then Return &H6F
        If (GetAsyncKeyState(VK_F21) And &H8000) Then Return &H70
        If (GetAsyncKeyState(VK_F22) And &H8000) Then Return &H71
        If (GetAsyncKeyState(VK_F23) And &H8000) Then Return &H72
        If (GetAsyncKeyState(VK_F24) And &H8000) Then Return &H73
        If (GetAsyncKeyState(VK_NUMLOCK) And &H8000) Then Return &H53
        If (GetAsyncKeyState(VK_SCROLL) And &H8000) Then Return &H47
        If (GetAsyncKeyState(VK_LSHIFT) And &H8000) Then Return &HE1
        If (GetAsyncKeyState(VK_RSHIFT) And &H8000) Then Return &HE5
        If (GetAsyncKeyState(VK_LCONTROL) And &H8000) Then Return &HE0
        If (GetAsyncKeyState(VK_RCONTROL) And &H8000) Then Return &HE4
        If (GetAsyncKeyState(VK_LMENU) And &H8000) Then Return &HE2
        If (GetAsyncKeyState(VK_RMENU) And &H8000) Then Return &HE6
        If (GetAsyncKeyState(VK_OEM_1) And &H8000) Then Return 51
        If (GetAsyncKeyState(VK_OEM_PLUS) And &H8000) Then Return 46
        If (GetAsyncKeyState(VK_OEM_COMMA) And &H8000) Then Return 54
        If (GetAsyncKeyState(VK_OEM_MINUS) And &H8000) Then Return 45
        If (GetAsyncKeyState(VK_OEM_PERIOD) And &H8000) Then Return 55
        If (GetAsyncKeyState(VK_OEM_2) And &H8000) Then Return 56
        If (GetAsyncKeyState(VK_OEM_3) And &H8000) Then Return 53
        If (GetAsyncKeyState(VK_OEM_4) And &H8000) Then Return 47
        If (GetAsyncKeyState(VK_OEM_5) And &H8000) Then Return 49
        If (GetAsyncKeyState(VK_OEM_6) And &H8000) Then Return 48
        If (GetAsyncKeyState(VK_OEM_7) And &H8000) Then Return 52
        If (GetAsyncKeyState(VK_VOLUME_MUTE) And &H8000) Then Return 252
        If (GetAsyncKeyState(VK_VOLUME_DOWN) And &H8000) Then Return 253
        If (GetAsyncKeyState(VK_VOLUME_UP) And &H8000) Then Return 254

        If originalNumber = 178 Then Return 42 'backspace
        If originalNumber = 179 Then Return 43 'tab
        If originalNumber = 176 Then Return 40 'enter
        If originalNumber = 208 Then Return &H48 '"PAUSE key"
        If originalNumber = 193 Then Return &H39 '"CAPS LOCK key"
        If originalNumber = 177 Then Return 41 '"ESC key"
        If originalNumber = 32 Then Return 44 ' "SPACEBAR"
        If originalNumber = 211 Then Return &H4B '"PAGE UP key"
        If originalNumber = 214 Then Return &H4E '"PAGE DOWN key"
        If originalNumber = 35 Then Return &H4D '"END key"
        If originalNumber = 210 Then Return &H4A ' "HOME key"
        If originalNumber = 216 Then Return &H50 '"LEFT ARROW key"
        If originalNumber = 218 Then Return &H52 '"UP ARROW key"
        If originalNumber = 215 Then Return &H4F ' "RIGHT ARROW key"
        If originalNumber = 217 Then Return &H51 ' "DOWN ARROW key"
        If originalNumber = 206 Then Return &H46 '"PRINT SCREEN key"
        If originalNumber = 209 Then Return &H49 '"INS key"
        If originalNumber = 212 Then Return &H4C '"DEL key"
        If originalNumber = 44 Then Return 54 '", key"
        If originalNumber = 45 Then Return 45 '"- key"
        If originalNumber = 46 Then Return 55 '". key"
        If originalNumber = 47 Then Return 56 '"/ key"
        If originalNumber = 48 Then Return 39 '"0 key"
        If originalNumber = 49 Then Return 30 '"1 key"
        If originalNumber = 50 Then Return 31 '"2 key"
        If originalNumber = 51 Then Return 32 '"3 key"
        If originalNumber = 52 Then Return 33 '"4 key"
        If originalNumber = 53 Then Return 34 '"5 key"
        If originalNumber = 54 Then Return 35 '"6 key"
        If originalNumber = 55 Then Return 36 '"7 key"
        If originalNumber = 56 Then Return 37 '"8 key"
        If originalNumber = 57 Then Return 38 '"9 key"
        If originalNumber = 59 Then Return 51 '"; key"
        If originalNumber = 61 Then Return 46 '"= key"
        If originalNumber = 97 Then Return 4 '"A key"
        If originalNumber = 98 Then Return 5 ' "B key"
        If originalNumber = 99 Then Return 6 '"C key"
        If originalNumber = 100 Then Return 7 '"D key"
        If originalNumber = 101 Then Return 8 '"E key"
        If originalNumber = 102 Then Return 9 '"F key"
        If originalNumber = 103 Then Return 10 '"G key"
        If originalNumber = 104 Then Return 11 '"H key"
        If originalNumber = 105 Then Return 12 '"I key"
        If originalNumber = 106 Then Return 13 '"J key"
        If originalNumber = 107 Then Return 14 '"K key"
        If originalNumber = 108 Then Return 15 '"L key"
        If originalNumber = 109 Then Return 16 '"M key"
        If originalNumber = 110 Then Return 17 '"N key"
        If originalNumber = 111 Then Return 18 '"O key"
        If originalNumber = 112 Then Return 19 '"P key"
        If originalNumber = 113 Then Return 20 '"Q key"
        If originalNumber = 114 Then Return 21 '"R key"
        If originalNumber = 115 Then Return 22 '"S key"
        If originalNumber = 116 Then Return 23 '"T key"
        If originalNumber = 117 Then Return 24 '"U key"
        If originalNumber = 118 Then Return 25 '"V key"
        If originalNumber = 119 Then Return 26 '"W key"
        If originalNumber = 120 Then Return 27 '"X key"
        If originalNumber = 121 Then Return 28 '"Y key"
        If originalNumber = 122 Then Return 29 '"Z key"
        If originalNumber = 91 Then Return 47 '"[ key"
        If originalNumber = 92 Then Return 49 '"\ key"
        If originalNumber = 93 Then Return 48 '"] key"
        If originalNumber = 96 Then Return 53 '"` key"
        If originalNumber = 131 Then Return &HE3 '"Left Windows key"
        If originalNumber = 135 Then Return &HE7 '"Right Windows key"
        If originalNumber = 234 Then Return &H62 '"Numeric keypad 0 key"
        If originalNumber = 225 Then Return &H59 '"Numeric keypad 1 key"
        If originalNumber = 226 Then Return &H5A '"Numeric keypad 2 key"
        If originalNumber = 227 Then Return &H5B '"Numeric keypad 3 key"
        If originalNumber = 228 Then Return &H5C '"Numeric keypad 4 key"
        If originalNumber = 229 Then Return &H5D '"Numeric keypad 5 key"
        If originalNumber = 230 Then Return &H5E '"Numeric keypad 6 key"
        If originalNumber = 231 Then Return &H5F '"Numeric keypad 7 key"
        If originalNumber = 232 Then Return &H60 '"Numeric keypad 8 key"
        If originalNumber = 233 Then Return &H61 '"Numeric keypad 9 key"
        If originalNumber = 221 Then Return &H55 '"Multiply key"
        If originalNumber = 223 Then Return &H57 '"Add key"
        If originalNumber = 224 Then Return 255 '"Separator key"
        If originalNumber = 222 Then Return &H56 '"Subtract key"
        If originalNumber = 235 Then Return &H63 '"Decimal key"
        If originalNumber = 220 Then Return &H54 '"Divide key"
        If originalNumber = 194 Then Return &H3A '"F1 key"
        If originalNumber = 195 Then Return &H3B '"F2 key"
        If originalNumber = 196 Then Return &H3C '"F3 key"
        If originalNumber = 197 Then Return &H3D '"F4 key"
        If originalNumber = 198 Then Return &H3E '"F5 key"
        If originalNumber = 199 Then Return &H3F '"F6 key"
        If originalNumber = 200 Then Return &H40 '"F7 key"
        If originalNumber = 201 Then Return &H41 '"F8 key"
        If originalNumber = 202 Then Return &H42 '"F9 key"
        If originalNumber = 203 Then Return &H43 '"F10 key"
        If originalNumber = 204 Then Return &H44 '"F11 key"
        If originalNumber = 205 Then Return &H45 '"F12 key"
        If originalNumber = 240 Then Return &H69 '"F13 key"
        If originalNumber = 241 Then Return &H6A '"F14 key"
        If originalNumber = 242 Then Return &H6B '"F15 key"
        If originalNumber = 243 Then Return &H6C '"F16 key"
        If originalNumber = 244 Then Return &H6D '"F17 key"
        If originalNumber = 245 Then Return &H6E '"F18 key"
        If originalNumber = 246 Then Return &H6F '"F19 key"
        If originalNumber = 247 Then Return &H70 '"F20 key"
        If originalNumber = 248 Then Return &H71 '"F21 key"
        If originalNumber = 249 Then Return &H72 '"F22 key"
        If originalNumber = 250 Then Return &H73 '"F23 key"
        If originalNumber = 251 Then Return &H74 '"F24 key"
        If originalNumber = 219 Then Return &H53 '"NUM LOCK key"
        If originalNumber = 207 Then Return &H47 '"SCROLL LOCK key"
        If originalNumber = 129 Then Return &HE1 '"Left SHIFT key"
        If originalNumber = 133 Then Return &HE5 '"Right SHIFT key"
        If originalNumber = 128 Then Return &HE0 '"Left CONTROL key"
        If originalNumber = 132 Then Return &HE4 '"Right CONTROL key"
        If originalNumber = System.Windows.Forms.Keys.Menu Or System.Windows.Forms.Keys.Alt Then Return &HE2 '"Left ALT key"
        If originalNumber = 134 Then Return &HE6 '"Right ALT key"
        If originalNumber = 0 Then Return "None"
        If originalNumber = 186 Then Return 51 '"; key"
        If originalNumber = 61 Then Return 46 '"= key"
        If originalNumber = 44 Then Return 54 '", key"
        If originalNumber = 45 Then Return 45 '"- key"
        If originalNumber = 46 Then Return 55 '". Key"
        If originalNumber = 47 Then Return 56 '"/ key"
        If originalNumber = 126 Then Return 53 '"~ key"
        If originalNumber = 91 Then Return 47 '"[ key"
        If originalNumber = 92 Then Return 49 '"\ key"
        If originalNumber = 93 Then Return 48 '" ] key"
        If originalNumber = 222 Then Return 52 '"' key"
        If originalNumber = System.Windows.Forms.Keys.VolumeMute Then Return 252 '"Mute key"
        If originalNumber = System.Windows.Forms.Keys.VolumeDown Then Return 253 '"Volume Down key"
        If originalNumber = System.Windows.Forms.Keys.VolumeUp Then Return 254 '"Volume Up key"

        Return CByte(originalNumber)
    End Function

    Public Shared Function NumberToText(originalNumber As Byte) As String
        If originalNumber = 42 Then Return "backspace"
        If originalNumber = 43 Then Return "tab"
        If originalNumber = 40 Then Return "enter"
        If originalNumber = &H48 Then Return "PAUSE key"
        If originalNumber = &H39 Then Return "CAPS LOCK key"
        If originalNumber = 41 Then Return "ESC key"
        If originalNumber = 44 Then Return "SPACEBAR"
        If originalNumber = &H4B Then Return "PAGE UP key"
        If originalNumber = &H4E Then Return "PAGE DOWN key"
        If originalNumber = &H4D Then Return "END key"
        If originalNumber = &H4A Then Return "HOME key"
        If originalNumber = &H50 Then Return "LEFT ARROW key"
        If originalNumber = &H52 Then Return "UP ARROW key"
        If originalNumber = &H4F Then Return "RIGHT ARROW key"
        If originalNumber = &H51 Then Return "DOWN ARROW key"
        If originalNumber = &H46 Then Return "PRINT SCREEN key"
        If originalNumber = &H49 Then Return "INS key"
        If originalNumber = &H4C Then Return "DEL key"
        If originalNumber = 54 Then Return ", key"
        If originalNumber = 45 Then Return "- key"
        If originalNumber = 55 Then Return ". key"
        If originalNumber = 56 Then Return "/ key"
        If originalNumber = 39 Then Return "0 key"
        If originalNumber = 30 Then Return "1 key"
        If originalNumber = 31 Then Return "2 key"
        If originalNumber = 32 Then Return "3 key"
        If originalNumber = 33 Then Return "4 key"
        If originalNumber = 34 Then Return "5 key"
        If originalNumber = 35 Then Return "6 key"
        If originalNumber = 36 Then Return "7 key"
        If originalNumber = 37 Then Return "8 key"
        If originalNumber = 38 Then Return "9 key"
        If originalNumber = 51 Then Return "; key"
        If originalNumber = 46 Then Return "= key"
        If originalNumber = 4 Then Return "A key"
        If originalNumber = 5 Then Return "B key"
        If originalNumber = 6 Then Return "C key"
        If originalNumber = 7 Then Return "D key"
        If originalNumber = 8 Then Return "E key"
        If originalNumber = 9 Then Return "F key"
        If originalNumber = 10 Then Return "G key"
        If originalNumber = 11 Then Return "H key"
        If originalNumber = 12 Then Return "I key"
        If originalNumber = 13 Then Return "J key"
        If originalNumber = 14 Then Return "K key"
        If originalNumber = 15 Then Return "L key"
        If originalNumber = 16 Then Return "M key"
        If originalNumber = 17 Then Return "N key"
        If originalNumber = 18 Then Return "O key"
        If originalNumber = 19 Then Return "P key"
        If originalNumber = 20 Then Return "Q key"
        If originalNumber = 21 Then Return "R key"
        If originalNumber = 22 Then Return "S key"
        If originalNumber = 23 Then Return "T key"
        If originalNumber = 24 Then Return "U key"
        If originalNumber = 25 Then Return "V key"
        If originalNumber = 26 Then Return "W key"
        If originalNumber = 27 Then Return "X key"
        If originalNumber = 28 Then Return "Y key"
        If originalNumber = 29 Then Return "Z key"
        If originalNumber = 47 Then Return "[ key"
        If originalNumber = 49 Then Return "\ key"
        If originalNumber = 48 Then Return "] key"
        If originalNumber = 53 Then Return "` key"
        If originalNumber = &HE3 Then Return "Left Windows key"
        If originalNumber = &HE7 Then Return "Right Windows key"
        If originalNumber = &H62 Then Return "Numeric keypad 0 key"
        If originalNumber = &H59 Then Return "Numeric keypad 1 key"
        If originalNumber = &H5A Then Return "Numeric keypad 2 key"
        If originalNumber = &H5B Then Return "Numeric keypad 3 key"
        If originalNumber = &H5C Then Return "Numeric keypad 4 key"
        If originalNumber = &H5D Then Return "Numeric keypad 5 key"
        If originalNumber = &H5E Then Return "Numeric keypad 6 key"
        If originalNumber = &H5F Then Return "Numeric keypad 7 key"
        If originalNumber = &H60 Then Return "Numeric keypad 8 key"
        If originalNumber = &H61 Then Return "Numeric keypad 9 key"
        If originalNumber = &H55 Then Return "Multiply key"
        If originalNumber = &H57 Then Return "Add key"
        If originalNumber = 255 Then Return "Unknown key"
        If originalNumber = &H56 Then Return "Subtract key"
        If originalNumber = &H63 Then Return "Decimal key"
        If originalNumber = &H54 Then Return "Divide key"
        If originalNumber = &H3A Then Return "F1 key"
        If originalNumber = &H3B Then Return "F2 key"
        If originalNumber = &H3C Then Return "F3 key"
        If originalNumber = &H3D Then Return "F4 key"
        If originalNumber = &H3E Then Return "F5 key"
        If originalNumber = &H3F Then Return "F6 key"
        If originalNumber = &H40 Then Return "F7 key"
        If originalNumber = &H41 Then Return "F8 key"
        If originalNumber = &H42 Then Return "F9 key"
        If originalNumber = &H43 Then Return "F10 key"
        If originalNumber = &H44 Then Return "F11 key"
        If originalNumber = &H45 Then Return "F12 key"
        If originalNumber = &H69 Then Return "F13 key"
        If originalNumber = &H6A Then Return "F14 key"
        If originalNumber = &H6B Then Return "F15 key"
        If originalNumber = &H6C Then Return "F16 key"
        If originalNumber = &H6D Then Return "F17 key"
        If originalNumber = &H6E Then Return "F18 key"
        If originalNumber = &H6F Then Return "F19 key"
        If originalNumber = &H70 Then Return "F20 key"
        If originalNumber = &H71 Then Return "F21 key"
        If originalNumber = &H72 Then Return "F22 key"
        If originalNumber = &H73 Then Return "F23 key"
        If originalNumber = &H74 Then Return "F24 key"
        If originalNumber = &H53 Then Return "NUM LOCK key"
        If originalNumber = &H47 Then Return "SCROLL LOCK key"
        If originalNumber = &HE1 Then Return "Left SHIFT key"
        If originalNumber = &HE5 Then Return "Right SHIFT key"
        If originalNumber = &HE0 Then Return "Left CONTROL key"
        If originalNumber = &HE4 Then Return "Right CONTROL key"
        If originalNumber = &HE2 Then Return "Left ALT key"
        If originalNumber = &HE6 Then Return "Right ALT key"
        If originalNumber = 0 Then Return "None"
        If originalNumber = 51 Then Return "; key"
        If originalNumber = 46 Then Return "= key"
        If originalNumber = 54 Then Return ", key"
        If originalNumber = 45 Then Return "- key"
        If originalNumber = 55 Then Return ". Key"
        If originalNumber = 56 Then Return "/ key"
        If originalNumber = 53 Then Return "~ key"
        If originalNumber = 47 Then Return "[ key"
        If originalNumber = 49 Then Return "\ key"
        If originalNumber = 48 Then Return " ] key"
        If originalNumber = 52 Then Return "' key"
        If originalNumber = 252 Then Return "Mute key"
        If originalNumber = 253 Then Return "Volume Down key"
        If originalNumber = 254 Then Return "Volume Up key"



        Return originalNumber.ToString()
    End Function
End Class
