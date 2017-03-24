Namespace Core
	Public Class Manager
		Dim ctrlCount As Integer = 0

		Friend DictControlSizer As Dictionary(Of Control, Control)   'This is the Main-control to Sizer dict.
		Friend DictControlDragClass As Dictionary(Of Control, DragSup)   'This is the Main-control to Drag-Support class dict.
		Friend DictControlSizeClass As Dictionary(Of Control, SizeSup)   'This is the Main-control to Size-Support class dict.
		Friend DictControlName As Dictionary(Of Control, String)    'This is the dict. of Main-control to its Name

		Friend DesignerForm As Form
		Friend UserCode As String
		Friend References As New Collections.Specialized.StringCollection
		Friend ImportStatments As New List(Of String)

		Dim _prop As PropertyGrid
		Dim _active As Control
		Dim WithEvents _txtnam As TextBox

		Public Sub New(F As Form, Prop As PropertyGrid, Txt As TextBox)
			DesignerForm = F
			_prop = Prop
			_txtnam = Txt

			DictControlSizer = New Dictionary(Of Control, Control)
			DictControlDragClass = New Dictionary(Of Control, DragSup)
			DictControlSizeClass = New Dictionary(Of Control, SizeSup)
			DictControlName = New Dictionary(Of Control, String)

			AddHandler DesignerForm.Click, AddressOf ctrl_Click
			DictControlName.Add(DesignerForm, "Blank")

			UserCode = String.Format("Partial Class " & F.Name & "{0}" &
									 "    {0}" &
									 "End Class", vbCrLf)

			References.AddRange({"System.dll",
									 "System.Drawing.dll",
									 "System.Windows.Forms.dll",
									 "System.Data.dll",
									 "Microsoft.VisualBasic.dll"})

			ImportStatments.AddRange({"System",
									 "System.Drawing",
									 "System.Windows.Forms",
									 "System.Data",
									 "System.Collections",
									 "System.Collections.Generic",
									 "System.Drawing",
									 "System.Linq",
									 "Microsoft.VisualBasic"})
		End Sub

		Public Sub AddControl(c As Control)
			If c Is Nothing Then Throw New ArgumentNullException
			If Not DesignerForm.Controls.Contains(c) Then Throw New ArgumentException

			Dim sizer As New Button()
			sizer.Top = c.Top + c.Height
			sizer.Left = c.Left + c.Width
			sizer.Size = New Size(10, 10)
			sizer.Text = ""

			Dim ds As New DragSup(c)
			Dim ss As New SizeSup(c, sizer)

			AddHandler c.MouseUp, AddressOf ctrl_Click

			DesignerForm.Controls.Add(sizer)
			DictControlSizer.Add(c, sizer)
			DictControlDragClass.Add(c, ds)
			DictControlSizeClass.Add(c, ss)
			DictControlName.Add(c, "Control" & ctrlCount.ToString)

			ctrlCount += 1
		End Sub

		Public Function RemoveControl(c As Control) As Boolean
			Try
				DesignerForm.Controls.Remove(c)
				DesignerForm.Controls.Remove(DictControlSizer(c))

				DictControlSizer.Remove(c)
				DictControlDragClass.Remove(c)
				DictControlSizeClass.Remove(c)
				DictControlName.Remove(c)
			Catch ex As Exception
				Return False
			End Try
			Return True
		End Function

		Private Sub ctrl_Click(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				_prop.SelectedObject = sender
				_active = sender
				_txtnam.Text = DictControlName(sender)
			ElseIf e.Button = MouseButtons.Right Then
				If Not RemoveControl(sender) Then MsgBox("Error in removing control")
			End If
		End Sub

		Public Property DragEnable(c As Control) As Boolean
			Get
				If Not DictControlDragClass.ContainsKey(c) Then Throw New KeyNotFoundException
				Return DictControlDragClass(c).Enabled
			End Get
			Set(ByVal value As Boolean)
				DictControlDragClass(c).Enabled = value
			End Set
		End Property

		Public Property SizeEnable(c As Control) As Boolean
			Get
				If Not DictControlSizeClass.ContainsKey(c) Then Throw New KeyNotFoundException
				Return DictControlSizeClass(c).Enabled
			End Get
			Set(ByVal value As Boolean)
				DictControlSizeClass(c).Enabled = value
			End Set
		End Property

		Private Sub _txtnam_TextChanged(sender As Object, e As EventArgs) Handles _txtnam.TextChanged
			If _active Is Nothing Then Exit Sub
			DictControlName(_active) = _txtnam.Text
		End Sub
	End Class
End Namespace

