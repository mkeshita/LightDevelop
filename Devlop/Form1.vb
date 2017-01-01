Public Class Form1
    Dim man As Manager
    Dim page As New Blank
    Dim sav As Saver

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        man = New Manager(page, PropertyGrid1, TextBox1)

        page.MdiParent = Me
        page.Show()
    End Sub

    Private Sub TreeView1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        Try
            Dim c As Control = AddControlHelper.CreatControlToContainer(e.Node.Text, page)
            man.AddControl(c)
        Catch ex As Exception
            MsgBox("Error in creating control!")
        End Try
    End Sub

    Private Sub ViewSourceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSourceToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Code file|*.vb|Text file|*.txt|All files|*.*"
        If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub
		sav = New Saver(man)
        Dim i = New IO.StreamWriter(SaveFileDialog1.FileName, False)
        i.Write(sav.CompileForm)
        i.Flush()
        i.Close()
    End Sub

    Private Sub CreateExecutableToolStripMenuItem_Click( sender As Object,  e As EventArgs) Handles CreateExecutableToolStripMenuItem.Click
		SaveFileDialog1.Filter = "Executable|*.exe"
		If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub

		Status.Text = "Compiling..."
		Progress.Style = ProgressBarStyle.Marquee
        Dim cr = New CodeRunner(SaveFileDialog1.FileName, New Saver(man).CompileForm, man._f.Text, man)
        cr.Compile(SaveFileDialog1.FileName)
		Progress.Style = ProgressBarStyle.Blocks

        DialogError.ListBox1.Items.Clear
        If cr.Errors.Count <> 0 Then
            For Each er As CodeDom.Compiler.CompilerError In cr.Errors
                DialogError.ListBox1.Items.Add(
					"Error " & er.ErrorNumber & ": " & vbCrLf & er.ErrorText)
            Next
            DialogError.ShowDialog
        Else
            Status.Text = "Compiled, running..."
            Shell(SaveFileDialog1.FileName)
        End If
		Status.Text = "Ready"
    End Sub

    Private Sub SaveToolStripMenuItem_Click( sender As Object,  e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Xml form data|*.xml"
		If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub

		Dim s As New IO.StreamWriter(SaveFileDialog1.FileName)
		s.Write(New XmlSaver(man).CompileToXml())
		s.Flush
		s.Close
    End Sub

    Private Sub ReferencesToolStripMenuItem_Click( sender As Object,  e As EventArgs) Handles ReferencesToolStripMenuItem.Click
        Dim ref As New ReferencesEdit(man)
        ref.ShowDialog
    End Sub

	Private Sub ToolStripButton2_CheckedChanged(sender As Object, e As EventArgs) Handles ToolStripButton2.CheckedChanged
		If ToolStripButton2.Checked Then
			page.Show()
		Else
			page.Hide()
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
		AboutBox.show()
	End Sub

	Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
		OptionWindow.show()
	End Sub

	Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadFormToolStripMenuItem.Click
		If OpenFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub
		Dim x As New XmlLoader(man)
		x.LoadXml(OpenFileDialog1.FileName)
	End Sub
End Class
