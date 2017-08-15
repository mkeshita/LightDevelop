<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.SButton1 = New DevelopControls.SButton()
		Me.SButton2 = New DevelopControls.SButton()
		Me.SuspendLayout
		'
		'Timer1
		'
		Me.Timer1.Enabled = true
		Me.Timer1.Interval = 5000
		'
		'SButton1
		'
		Me.SButton1.BackColor = System.Drawing.SystemColors.Control
		Me.SButton1.ButtonText = "About"
		Me.SButton1.DownColor = System.Drawing.Color.DarkSlateGray
		Me.SButton1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.SButton1.HoverColor = System.Drawing.Color.LightSlateGray
		Me.SButton1.HoverInFadeTime = 0.05R
		Me.SButton1.HoverOutFadeTime = 0.2R
		Me.SButton1.IdleColor = System.Drawing.Color.LightSteelBlue
		Me.SButton1.Location = New System.Drawing.Point(296, 269)
		Me.SButton1.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
		Me.SButton1.Name = "SButton1"
		Me.SButton1.Size = New System.Drawing.Size(132, 43)
		Me.SButton1.TabIndex = 0
		'
		'SButton2
		'
		Me.SButton2.BackColor = System.Drawing.SystemColors.Control
		Me.SButton2.ButtonText = "GitHub"
		Me.SButton2.DownColor = System.Drawing.Color.DarkSlateGray
		Me.SButton2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.SButton2.HoverColor = System.Drawing.Color.LightSlateGray
		Me.SButton2.HoverInFadeTime = 0.05R
		Me.SButton2.HoverOutFadeTime = 0.2R
		Me.SButton2.IdleColor = System.Drawing.Color.LightSteelBlue
		Me.SButton2.Location = New System.Drawing.Point(177, 269)
		Me.SButton2.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
		Me.SButton2.Name = "SButton2"
		Me.SButton2.Size = New System.Drawing.Size(111, 43)
		Me.SButton2.TabIndex = 1
		'
		'Splash
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Black
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"),System.Drawing.Image)
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.ClientSize = New System.Drawing.Size(531, 398)
		Me.ControlBox = false
		Me.Controls.Add(Me.SButton2)
		Me.Controls.Add(Me.SButton1)
		Me.Cursor = System.Windows.Forms.Cursors.AppStarting
		Me.DoubleBuffered = true
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "Splash"
		Me.ShowInTaskbar = false
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.ResumeLayout(false)

End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
	Friend WithEvents SButton1 As DevelopControls.SButton
	Friend WithEvents SButton2 As DevelopControls.SButton
End Class
