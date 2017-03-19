<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingDialog
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
		Me.Progress = New System.Windows.Forms.ProgressBar()
		Me.Prompt = New System.Windows.Forms.Label()
		Me.SuspendLayout
		'
		'Progress
		'
		Me.Progress.Location = New System.Drawing.Point(14, 38)
		Me.Progress.Name = "Progress"
		Me.Progress.Size = New System.Drawing.Size(411, 24)
		Me.Progress.TabIndex = 0
		'
		'Prompt
		'
		Me.Prompt.AutoSize = true
		Me.Prompt.Location = New System.Drawing.Point(12, 9)
		Me.Prompt.Name = "Prompt"
		Me.Prompt.Size = New System.Drawing.Size(137, 12)
		Me.Prompt.TabIndex = 1
		Me.Prompt.Text = "Loading Assembly 1 / 5"
		'
		'LoadingDialog
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(435, 73)
		Me.ControlBox = false
		Me.Controls.Add(Me.Prompt)
		Me.Controls.Add(Me.Progress)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "LoadingDialog"
		Me.ShowInTaskbar = false
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Hold On"
		Me.TopMost = true
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Friend WithEvents Progress As ProgressBar
	Friend WithEvents Prompt As Label
End Class
