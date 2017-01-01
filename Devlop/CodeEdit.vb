Imports System.Text.RegularExpressions

Public Class CodeEdit

    Friend Shared opened As Boolean = False
    Dim _manager As Manager, highlighter As HighlightingSup, finisher As AutoFinishSup, taber As AutoTabsSup
	Dim snippets As New Dictionary(Of String, String)

    Public Property MManager() As Manager
        Get
            Return _manager
        End Get
        Set(ByVal value As Manager)
            _manager = value
            Me.RichTextBox1.Text = value.UserCode
        End Set
    End Property

	Private Sub CodeEdit_FormClosing(sender As Object, e As EventArgs) Handles Me.FormClosing
        _manager.UserCode = Me.RichTextBox1.Text
        opened = False
    End Sub

    Private Sub CodeEdit_Load(sender As Object, e As EventArgs) Handles Me.Load
        opened = True
        Me.DoubleBuffered = True

		highlighter = New HighlightingSup(RichTextBox1, Keywords.KeyTable)
		finisher = New AutoFinishSup(RichTextBox1, ImageList1, _manager.References)
		taber = New AutoTabsSup(RichTextBox1)

		If Settings.EnableCodeSnippets Then
			Try
				Dim x = Xml.XmlReader.Create(Settings.CodeSnippetsLocation)
				x.ReadToFollowing("Item")
				Do
					Dim snipTitle, snipText As String
					snipTitle = x.GetAttribute("name")
					snipText = Regex.Replace(x.ReadString(), "\s{2,}", "")
					snippets.Add(snipTitle, snipText)
				Loop While x.ReadToNextSibling("Item")
				x.Close()

				ListBox1.Items.Clear()
				For Each pair In snippets
					ListBox1.Items.Add(pair.Key)
				Next
			Catch ex As Exception
				MessageBox.Show("Bad snippets file format! Disable code snippets to avoid this message.", 
								"Bad format", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		End If
    End Sub

    Private Sub RichTextBox1_SelectionChanged(sender As Object, e As EventArgs) Handles RichTextBox1.SelectionChanged
        LineLabel.Text = "Line: " & _
            RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart)
        RowLabel.Text = "Row: " & _
            RichTextBox1.SelectionStart - RichTextBox1.GetFirstCharIndexOfCurrentLine()
        SelectLabel.Text = "Selection length: " & _
            RichTextBox1.SelectionLength
    End Sub

	Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
		If ListBox1.SelectedIndices.Count = 1 Then
			Dim line As Integer = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart)
            Dim oldSelectionStart = RichTextBox1.SelectionStart
            If line = -1 Then Exit Sub
            Dim spaces As Integer = RichTextBox1.Lines(line).Length - LTrim(RichTextBox1.Lines(line)).Length

			Dim snip As String = snippets(ListBox1.SelectedItem).Replace("\n", vbCrLf & StrDup(spaces, " "))
			RichTextBox1.Text = 
                RichTextBox1.Text.Insert(oldSelectionStart, snip)

			RichTextBox1.SelectionStart = oldSelectionStart
		End If
	End Sub

	Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
		If ListBox1.SelectedIndices.Count = 1 Then
			Dim snip As String = snippets(ListBox1.SelectedItem).Replace("\n", vbCrLf)
			ToolTip.Show(snip, ListBox1,ListBox1.Width, 0, 2000)
		End If
	End Sub
End Class