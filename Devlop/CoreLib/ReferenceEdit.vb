Public Class ReferencesEdit
    Dim _m As Manager

    Private Sub Button1_Click( sender As Object,  e As EventArgs) Handles Button1.Click
        ListView1.Items.Add("New Item")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each item In ListView1.SelectedIndices
            ListView1.Items.RemoveAt(item)
        Next
    End Sub
    Public Sub New(man As Manager)
        
        ' 此调用是设计器所必需的。
        InitializeComponent()
        
        ' 在 InitializeComponent() 调用之后添加任何初始化。
        
        ListView1.Clear
        For Each ref In man.referencesAssm
            ListView1.Items.Add(ref)
        Next

        _m = man

    End Sub

    Private Sub ReferencesEdit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _m.referencesAssm.Clear
        For Each item As ListViewItem In ListView1.Items
            _m.referencesAssm.Add(item.Text)
        Next
    End Sub
End Class