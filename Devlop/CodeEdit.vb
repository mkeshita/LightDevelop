Imports System.Text.RegularExpressions
Imports Develop.Core
Imports Develop.Editing

Public Class CodeEdit
	Friend Shared opened As Boolean = False

	Dim _manager As Manager
	Dim autofin As AutoFinish
	Dim snippets As New Dictionary(Of String, String)

	Public Property MManager() As Manager
		Get
			Return _manager
		End Get
		Set(ByVal value As Manager)
			_manager = value
			Editor.AllText = value.UserCode
		End Set
	End Property

	Private Sub CodeEdit_FormClosing(sender As Object, e As EventArgs) Handles Me.FormClosing
		_manager.UserCode = Editor.AllText
		opened = False
	End Sub

	Private Sub CodeEdit_Load(sender As Object, e As EventArgs) Handles Me.Load
		opened = True
		Me.DoubleBuffered = True
		Editor.AllText = MManager.UserCode
		Editor.ColorTable = New List(Of Color)(Keywords.ColorTable)
		Editor.HighlightRules = 
				New List(Of KeyValuePair(Of String, Integer))(Keywords.RuleTable)
		autofin = New AutoFinish(Editor, ImageList1, _manager.ImportStatments.ToArray)
	End Sub

	Private Sub RichTextBox1_SelectionChanged(sender As Object, e As EventArgs) Handles Editor.SelectionChanged
		LineLabel.Text = "Line: " & Editor.CurrentCursor.Y
		RowLabel.Text = "Row: " & Editor.CurrentCursor.X
	End Sub

End Class