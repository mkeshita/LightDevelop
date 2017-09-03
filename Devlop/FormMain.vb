' Manager.vb
' This file contains:
'
' Class Develop.FormMain

Imports Develop.Core

''' <summary>
''' The main UI for the program.
''' </summary>
Public Class FormMain
	Dim _manager As Manager
	Dim _designer As New Blank

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		_manager = New Manager(_designer, PropertyGrid, NameBox)

		_designer.MdiParent = Me
		_designer.Show()
	End Sub

	Private Sub ToolList_ItemClick(sender As Object, item As String) Handles ToolList.ItemClick
		Try
			_manager.AddControl(ControlCreater.CreatControlToContainer(item, _designer))
		Catch ex As Exception
			MsgBox("Error in creating control!")
		End Try
	End Sub

	Private Sub TestRun()
		CompileTo("\temp.exe")
	End Sub

	Private Sub BuildExecutable()
		SaveDialog.Filter = "Executable|*.exe"
		If SaveDialog.ShowDialog() = DialogResult.Cancel Then Exit Sub

		CompileTo(SaveDialog.FileName)
	End Sub

	Private Sub CompileTo(name As String)
		Status.Text = "Compiling..."
		Progress.Style = ProgressBarStyle.Marquee
		Dim compiler = New CodeCompiler(New CodeGenerator(_manager).Generate, _manager.DesignerForm.Text, _manager)
		compiler.Compile(name)
		Progress.Style = ProgressBarStyle.Blocks

		DialogError.ListBox1.Items.Clear()

		If compiler.Errors.Count <> 0 Then
			For Each er As CodeDom.Compiler.CompilerError In compiler.Errors
				DialogError.ListBox1.Items.Add(
					"Error " & er.ErrorNumber & ": " & vbCrLf & er.ErrorText)
			Next
			DialogError.ShowDialog()
		Else
			Status.Text = "Compiled, running..."

			' no debug for now
			Shell("\temp.exe")
		End If
		Status.Text = "Ready"

	End Sub

	Private Sub Save()
		SaveDialog.Filter = "Xml form data|*.xml"
		If SaveDialog.ShowDialog() = DialogResult.Cancel Then Exit Sub

		Dim s As New IO.StreamWriter(SaveDialog.FileName)
		s.Write(New XmlSaver(_manager).CompileToXml())
		s.Flush()
		s.Close()
	End Sub

	Private Sub ProjSettings()
		Dim ref As New ProjectSettings(_manager)
		ref.ShowDialog()
	End Sub

	Private Sub Open()
		If OpenDialog.ShowDialog() = DialogResult.Cancel Then Exit Sub
		Dim x As New XmlLoader(_manager)
		x.LoadXml(OpenDialog.FileName)
	End Sub

	Private Sub ToolOpen_Click(sender As Object, e As EventArgs) Handles ToolOpen.Click
		Open()
	End Sub

	Private Sub ToolCode_Click(sender As Object, e As EventArgs) Handles ToolCode.Click
		If ToolCode.Checked Then
			CodeEdit.MManager = _manager
			CodeEdit.Show()
		Else
			CodeEdit.Close()
		End If
	End Sub

	Private Sub ToolBuild_Click(sender As Object, e As EventArgs) Handles ToolBuild.Click
		BuildExecutable()
	End Sub

	Private Sub ToolTest_Click(sender As Object, e As EventArgs) Handles ToolTest.Click
		TestRun()
	End Sub

	Private Sub ToolStripSave_Click(sender As Object, e As EventArgs) Handles ToolStripSave.Click
		Save()
	End Sub
End Class
