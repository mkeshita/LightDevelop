<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CodeEdit
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CodeEdit))
		Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.LineLabel = New System.Windows.Forms.ToolStripStatusLabel()
		Me.RowLabel = New System.Windows.Forms.ToolStripStatusLabel()
		Me.SaveCode = New System.Windows.Forms.ToolStripDropDownButton()
		Me.RebuildData = New System.Windows.Forms.ToolStripDropDownButton()
		Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
		Me.Editor = New DevelopControls.SEditor()
		Me.StatusStrip1.SuspendLayout
		Me.SuspendLayout
		'
		'ImageList1
		'
		Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"),System.Windows.Forms.ImageListStreamer)
		Me.ImageList1.TransparentColor = System.Drawing.Color.White
		Me.ImageList1.Images.SetKeyName(0, "class.bmp")
		Me.ImageList1.Images.SetKeyName(1, "event.bmp")
		Me.ImageList1.Images.SetKeyName(2, "field.bmp")
		Me.ImageList1.Images.SetKeyName(3, "method.bmp")
		Me.ImageList1.Images.SetKeyName(4, "property.bmp")
		Me.ImageList1.Images.SetKeyName(5, "module.bmp")
		Me.ImageList1.Images.SetKeyName(6, "enum.bmp")
		Me.ImageList1.Images.SetKeyName(7, "interface.bmp")
		Me.ImageList1.Images.SetKeyName(8, "namespace.png")
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LineLabel, Me.RowLabel, Me.SaveCode, Me.RebuildData})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 460)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(854, 26)
		Me.StatusStrip1.TabIndex = 3
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'LineLabel
		'
		Me.LineLabel.AutoSize = false
		Me.LineLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
		Me.LineLabel.Name = "LineLabel"
		Me.LineLabel.Size = New System.Drawing.Size(298, 21)
		Me.LineLabel.Spring = true
		Me.LineLabel.Text = "Line: 0"
		'
		'RowLabel
		'
		Me.RowLabel.AutoSize = false
		Me.RowLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
		Me.RowLabel.Name = "RowLabel"
		Me.RowLabel.Size = New System.Drawing.Size(298, 21)
		Me.RowLabel.Spring = true
		Me.RowLabel.Text = "Row: 0"
		'
		'SaveCode
		'
		Me.SaveCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.SaveCode.Image = CType(resources.GetObject("SaveCode.Image"),System.Drawing.Image)
		Me.SaveCode.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.SaveCode.Name = "SaveCode"
		Me.SaveCode.Size = New System.Drawing.Size(81, 24)
		Me.SaveCode.Text = "&Save code"
		'
		'RebuildData
		'
		Me.RebuildData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.RebuildData.Image = CType(resources.GetObject("RebuildData.Image"),System.Drawing.Image)
		Me.RebuildData.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.RebuildData.Name = "RebuildData"
		Me.RebuildData.Size = New System.Drawing.Size(162, 24)
		Me.RebuildData.Text = "Rebuild Sense Database"
		'
		'ToolTip
		'
		Me.ToolTip.AutomaticDelay = 65536
		'
		'Editor
		'
		Me.Editor.AllText = ""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
		Me.Editor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.Editor.Antialiasing = true
		Me.Editor.AutoTabs = true
		Me.Editor.BackColor = System.Drawing.Color.White
		Me.Editor.BlinkCursor = true
		Me.Editor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Editor.Colors = CType(resources.GetObject("Editor.Colors"),System.Collections.Generic.List(Of String))
		Me.Editor.ColorTable = CType(resources.GetObject("Editor.ColorTable"),System.Collections.Generic.List(Of System.Drawing.Color))
		Me.Editor.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Editor.HighlightRules = CType(resources.GetObject("Editor.HighlightRules"),System.Collections.Generic.List(Of System.Collections.Generic.KeyValuePair(Of String, Integer)))
		Me.Editor.LineNumber = true
		Me.Editor.LineNumberColor = System.Drawing.Color.DarkCyan
		Me.Editor.Lines = CType(resources.GetObject("Editor.Lines"),System.Collections.Generic.List(Of String))
		Me.Editor.Location = New System.Drawing.Point(12, 12)
		Me.Editor.Name = "Editor"
		Me.Editor.SelectionAlpha = CType(128,Byte)
		Me.Editor.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(135,Byte),Integer), CType(CType(206,Byte),Integer), CType(CType(235,Byte),Integer))
		Me.Editor.SeperatorColor = System.Drawing.Color.DarkBlue
		Me.Editor.SeperatorWidth = 2!
		Me.Editor.Size = New System.Drawing.Size(830, 445)
		Me.Editor.TabIndex = 7
		Me.Editor.TextRenderMethod = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
		'
		'CodeEdit
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(854, 486)
		Me.Controls.Add(Me.Editor)
		Me.Controls.Add(Me.StatusStrip1)
		Me.MinimumSize = New System.Drawing.Size(300, 180)
		Me.Name = "CodeEdit"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
		Me.Text = "CodeEdit"
		Me.StatusStrip1.ResumeLayout(false)
		Me.StatusStrip1.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents LineLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RowLabel As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents ToolTip As ToolTip
	Friend WithEvents SaveCode As ToolStripDropDownButton
	Friend WithEvents RebuildData As ToolStripDropDownButton
	Friend WithEvents Editor As DevelopControls.SEditor
End Class
