Imports Develop.Core

Public Class FormMain
	Dim man As Manager
	Dim page As New Blank
	Dim sav As CodeGenerater
	Dim ctrl As New ControlCreater

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Settings.Initialize

		man = New Manager(page, PropertyGrid1, TextBox1)

		page.MdiParent = Me
		page.Show()
	End Sub

	Private Sub TreeView1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
		Try
			Dim c As Control = ctrl.CreatControlToContainer(e.Node.Text, page)
			man.AddControl(c)
		Catch ex As Exception
			MsgBox("Error in creating control!")
		End Try
	End Sub

	Private Sub TestRunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestRunToolStripMenuItem.Click
		Status.Text = "Compiling..."
		Progress.Style = ProgressBarStyle.Marquee
		
		compileTo("\temp.exe")
	End Sub

	Private Sub BuildExecutableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuildExecutableToolStripMenuItem.Click
		SaveFileDialog1.Filter = "Executable|*.exe"
		If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub

		Status.Text = "Compiling..."
		Progress.Style = ProgressBarStyle.Marquee

		compileTo(SaveFileDialog1.FileName)
	End Sub

	Private Sub compileTo(path As String)
		Dim code As String = New CodeGenerater(man).Compile
		Dim cr = New CodeRunner(code, man.DesignerForm.Text, man)
		cr.Compile(path)
		Progress.Style = ProgressBarStyle.Blocks
		
		DialogError.ListBox1.Items.Clear()

		If cr.Errors.Count <> 0 Then
			Dim genLines As Integer = 
				code.Split(vbCrLf).Length - man.UserCode.Split(vbCrLf).Length - 1

			My.Forms.CodeEdit.Highlighter.ErrorLines.Clear

			For Each er As CodeDom.Compiler.CompilerError In cr.Errors
				If er.IsWarning Then
					DialogError.ListBox1.Items.Add(
						"Warning " & er.ErrorNumber & " at line " & er.Line - genLines & 
						": " & vbCrLf & er.ErrorText)
				Else
					DialogError.ListBox1.Items.Add(
						"Error " & er.ErrorNumber & " at line " & er.Line - genLines & 
						": " & vbCrLf & er.ErrorText)

					My.Forms.CodeEdit.Highlighter.ErrorLines.Add(er.Line - genLines - 1)
				End If
			Next

			DialogError.ShowDialog()
		Else
			Status.Text = "Compiled, running..."
			Shell(path)
		End If
		Status.Text = "Ready"
	End Sub

	Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
		SaveFileDialog1.Filter = "Xml form data|*.xml"
		If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub

		Dim s As New IO.StreamWriter(SaveFileDialog1.FileName)
		s.Write(New XmlSaver(man).CompileToXml())
		s.Flush()
		s.Close()
	End Sub

	Private Sub ReferencesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjSettingsToolStripMenuItem.Click
		Dim ref As New ProjectSettings(man)
		ref.ShowDialog()
	End Sub

	Private Sub ToolStripButton2_CheckedChanged(sender As Object, e As EventArgs) Handles ToolStripButton2.CheckedChanged
		If ToolStripButton2.Checked Then
			' QUESTION: if i add this line then program crash
			' page.MdiParent = Me
			page.Show()
		Else
			page.Close()
		End If
	End Sub

	Private Sub ToolStripButton1_CheckedChanged(sender As Object, e As EventArgs) Handles ToolStripButton1.CheckedChanged
		If ToolStripButton1.Checked Then
			CodeEdit.MManager = man
			CodeEdit.MdiParent = Me
			CodeEdit.Show()
		Else
			CodeEdit.Close()
		End If
	End Sub

	Private Sub SplittedViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SplittedViewToolStripMenuItem.Click
		Me.LayoutMdi(MdiLayout.TileHorizontal)
	End Sub

	Private Sub StackViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StackViewToolStripMenuItem.Click
		Me.LayoutMdi(MdiLayout.Cascade)
	End Sub

	Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
		AboutBox.Show()
	End Sub

	Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
		OptionWindow.Show()
	End Sub

	Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadFormToolStripMenuItem.Click
		If OpenFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub
		Dim x As New XmlLoader(man)
		x.LoadXml(OpenFileDialog1.FileName)
	End Sub

End Class
