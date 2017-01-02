Public Class ProjectSettings
    Dim _m As Manager

    Public Sub New(man As Manager)
        
        ' 此调用是设计器所必需的。
        InitializeComponent()
        
        ' 在 InitializeComponent() 调用之后添加任何初始化。
        
        ListView1.Clear
        For Each ref In man.References
            ListView1.Items.Add(ref)
        Next

		ListView2.Clear
        For Each ref In man.ImportStatments
            ListView2.Items.Add(ref)
        Next

        _m = man

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
		_m.References.Clear
        For Each item As ListViewItem In ListView1.Items
            _m.References.Add(item.Text)
        Next

		_m.ImportStatments.Clear
        For Each item As ListViewItem In ListView2.Items
            _m.ImportStatments.Add(item.Text)
        Next

		Me.Close()
	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
		Me.Close()
	End Sub
	
End Class