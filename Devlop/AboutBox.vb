Public NotInheritable Class AboutBox

	Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
		Me.Close()
	End Sub
	
	Sub SetTransp(ctrl As Control())
		For Each c In ctrl
			c.BackColor = Color.FromArgb(128, c.BackColor)
		Next
	End Sub

	Private Sub AboutBox_Load(sender As Object, e As EventArgs) Handles Me.Load
		SetTransp({TableLayoutPanel, LabelCompanyName, LabelCopyright, LabelProductName, 
					LabelVersion, OKButton})
	End Sub
End Class
