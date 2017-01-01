Public Class AutoTabsSup
	Inherits EditingSupporter

	Public Sub New(box As RichTextBox)
		MyBase.New(box)
	End Sub

	Private Sub EditTextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EditTextBox.KeyPress
		If e.KeyChar = vbTab Then
            e.KeyChar = ""
            Dim oss = EditTextBox.SelectionStart
            EditTextBox.Text =
                EditTextBox.Text.Insert(EditTextBox.SelectionStart, StrDup(Settings.TabLength, " "))
            EditTextBox.SelectionStart = oss + Settings.TabLength
        End If
	End Sub

	Private Sub EditTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles EditTextBox.KeyUp
        If e.KeyValue = Asc(vbCr) Then
			CodeEditHlp.DisableRedraw(EditTextBox)

            Dim r As Integer = EditTextBox.GetLineFromCharIndex(EditTextBox.SelectionStart) - 1
            Dim oss = EditTextBox.SelectionStart
            If r = -1 Then Exit Sub
            Dim line = EditTextBox.Lines(r)
            Dim spaces As Integer = line.Length - LTrim(line).Length
            EditTextBox.Text = 
                EditTextBox.Text.Insert(oss, StrDup(spaces, " "))
            EditTextBox.SelectionStart = oss + spaces

			CodeEditHlp.EnableRedraw(EditTextBox)
			EditTextBox.Refresh
        End If
    End Sub
End Class
