Public Class SWindow
	Property RoundRadius As Single
		Get
			Return radius
		End Get
	    Set
			radius = value
			UpdateRegion()
	    End Set
	End Property
	Public Overrides Property Text As String
		Get
			Return MyBase.Text
		End Get
		Set
			MyBase.Text = Value
			Caption.Text = Value
		End Set
	End Property
	Property GradientAngle As Single = 90
	Property GradientColorA As Color = Color.Gray
	Property GradientColorB As Color = Color.DimGray

	Private BackgroundBrush As Brush
	Private radius As Single = 10
	Private path As Drawing2D.GraphicsPath
	Private mdown As Boolean
	Private mdPos As Point
	Private mdfPos As Point

	Private Sub SWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		UpdateRegion()
	End Sub

	Protected Sub UpdateRegion()
		path = New Drawing2D.GraphicsPath()
		path.FillMode = Drawing2D.FillMode.Winding
		path.AddRectangle(New RectangleF(0, RoundRadius, Width, Height - RoundRadius * 2))
		path.AddRectangle(New RectangleF(RoundRadius, 0, Width - RoundRadius * 2, Height))
		path.AddEllipse(0, 0, RoundRadius * 2, RoundRadius * 2)
		path.AddEllipse(Width - RoundRadius * 2, 0, RoundRadius * 2, RoundRadius * 2)
		path.AddEllipse(0, Height - RoundRadius * 2, RoundRadius * 2, RoundRadius * 2)
		path.AddEllipse(Width - RoundRadius * 2, Height - RoundRadius * 2, 
							RoundRadius * 2, RoundRadius * 2)
		
		Dim r As New Region(path)
		Me.Region = r
	End Sub

	Private sub SWindow_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
		BackgroundBrush = New Drawing2D.LinearGradientBrush(Me.ClientRectangle, 
					GradientColorA, GradientColorB, GradientAngle)
		e.Graphics.FillRectangle(BackgroundBrush, Me.ClientRectangle)
	End sub

	Private sub SWindow_Resize(sender As Object, e As EventArgs) Handles Me.Resize
		UpdateRegion()
	End sub

	Private Sub SButton1_Load(sender As Object, e As EventArgs) Handles SButton1.Load
		Me.Close()
	End Sub

	Private Sub Header_MouseDown(sender As Object, e As MouseEventArgs) Handles Header.MouseDown
		mdown = True
		mdPos = e.Location
		mdfPos = Me.Location
	End Sub

	Private Sub Header_MouseUp(sender As Object, e As MouseEventArgs) Handles Header.MouseUp
		mdown = False
	End Sub

	Private Sub Header_MouseMove(sender As Object, e As MouseEventArgs) Handles Header.MouseMove
		If mdown Then
			Me.Location = Point.Add(mdfPos, Point.Subtract(e.Location, mdPos))
		End If
	End Sub
End Class