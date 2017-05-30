<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SButton
	Inherits System.Windows.Forms.UserControl

	'UserControl 重写释放以清理组件列表。
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
		Me.components = New System.ComponentModel.Container()
		Me.Timer = New System.Windows.Forms.Timer(Me.components)
		Me.Label = New System.Windows.Forms.Label()
		Me.SuspendLayout
		'
		'Timer
		'
		Me.Timer.Enabled = true
		Me.Timer.Interval = 20
		'
		'Label
		'
		Me.Label.BackColor = System.Drawing.SystemColors.Control
		Me.Label.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label.Location = New System.Drawing.Point(0, 0)
		Me.Label.Margin = New System.Windows.Forms.Padding(3)
		Me.Label.Name = "Label"
		Me.Label.Padding = New System.Windows.Forms.Padding(3)
		Me.Label.Size = New System.Drawing.Size(152, 67)
		Me.Label.TabIndex = 0
		Me.Label.Text = "Text"
		Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'SButton
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 19!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.Controls.Add(Me.Label)
		Me.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me.Name = "SButton"
		Me.Size = New System.Drawing.Size(152, 67)
		Me.ResumeLayout(false)

End Sub

	Friend WithEvents Timer As Timer
	Friend WithEvents Label As Label
End Class
