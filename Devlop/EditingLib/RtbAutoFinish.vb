Imports System.Text.RegularExpressions
Namespace Editing
	Public Class AutoFinishSup
		Inherits EditingSupporter

		Public Images As ImageList
		Public TextFont As Font = Control.DefaultFont
		Private cuebox As ListView = Nothing, textcue As Label = Nothing
		Private reslover As New TypeResolver()

		Public Sub New(box As RichTextBox, image As ImageList, imp As String())
			MyBase.New(box)
			If image Is Nothing Then Throw New ArgumentNullException()
			Images = image

			reslover.ImportedPrefix = imp
			reslover.LoadAssembly(GetType(Int32))           ' System.Core
			reslover.LoadAssembly(GetType(Collection))      ' Microsoft.VisualBasic
			reslover.LoadAssembly(GetType(Pen))             ' System.Drawing
			reslover.LoadAssembly(GetType(Form))            ' System.Windows.Forms
			reslover.BuildList()
		End Sub

		Private Sub EditTextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EditTextBox.KeyPress
			If Not Settings.EnableAutoFinish Then Exit Sub

			If e.KeyChar = "." Then
				' if there's nothing to finish then exit
				If GetLastWord(EditTextBox.Text, EditTextBox.SelectionStart) = "" Then
					Exit Sub
				End If
				' if it's already here then delete it
				If cuebox IsNot Nothing Then
					DeleteBox()
					Exit Sub
				End If

				cuebox = CreateCueBox(EditTextBox.GetPositionFromCharIndex(EditTextBox.SelectionStart))
				textcue = CreateLabel(cuebox.Location)
				textcue.Left += cuebox.Width + 10

				AddHandler cuebox.KeyPress, AddressOf ListBox_KeyPress
				AddHandler cuebox.DoubleClick, AddressOf ListBox_DoubleClick
				AddHandler cuebox.LostFocus, AddressOf ListBox_LostFocus
				AddHandler cuebox.SelectedIndexChanged,
												AddressOf ListBox_SelectionChange

				Dim name As String = GetName(EditTextBox, e.KeyChar)
				Dim member As TypeResolver.SpaceMember = reslover.ResolveType(name)
				If member IsNot Nothing Then
					' this is a class! add all class member into this box

					For Each mem In member.Type.GetMembers()
						' if it's a repeat then skip
						If cuebox.Items.ContainsKey(mem.Name) Then Continue For

						' icons switch
						Dim num As Integer = -1
						Select Case mem.MemberType
							Case Reflection.MemberTypes.NestedType
								num = 0
							Case Reflection.MemberTypes.Event
								num = 1
							Case Reflection.MemberTypes.Field
								If Not CType(mem, Reflection.FieldInfo).IsPublic Then Continue For
								num = 2
							Case Reflection.MemberTypes.Method
								If Not CType(mem, Reflection.MethodInfo).IsPublic Then Continue For
								num = 3
							Case Reflection.MemberTypes.Property
								num = 4
							Case Reflection.MemberTypes.Constructor
								num = 3
						End Select

						If num >= 0 Then
							Dim i = cuebox.Items.Add(mem.Name, num)
							i.Name = mem.Name
							' set the tag to get info in selectionChange()
							i.Tag = member.Type
						Else
							' unexpected member type
							Dim i = cuebox.Items.Add(mem.Name)
							i.Name = mem.Name
						End If
					Next

					' show it
					cuebox.Show()
					cuebox.Focus()
				Else
					' ...is it a namespace name?
					Dim types As List(Of TypeResolver.SpaceMember) = reslover.ResolveNamespace(name)

					If types Is Nothing Then
						' if not, everything is over
						DeleteBox()
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
						cuebox.Items.Add(t.Name, iconIndex).Tag = t.Type
					Next

					' show it
					cuebox.Show()
					cuebox.Focus()
				End If
			Else
				If cuebox IsNot Nothing Then DeleteBox()
			End If

		End Sub

		'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

		Private Sub ListBox_KeyPress(sender As Object, e As KeyPressEventArgs)
			Dim lb = CType(sender, ListView)
			If e.KeyChar = " " Then
				If lb.SelectedItems.Count = 0 Then Exit Sub
				Dim oldSS = EditTextBox.SelectionStart
				EditTextBox.Text = EditTextBox.Text.Insert(EditTextBox.SelectionStart, lb.SelectedItems(0).Text)
				EditTextBox.SelectionStart = oldSS + lb.SelectedItems(0).Text.Length
				DeleteBox()
			ElseIf e.KeyChar = vbBack Then
				DeleteBox()
			End If
		End Sub

		Private Sub ListBox_DoubleClick(sender As Object, e As EventArgs)
			Dim lb = CType(sender, ListView)
			If lb.SelectedItems.Count = 0 Then Exit Sub
			Dim oldSS = EditTextBox.SelectionStart
			EditTextBox.Text = EditTextBox.Text.Insert(EditTextBox.SelectionStart, lb.SelectedItems(0).Text)
			EditTextBox.SelectionStart = oldSS + lb.SelectedItems(0).Text.Length
			DeleteBox()
		End Sub

		Private Sub ListBox_LostFocus(sender As Object, e As EventArgs)
			DeleteBox()
		End Sub

		Private Sub ListBox_SelectionChange(sender As Object, e As EventArgs)
			Dim lb = cuebox
			If lb.SelectedItems.Count = 0 Then Exit Sub

			Dim it = lb.SelectedItems(0)
			Dim t = CType(lb.SelectedItems(0).Tag, Type)
			Try
				Select Case it.ImageIndex
					Case 0
						' class
						textcue.Text = "Class " & it.Text
						Exit Sub
					Case 6
						' enum
						textcue.Text = "Enum " & it.Text
						Exit Sub
					Case 7
						' interface
						textcue.Text = "Interface " & it.Text
						Exit Sub
					Case 4
						' property
						textcue.Text = "Property " & it.Text & " As " & t.GetProperty(it.Text).PropertyType.Name
					Case 2
						' field
						Dim f = t.GetField(it.Text)
						textcue.Text = it.Text & " As " & f.FieldType.Name
						If f.IsStatic Then textcue.Text &= " = " & f.GetValue(Nothing).ToString()
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
						textcue.Text = str
						Exit Sub
				End Select
			Catch ex As Exception
				textcue.Text = ""
			End Try
		End Sub

		'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

		Private Sub DeleteBox()
			If textcue IsNot Nothing Then textcue.Dispose()
			textcue = Nothing

			If cuebox IsNot Nothing Then cuebox.Dispose()
			cuebox = Nothing
		End Sub

		Private Function CreateCueBox(loca As Point) As ListView
			Dim cue As New ListView()
			cue.Name = "keywdCue"
			cue.SmallImageList = Images
			cue.Font = TextFont
			cue.View = View.SmallIcon
			cue.TabStop = False
			cue.TabIndex = 100
			cue.Size = New Size(200, 400)
			cue.Location = EditTextBox.GetPositionFromCharIndex(EditTextBox.SelectionStart)
			cue.Left += 10
			cue.Top += 20
			EditTextBox.Controls.Add(cue)

			Return cue
		End Function

		Private Function CreateLabel(loca As Point) As Label
			Dim text As New Label()

			EditTextBox.Controls.Add(text)
			text.Text = "Test"
			text.Font = TextFont
			text.Location = loca
			text.BorderStyle = BorderStyle.FixedSingle
			text.BackColor = Color.LightYellow
			text.AutoSize = True
			text.MaximumSize = New Size(EditTextBox.Width - text.Left,
										EditTextBox.Height - text.Height)

			Return text
		End Function

		Private sepr As Char() = {"+", "-", "*", "/", " ", "(", ")", "{", "}", ",", "&", "^", "="}

		Public Function GetName(rt As RichTextBox, editChar As Char) As String
			Dim reftxt As String
			reftxt = rt.Lines(rt.GetLineFromCharIndex(rt.SelectionStart)) & editChar
			Dim pos = reftxt.LastIndexOf(".")
			If pos >= 0 Then reftxt = Left(reftxt, pos)
			reftxt = Trim(reftxt)

			For Each sep In sepr
				Dim npos = reftxt.LastIndexOf(sep)
				If npos >= 0 Then reftxt = reftxt.Substring(npos + 1)
			Next
			Return reftxt
		End Function

		Public Function GetLastWord(s As String, i As Integer) As String
			' Get the last word.
			Dim x = Left(s, i)
			x = Regex.Match(x, "\s*[a-zA-Z]+\s*", RegexOptions.RightToLeft).Value

			' Remove all whitespaces.
			x = Regex.Replace(x, "\s", "")

			Return x
		End Function
	End Class
End Namespace
