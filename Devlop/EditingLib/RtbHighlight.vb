Imports System.Text.RegularExpressions

Public Class HighlightingSup
	Inherits EditingSupporter
	
	Public KeyTable() As KeyValuePair(Of String, Color)

	Public Sub New(box As RichTextBox, table() As KeyValuePair(Of String, Color))
		MyBase.New(box)

		If table Is Nothing Then Throw New ArgumentNullException()
		KeyTable = table
	End Sub
	
	Private Sub EditTextBox_TextChanged(sender As Object, e As EventArgs) Handles EditTextBox.TextChanged
		If Settings.EnableHighlight
			Dim pos = EditTextBox.SelectionStart
			CodeEditHlp.DisableRedraw(EditTextBox)
			EditTextBox.SelectAll
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
			CodeEditHlp.EnableRedraw(EditTextBox)
			EditTextBox.Refresh
		End If
	End Sub
End Class
