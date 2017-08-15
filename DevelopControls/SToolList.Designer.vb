<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SToolList
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
		Me.FlowLayout = New System.Windows.Forms.FlowLayoutPanel()
		Me.SuspendLayout
		'
		'FlowLayout
		'
		Me.FlowLayout.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayout.Location = New System.Drawing.Point(0, 0)
		Me.FlowLayout.Name = "FlowLayout"
		Me.FlowLayout.Size = New System.Drawing.Size(200, 400)
		Me.FlowLayout.TabIndex = 0
		'
		'SToolList
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.FlowLayout)
		Me.Name = "SToolList"
		Me.Size = New System.Drawing.Size(200, 400)
		Me.ResumeLayout(false)

End Sub

	Friend WithEvents FlowLayout As FlowLayoutPanel
End Class
