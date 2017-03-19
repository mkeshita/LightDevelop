Imports System.Text.RegularExpressions
Imports System.Runtime.InteropServices

Module CodeEditHlp
    Private ass, vbass As Reflection.Assembly ' the assembly of mscorlib.dll
    Private types As Type(), vbtypes As Type()

    Sub New()
        ass = Reflection.Assembly.GetAssembly(GetType(System.Object))
        vbass = Reflection.Assembly.GetAssembly(GetType(Microsoft.VisualBasic.Collection))
        types = ass.GetTypes()
        vbtypes = vbass.GetTypes()
    End Sub

    Public Sub Highlight(tb As RichTextBox, word As String, c As Color)
        Dim oldSS = tb.SelectionStart
        tb.Select(oldSS - word.Length, word.Length)
        tb.SelectionColor = c

        ' Restore
        tb.Select(oldSS, 0)
        tb.SelectionColor = Color.Black
    End Sub

    <DllImport("user32.dll")>
    Function SendMessage(hwnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As IntPtr) As Integer
    End Function

    Sub EnableRedraw(c As Control)
        SendMessage(c.Handle, &HB, 1, IntPtr.Zero)
    End Sub

    Sub DisableRedraw(c As Control)
        SendMessage(c.Handle, &HB, 0, IntPtr.Zero)
        c.Refresh()
    End Sub
End Module
