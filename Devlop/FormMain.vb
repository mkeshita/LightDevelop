Imports Develop.Core

Public Class FormMain
	Dim man As Manager
	Dim page As New Blank
	Dim sav As CodeGenerater

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		man = New Manager(page, PropertyGrid, NameBox)

		page.MdiParent = Me
		page.Show()
	End Sub

	Private Sub ToolList_ItemClick(sender As Object, item As String) Handles ToolList.ItemClick
		Try
			man.AddControl(CreatControlToContainer(item, page))
		Catch ex As Exception
			MsgBox("Error in creating control!")
		End Try
	End Sub

	Private Sub TestRun()
		Status.Text = "Compiling..."
		Progress.Style = ProgressBarStyle.Marquee
		Dim cr = New CodeRunner(New CodeGenerater(man).Compile, man.DesignerForm.Text, man)
		cr.Compile("\temp.exe")
		Progress.Style = ProgressBarStyle.Blocks

		DialogError.ListBox1.Items.Clear()

		If cr.Errors.Count <> 0 Then
			For Each er As CodeDom.Compiler.CompilerError In cr.Errors
				DialogError.ListBox1.Items.Add(
					"Error " & er.ErrorNumber & ": " & vbCrLf & er.ErrorText)
			Next
			DialogError.ShowDialog()
		Else
			Status.Text = "Compiled, running..."
			Shell("\temp.exe")
		End If
		Status.Text = "Ready"
	End Sub

	Private Sub BuildExecutable()
		SaveDialog.Filter = "Executable|*.exe"
		If SaveDialog.ShowDialog() = DialogResult.Cancel Then Exit Sub

		Status.Text = "Compiling..."
		Progress.Style = ProgressBarStyle.Marquee
		Dim cr = New CodeRunner(New CodeGenerater(man).Compile, man.DesignerForm.Text, man)
		cr.Compile(SaveDialog.FileName)
		Progress.Style = ProgressBarStyle.Blocks

		DialogError.ListBox1.Items.Clear()

		If cr.Errors.Count <> 0 Then
			For Each er As CodeDom.Compiler.CompilerError In cr.Errors
				DialogError.ListBox1.Items.Add(
					"Error " & er.ErrorNumber & ": " & vbCrLf & er.ErrorText)
			Next
			DialogError.ShowDialog()
		Else
			Status.Text = "Compiled, running..."
			Shell(SaveDialog.FileName)
		End If
		Status.Text = "Ready"
	End Sub

	Private Sub Save()
		SaveDialog.Filter = "Xml form data|*.xml"
		If SaveDialog.ShowDialog() = DialogResult.Cancel Then Exit Sub

		Dim s As New IO.StreamWriter(SaveDialog.FileName)
		s.Write(New XmlSaver(man).CompileToXml())
		s.Flush()
		s.Close()
	End Sub

	Private Sub ProjSettings()
		Dim ref As New ProjectSettings(man)
		ref.ShowDialog()
	End Sub

	Private Sub Open()
		If OpenDialog.ShowDialog() = DialogResult.Cancel Then Exit Sub
		Dim x As New XmlLoader(man)
		x.LoadXml(OpenDialog.FileName)
	End Sub

	Private Sub ToolOpen_Click(sender As Object, e As EventArgs) Handles ToolOpen.Click
		Open()
	End Sub

	Private Sub ToolCode_Click(sender As Object, e As EventArgs) Handles ToolCode.Click
		If ToolCode.Checked Then
			CodeEdit.MManager = man
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
