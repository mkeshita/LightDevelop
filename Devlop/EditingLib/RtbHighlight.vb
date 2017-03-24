Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions

Namespace Editing
	Public Class HighlightingSup
		Inherits EditingSupporter

		Public KeyTable() As KeyValuePair(Of String, Color)

		Public Sub New(box As RichTextBox, table() As KeyValuePair(Of String, Color))
			MyBase.New(box)

			If table Is Nothing Then Throw New ArgumentNullException()
			KeyTable = table
		End Sub

		Private Sub EditTextBox_TextChanged(sender As Object, e As EventArgs) Handles EditTextBox.TextChanged
			If Settings.EnableHighlight Then
				Dim pos = EditTextBox.SelectionStart
				DisableRedraw(EditTextBox)
				EditTextBox.SelectAll()
				EditTextBox.SelectionColor = Color.Black

				For Each pair In KeyTable
					Dim i = Regex.Matches(EditTextBox.Text, pair.Key)
					If i.Count > 0 Then
						For Each mat As Match In i
							EditTextBox.SelectionStart = mat.Index
							EditTextBox.SelectionLength = mat.Length
							EditTextBox.SelectionColor = pair.Value
						Next
					End If
				Next

				EditTextBox.SelectionStart = pos
				EditTextBox.SelectionLength = 0
				EnableRedraw(EditTextBox)
				EditTextBox.Refresh()
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
