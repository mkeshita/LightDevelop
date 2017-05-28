Imports System.Runtime.InteropServices

Namespace Editing
	Public Class AutoTabsSup
		Inherits EditingSupporter

		Public Sub New(box As RichTextBox)
			MyBase.New(box)
		End Sub

		Private Sub EditTextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox.KeyPress
			If e.KeyChar = vbTab Then
				e.KeyChar = ""
				Dim oss = TextBox.SelectionStart
				TextBox.Text =
				TextBox.Text.Insert(TextBox.SelectionStart, StrDup(Settings.TabLength, " "))
				TextBox.SelectionStart = oss + Settings.TabLength
			End If
		End Sub

		Private Sub EditTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox.KeyUp
			If e.KeyValue = Asc(vbCr) Then
				DisableRedraw(TextBox)

				Dim r As Integer = TextBox.GetLineFromCharIndex(TextBox.SelectionStart) - 1
				Dim oss = TextBox.SelectionStart
				If r = -1 Then Exit Sub
				Dim line = TextBox.Lines(r)
				Dim spaces As Integer = line.Length - LTrim(line).Length
				TextBox.Text =
				TextBox.Text.Insert(oss, StrDup(spaces, " "))
				TextBox.SelectionStart = oss + spaces

				EnableRedraw(TextBox)
				TextBox.Refresh()
			End If
		End Sub

		<DllImport("user32.dll")>
		Private Shared Function SendMessage(hwnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As IntPtr) As Integer
		End Function

		Sub EnableRedraw(c As Control)
			SendMessage(c.Handle, &HB, 1, IntPtr.Zero)
		End Sub

		Sub DisableRedraw(c As Control)
			SendMessage(c.Handle, &HB, 0, IntPtr.Zero)
			c.Refresh()
		End Sub
	End Class

End Namespace
