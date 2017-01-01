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
	Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
	Friend WithEvents LabelProductName As System.Windows.Forms.Label
	Friend WithEvents LabelVersion As System.Windows.Forms.Label
	Friend WithEvents LabelCompanyName As System.Windows.Forms.Label
	Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
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
		Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
		Me.LabelProductName = New System.Windows.Forms.Label()
		Me.LabelVersion = New System.Windows.Forms.Label()
		Me.LabelCopyright = New System.Windows.Forms.Label()
		Me.LabelCompanyName = New System.Windows.Forms.Label()
		Me.TextBoxDescription = New System.Windows.Forms.TextBox()
		Me.OKButton = New System.Windows.Forms.Button()
		Me.TableLayoutPanel.SuspendLayout
		CType(Me.LogoPictureBox,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'TableLayoutPanel
		'
		Me.TableLayoutPanel.ColumnCount = 2
		Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.28809!))
		Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.71191!))
		Me.TableLayoutPanel.Controls.Add(Me.LogoPictureBox, 0, 0)
		Me.TableLayoutPanel.Controls.Add(Me.LabelProductName, 1, 0)
		Me.TableLayoutPanel.Controls.Add(Me.LabelVersion, 1, 1)
		Me.TableLayoutPanel.Controls.Add(Me.LabelCopyright, 1, 2)
		Me.TableLayoutPanel.Controls.Add(Me.LabelCompanyName, 1, 3)
		Me.TableLayoutPanel.Controls.Add(Me.TextBoxDescription, 1, 4)
		Me.TableLayoutPanel.Controls.Add(Me.OKButton, 1, 5)
		Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel.ForeColor = System.Drawing.Color.AliceBlue
		Me.TableLayoutPanel.Location = New System.Drawing.Point(9, 8)
		Me.TableLayoutPanel.Name = "TableLayoutPanel"
		Me.TableLayoutPanel.RowCount = 6
		Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10!))
		Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10!))
		Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10!))
		Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10!))
		Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.5!))
		Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.5!))
		Me.TableLayoutPanel.Size = New System.Drawing.Size(722, 496)
		Me.TableLayoutPanel.TabIndex = 0
		'
		'LogoPictureBox
		'
		Me.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"),System.Drawing.Image)
		Me.LogoPictureBox.Location = New System.Drawing.Point(3, 3)
		Me.LogoPictureBox.Name = "LogoPictureBox"
		Me.TableLayoutPanel.SetRowSpan(Me.LogoPictureBox, 6)
		Me.LogoPictureBox.Size = New System.Drawing.Size(256, 490)
		Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
		Me.LogoPictureBox.TabIndex = 0
		Me.LogoPictureBox.TabStop = false
		'
		'LabelProductName
		'
		Me.LabelProductName.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LabelProductName.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.LabelProductName.Location = New System.Drawing.Point(268, 0)
		Me.LabelProductName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
		Me.LabelProductName.MaximumSize = New System.Drawing.Size(1000, 1000)
		Me.LabelProductName.Name = "LabelProductName"
		Me.LabelProductName.Size = New System.Drawing.Size(451, 49)
		Me.LabelProductName.TabIndex = 0
		Me.LabelProductName.Text = "Develop"
		Me.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LabelVersion
		'
		Me.LabelVersion.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LabelVersion.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.LabelVersion.Location = New System.Drawing.Point(268, 49)
		Me.LabelVersion.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
		Me.LabelVersion.MaximumSize = New System.Drawing.Size(1000, 1000)
		Me.LabelVersion.Name = "LabelVersion"
		Me.LabelVersion.Size = New System.Drawing.Size(451, 49)
		Me.LabelVersion.TabIndex = 0
		Me.LabelVersion.Text = "Version 1.0.1 Release"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"First releast ever!"
		Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LabelCopyright
		'
		Me.LabelCopyright.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LabelCopyright.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.LabelCopyright.Location = New System.Drawing.Point(268, 98)
		Me.LabelCopyright.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
		Me.LabelCopyright.MaximumSize = New System.Drawing.Size(1000, 1000)
		Me.LabelCopyright.Name = "LabelCopyright"
		Me.LabelCopyright.Size = New System.Drawing.Size(451, 49)
		Me.LabelCopyright.TabIndex = 0
		Me.LabelCopyright.Text = "Made by Kong Xiangxiang"
		Me.LabelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LabelCompanyName
		'
		Me.LabelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LabelCompanyName.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.LabelCompanyName.Location = New System.Drawing.Point(268, 147)
		Me.LabelCompanyName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
		Me.LabelCompanyName.MaximumSize = New System.Drawing.Size(1000, 1000)
		Me.LabelCompanyName.Name = "LabelCompanyName"
		Me.LabelCompanyName.Size = New System.Drawing.Size(451, 49)
		Me.LabelCompanyName.TabIndex = 0
		Me.LabelCompanyName.Text = "2016/12 - 2017/1"
		Me.LabelCompanyName.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'TextBoxDescription
		'
		Me.TextBoxDescription.BackColor = System.Drawing.Color.DarkSlateGray
		Me.TextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TextBoxDescription.Font = New System.Drawing.Font("微软雅黑", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.TextBoxDescription.ForeColor = System.Drawing.Color.Honeydew
		Me.TextBoxDescription.Location = New System.Drawing.Point(268, 199)
		Me.TextBoxDescription.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
		Me.TextBoxDescription.Multiline = true
		Me.TextBoxDescription.Name = "TextBoxDescription"
		Me.TextBoxDescription.ReadOnly = true
		Me.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.TextBoxDescription.Size = New System.Drawing.Size(451, 249)
		Me.TextBoxDescription.TabIndex = 0
		Me.TextBoxDescription.TabStop = false
		Me.TextBoxDescription.Text = resources.GetString("TextBoxDescription.Text")
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
		Me.OKButton.Location = New System.Drawing.Point(644, 454)
		Me.OKButton.MaximumSize = New System.Drawing.Size(80, 100)
		Me.OKButton.Name = "OKButton"
		Me.OKButton.Size = New System.Drawing.Size(75, 39)
		Me.OKButton.TabIndex = 0
		Me.OKButton.Text = "Okay"
		Me.OKButton.UseVisualStyleBackColor = false
		'
		'AboutBox
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.CadetBlue
		Me.CancelButton = Me.OKButton
		Me.ClientSize = New System.Drawing.Size(740, 512)
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
		CType(Me.LogoPictureBox,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)

End Sub

End Class
