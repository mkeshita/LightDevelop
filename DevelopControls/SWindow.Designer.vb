<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SWindow
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
		Me.Header = New System.Windows.Forms.Panel()
		Me.SButton1 = New DevelopControls.SButton()
		Me.Caption = New System.Windows.Forms.Label()
		Me.Header.SuspendLayout
		Me.SuspendLayout
		'
		'Header
		'
		Me.Header.BackColor = System.Drawing.Color.DarkSlateGray
		Me.Header.Controls.Add(Me.SButton1)
		Me.Header.Controls.Add(Me.Caption)
		Me.Header.Dock = System.Windows.Forms.DockStyle.Top
		Me.Header.Location = New System.Drawing.Point(0, 0)
		Me.Header.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.Header.Name = "Header"
		Me.Header.Size = New System.Drawing.Size(669, 48)
		Me.Header.TabIndex = 0
		'
		'SButton1
		'
		Me.SButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.SButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47,Byte),Integer), CType(CType(79,Byte),Integer), CType(CType(79,Byte),Integer))
		Me.SButton1.ButtonText = "×"
		Me.SButton1.DownColor = System.Drawing.Color.Maroon
		Me.SButton1.Font = New System.Drawing.Font("宋体", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.SButton1.HoverColor = System.Drawing.Color.Red
		Me.SButton1.HoverInFadeTime = 0.05R
		Me.SButton1.HoverOutFadeTime = 0.1R
		Me.SButton1.IdleColor = System.Drawing.Color.DarkSlateGray
		Me.SButton1.Location = New System.Drawing.Point(613, -2)
		Me.SButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.SButton1.Name = "SButton1"
		Me.SButton1.Size = New System.Drawing.Size(57, 46)
		Me.SButton1.TabIndex = 1
		'
		'Caption
		'
		Me.Caption.Dock = System.Windows.Forms.DockStyle.Left
		Me.Caption.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Caption.ForeColor = System.Drawing.Color.White
		Me.Caption.Location = New System.Drawing.Point(0, 0)
		Me.Caption.Name = "Caption"
		Me.Caption.Padding = New System.Windows.Forms.Padding(23, 0, 0, 0)
		Me.Caption.Size = New System.Drawing.Size(504, 48)
		Me.Caption.TabIndex = 1
		Me.Caption.Text = "Window Caption"
		Me.Caption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'SWindow
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 15!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(669, 433)
		Me.Controls.Add(Me.Header)
		Me.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.Name = "SWindow"
		Me.Text = "Window Caption"
		Me.Header.ResumeLayout(false)
		Me.ResumeLayout(false)

End Sub

	Friend WithEvents Header As Panel
	Friend WithEvents Caption As Label
	Friend WithEvents SButton1 As SButton
End Class
