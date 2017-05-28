Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions

Namespace Editing
	Public Class HighlightingSup
		Inherits EditingSupporter

		Public KeyTable() As KeyValuePair(Of String, Color)
		Public ErrorLines As New List(Of Integer)

		Public Sub New(box As RichTextBox, table() As KeyValuePair(Of String, Color))
			MyBase.New(box)

			If table Is Nothing Then Throw New ArgumentNullException()
			KeyTable = table
		End Sub
		

		Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles TextBox.TextChanged
			Highlight()
		End Sub

		Public Sub Highlight()
			Dim pos = TextBox.SelectionStart
			DisableRedraw(TextBox)
			TextBox.SelectAll()
			TextBox.SelectionColor = Color.Black
			TextBox.SelectionBackColor = Color.White

			If Settings.EnableHighlight Then
				For Each pair In KeyTable
					Dim i = Regex.Matches(TextBox.Text, pair.Key)
					If i.Count > 0 Then
						For Each mat As Match In i
							TextBox.SelectionStart = mat.Index
							TextBox.SelectionLength = mat.Length
							TextBox.SelectionColor = pair.Value
						Next
					End If
				Next
			End If
							
			For Each l As Integer In ErrorLines
				Dim pStart As Integer = TextBox.GetFirstCharIndexFromLine(l)
				TextBox.Select(pStart, TextBox.Lines(l).Length)
				TextBox.SelectionBackColor = Color.Pink
			Next

			TextBox.SelectionStart = pos
			TextBox.SelectionLength = 0
			EnableRedraw(TextBox)
			TextBox.Refresh()
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
