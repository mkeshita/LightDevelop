Public Class SButton
	Property IdleColor As Color = Color.Lavender
	Property HoverColor As Color = Color.LightSteelBlue
	'Property HoverEdge As Color = Color.SteelBlue
	Property DownColor As Color = Color.CadetBlue
	Property HoverInFadeTime As double = 0.05
	Property HoverOutFadeTime As double = 0.2
	Public Property ButtonText As String
		Get
			Return Label.Text
		End Get
	    Set
			Label.Text = value
		End Set
	End Property

	Public Shadows Event MouseDown(sender As Object, e As EventArgs)
	Public Shadows Event MouseUp(sender As Object, e As EventArgs)
	Public Shadows Event Click(sender As Object, e As EventArgs)

	Private t As Double = 0
	Private mouseIn As Boolean = False
	Private mouseDn As Boolean = False

	Private Sub SButton_MouseEnter(sender As Object, e As EventArgs) Handles Label.MouseEnter
		mouseIn = True
	End Sub

	Private Sub SButton_MouseLeave(sender As Object, e As EventArgs) Handles Label.MouseLeave
		mouseIn = False
	End Sub

	Private Sub SButton_MouseDown(sender As Object, e As EventArgs) Handles Label.MouseDown
		RaiseEvent MouseDown(Me, New EventArgs)
		mouseDn = True
	End Sub

	Private Sub SButton_MouseUp(sender As Object, e As EventArgs) Handles Label.MouseUp
		RaiseEvent MouseUp(Me, New EventArgs)
		RaiseEvent Click(Me, New EventArgs)
		mouseDn = False
	End Sub

	Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
		Dim dtOut As Double = Timer.Interval / (HoverOutFadeTime * 1000)
		Dim dtIn As Double = Timer.Interval / (HoverInFadeTime * 1000)
		If mouseIn Then t += dtIn Else t -= dtOut
		If t > 1 Then t = 1
		If t < 0 Then t = 0

		Label.BackColor = Interpolate(IdleColor, HoverColor, t)
		'Me.BackColor = Interpolate(Me.Parent.BackColor, HoverEdge, t)
		If mouseDn Then Label.BackColor = DownColor
	End Sub

	Private Function Linear(a As Color, b As Color, t As Double) As Color
		Dim dR, dG, dB As Integer
		dR = CInt(b.R) - a.R
		dG = CInt(b.G) - a.G
		dB = CInt(b.B) - a.B

		Return Color.FromArgb(a.R + dR * t, a.G + dG * t, a.B + dB * t)
	End Function

	Private Function Interpolate(a As Color, b As Color, t As Double) As Color
		Return Linear(a, b, -2*t^3 + 3*t^2)
	End Function
End Class
