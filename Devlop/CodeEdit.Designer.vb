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
		Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
		Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.LineLabel = New System.Windows.Forms.ToolStripStatusLabel()
		Me.RowLabel = New System.Windows.Forms.ToolStripStatusLabel()
		Me.SelectLabel = New System.Windows.Forms.ToolStripStatusLabel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ListBox1 = New System.Windows.Forms.ListBox()
		Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
		Me.SaveCode = New System.Windows.Forms.ToolStripDropDownButton()
		Me.RebuildData = New System.Windows.Forms.ToolStripDropDownButton()
		Me.StatusStrip1.SuspendLayout
		Me.SuspendLayout
		'
		'RichTextBox1
		'
		Me.RichTextBox1.AcceptsTab = true
		Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.RichTextBox1.CausesValidation = false
		Me.RichTextBox1.DetectUrls = false
		Me.RichTextBox1.Font = New System.Drawing.Font("Consolas", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.RichTextBox1.HideSelection = false
		Me.RichTextBox1.ImeMode = System.Windows.Forms.ImeMode.Disable
		Me.RichTextBox1.Location = New System.Drawing.Point(12, 12)
		Me.RichTextBox1.Name = "RichTextBox1"
		Me.RichTextBox1.Size = New System.Drawing.Size(709, 596)
		Me.RichTextBox1.TabIndex = 0
		Me.RichTextBox1.TabStop = false
		Me.RichTextBox1.Text = ""
		Me.RichTextBox1.WordWrap = false
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
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LineLabel, Me.RowLabel, Me.SelectLabel, Me.SaveCode, Me.RebuildData})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 611)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(873, 26)
		Me.StatusStrip1.TabIndex = 3
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'LineLabel
		'
		Me.LineLabel.AutoSize = false
		Me.LineLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
		Me.LineLabel.Name = "LineLabel"
		Me.LineLabel.Size = New System.Drawing.Size(100, 21)
		Me.LineLabel.Text = "Line: 0"
		'
		'RowLabel
		'
		Me.RowLabel.AutoSize = false
		Me.RowLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
		Me.RowLabel.Name = "RowLabel"
		Me.RowLabel.Size = New System.Drawing.Size(100, 21)
		Me.RowLabel.Text = "Row: 0"
		'
		'SelectLabel
		'
		Me.SelectLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
		Me.SelectLabel.Name = "SelectLabel"
		Me.SelectLabel.Size = New System.Drawing.Size(415, 21)
		Me.SelectLabel.Spring = true
		Me.SelectLabel.Text = "Selection length: 0"
		'
		'Label1
		'
		Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label1.Font = New System.Drawing.Font("微软雅黑", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Label1.Location = New System.Drawing.Point(727, 12)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(134, 20)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "Code Snippets"
		'
		'ListBox1
		'
		Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.ListBox1.Font = New System.Drawing.Font("微软雅黑", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
		Me.ListBox1.FormattingEnabled = true
		Me.ListBox1.IntegralHeight = false
		Me.ListBox1.ItemHeight = 17
		Me.ListBox1.Location = New System.Drawing.Point(727, 35)
		Me.ListBox1.Name = "ListBox1"
		Me.ListBox1.Size = New System.Drawing.Size(134, 573)
		Me.ListBox1.TabIndex = 6
		Me.ListBox1.TabStop = false
		'
		'ToolTip
		'
		Me.ToolTip.AutomaticDelay = 65536
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
		'CodeEdit
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(873, 637)
		Me.Controls.Add(Me.ListBox1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.RichTextBox1)
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
    Friend WithEvents SelectLabel As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents Label1 As Label
	Friend WithEvents ListBox1 As ListBox
	Friend WithEvents RichTextBox1 As RichTextBox
	Friend WithEvents ToolTip As ToolTip
	Friend WithEvents SaveCode As ToolStripDropDownButton
	Friend WithEvents RebuildData As ToolStripDropDownButton
End Class
