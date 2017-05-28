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
	Friend WithEvents OKButton As System.Windows.Forms.Button

	'Windows 窗体设计器所必需的
	Private components As System.ComponentModel.IContainer

	'注意: 以下过程是 Windows 窗体设计器所必需的
	'可以使用 Windows 窗体设计器修改它。  
	'不要使用代码编辑器修改它。
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutBox))
		Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
		Me.LabelProductName = New System.Windows.Forms.Label()
		Me.LabelVersion = New System.Windows.Forms.Label()
		Me.OKButton = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
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
		Me.TableLayoutPanel.Controls.Add(Me.OKButton, 1, 4)
		Me.TableLayoutPanel.Controls.Add(Me.TextBox1, 1, 1)
		Me.TableLayoutPanel.Controls.Add(Me.LinkLabel1, 0, 2)
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
		Me.TableLayoutPanel.Size = New System.Drawing.Size(624, 537)
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
		Me.LabelProductName.Size = New System.Drawing.Size(624, 136)
		Me.LabelProductName.TabIndex = 0
		Me.LabelProductName.Text = "LightDevelop"
		Me.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LabelVersion
		'
		Me.LabelVersion.BackColor = System.Drawing.Color.CadetBlue
		Me.LabelVersion.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LabelVersion.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.LabelVersion.ForeColor = System.Drawing.Color.Black
		Me.LabelVersion.Location = New System.Drawing.Point(0, 136)
		Me.LabelVersion.Margin = New System.Windows.Forms.Padding(0)
		Me.LabelVersion.MaximumSize = New System.Drawing.Size(1000, 1000)
		Me.LabelVersion.Name = "LabelVersion"
		Me.LabelVersion.Size = New System.Drawing.Size(314, 214)
		Me.LabelVersion.TabIndex = 0
		Me.LabelVersion.Text = "Build 4"
		Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
		Me.OKButton.Location = New System.Drawing.Point(546, 485)
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
		Me.TextBox1.Location = New System.Drawing.Point(315, 136)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(1, 0, 0, 0)
		Me.TextBox1.Multiline = true
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TableLayoutPanel.SetRowSpan(Me.TextBox1, 3)
		Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.TextBox1.Size = New System.Drawing.Size(309, 346)
		Me.TextBox1.TabIndex = 1
		'
		'LinkLabel1
		'
		Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.DarkSlateGray
		Me.LinkLabel1.AutoSize = true
		Me.LinkLabel1.BackColor = System.Drawing.Color.DarkCyan
		Me.LinkLabel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LinkLabel1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.LinkLabel1.LinkArea = New System.Windows.Forms.LinkArea(0, 40)
		Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
		Me.LinkLabel1.LinkColor = System.Drawing.Color.SkyBlue
		Me.LinkLabel1.Location = New System.Drawing.Point(0, 350)
		Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(0)
		Me.LinkLabel1.Name = "LinkLabel1"
		Me.TableLayoutPanel.SetRowSpan(Me.LinkLabel1, 2)
		Me.LinkLabel1.Size = New System.Drawing.Size(314, 132)
		Me.LinkLabel1.TabIndex = 2
		Me.LinkLabel1.TabStop = true
		Me.LinkLabel1.Text = "https://github.com/Knowif/LightDevelop"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Visit the project on GitHub!"
		Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.LinkLabel1.UseCompatibleTextRendering = true
		Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.LightSteelBlue
		'
		'AboutBox
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.CadetBlue
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"),System.Drawing.Image)
		Me.CancelButton = Me.OKButton
		Me.ClientSize = New System.Drawing.Size(642, 553)
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
	Friend WithEvents LinkLabel1 As LinkLabel
End Class
