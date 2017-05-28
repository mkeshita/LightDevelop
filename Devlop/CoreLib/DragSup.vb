Namespace Core
	Public Class DragSupporter
		WithEvents _ctrl As Control
		Dim _enabled As Boolean, dx, dy As Single

		Public Sub New(ctrl As Control, Optional ena As Boolean = True)
			_ctrl = ctrl
			_enabled = ena
		End Sub

		Private Sub _ctrl_MouseDown(sender As Object, e As MouseEventArgs) Handles _ctrl.MouseDown
			If _enabled Then
				dx = e.X
				dy = e.Y
			End If
		End Sub

		Private Sub _ctrl_MouseMove(sender As Object, e As MouseEventArgs) Handles _ctrl.MouseMove
			If e.Button = MouseButtons.Left AndAlso _enabled Then
				_ctrl.Top += e.Y - dy
				_ctrl.Left += e.X - dx
			End If
		End Sub

		Public Property Enabled() As Boolean
			Get
				Return _enabled
			End Get
			Set(ByVal value As Boolean)
				_enabled = value
			End Set
		End Property

	End Class

End Namespace
