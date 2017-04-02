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
		Me.CopyMenu = New System.Windows.Forms.ToolStripMenuItem()
		Me.CutMenu = New System.Windows.Forms.ToolStripMenuItem()
		Me.PasteMenu = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
		Me.SelectAllMenu = New System.Windows.Forms.ToolStripMenuItem()
		Me.VScrollBar = New System.Windows.Forms.VScrollBar()
		Me.HScrollBar = New System.Windows.Forms.HScrollBar()
		Me.Label1 = New System.Windows.Forms.Label()
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
		Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyMenu, Me.CutMenu, Me.PasteMenu, Me.ToolStripMenuItem1, Me.SelectAllMenu})
		Me.Menu.Name = "ContextMenuStrip1"
		Me.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
		Me.Menu.Size = New System.Drawing.Size(174, 98)
		'
		'CopyMenu
		'
		Me.CopyMenu.Name = "CopyMenu"
		Me.CopyMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
		Me.CopyMenu.Size = New System.Drawing.Size(173, 22)
		Me.CopyMenu.Text = "Copy"
		'
		'CutMenu
		'
		Me.CutMenu.Name = "CutMenu"
		Me.CutMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
		Me.CutMenu.Size = New System.Drawing.Size(173, 22)
		Me.CutMenu.Text = "Cut"
		'
		'PasteMenu
		'
		Me.PasteMenu.Name = "PasteMenu"
		Me.PasteMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
		Me.PasteMenu.Size = New System.Drawing.Size(173, 22)
		Me.PasteMenu.Text = "Paste"
		'
		'ToolStripMenuItem1
		'
		Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
		Me.ToolStripMenuItem1.Size = New System.Drawing.Size(170, 6)
		'
		'SelectAllMenu
		'
		Me.SelectAllMenu.Name = "SelectAllMenu"
		Me.SelectAllMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
		Me.SelectAllMenu.Size = New System.Drawing.Size(173, 22)
		Me.SelectAllMenu.Text = "Select All"
		'
		'VScrollBar
		'
		Me.VScrollBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.VScrollBar.Cursor = System.Windows.Forms.Cursors.Arrow
		Me.VScrollBar.Location = New System.Drawing.Point(714, 0)
		Me.VScrollBar.Maximum = 10
		Me.VScrollBar.Name = "VScrollBar"
		Me.VScrollBar.Size = New System.Drawing.Size(20, 640)
		Me.VScrollBar.TabIndex = 1
		'
		'HScrollBar
		'
		Me.HScrollBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.HScrollBar.Cursor = System.Windows.Forms.Cursors.Arrow
		Me.HScrollBar.Location = New System.Drawing.Point(0, 640)
		Me.HScrollBar.Maximum = 10
		Me.HScrollBar.Name = "HScrollBar"
		Me.HScrollBar.Size = New System.Drawing.Size(714, 20)
		Me.HScrollBar.TabIndex = 2
		'
		'Label1
		'
		Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Arrow
		Me.Label1.Location = New System.Drawing.Point(713, 639)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(22, 22)
		Me.Label1.TabIndex = 3
		'
		'UserControl1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.HScrollBar)
		Me.Controls.Add(Me.VScrollBar)
		Me.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Name = "UserControl1"
		Me.Size = New System.Drawing.Size(734, 660)
		Me.Menu.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Timer As Timer
	Friend WithEvents Menu As ContextMenuStrip
	Friend WithEvents PasteMenu As ToolStripMenuItem
	Friend WithEvents VScrollBar As VScrollBar
	Friend WithEvents CopyMenu As ToolStripMenuItem
	Friend WithEvents CutMenu As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
	Friend WithEvents SelectAllMenu As ToolStripMenuItem
	Friend WithEvents HScrollBar As HScrollBar
	Friend WithEvents Label1 As Label
End Class
