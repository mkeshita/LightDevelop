<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.TreeView1 = New System.Windows.Forms.TreeView()
		Me.Splitter2 = New System.Windows.Forms.Splitter()
		Me.Splitter1 = New System.Windows.Forms.Splitter()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.ProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
		Me.LoadFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.TestRunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.BuildExecutableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
		Me.ProjSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
		Me.SplittedViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.StackViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.Status = New System.Windows.Forms.ToolStripStatusLabel()
		Me.Progress = New System.Windows.Forms.ToolStripProgressBar()
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
		Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.Panel1.SuspendLayout
		Me.Panel2.SuspendLayout
		Me.MenuStrip1.SuspendLayout
		Me.StatusStrip1.SuspendLayout
		Me.ToolStrip1.SuspendLayout
		Me.SuspendLayout
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.LightCyan
		Me.Panel1.Controls.Add(Me.TextBox1)
		Me.Panel1.Controls.Add(Me.PropertyGrid1)
		resources.ApplyResources(Me.Panel1, "Panel1")
		Me.Panel1.Name = "Panel1"
		'
		'TextBox1
		'
		resources.ApplyResources(Me.TextBox1, "TextBox1")
		Me.TextBox1.Name = "TextBox1"
		Me.ToolTip1.SetToolTip(Me.TextBox1, resources.GetString("TextBox1.ToolTip"))
		'
		'PropertyGrid1
		'
		resources.ApplyResources(Me.PropertyGrid1, "PropertyGrid1")
		Me.PropertyGrid1.BackColor = System.Drawing.Color.LightBlue
		Me.PropertyGrid1.CommandsBackColor = System.Drawing.Color.LightBlue
		Me.PropertyGrid1.HelpBackColor = System.Drawing.Color.PowderBlue
		Me.PropertyGrid1.LineColor = System.Drawing.Color.SteelBlue
		Me.PropertyGrid1.Name = "PropertyGrid1"
		Me.PropertyGrid1.ViewBackColor = System.Drawing.Color.LightCyan
		'
		'Panel2
		'
		Me.Panel2.Controls.Add(Me.TreeView1)
		resources.ApplyResources(Me.Panel2, "Panel2")
		Me.Panel2.Name = "Panel2"
		'
		'TreeView1
		'
		Me.TreeView1.BackColor = System.Drawing.Color.LightSteelBlue
		Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.TreeView1, "TreeView1")
		Me.TreeView1.HotTracking = true
		Me.TreeView1.ItemHeight = 20
		Me.TreeView1.Name = "TreeView1"
		Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {CType(resources.GetObject("TreeView1.Nodes"),System.Windows.Forms.TreeNode), CType(resources.GetObject("TreeView1.Nodes1"),System.Windows.Forms.TreeNode)})
		Me.TreeView1.ShowLines = false
		'
		'Splitter2
		'
		resources.ApplyResources(Me.Splitter2, "Splitter2")
		Me.Splitter2.Name = "Splitter2"
		Me.Splitter2.TabStop = false
		'
		'Splitter1
		'
		resources.ApplyResources(Me.Splitter1, "Splitter1")
		Me.Splitter1.Name = "Splitter1"
		Me.Splitter1.TabStop = false
		'
		'MenuStrip1
		'
		resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
		Me.MenuStrip1.BackColor = System.Drawing.Color.SkyBlue
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProjectToolStripMenuItem, Me.ProgramToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
		Me.MenuStrip1.Name = "MenuStrip1"
		'
		'ProjectToolStripMenuItem
		'
		Me.ProjectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ToolStripMenuItem1, Me.LoadFormToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
		Me.ProjectToolStripMenuItem.Name = "ProjectToolStripMenuItem"
		resources.ApplyResources(Me.ProjectToolStripMenuItem, "ProjectToolStripMenuItem")
		Me.ProjectToolStripMenuItem.Tag = ""
		'
		'SaveToolStripMenuItem
		'
		Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
		resources.ApplyResources(Me.SaveToolStripMenuItem, "SaveToolStripMenuItem")
		'
		'ToolStripMenuItem1
		'
		Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
		resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
		'
		'LoadFormToolStripMenuItem
		'
		Me.LoadFormToolStripMenuItem.Name = "LoadFormToolStripMenuItem"
		resources.ApplyResources(Me.LoadFormToolStripMenuItem, "LoadFormToolStripMenuItem")
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
		'
		'ExitToolStripMenuItem
		'
		Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
		resources.ApplyResources(Me.ExitToolStripMenuItem, "ExitToolStripMenuItem")
		'
		'ProgramToolStripMenuItem
		'
		Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestRunToolStripMenuItem, Me.BuildExecutableToolStripMenuItem, Me.ToolStripMenuItem3, Me.ProjSettingsToolStripMenuItem})
		Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
		resources.ApplyResources(Me.ProgramToolStripMenuItem, "ProgramToolStripMenuItem")
		Me.ProgramToolStripMenuItem.Tag = ""
		'
		'TestRunToolStripMenuItem
		'
		Me.TestRunToolStripMenuItem.Name = "TestRunToolStripMenuItem"
		resources.ApplyResources(Me.TestRunToolStripMenuItem, "TestRunToolStripMenuItem")
		'
		'BuildExecutableToolStripMenuItem
		'
		Me.BuildExecutableToolStripMenuItem.Name = "BuildExecutableToolStripMenuItem"
		resources.ApplyResources(Me.BuildExecutableToolStripMenuItem, "BuildExecutableToolStripMenuItem")
		'
		'ToolStripMenuItem3
		'
		Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
		resources.ApplyResources(Me.ToolStripMenuItem3, "ToolStripMenuItem3")
		'
		'ProjSettingsToolStripMenuItem
		'
		Me.ProjSettingsToolStripMenuItem.Name = "ProjSettingsToolStripMenuItem"
		resources.ApplyResources(Me.ProjSettingsToolStripMenuItem, "ProjSettingsToolStripMenuItem")
		'
		'ToolsToolStripMenuItem
		'
		Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.ToolStripMenuItem2, Me.SplittedViewToolStripMenuItem, Me.StackViewToolStripMenuItem})
		Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
		resources.ApplyResources(Me.ToolsToolStripMenuItem, "ToolsToolStripMenuItem")
		'
		'OptionsToolStripMenuItem
		'
		Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
		resources.ApplyResources(Me.OptionsToolStripMenuItem, "OptionsToolStripMenuItem")
		'
		'ToolStripMenuItem2
		'
		Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
		resources.ApplyResources(Me.ToolStripMenuItem2, "ToolStripMenuItem2")
		'
		'SplittedViewToolStripMenuItem
		'
		Me.SplittedViewToolStripMenuItem.Name = "SplittedViewToolStripMenuItem"
		resources.ApplyResources(Me.SplittedViewToolStripMenuItem, "SplittedViewToolStripMenuItem")
		'
		'StackViewToolStripMenuItem
		'
		Me.StackViewToolStripMenuItem.Name = "StackViewToolStripMenuItem"
		resources.ApplyResources(Me.StackViewToolStripMenuItem, "StackViewToolStripMenuItem")
		'
		'HelpToolStripMenuItem
		'
		Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
		Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
		resources.ApplyResources(Me.HelpToolStripMenuItem, "HelpToolStripMenuItem")
		'
		'AboutToolStripMenuItem
		'
		Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
		resources.ApplyResources(Me.AboutToolStripMenuItem, "AboutToolStripMenuItem")
		'
		'SaveFileDialog1
		'
		Me.SaveFileDialog1.DefaultExt = "exe"
		resources.ApplyResources(Me.SaveFileDialog1, "SaveFileDialog1")
		'
		'StatusStrip1
		'
		resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
		Me.StatusStrip1.BackColor = System.Drawing.Color.CornflowerBlue
		Me.StatusStrip1.GripMargin = New System.Windows.Forms.Padding(0)
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status, Me.Progress})
		Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
		Me.StatusStrip1.Name = "StatusStrip1"
		'
		'Status
		'
		Me.Status.ForeColor = System.Drawing.Color.White
		Me.Status.Name = "Status"
		resources.ApplyResources(Me.Status, "Status")
		'
		'Progress
		'
		Me.Progress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
		Me.Progress.Name = "Progress"
		resources.ApplyResources(Me.Progress, "Progress")
		Me.Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		'
		'ToolStrip1
		'
		Me.ToolStrip1.BackColor = System.Drawing.Color.LightBlue
		Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2})
		resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
		'
		'ToolStripButton1
		'
		Me.ToolStripButton1.CheckOnClick = true
		Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		resources.ApplyResources(Me.ToolStripButton1, "ToolStripButton1")
		Me.ToolStripButton1.Name = "ToolStripButton1"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
		'
		'ToolStripButton2
		'
		Me.ToolStripButton2.Checked = true
		Me.ToolStripButton2.CheckOnClick = true
		Me.ToolStripButton2.CheckState = System.Windows.Forms.CheckState.Checked
		Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		resources.ApplyResources(Me.ToolStripButton2, "ToolStripButton2")
		Me.ToolStripButton2.Name = "ToolStripButton2"
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		'
		'FormMain
		'
		resources.ApplyResources(Me, "$this")
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.ToolStrip1)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.Splitter1)
		Me.Controls.Add(Me.Splitter2)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.IsMdiContainer = true
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "FormMain"
		Me.ToolTip1.SetToolTip(Me, resources.GetString("$this.ToolTip"))
		Me.TransparencyKey = System.Drawing.Color.Transparent
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.Panel1.ResumeLayout(false)
		Me.Panel1.PerformLayout
		Me.Panel2.ResumeLayout(false)
		Me.MenuStrip1.ResumeLayout(false)
		Me.MenuStrip1.PerformLayout
		Me.StatusStrip1.ResumeLayout(false)
		Me.StatusStrip1.PerformLayout
		Me.ToolStrip1.ResumeLayout(false)
		Me.ToolStrip1.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PropertyGrid1 As System.Windows.Forms.PropertyGrid
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TestRunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProjSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents Status As ToolStripStatusLabel
	Friend WithEvents Progress As ToolStripProgressBar
	Friend WithEvents ToolStrip1 As ToolStrip
	Friend WithEvents ToolStripButton1 As ToolStripButton
	Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
	Friend WithEvents ToolStripButton2 As ToolStripButton
	Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
	Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
	Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
	Friend WithEvents SplittedViewToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents StackViewToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents BuildExecutableToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
End Class
