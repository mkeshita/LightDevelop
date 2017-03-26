<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControl1
	Inherits System.Windows.Forms.UserControl

	'UserControl1 重写 Dispose，以清理组件列表。
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.Timer = New System.Windows.Forms.Timer(Me.components)
		Me.Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.PasteMenu = New System.Windows.Forms.ToolStripMenuItem()
		Me.VScrollBar = New System.Windows.Forms.VScrollBar()
		Me.Menu.SuspendLayout()
		Me.SuspendLayout()
		'
		'Timer
		'
		Me.Timer.Enabled = True
		Me.Timer.Interval = 15
		'
		'Menu
		'
		Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PasteMenu})
		Me.Menu.Name = "ContextMenuStrip1"
		Me.Menu.Size = New System.Drawing.Size(153, 48)
		'
		'PasteMenu
		'
		Me.PasteMenu.Name = "PasteMenu"
		Me.PasteMenu.Size = New System.Drawing.Size(152, 22)
		Me.PasteMenu.Text = "Paste"
		'
		'VScrollBar
		'
		Me.VScrollBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.VScrollBar.Location = New System.Drawing.Point(575, 0)
		Me.VScrollBar.Maximum = 10
		Me.VScrollBar.Name = "VScrollBar"
		Me.VScrollBar.Size = New System.Drawing.Size(23, 503)
		Me.VScrollBar.TabIndex = 1
		'
		'UserControl1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Controls.Add(Me.VScrollBar)
		Me.Name = "UserControl1"
		Me.Size = New System.Drawing.Size(598, 503)
		Me.Menu.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Timer As Timer
	Friend WithEvents Menu As ContextMenuStrip
	Friend WithEvents PasteMenu As ToolStripMenuItem
	Friend WithEvents VScrollBar As VScrollBar
End Class
