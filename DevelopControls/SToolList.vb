Public Class SToolList
	Public Property Items As String()
		Get
			Return _items
		End Get
	    Set(value As String())
			_items = value
			RefreshList()
	    End Set
	End Property
	Public Property ItemHeight As Integer
		Get
			Return _height
		End Get
	    Set(value As Integer)
			_height = value
			RefreshList()
	    End Set
	End Property
	Public Property HoverColor As Color = Color.LightSteelBlue
	Public Property DownColor As Color = Color.CadetBlue

	Public Event ItemClick(sender As Object, item As String)

	Private _items As String() = {}
	Private _height As Integer = 35

	Public Sub RefreshList()
		Dim y As Integer = 0
		FlowLayout.Controls.Clear()
		For Each item In Items
			Dim b As New SButton()
			FlowLayout.Controls.Add(b)
			b.Dock = DockStyle.Top
			b.Margin = New Padding(2)
			b.Anchor = AnchorStyles.Top And AnchorStyles.Left And AnchorStyles.Right
			b.Width = FlowLayout.Width
			b.Height = ItemHeight
			b.ButtonText = item
			b.Font = Font
			b.ForeColor = ForeColor
			b.IdleColor = FlowLayout.BackColor
			b.HoverColor = HoverColor
			b.DownColor = DownColor
			b.Tag = item
			AddHandler b.Click, _
				Sub(s, e) RaiseEvent ItemClick(Me, CType(s, Control).Tag)
		Next
	End Sub

	Private Sub SToolList_Resize(sender As Object, e As EventArgs) Handles Me.Resize
		RefreshList
	End Sub
End Class
