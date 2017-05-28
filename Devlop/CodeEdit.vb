Imports Develop.Core
Imports Develop.Editing

Public Class CodeEdit
	Friend Shared opened As Boolean = False

	Dim _manager As Manager
	Public Highlighter As HighlightingSup,
			Finisher As AutoFinishSup,
			Taber As AutoTabsSup,
			Snippeter As CodeSnippetSup
	Dim snippets As New Dictionary(Of String, String)

	Private Sub SaveCode_Click(sender As Object, e As EventArgs) Handles SaveCode.Click
		_manager.UserCode = Me.RichTextBox1.Text
	End Sub

	Private Sub RebuildData_Click(sender As Object, e As EventArgs) Handles RebuildData.Click
		Finisher = New AutoFinishSup(RichTextBox1, ImageList1, _manager.ImportStatments.ToArray)
	End Sub

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

		Highlighter = New HighlightingSup(RichTextBox1, Keywords.KeyTable)
		Finisher = New AutoFinishSup(RichTextBox1, ImageList1, _manager.ImportStatments.ToArray)
		Taber = New AutoTabsSup(RichTextBox1)
		Snippeter = New CodeSnippetSup(RichTextBox1, ListBox1)
	End Sub

	Private Sub RichTextBox1_SelectionChanged(sender As Object, e As EventArgs) Handles RichTextBox1.SelectionChanged
		LineLabel.Text = "Line: " &
			RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart)
		RowLabel.Text = "Row: " &
			RichTextBox1.SelectionStart - RichTextBox1.GetFirstCharIndexOfCurrentLine()
		SelectLabel.Text = "Selection length: " &
			RichTextBox1.SelectionLength
	End Sub

End Class