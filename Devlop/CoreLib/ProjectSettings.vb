' ProjectSettings.vb
' This file contains:
'
' Class Develop.ProjectSettings

Imports Develop.Core

''' <summary>
''' Form to edit project settings.
''' </summary>
Public Class ProjectSettings
    Dim _manager As Manager

    Public Sub New(man As Manager)
        ' 此调用是设计器所必需的。
        InitializeComponent()
        
        ListView1.Clear
        For Each ref In man.References
            ListView1.Items.Add(ref)
        Next

		ListView2.Clear
        For Each ref In man.ImportStatments
            ListView2.Items.Add(ref)
        Next

        _manager = man
    End Sub

    Private Sub Button1_Click( sender As Object,  e As EventArgs) Handles Button1.Click
        ListView1.Items.Add("New Item")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each item In ListView1.SelectedIndices
            ListView1.Items.RemoveAt(item)
        Next
    End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		ListView2.Items.Add("New Item")
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		For Each item In ListView2.SelectedIndices
            ListView2.Items.RemoveAt(item)
        Next
	End Sub

	Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
		_manager.References.Clear
        For Each item As ListViewItem In ListView1.Items
            _manager.References.Add(item.Text)
        Next

		_manager.ImportStatments.Clear
        For Each item As ListViewItem In ListView2.Items
            _manager.ImportStatments.Add(item.Text)
        Next

		Close()
	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
		Close()
	End Sub

	Private Sub ProjectSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class