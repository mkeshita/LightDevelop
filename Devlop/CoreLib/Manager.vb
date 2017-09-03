' Manager.vb
' This file contains:
'
' Class Develop.Core.Manager

Namespace Core
	''' <summary>
	''' The main manager of designer interface.
	''' </summary>
	Public Class Manager
		Private ctrlCount As Integer = 0

		Public SizerCtrlDictionary	As Dictionary(Of Control, Control)
		Public DragSupDictionary	As Dictionary(Of Control, DragSupporter)
		Public SizeSupDictionary	As Dictionary(Of Control, SizeSupporter)
		Public CtrlNameDictionary	As Dictionary(Of Control, String)

		Public DesignerForm As Form
		Public UserCode As String
		Public References As New Specialized.StringCollection
		Public ImportStatments As New List(Of String)

		Public Property DragEnable(c As Control) As Boolean
			Get
				If Not DragSupDictionary.ContainsKey(c) Then Throw New KeyNotFoundException
				Return DragSupDictionary(c).Enabled
			End Get
			Set(ByVal value As Boolean)
				DragSupDictionary(c).Enabled = value
			End Set
		End Property

		Public Property SizeEnable(c As Control) As Boolean
			Get
				If Not SizeSupDictionary.ContainsKey(c) Then Throw New KeyNotFoundException
				Return SizeSupDictionary(c).Enabled
			End Get
			Set(ByVal value As Boolean)
				SizeSupDictionary(c).Enabled = value
			End Set
		End Property

		Private _propGrid As PropertyGrid
		Private _focusCtrl As Control
		Private WithEvents _nameBox As TextBox

		Public Sub New(F As Form, Prop As PropertyGrid, Txt As TextBox)
			DesignerForm = F
			_propGrid = Prop
			_nameBox = Txt

			SizerCtrlDictionary = New Dictionary(Of Control, Control)
			DragSupDictionary = New Dictionary(Of Control, DragSupporter)
			SizeSupDictionary = New Dictionary(Of Control, SizeSupporter)
			CtrlNameDictionary = New Dictionary(Of Control, String)

			AddHandler DesignerForm.Click, AddressOf ctrl_Click
			CtrlNameDictionary.Add(DesignerForm, "Blank")

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

			Dim ds As New DragSupporter(c)
			Dim ss As New SizeSupporter(c, sizer)

			AddHandler c.MouseUp, AddressOf ctrl_Click

			DesignerForm.Controls.Add(sizer)
			SizerCtrlDictionary.Add(c, sizer)
			DragSupDictionary.Add(c, ds)
			SizeSupDictionary.Add(c, ss)
			CtrlNameDictionary.Add(c, "Control" & ctrlCount.ToString)

			ctrlCount += 1
		End Sub

		Public Function RemoveControl(c As Control) As Boolean
			Try
				DesignerForm.Controls.Remove(c)
				DesignerForm.Controls.Remove(SizerCtrlDictionary(c))

				SizerCtrlDictionary.Remove(c)
				DragSupDictionary.Remove(c)
				SizeSupDictionary.Remove(c)
				CtrlNameDictionary.Remove(c)
			Catch ex As Exception
				Return False
			End Try
			Return True
		End Function

		Private Sub ctrl_Click(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				_propGrid.SelectedObject = sender
				_focusCtrl = sender
				_nameBox.Text = CtrlNameDictionary(sender)
			ElseIf e.Button = MouseButtons.Right Then
				If Not RemoveControl(sender) Then MsgBox("Error in removing control")
			End If
		End Sub

		Private Sub _txtnam_TextChanged(sender As Object, e As EventArgs) Handles _nameBox.TextChanged
			If _focusCtrl Is Nothing Then Exit Sub
			CtrlNameDictionary(_focusCtrl) = _nameBox.Text
		End Sub
	End Class
End Namespace

