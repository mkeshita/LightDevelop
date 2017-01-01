Public Class OptionWindow
	Private Sub OptionWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		hlight.Checked = Settings.EnableHighlight
		afinish.Checked = Settings.EnableAutoFinish
		csnippet.Checked = Settings.EnableCodeSnippets
		psnippet.Text = Settings.CodeSnippetsLocation
	End Sub

	Private Sub hlight_CheckedChanged(sender As Object, e As EventArgs) Handles hlight.CheckedChanged
		CType(sender, CheckBox).Text = IIf(CType(sender, CheckBox).Checked, "Enabled", "Disabled")
	End Sub

	Private Sub afinish_CheckedChanged(sender As Object, e As EventArgs) Handles afinish.CheckedChanged
		CType(sender, CheckBox).Text = IIf(CType(sender, CheckBox).Checked, "Enabled", "Disabled")
	End Sub

	Private Sub csnippet_CheckedChanged(sender As Object, e As EventArgs) Handles csnippet.CheckedChanged
		CType(sender, CheckBox).Text = IIf(CType(sender, CheckBox).Checked, "Enabled", "Disabled")
	End Sub

	Private Sub psnipBros_Click(sender As Object, e As EventArgs) Handles psnipBros.Click
		If OpenFile.ShowDialog() = DialogResult.Cancel Then Exit Sub
		psnippet.Text = OpenFile.FileName
	End Sub

	Private Sub OptionWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
		Settings.EnableHighlight = hlight.Checked
		Settings.EnableAutoFinish = afinish.Checked
		Settings.EnableCodeSnippets = csnippet.Checked
		Settings.CodeSnippetsLocation = psnippet.Text

		Settings.SaveAll()
	End Sub
End Class