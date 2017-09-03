' Splash.vb
' This file contains:
'
' Class Develop.Splash


''' <summary>
''' The main enterance of the program.
''' </summary>
Public NotInheritable Class Splash
    Private Sub Timer1_Tick( sender As Object,  e As EventArgs) Handles Timer1.Tick
        FormMain.Show
        Me.Close
        Timer1.Enabled = False
    End Sub

	Private Sub SButton2_Click(sender As Object, e As EventArgs) Handles SButton2.Click
		Shell("cmd /c ""start http://github.com/Knowif/LightDevelop""", AppWinStyle.Hide, False)
	End Sub

	Private Sub SButton1_Click(sender As Object, e As EventArgs) Handles SButton1.Click
		AboutBox.Show
	End Sub
End Class
