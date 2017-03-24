Public NotInheritable Class Splash
    Private Sub Timer1_Tick( sender As Object,  e As EventArgs) Handles Timer1.Tick
        FormMain.Show
        Me.Close
        Timer1.Enabled = False
    End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Timer1_Tick(Nothing, Nothing)
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		AboutBox.Show()
	End Sub

	Private Sub Splash_Load(sender As Object, e As EventArgs) Handles Me.Load
		SetTransp({Label1, Label2, LinkLabel1, Button1, Button2})
	End Sub

	Sub SetTransp(ctrl As Control())
		For Each c In ctrl
			c.BackColor = Color.FromArgb(128, c.BackColor)
		Next
	End Sub

	Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
		Interaction.Shell("cmd /c ""start http://github.com/Knowif/LightDevelop""", AppWinStyle.Hide, False)
	End Sub
End Class
