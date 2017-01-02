<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectSettings
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("System.dll")
		Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("System.Windows.Forms.dll")
		Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("System.dll")
		Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("System.Windows.Forms.dll")
		Me.ListView1 = New System.Windows.Forms.ListView()
		Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.ListView2 = New System.Windows.Forms.ListView()
		Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.Button6 = New System.Windows.Forms.Button()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout
		Me.GroupBox2.SuspendLayout
		Me.GroupBox3.SuspendLayout
		Me.SuspendLayout
		'
		'ListView1
		'
		Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
		Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
		Me.ListView1.Font = New System.Drawing.Font("微软雅黑", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.ListView1.HideSelection = false
		ListViewItem1.StateImageIndex = 0
		ListViewItem2.StateImageIndex = 0
		Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
		Me.ListView1.LabelEdit = true
		Me.ListView1.LabelWrap = false
		Me.ListView1.Location = New System.Drawing.Point(6, 37)
		Me.ListView1.Name = "ListView1"
		Me.ListView1.Size = New System.Drawing.Size(282, 419)
		Me.ListView1.TabIndex = 0
		Me.ListView1.UseCompatibleStateImageBehavior = false
		Me.ListView1.View = System.Windows.Forms.View.List
		'
		'ColumnHeader1
		'
		Me.ColumnHeader1.Text = "References"
		Me.ColumnHeader1.Width = 276
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.LightGreen
		Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
		Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen
		Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.Button1.Location = New System.Drawing.Point(294, 20)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(47, 39)
		Me.Button1.TabIndex = 1
		Me.Button1.Text = "＋"
		Me.Button1.UseVisualStyleBackColor = false
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.Color.LightGreen
		Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
		Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen
		Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.Button2.Location = New System.Drawing.Point(294, 65)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(47, 39)
		Me.Button2.TabIndex = 2
		Me.Button2.Text = "－"
		Me.Button2.UseVisualStyleBackColor = false
		'
		'GroupBox1
		'
		Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.ListView1)
		Me.GroupBox1.Controls.Add(Me.Button1)
		Me.GroupBox1.Controls.Add(Me.Button2)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(349, 462)
		Me.GroupBox1.TabIndex = 4
		Me.GroupBox1.TabStop = false
		'
		'Label1
		'
		Me.Label1.AutoSize = true
		Me.Label1.Font = New System.Drawing.Font("微软雅黑", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.Label1.Location = New System.Drawing.Point(6, 17)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(75, 17)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "References:"
		'
		'GroupBox2
		'
		Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
		Me.GroupBox2.Controls.Add(Me.Label2)
		Me.GroupBox2.Controls.Add(Me.ListView2)
		Me.GroupBox2.Controls.Add(Me.Button3)
		Me.GroupBox2.Controls.Add(Me.Button4)
		Me.GroupBox2.Location = New System.Drawing.Point(367, 12)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(349, 462)
		Me.GroupBox2.TabIndex = 5
		Me.GroupBox2.TabStop = false
		'
		'Label2
		'
		Me.Label2.AutoSize = true
		Me.Label2.Font = New System.Drawing.Font("微软雅黑", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.Label2.Location = New System.Drawing.Point(6, 17)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(92, 17)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Code Imports:"
		'
		'ListView2
		'
		Me.ListView2.Activation = System.Windows.Forms.ItemActivation.OneClick
		Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
		Me.ListView2.Font = New System.Drawing.Font("微软雅黑", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.ListView2.HideSelection = false
		ListViewItem3.StateImageIndex = 0
		ListViewItem4.StateImageIndex = 0
		Me.ListView2.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem3, ListViewItem4})
		Me.ListView2.LabelEdit = true
		Me.ListView2.LabelWrap = false
		Me.ListView2.Location = New System.Drawing.Point(6, 41)
		Me.ListView2.Name = "ListView2"
		Me.ListView2.Size = New System.Drawing.Size(282, 415)
		Me.ListView2.TabIndex = 0
		Me.ListView2.UseCompatibleStateImageBehavior = false
		Me.ListView2.View = System.Windows.Forms.View.List
		'
		'ColumnHeader2
		'
		Me.ColumnHeader2.Text = "Code Imports"
		Me.ColumnHeader2.Width = 276
		'
		'Button3
		'
		Me.Button3.BackColor = System.Drawing.Color.LightGreen
		Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
		Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen
		Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.Button3.Location = New System.Drawing.Point(294, 20)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(47, 39)
		Me.Button3.TabIndex = 1
		Me.Button3.Text = "＋"
		Me.Button3.UseVisualStyleBackColor = false
		'
		'Button4
		'
		Me.Button4.BackColor = System.Drawing.Color.LightGreen
		Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
		Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen
		Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen
		Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button4.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.Button4.Location = New System.Drawing.Point(294, 65)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(47, 39)
		Me.Button4.TabIndex = 2
		Me.Button4.Text = "－"
		Me.Button4.UseVisualStyleBackColor = false
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.Button6)
		Me.GroupBox3.Controls.Add(Me.Button5)
		Me.GroupBox3.Location = New System.Drawing.Point(12, 480)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(704, 61)
		Me.GroupBox3.TabIndex = 6
		Me.GroupBox3.TabStop = false
		'
		'Button6
		'
		Me.Button6.Font = New System.Drawing.Font("微软雅黑", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.Button6.Location = New System.Drawing.Point(494, 20)
		Me.Button6.Name = "Button6"
		Me.Button6.Size = New System.Drawing.Size(98, 35)
		Me.Button6.TabIndex = 1
		Me.Button6.Text = "Okay"
		Me.Button6.UseVisualStyleBackColor = true
		'
		'Button5
		'
		Me.Button5.Font = New System.Drawing.Font("微软雅黑", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.Button5.Location = New System.Drawing.Point(598, 20)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(98, 35)
		Me.Button5.TabIndex = 0
		Me.Button5.Text = "Cancel"
		Me.Button5.UseVisualStyleBackColor = true
		'
		'ReferencesEdit
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Gainsboro
		Me.ClientSize = New System.Drawing.Size(741, 563)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "ReferencesEdit"
		Me.ShowIcon = false
		Me.ShowInTaskbar = false
		Me.Text = "Project Settings"
		Me.TopMost = true
		Me.GroupBox1.ResumeLayout(false)
		Me.GroupBox1.PerformLayout
		Me.GroupBox2.ResumeLayout(false)
		Me.GroupBox2.PerformLayout
		Me.GroupBox3.ResumeLayout(false)
		Me.ResumeLayout(false)

End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
	Friend WithEvents ColumnHeader1 As ColumnHeader
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents ListView2 As ListView
	Friend WithEvents ColumnHeader2 As ColumnHeader
	Friend WithEvents Button3 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents Button6 As Button
	Friend WithEvents Button5 As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
End Class
