<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutBox
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

	Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents LabelProductName As System.Windows.Forms.Label
	Friend WithEvents LabelVersion As System.Windows.Forms.Label
	Friend WithEvents LabelCompanyName As System.Windows.Forms.Label
	Friend WithEvents OKButton As System.Windows.Forms.Button
	Friend WithEvents LabelCopyright As System.Windows.Forms.Label

	'Windows 窗体设计器所必需的
	Private components As System.ComponentModel.IContainer

	'注意: 以下过程是 Windows 窗体设计器所必需的
	'可以使用 Windows 窗体设计器修改它。  
	'不要使用代码编辑器修改它。
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutBox))
		Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
		Me.LabelProductName = New System.Windows.Forms.Label()
		Me.LabelVersion = New System.Windows.Forms.Label()
		Me.LabelCopyright = New System.Windows.Forms.Label()
		Me.LabelCompanyName = New System.Windows.Forms.Label()
		Me.OKButton = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TableLayoutPanel.SuspendLayout
		Me.SuspendLayout
		'
		'TableLayoutPanel
		'
		Me.TableLayoutPanel.BackColor = System.Drawing.Color.Transparent
		Me.TableLayoutPanel.ColumnCount = 2
		Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
		Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 310!))
		Me.TableLayoutPanel.Controls.Add(Me.LabelProductName, 0, 0)
		Me.TableLayoutPanel.Controls.Add(Me.LabelVersion, 0, 1)
		Me.TableLayoutPanel.Controls.Add(Me.LabelCopyright, 0, 2)
		Me.TableLayoutPanel.Controls.Add(Me.LabelCompanyName, 0, 3)
		Me.TableLayoutPanel.Controls.Add(Me.OKButton, 1, 4)
		Me.TableLayoutPanel.Controls.Add(Me.TextBox1, 1, 1)
		Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel.ForeColor = System.Drawing.Color.AliceBlue
		Me.TableLayoutPanel.Location = New System.Drawing.Point(9, 8)
		Me.TableLayoutPanel.Name = "TableLayoutPanel"
		Me.TableLayoutPanel.RowCount = 5
		Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.25253!))
		Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.79798!))
		Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.54545!))
		Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10101!))
		Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10!))
		Me.TableLayoutPanel.Size = New System.Drawing.Size(619, 533)
		Me.TableLayoutPanel.TabIndex = 0
		'
		'LabelProductName
		'
		Me.LabelProductName.BackColor = System.Drawing.Color.DarkCyan
		Me.TableLayoutPanel.SetColumnSpan(Me.LabelProductName, 2)
		Me.LabelProductName.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LabelProductName.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.LabelProductName.ForeColor = System.Drawing.Color.Black
		Me.LabelProductName.Location = New System.Drawing.Point(0, 0)
		Me.LabelProductName.Margin = New System.Windows.Forms.Padding(0)
		Me.LabelProductName.MaximumSize = New System.Drawing.Size(1000, 1000)
		Me.LabelProductName.Name = "LabelProductName"
		Me.LabelProductName.Size = New System.Drawing.Size(619, 135)
		Me.LabelProductName.TabIndex = 0
		Me.LabelProductName.Text = "Develop"
		Me.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LabelVersion
		'
		Me.LabelVersion.BackColor = System.Drawing.Color.CadetBlue
		Me.LabelVersion.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LabelVersion.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.LabelVersion.ForeColor = System.Drawing.Color.Black
		Me.LabelVersion.Location = New System.Drawing.Point(0, 135)
		Me.LabelVersion.Margin = New System.Windows.Forms.Padding(0)
		Me.LabelVersion.MaximumSize = New System.Drawing.Size(1000, 1000)
		Me.LabelVersion.Name = "LabelVersion"
		Me.LabelVersion.Size = New System.Drawing.Size(309, 212)
		Me.LabelVersion.TabIndex = 0
		Me.LabelVersion.Text = "Version 1.0.1 Release"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"First releast ever!"
		Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LabelCopyright
		'
		Me.LabelCopyright.BackColor = System.Drawing.Color.CadetBlue
		Me.LabelCopyright.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LabelCopyright.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.LabelCopyright.ForeColor = System.Drawing.Color.Black
		Me.LabelCopyright.Location = New System.Drawing.Point(0, 347)
		Me.LabelCopyright.Margin = New System.Windows.Forms.Padding(0)
		Me.LabelCopyright.MaximumSize = New System.Drawing.Size(1000, 1000)
		Me.LabelCopyright.Name = "LabelCopyright"
		Me.LabelCopyright.Size = New System.Drawing.Size(309, 77)
		Me.LabelCopyright.TabIndex = 0
		Me.LabelCopyright.Text = "Made by Kong Xiangxiang"
		Me.LabelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LabelCompanyName
		'
		Me.LabelCompanyName.BackColor = System.Drawing.Color.CadetBlue
		Me.LabelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LabelCompanyName.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.LabelCompanyName.ForeColor = System.Drawing.Color.Black
		Me.LabelCompanyName.Location = New System.Drawing.Point(0, 424)
		Me.LabelCompanyName.Margin = New System.Windows.Forms.Padding(0)
		Me.LabelCompanyName.MaximumSize = New System.Drawing.Size(1000, 1000)
		Me.LabelCompanyName.Name = "LabelCompanyName"
		Me.LabelCompanyName.Size = New System.Drawing.Size(309, 54)
		Me.LabelCompanyName.TabIndex = 0
		Me.LabelCompanyName.Text = "2016/12 - 2017/1"
		Me.LabelCompanyName.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'OKButton
		'
		Me.OKButton.BackColor = System.Drawing.Color.LightSeaGreen
		Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.OKButton.Dock = System.Windows.Forms.DockStyle.Right
		Me.OKButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
		Me.OKButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray
		Me.OKButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
		Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.OKButton.Font = New System.Drawing.Font("微软雅黑", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.OKButton.ForeColor = System.Drawing.Color.Black
		Me.OKButton.Location = New System.Drawing.Point(541, 481)
		Me.OKButton.MaximumSize = New System.Drawing.Size(80, 100)
		Me.OKButton.Name = "OKButton"
		Me.OKButton.Size = New System.Drawing.Size(75, 49)
		Me.OKButton.TabIndex = 0
		Me.OKButton.Text = "Okay"
		Me.OKButton.UseVisualStyleBackColor = false
		'
		'TextBox1
		'
		Me.TextBox1.BackColor = System.Drawing.Color.DarkSlateGray
		Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
		Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TextBox1.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.TextBox1.Location = New System.Drawing.Point(310, 135)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(1, 0, 0, 0)
		Me.TextBox1.Multiline = true
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TableLayoutPanel.SetRowSpan(Me.TextBox1, 3)
		Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.TextBox1.Size = New System.Drawing.Size(309, 343)
		Me.TextBox1.TabIndex = 1
		Me.TextBox1.Text = resources.GetString("TextBox1.Text")
		'
		'AboutBox
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.CadetBlue
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"),System.Drawing.Image)
		Me.CancelButton = Me.OKButton
		Me.ClientSize = New System.Drawing.Size(637, 549)
		Me.Controls.Add(Me.TableLayoutPanel)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "AboutBox"
		Me.Padding = New System.Windows.Forms.Padding(9, 8, 9, 8)
		Me.ShowInTaskbar = false
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "AboutBox"
		Me.TableLayoutPanel.ResumeLayout(false)
		Me.TableLayoutPanel.PerformLayout
		Me.ResumeLayout(false)

End Sub

	Friend WithEvents TextBox1 As TextBox
End Class
