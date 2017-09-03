' CodeEdit.vb
' This file contains:
'
' Class Develop.CodeEdit

Imports Develop.Core
Imports Develop.Editing

''' <summary>
''' Form of code editing interface.
''' </summary>
Public Class CodeEdit
	Friend Shared opened As Boolean = False

	Dim _manager As Manager
	Dim _autofinish As AutoFinish

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
		Editor.AllText = MManager.UserCode
		Editor.ColorTable = New List(Of Color)(Keywords.ColorTable)
		Editor.HighlightRules = 
				New List(Of KeyValuePair(Of String, Integer))(Keywords.RuleTable)
		_autofinish = New AutoFinish(Editor, ImageList1, _manager.ImportStatments.ToArray)
	End Sub

	Private Sub RichTextBox1_SelectionChanged(sender As Object, e As EventArgs) Handles Editor.SelectionChanged
		LineLabel.Text = "Line: " & Editor.CurrentCursor.Y
		RowLabel.Text = "Row: " & Editor.CurrentCursor.X
	End Sub

	Private Sub SaveCode_Click(sender As Object, e As EventArgs) Handles SaveCode.Click
		_manager.UserCode = Editor.AllText
	End Sub

	Private Sub RebuildData_Click(sender As Object, e As EventArgs) Handles RebuildData.Click
		_autofinish.RebuildResolver()
	End Sub
End Class