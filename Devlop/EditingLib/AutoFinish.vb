' AutoFinish.vb
' This file contains:
'
' Class Develop.Editing.AutoFinish

Imports System.Text.RegularExpressions
Imports DevelopControls

Namespace Editing
	''' <summary>
	''' Class to enable simple Auto-Finishing for SEditor
	''' </summary>
	Public Class AutoFinish
		Public Images As ImageList
		Public TextFont As Font = Control.DefaultFont
		Public WithEvents Editor As SEditor

		Private _autobox As ListView = Nothing
		Private _boxLabel As Label = Nothing
		Private _reslover As New TypeResolver()

		Private sepr As Char() = {"+", "-", "*", "/", " ", "(", ")", "{", "}", ",", "&", "^", "="}

		Public Sub New(box As SEditor, image As ImageList, imp As String())
			Editor = box
			If image Is Nothing Then Throw New ArgumentNullException()
			Images = image

			_reslover.ImportedPrefix = imp
			_reslover.LoadAssembly(GetType(Int32))           ' System.Core
			_reslover.LoadAssembly(GetType(Collection))      ' Microsoft.VisualBasic
			_reslover.LoadAssembly(GetType(Pen))             ' System.Drawing
			_reslover.LoadAssembly(GetType(Form))            ' System.Windows.Forms
			_reslover.BuildList()

			CreateCueBox()
			CreateLabel(New Point(0, 0))
		End Sub

		Public Sub RebuildResolver()
			_reslover.BuildList()
		End Sub

		Private Sub Editor_TextChanged(sender As Object, e As EventArgs) Handles Editor.TextChanged
			If Not Settings.EnableAutoFinish Then Exit Sub

			Dim keyChar As Char = Editor.CurrentPressedKeyChar

			If keyChar = "." Then
				' what if i skip this step?
				'
				'' if there's nothing to finish then exit
				'If GetLastWord(Editor.AllText, Editor.SelectionStart) = "" Then
				'	Exit Sub
				'End If

				' if it's already here then delete it
				If _autobox.Visible Then
					HideBox()
					Exit Sub
				End If

				ShowCueBox()
				ShowLabel(_autobox.Location)
				_boxLabel.Left += _autobox.Width + 10

				' let's see what's under the cursor
				Dim name As String = GetName()
				Dim member As TypeResolver.SpaceMember = _reslover.ResolveType(name)
				If member IsNot Nothing Then
					' this is a class! add all class member into this box
					For Each mem In member.Type.GetMembers()
						' if it's a duplicate then skip
						If _autobox.Items.ContainsKey(mem.Name) Then Continue For

						' icons switch
						Dim num As Integer = -1
						Select Case mem.MemberType
							Case Reflection.MemberTypes.NestedType
								num = 0
							Case Reflection.MemberTypes.Event
								num = 1
							Case Reflection.MemberTypes.Field
								If CType(mem, Reflection.FieldInfo).IsPrivate Then Continue For
								num = 2
							Case Reflection.MemberTypes.Method
								If CType(mem, Reflection.MethodInfo).IsPrivate Then Continue For
								num = 3
							Case Reflection.MemberTypes.Property
								num = 4
							Case Reflection.MemberTypes.Constructor
								If CType(mem, Reflection.ConstructorInfo).IsPrivate Then Continue For
								num = 3
						End Select

						If num >= 0 Then
							Dim i = _autobox.Items.Add(mem.Name, num)
							i.Name = mem.Name
							' set the tag to get info in selectionChange()
							i.Tag = member.Type
						Else
							' unexpected member type
							Dim i = _autobox.Items.Add(mem.Name)
							i.Name = mem.Name
						End If
					Next

					' show it
					_autobox.Show()
					_autobox.Focus()
				Else
					' ...is it a namespace name?
					Dim types As List(Of TypeResolver.SpaceMember) = _reslover.ResolveNamespace(name)

					If types Is Nothing Then
						' if not, everything is over
						HideBox()
						Exit Sub
					End If

					' icon switch again
					For Each t In types
						Dim iconIndex As Integer
						Select Case t.Kind
							Case TypeResolver.ElementKind.KindClass
								iconIndex = 0
							Case TypeResolver.ElementKind.KindEnum
								iconIndex = 6
							Case TypeResolver.ElementKind.KindInterface
								iconIndex = 7
							Case Else
								iconIndex = 0
						End Select
						_autobox.Items.Add(t.Name, iconIndex).Tag = t.Type
					Next

					' show it
					_autobox.Show()
					_autobox.Focus()
				End If
			Else
				If _autobox.Visible Then HideBox()
			End If
		End Sub

		Private Sub ListBox_KeyPress(sender As Object, e As KeyPressEventArgs)
			Dim lb = CType(sender, ListView)
			If e.KeyChar = " " Then
				If lb.SelectedItems.Count = 0 Then Exit Sub
				Editor.InsertSLStringAtCurrent(lb.SelectedItems(0).Text)
				HideBox()
			ElseIf e.KeyChar = vbBack Then
				HideBox()
			End If
		End Sub

		Private Sub ListBox_DoubleClick(sender As Object, e As EventArgs)
			Dim lb = CType(sender, ListView)
			If lb.SelectedItems.Count = 0 Then Exit Sub
			Editor.InsertSLStringAtCurrent(lb.SelectedItems(0).Text)
			HideBox()
		End Sub

		Private Sub ListBox_LostFocus(sender As Object, e As EventArgs)
			HideBox()
		End Sub

		Private Sub ListBox_SelectionChange(sender As Object, e As EventArgs)
			Dim lb = _autobox
			If lb.SelectedItems.Count = 0 Then Exit Sub

			Dim it = lb.SelectedItems(0)
			Dim t = CType(lb.SelectedItems(0).Tag, Type)
			Try
				Select Case it.ImageIndex
					Case 0
						' class
						_boxLabel.Text = "Class " & it.Text
						Exit Sub
					Case 6
						' enum
						_boxLabel.Text = "Enum " & it.Text
						Exit Sub
					Case 7
						' interface
						_boxLabel.Text = "Interface " & it.Text
						Exit Sub
					Case 4
						' property
						_boxLabel.Text = "Property " & it.Text & " As " & t.GetProperty(it.Text).PropertyType.Name
					Case 2
						' field
						Dim f = t.GetField(it.Text)
						_boxLabel.Text = it.Text & " As " & f.FieldType.Name
						If f.IsStatic Then _boxLabel.Text &= " = " & f.GetValue(Nothing).ToString()
						Exit Sub
					Case 3
						' method(!)
						' MethodName(arg1 As type1, arg2 As type2) As type3
						Dim str = ""
						Dim methods As Reflection.MethodInfo() = t.GetMethods()
						Dim method = From m In methods
									 Where m.Name = it.Text
									 Select m

						For Each m In method
							Dim mstr = m.Name & "("
							Dim noarg As Boolean = True
							For Each arg In m.GetParameters()
								noarg = False
								mstr &= arg.Name & " As " & arg.ParameterType.Name & ", "
							Next
							If Not noarg Then
								mstr = Left(mstr, mstr.Length - 2)
							End If
							mstr &= ")"
							If m.ReturnType.Name <> "Void" Then mstr &= " As " & m.ReturnType.Name

							str &= mstr & vbCrLf
						Next
						_boxLabel.Text = str
						Exit Sub
				End Select
			Catch ex As Exception
				_boxLabel.Text = ""
			End Try
		End Sub

		Private Sub HideBox()
			_boxLabel.Hide()
			_autobox.Hide()

			' note this, for not being 'disabled'
			Editor.Focus()
		End Sub

		Private Sub ShowCueBox()
			_autobox.Location = Editor.CurrentPixelPosition
			_autobox.Show()
		End Sub 

		Private Sub CreateCueBox()
			Dim cue As New ListView()
			cue.Name = "keywdCue"
			cue.SmallImageList = Images
			cue.Font = TextFont
			cue.View = View.SmallIcon
			cue.TabStop = False
			cue.TabIndex = 100
			cue.Size = New Size(200, 400)
			cue.Location = Editor.CurrentPixelPosition
			cue.Left += 10
			cue.Top += 20
			Editor.Controls.Add(cue)
			cue.Hide()
			_autobox = cue
			
			AddHandler _autobox.KeyPress, AddressOf ListBox_KeyPress
			AddHandler _autobox.DoubleClick, AddressOf ListBox_DoubleClick
			AddHandler _autobox.LostFocus, AddressOf ListBox_LostFocus
			AddHandler _autobox.SelectedIndexChanged,
											AddressOf ListBox_SelectionChange
		End Sub

		Private Sub ShowLabel(loca As Point)
			_boxLabel.Font = TextFont
			_boxLabel.Show()
		End Sub

		Private Sub CreateLabel(loca As Point)
			Dim text As New Label()

			Editor.Controls.Add(text)
			text.Text = ""
			text.Font = TextFont
			text.Location = loca
			text.BorderStyle = BorderStyle.FixedSingle
			text.BackColor = Color.LightYellow
			text.AutoSize = True
			text.MaximumSize = New Size(Editor.Width - text.Left,
										Editor.Height - text.Height)
			text.Hide()

			_boxLabel = text
		End Sub

		Private Function GetName() As String
			Dim line As String
			line = Editor.Lines(Editor.CurrentCursor.Y)
			Dim pos = line.LastIndexOf(".")
			If pos >= 0 Then line = Left(line, pos)
			line = Trim(line)

			For Each sep In sepr
				Dim npos = line.LastIndexOf(sep)
				If npos >= 0 Then line = line.Substring(npos + 1)
			Next
			Return line
		End Function

		Private Function GetLastWord(s As String, i As Integer) As String
			' Get the last word.
			Dim x = Left(s, i)
			x = Regex.Match(x, "\s*[a-zA-Z]+\s*", RegexOptions.RightToLeft).Value

			' Remove all whitespaces.
			x = Regex.Replace(x, "\s", "")

			Return x
		End Function
	End Class
End Namespace
