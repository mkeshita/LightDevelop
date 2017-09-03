' DialogError.vb
' This file contains:
'
' Class Develop.DialogError

''' <summary>
''' Form to display compile errors.
''' </summary>
Public Class DialogError
	Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
		DialogResult = DialogResult.OK
		Close()
	End Sub
End Class
