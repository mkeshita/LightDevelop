Public NotInheritable Class Splash

    Private Sub Timer1_Tick( sender As Object,  e As EventArgs) Handles Timer1.Tick
        Form1.Show
        Me.Close
        Timer1.Enabled = False
    End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Timer1_Tick(Nothing, Nothing)
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		AboutBox.Show()
	End Sub
End Class
