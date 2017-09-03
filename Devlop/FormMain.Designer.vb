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
		Me.StatusStrip = New System.Windows.Forms.StatusStrip()
		Me.Status = New System.Windows.Forms.ToolStripStatusLabel()
		Me.Progress = New System.Windows.Forms.ToolStripProgressBar()
		Me.SplitterLeft = New System.Windows.Forms.Splitter()
		Me.SplitterRight = New System.Windows.Forms.Splitter()
		Me.PanelRight = New System.Windows.Forms.Panel()
		Me.ToolList = New DevelopControls.SToolList()
		Me.PanelLeft = New System.Windows.Forms.Panel()
		Me.NameBox = New System.Windows.Forms.TextBox()
		Me.PropertyGrid = New System.Windows.Forms.PropertyGrid()
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
		Me.ToolOpen = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripSave = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolCode = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolBuild = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolTest = New System.Windows.Forms.ToolStripButton()
		Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
		Me.SaveDialog = New System.Windows.Forms.SaveFileDialog()
		Me.OpenDialog = New System.Windows.Forms.OpenFileDialog()
		Me.StatusStrip.SuspendLayout
		Me.PanelRight.SuspendLayout
		Me.PanelLeft.SuspendLayout
		Me.ToolStrip1.SuspendLayout
		Me.SuspendLayout
		'
		'StatusStrip
		'
		resources.ApplyResources(Me.StatusStrip, "StatusStrip")
		Me.StatusStrip.BackColor = System.Drawing.Color.DimGray
		Me.StatusStrip.GripMargin = New System.Windows.Forms.Padding(0)
		Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status, Me.Progress})
		Me.StatusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
		Me.StatusStrip.Name = "StatusStrip"
		Me.StatusStrip.SizingGrip = false
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
		'SplitterLeft
		'
		resources.ApplyResources(Me.SplitterLeft, "SplitterLeft")
		Me.SplitterLeft.Name = "SplitterLeft"
		Me.SplitterLeft.TabStop = false
		'
		'SplitterRight
		'
		resources.ApplyResources(Me.SplitterRight, "SplitterRight")
		Me.SplitterRight.Name = "SplitterRight"
		Me.SplitterRight.TabStop = false
		'
		'PanelRight
		'
		Me.PanelRight.Controls.Add(Me.ToolList)
		resources.ApplyResources(Me.PanelRight, "PanelRight")
		Me.PanelRight.Name = "PanelRight"
		'
		'ToolList
		'
		Me.ToolList.BackColor = System.Drawing.Color.Gainsboro
		resources.ApplyResources(Me.ToolList, "ToolList")
		Me.ToolList.DownColor = System.Drawing.Color.CadetBlue
		Me.ToolList.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ToolList.HoverColor = System.Drawing.Color.LightSteelBlue
		Me.ToolList.ItemHeight = 35
		Me.ToolList.Items = New String() {"Label", "Button", "TextBox", "ComboBox", "CheckBox", "ListBox"}
		Me.ToolList.Name = "ToolList"
		'
		'PanelLeft
		'
		Me.PanelLeft.BackColor = System.Drawing.Color.Gainsboro
		Me.PanelLeft.Controls.Add(Me.NameBox)
		Me.PanelLeft.Controls.Add(Me.PropertyGrid)
		resources.ApplyResources(Me.PanelLeft, "PanelLeft")
		Me.PanelLeft.Name = "PanelLeft"
		'
		'NameBox
		'
		resources.ApplyResources(Me.NameBox, "NameBox")
		Me.NameBox.BackColor = System.Drawing.Color.WhiteSmoke
		Me.NameBox.Name = "NameBox"
		Me.ToolTip.SetToolTip(Me.NameBox, resources.GetString("NameBox.ToolTip"))
		'
		'PropertyGrid
		'
		resources.ApplyResources(Me.PropertyGrid, "PropertyGrid")
		Me.PropertyGrid.BackColor = System.Drawing.Color.Silver
		Me.PropertyGrid.CommandsBackColor = System.Drawing.Color.DarkGray
		Me.PropertyGrid.HelpBackColor = System.Drawing.Color.DarkGray
		Me.PropertyGrid.LineColor = System.Drawing.Color.SteelBlue
		Me.PropertyGrid.Name = "PropertyGrid"
		Me.PropertyGrid.ViewBackColor = System.Drawing.Color.DarkGray
		'
		'ToolStrip1
		'
		Me.ToolStrip1.BackColor = System.Drawing.Color.DimGray
		resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
		Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
		Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolOpen, Me.ToolStripSeparator1, Me.ToolStripSave, Me.ToolStripSeparator2, Me.ToolCode, Me.ToolStripSeparator3, Me.ToolBuild, Me.ToolStripSeparator4, Me.ToolTest})
		Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
		Me.ToolStrip1.Stretch = true
		'
		'ToolOpen
		'
		resources.ApplyResources(Me.ToolOpen, "ToolOpen")
		Me.ToolOpen.Name = "ToolOpen"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
		'
		'ToolStripSave
		'
		resources.ApplyResources(Me.ToolStripSave, "ToolStripSave")
		Me.ToolStripSave.Name = "ToolStripSave"
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
		'
		'ToolCode
		'
		Me.ToolCode.CheckOnClick = true
		resources.ApplyResources(Me.ToolCode, "ToolCode")
		Me.ToolCode.Name = "ToolCode"
		'
		'ToolStripSeparator3
		'
		Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
		resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
		'
		'ToolBuild
		'
		resources.ApplyResources(Me.ToolBuild, "ToolBuild")
		Me.ToolBuild.Name = "ToolBuild"
		'
		'ToolStripSeparator4
		'
		Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
		resources.ApplyResources(Me.ToolStripSeparator4, "ToolStripSeparator4")
		'
		'ToolTest
		'
		resources.ApplyResources(Me.ToolTest, "ToolTest")
		Me.ToolTest.Name = "ToolTest"
		'
		'SaveDialog
		'
		Me.SaveDialog.DefaultExt = "exe"
		resources.ApplyResources(Me.SaveDialog, "SaveDialog")
		'
		'OpenDialog
		'
		Me.OpenDialog.FileName = "OpenFileDialog1"
		'
		'FormMain
		'
		resources.ApplyResources(Me, "$this")
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.DarkSeaGreen
		Me.Controls.Add(Me.SplitterRight)
		Me.Controls.Add(Me.SplitterLeft)
		Me.Controls.Add(Me.ToolStrip1)
		Me.Controls.Add(Me.StatusStrip)
		Me.Controls.Add(Me.PanelLeft)
		Me.Controls.Add(Me.PanelRight)
		Me.IsMdiContainer = true
		Me.Name = "FormMain"
		Me.ToolTip.SetToolTip(Me, resources.GetString("$this.ToolTip"))
		Me.TransparencyKey = System.Drawing.Color.Transparent
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.StatusStrip.ResumeLayout(false)
		Me.StatusStrip.PerformLayout
		Me.PanelRight.ResumeLayout(false)
		Me.PanelLeft.ResumeLayout(false)
		Me.PanelLeft.PerformLayout
		Me.ToolStrip1.ResumeLayout(false)
		Me.ToolStrip1.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub
    Friend WithEvents PanelRight As System.Windows.Forms.Panel
    Friend WithEvents SplitterRight As System.Windows.Forms.Splitter
    Friend WithEvents SplitterLeft As System.Windows.Forms.Splitter
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents SaveDialog As System.Windows.Forms.SaveFileDialog
	Friend WithEvents StatusStrip As StatusStrip
	Friend WithEvents Status As ToolStripStatusLabel
	Friend WithEvents Progress As ToolStripProgressBar
	Friend WithEvents OpenDialog As OpenFileDialog
	Friend WithEvents ToolList As DevelopControls.SToolList
	Friend WithEvents PanelLeft As Panel
	Friend WithEvents NameBox As TextBox
	Friend WithEvents PropertyGrid As PropertyGrid
	Friend WithEvents ToolStrip1 As ToolStrip
	Friend WithEvents ToolBuild As ToolStripButton
	Friend WithEvents ToolCode As ToolStripButton
	Friend WithEvents ToolTest As ToolStripButton
	Friend WithEvents ToolOpen As ToolStripButton
	Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
	Friend WithEvents ToolStripSave As ToolStripButton
	Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
	Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
	Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
End Class
