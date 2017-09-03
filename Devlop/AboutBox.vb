' AboutBox.vb
' This file contains:
'
' Class Develop.AboutBox

''' <summary>
''' About dialog of the program.
''' </summary>
Public NotInheritable Class AboutBox
	Private Sub OKButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OKButton.Click
		Close()
	End Sub
	
	Sub SetTransp(ctrl As Control())
		For Each c In ctrl
			c.BackColor = Color.FromArgb(128, c.BackColor)
		Next
	End Sub

	Private Sub AboutBox_Load(sender As Object, e As EventArgs) Handles Me.Load
		SetTransp({TableLayoutPanel, LinkLabel1, LabelProductName,
					LabelVersion, OKButton})
	End Sub

	Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
		Shell("cmd /c ""start http://github.com/Knowif/LightDevelop""", AppWinStyle.Hide, False)
	End Sub
End Class
