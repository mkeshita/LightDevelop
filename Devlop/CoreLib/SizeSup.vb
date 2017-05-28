Namespace Core
	Public Class SizeSupporter
		WithEvents _ctrl, _sizer As Control
		Dim _enabled As Boolean, _ds As DragSupporter, ox, oy As Integer

		Public Sub New(ctrlMain As Control, ctrlSizer As Control, Optional ena As Boolean = True)
			_ctrl = ctrlMain
			_sizer = ctrlSizer
			_enabled = ena

			_ds = New DragSupporter(_sizer)
		End Sub

		Private Sub _sizer_MouseDown(sender As Object, e As MouseEventArgs) Handles _sizer.MouseDown
			If _enabled Then
				ox = e.X
				oy = e.Y
			End If
		End Sub

		Private Sub _sizer_MouseMove(sender As Object, e As MouseEventArgs) Handles _sizer.MouseMove
			If e.Button = MouseButtons.Left AndAlso _enabled Then
				Dim deltaX = e.X - ox
				Dim deltaY = e.Y - oy
				_ctrl.Height += deltaY
				_ctrl.Width += deltaX
			End If
		End Sub

		Private Sub _ctrl_LocationChanged(sender As Object, e As EventArgs) Handles _ctrl.LocationChanged
			_sizer.Top = _ctrl.Top + _ctrl.Height
			_sizer.Left = _ctrl.Left + _ctrl.Width
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
