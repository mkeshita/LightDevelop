<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits DevelopControls.SWindow

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
		Me.SButton1 = New DevelopControls.SButton()
		Me.SuspendLayout
		'
		'SButton1
		'
		Me.SButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer))
		Me.SButton1.ButtonText = "Test button"
		Me.SButton1.DownColor = System.Drawing.Color.DarkSlateGray
		Me.SButton1.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.SButton1.HoverColor = System.Drawing.Color.Gray
		Me.SButton1.HoverInFadeTime = 0.05R
		Me.SButton1.HoverOutFadeTime = 0.2R
		Me.SButton1.IdleColor = System.Drawing.Color.Silver
		Me.SButton1.Location = New System.Drawing.Point(235, 147)
		Me.SButton1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
		Me.SButton1.Name = "SButton1"
		Me.SButton1.Size = New System.Drawing.Size(163, 67)
		Me.SButton1.TabIndex = 0
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 15!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(718, 495)
		Me.Controls.Add(Me.SButton1)
		Me.GradientColorA = System.Drawing.Color.DimGray
		Me.GradientColorB = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me.Name = "Form1"
		Me.RoundRadius = 5!
		Me.Text = "DevelopControls Test window"
		Me.Controls.SetChildIndex(Me.SButton1, 0)
		Me.ResumeLayout(false)

End Sub

	Friend WithEvents SButton1 As DevelopControls.SButton
End Class
