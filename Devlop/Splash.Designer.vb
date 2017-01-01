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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.bPanel4 = New System.Windows.Forms.Panel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.bPanel3 = New System.Windows.Forms.Panel()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.bPanel1 = New System.Windows.Forms.Panel()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.bPanel2 = New System.Windows.Forms.Panel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.TableLayoutPanel1.SuspendLayout
		Me.bPanel4.SuspendLayout
		Me.Panel4.SuspendLayout
		Me.bPanel3.SuspendLayout
		Me.Panel2.SuspendLayout
		Me.bPanel1.SuspendLayout
		Me.bPanel2.SuspendLayout
		Me.SuspendLayout
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.29032!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.70968!))
		Me.TableLayoutPanel1.Controls.Add(Me.bPanel4, 1, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.bPanel2, 1, 0)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.White
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.42574!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.57426!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(573, 424)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'bPanel4
		'
		Me.bPanel4.BackColor = System.Drawing.Color.Transparent
		Me.bPanel4.Controls.Add(Me.Label2)
		Me.bPanel4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.bPanel4.Location = New System.Drawing.Point(354, 246)
		Me.bPanel4.Name = "bPanel4"
		Me.bPanel4.Size = New System.Drawing.Size(216, 175)
		Me.bPanel4.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Black
		Me.Label2.Font = New System.Drawing.Font("Consolas", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label2.Location = New System.Drawing.Point(0, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(189, 57)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "By Kong Xiangxiang, "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"2016/12."&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Enjoy it!"
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.Transparent
		Me.Panel4.Controls.Add(Me.bPanel3)
		Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel4.Location = New System.Drawing.Point(3, 246)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(345, 175)
		Me.Panel4.TabIndex = 2
		'
		'bPanel3
		'
		Me.bPanel3.BackColor = System.Drawing.Color.Transparent
		Me.bPanel3.Controls.Add(Me.Label3)
		Me.bPanel3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.bPanel3.Location = New System.Drawing.Point(0, 0)
		Me.bPanel3.Name = "bPanel3"
		Me.bPanel3.Size = New System.Drawing.Size(345, 175)
		Me.bPanel3.TabIndex = 1
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.Black
		Me.Label3.Font = New System.Drawing.Font("Consolas", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label3.Location = New System.Drawing.Point(54, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(272, 57)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Version 1.0.1 Release"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"This is the first relese version."&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Design for Windows 7 or"& _ 
    " later."
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.Transparent
		Me.Panel2.Controls.Add(Me.bPanel1)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel2.Location = New System.Drawing.Point(3, 3)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(345, 237)
		Me.Panel2.TabIndex = 1
		'
		'bPanel1
		'
		Me.bPanel1.BackColor = System.Drawing.Color.Transparent
		Me.bPanel1.Controls.Add(Me.Button2)
		Me.bPanel1.Controls.Add(Me.Button1)
		Me.bPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.bPanel1.Location = New System.Drawing.Point(0, 0)
		Me.bPanel1.Name = "bPanel1"
		Me.bPanel1.Size = New System.Drawing.Size(345, 237)
		Me.bPanel1.TabIndex = 1
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.Color.Silver
		Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
		Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.Button2.ForeColor = System.Drawing.Color.Black
		Me.Button2.Location = New System.Drawing.Point(193, 148)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(133, 37)
		Me.Button2.TabIndex = 2
		Me.Button2.Text = "About"
		Me.Button2.UseVisualStyleBackColor = false
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.Silver
		Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
		Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.Button1.ForeColor = System.Drawing.Color.Black
		Me.Button1.Location = New System.Drawing.Point(193, 191)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(133, 37)
		Me.Button1.TabIndex = 1
		Me.Button1.Text = "Skip"
		Me.Button1.UseVisualStyleBackColor = false
		'
		'bPanel2
		'
		Me.bPanel2.BackColor = System.Drawing.Color.Transparent
		Me.bPanel2.Controls.Add(Me.Label1)
		Me.bPanel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.bPanel2.Location = New System.Drawing.Point(354, 3)
		Me.bPanel2.Name = "bPanel2"
		Me.bPanel2.Size = New System.Drawing.Size(216, 237)
		Me.bPanel2.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.Black
		Me.Label1.Font = New System.Drawing.Font("微软雅黑", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label1.Location = New System.Drawing.Point(21, 148)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(168, 50)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Develop"
		'
		'Timer1
		'
		Me.Timer1.Enabled = true
		Me.Timer1.Interval = 10000
		'
		'Splash
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Black
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"),System.Drawing.Image)
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.ClientSize = New System.Drawing.Size(573, 424)
		Me.ControlBox = false
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Cursor = System.Windows.Forms.Cursors.AppStarting
		Me.DoubleBuffered = true
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "Splash"
		Me.ShowInTaskbar = false
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.TableLayoutPanel1.ResumeLayout(false)
		Me.bPanel4.ResumeLayout(false)
		Me.Panel4.ResumeLayout(false)
		Me.bPanel3.ResumeLayout(false)
		Me.Panel2.ResumeLayout(false)
		Me.bPanel1.ResumeLayout(false)
		Me.bPanel2.ResumeLayout(false)
		Me.ResumeLayout(false)

End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents bPanel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents bPanel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents bPanel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents bPanel1 As Panel
End Class
