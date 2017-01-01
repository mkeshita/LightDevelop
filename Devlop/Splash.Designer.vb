<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
		Me.components = New System.ComponentModel.Container()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.Panel6 = New System.Windows.Forms.Panel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.Panel5 = New System.Windows.Forms.Panel()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.TableLayoutPanel1.SuspendLayout
		Me.Panel6.SuspendLayout
		Me.Panel4.SuspendLayout
		Me.Panel5.SuspendLayout
		Me.Panel2.SuspendLayout
		Me.Panel3.SuspendLayout
		Me.Panel1.SuspendLayout
		Me.SuspendLayout
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Lavender
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.29032!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.70968!))
		Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 1, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.42574!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.57426!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(563, 371)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'Panel6
		'
		Me.Panel6.BackColor = System.Drawing.Color.CornflowerBlue
		Me.Panel6.Controls.Add(Me.Label2)
		Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel6.Location = New System.Drawing.Point(348, 216)
		Me.Panel6.Name = "Panel6"
		Me.Panel6.Size = New System.Drawing.Size(212, 152)
		Me.Panel6.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = true
		Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
		Me.Label2.Font = New System.Drawing.Font("Consolas", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label2.Location = New System.Drawing.Point(0, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(189, 57)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "By Kong Xiangxiang, "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"2016/12."&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Enjoy it!"
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.MediumTurquoise
		Me.Panel4.Controls.Add(Me.Panel5)
		Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel4.Location = New System.Drawing.Point(3, 216)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(339, 152)
		Me.Panel4.TabIndex = 2
		'
		'Panel5
		'
		Me.Panel5.BackColor = System.Drawing.Color.Plum
		Me.Panel5.Controls.Add(Me.Label3)
		Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel5.Location = New System.Drawing.Point(0, 0)
		Me.Panel5.Name = "Panel5"
		Me.Panel5.Size = New System.Drawing.Size(339, 152)
		Me.Panel5.TabIndex = 1
		'
		'Label3
		'
		Me.Label3.AutoSize = true
		Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
		Me.Label3.Font = New System.Drawing.Font("Consolas", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label3.Location = New System.Drawing.Point(67, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(272, 51)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Version 1.0.1 Release"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"This is the first relese version."&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Design for Windows 7 or"& _ 
    " later."
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.MediumTurquoise
		Me.Panel2.Controls.Add(Me.Panel3)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel2.Location = New System.Drawing.Point(3, 3)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(339, 207)
		Me.Panel2.TabIndex = 1
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.PaleGreen
		Me.Panel3.Controls.Add(Me.Button2)
		Me.Panel3.Controls.Add(Me.Button1)
		Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel3.Location = New System.Drawing.Point(0, 0)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(339, 207)
		Me.Panel3.TabIndex = 1
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.Color.LightGreen
		Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
		Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
		Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.Button2.Location = New System.Drawing.Point(203, 124)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(133, 37)
		Me.Button2.TabIndex = 2
		Me.Button2.Text = "About"
		Me.Button2.UseVisualStyleBackColor = false
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.LightGreen
		Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
		Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
		Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.Button1.Location = New System.Drawing.Point(203, 167)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(133, 37)
		Me.Button1.TabIndex = 1
		Me.Button1.Text = "Skip"
		Me.Button1.UseVisualStyleBackColor = false
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.PowderBlue
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel1.Location = New System.Drawing.Point(348, 3)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(212, 207)
		Me.Panel1.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = true
		Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.Label1.Font = New System.Drawing.Font("微软雅黑", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label1.Location = New System.Drawing.Point(0, 115)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(184, 92)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "  Develop"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&" "
		'
		'Timer1
		'
		Me.Timer1.Enabled = true
		Me.Timer1.Interval = 3500
		'
		'Splash
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Black
		Me.ClientSize = New System.Drawing.Size(563, 371)
		Me.ControlBox = false
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Cursor = System.Windows.Forms.Cursors.AppStarting
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "Splash"
		Me.ShowInTaskbar = false
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.TableLayoutPanel1.ResumeLayout(false)
		Me.Panel6.ResumeLayout(false)
		Me.Panel6.PerformLayout
		Me.Panel4.ResumeLayout(false)
		Me.Panel5.ResumeLayout(false)
		Me.Panel5.PerformLayout
		Me.Panel2.ResumeLayout(false)
		Me.Panel3.ResumeLayout(false)
		Me.Panel1.ResumeLayout(false)
		Me.Panel1.PerformLayout
		Me.ResumeLayout(false)

End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
End Class
