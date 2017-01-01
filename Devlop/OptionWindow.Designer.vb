<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionWindow
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

	'注意: 以下过程是 Windows 窗体设计器所必需的
	'可以使用 Windows 窗体设计器修改它。  
	'不要使用代码编辑器修改它。
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.psnipBros = New System.Windows.Forms.Button()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.afinish = New System.Windows.Forms.CheckBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.hlight = New System.Windows.Forms.CheckBox()
		Me.csnippet = New System.Windows.Forms.CheckBox()
		Me.psnippet = New System.Windows.Forms.TextBox()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
		Me.TabControl1.SuspendLayout
		Me.TabPage1.SuspendLayout
		Me.TableLayoutPanel1.SuspendLayout
		Me.TabPage2.SuspendLayout
		Me.SuspendLayout
		'
		'TabControl1
		'
		Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.TabControl1.Controls.Add(Me.TabPage1)
		Me.TabControl1.Controls.Add(Me.TabPage2)
		Me.TabControl1.Location = New System.Drawing.Point(14, 17)
		Me.TabControl1.Margin = New System.Windows.Forms.Padding(17, 21, 17, 21)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(611, 313)
		Me.TabControl1.TabIndex = 0
		'
		'TabPage1
		'
		Me.TabPage1.BackColor = System.Drawing.Color.AliceBlue
		Me.TabPage1.Controls.Add(Me.psnipBros)
		Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
		Me.TabPage1.Location = New System.Drawing.Point(4, 26)
		Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.TabPage1.Size = New System.Drawing.Size(603, 283)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "Features"
		'
		'psnipBros
		'
		Me.psnipBros.BackColor = System.Drawing.Color.LightBlue
		Me.psnipBros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(255,Byte),Integer))
		Me.psnipBros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
		Me.psnipBros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
		Me.psnipBros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.psnipBros.Location = New System.Drawing.Point(567, 195)
		Me.psnipBros.Name = "psnipBros"
		Me.psnipBros.Size = New System.Drawing.Size(27, 23)
		Me.psnipBros.TabIndex = 1
		Me.psnipBros.Text = "..."
		Me.psnipBros.UseVisualStyleBackColor = false
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.09121!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.90879!))
		Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
		Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.afinish, 1, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.hlight, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.csnippet, 1, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.psnippet, 1, 3)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 30)
		Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 30, 3, 3)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 4
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(603, 201)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'Label4
		'
		Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
		Me.Label4.Location = New System.Drawing.Point(15, 150)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(72, 51)
		Me.Label4.TabIndex = 5
		Me.Label4.Text = "Snippets Path"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label3
		'
		Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
		Me.Label3.Location = New System.Drawing.Point(15, 100)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(72, 50)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "Code Snippets"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'afinish
		'
		Me.afinish.Appearance = System.Windows.Forms.Appearance.Button
		Me.afinish.AutoSize = true
		Me.afinish.BackColor = System.Drawing.Color.LightSeaGreen
		Me.afinish.Dock = System.Windows.Forms.DockStyle.Fill
		Me.afinish.FlatAppearance.BorderColor = System.Drawing.Color.Teal
		Me.afinish.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleTurquoise
		Me.afinish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
		Me.afinish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
		Me.afinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.afinish.Location = New System.Drawing.Point(93, 53)
		Me.afinish.Name = "afinish"
		Me.afinish.Size = New System.Drawing.Size(507, 44)
		Me.afinish.TabIndex = 3
		Me.afinish.Text = "Disabled"
		Me.afinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.afinish.UseVisualStyleBackColor = false
		'
		'Label2
		'
		Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
		Me.Label2.Location = New System.Drawing.Point(15, 50)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(72, 50)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Auto-Finish"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label1
		'
		Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
		Me.Label1.Location = New System.Drawing.Point(15, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(72, 50)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Highlight"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'hlight
		'
		Me.hlight.Appearance = System.Windows.Forms.Appearance.Button
		Me.hlight.AutoSize = true
		Me.hlight.BackColor = System.Drawing.Color.LightSeaGreen
		Me.hlight.Dock = System.Windows.Forms.DockStyle.Fill
		Me.hlight.FlatAppearance.BorderColor = System.Drawing.Color.Teal
		Me.hlight.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleTurquoise
		Me.hlight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
		Me.hlight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
		Me.hlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.hlight.Location = New System.Drawing.Point(93, 3)
		Me.hlight.Name = "hlight"
		Me.hlight.Size = New System.Drawing.Size(507, 44)
		Me.hlight.TabIndex = 1
		Me.hlight.Text = "Disabled"
		Me.hlight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.hlight.UseVisualStyleBackColor = false
		'
		'csnippet
		'
		Me.csnippet.Appearance = System.Windows.Forms.Appearance.Button
		Me.csnippet.AutoSize = true
		Me.csnippet.BackColor = System.Drawing.Color.LightSeaGreen
		Me.csnippet.Dock = System.Windows.Forms.DockStyle.Fill
		Me.csnippet.FlatAppearance.BorderColor = System.Drawing.Color.Teal
		Me.csnippet.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleTurquoise
		Me.csnippet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
		Me.csnippet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
		Me.csnippet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.csnippet.Location = New System.Drawing.Point(93, 103)
		Me.csnippet.Name = "csnippet"
		Me.csnippet.Size = New System.Drawing.Size(507, 44)
		Me.csnippet.TabIndex = 3
		Me.csnippet.Text = "Disabled"
		Me.csnippet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.csnippet.UseVisualStyleBackColor = false
		'
		'psnippet
		'
		Me.psnippet.BackColor = System.Drawing.Color.Azure
		Me.psnippet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.psnippet.Location = New System.Drawing.Point(93, 165)
		Me.psnippet.Margin = New System.Windows.Forms.Padding(3, 15, 3, 3)
		Me.psnippet.Name = "psnippet"
		Me.psnippet.ReadOnly = true
		Me.psnippet.Size = New System.Drawing.Size(475, 23)
		Me.psnippet.TabIndex = 6
		'
		'TabPage2
		'
		Me.TabPage2.BackColor = System.Drawing.Color.AliceBlue
		Me.TabPage2.Controls.Add(Me.TextBox2)
		Me.TabPage2.Controls.Add(Me.Label5)
		Me.TabPage2.Location = New System.Drawing.Point(4, 26)
		Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.TabPage2.Size = New System.Drawing.Size(603, 283)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "Misc"
		'
		'TextBox2
		'
		Me.TextBox2.BackColor = System.Drawing.Color.Azure
		Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBox2.Location = New System.Drawing.Point(102, 131)
		Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 15, 3, 3)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(495, 23)
		Me.TextBox2.TabIndex = 7
		'
		'Label5
		'
		Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
		Me.Label5.Location = New System.Drawing.Point(3, 4)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(93, 275)
		Me.Label5.TabIndex = 0
		Me.Label5.Text = "Tab Length"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label6
		'
		Me.Label6.AutoSize = true
		Me.Label6.Location = New System.Drawing.Point(439, 15)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(183, 17)
		Me.Label6.TabIndex = 1
		Me.Label6.Text = "Close window to save settings"
		'
		'OpenFile
		'
		Me.OpenFile.Filter = "Code Snippets|*.xml"
		'
		'OptionWindow
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 17!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(639, 347)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.TabControl1)
		Me.Font = New System.Drawing.Font("微软雅黑", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "OptionWindow"
		Me.ShowInTaskbar = false
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Options"
		Me.TopMost = true
		Me.TabControl1.ResumeLayout(false)
		Me.TabPage1.ResumeLayout(false)
		Me.TableLayoutPanel1.ResumeLayout(false)
		Me.TableLayoutPanel1.PerformLayout
		Me.TabPage2.ResumeLayout(false)
		Me.TabPage2.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents afinish As CheckBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents hlight As CheckBox
	Friend WithEvents csnippet As CheckBox
	Friend WithEvents psnipBros As Button
	Friend WithEvents psnippet As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents OpenFile As OpenFileDialog
End Class
