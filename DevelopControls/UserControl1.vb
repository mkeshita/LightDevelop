Public Class UserControl1

#Region "    Properties&Varibles"

	Public Property Lines As List(Of String) = New List(Of String)({""})
	Public Property BlinkCursor As Boolean = True
	Public ReadOnly Property SelectionStart As Point
		Get
			Return sStart
		End Get
	End Property
	Public ReadOnly Property SelectionEnd As Point
		Get
			Return sEnd
		End Get
	End Property
	Public ReadOnly Property CurrentCursor As Point
		Get
			Return New Point(cCol, cLine)
		End Get
	End Property
	Public ReadOnly Property IsSelecting As Boolean
		Get
			Return selecting
		End Get
	End Property
	Public Overrides Property Font As Font
		Get
			Return textFont
		End Get
		Set
			textFont = Value
			charSize = buffer.Graphics.MeasureString("M", Font, 1000, StringFormat.GenericTypographic)
		End Set
	End Property
	Public Property AllText As String
		Get
			Dim text As String = ""
			For Each line In Lines
				text &= line & vbCrLf
			Next
			Return text
		End Get
		Set
			cLine = 0
			cCol = 0
			Lines = New List(Of String)(Value.Split({vbCrLf}, StringSplitOptions.None))
		End Set
	End Property
	Public ReadOnly Property SelectionText As String
		Get
			If Not selecting Then Return ""

			If sStart.Y = sEnd.Y Then
				' single line
				Return Mid(Lines(sStart.Y), Math.Min(sStart.X, sEnd.X), Math.Abs(sEnd.X - sStart.X))
			Else
				Dim startSel As Point = IIf(sStart.Y < sEnd.Y, sStart, sEnd)
				Dim endSel As Point = IIf(sStart.Y < sEnd.Y, sEnd, sStart)

				Dim text As String = Mid(Lines(startSel.Y), startSel.X) ' first line
				If endSel.Y > startSel.Y + 1 Then
					For lineNum As Integer = (startSel.Y + 1) To (endSel.Y - 1)
						text &= vbCrLf & Lines(lineNum)
					Next
				End If
				text &= vbCrLf & Strings.Left(Lines(endSel.Y), endSel.X)

				Return text
			End If
		End Get
	End Property
	Public Property SelectionColor As Color
		Get
			Return selectionBrush.Color
		End Get
		Set
			selectionBrush.Color = Color.FromArgb(SelectionAlpha, Value)
		End Set
	End Property
	Public Property SelectionAlpha As Byte
		Get
			Return selectionBrush.Color.A
		End Get
		Set
			selectionBrush.Color = Color.FromArgb(Value, selectionBrush.Color)
		End Set
	End Property


	Private selecting As Boolean = False
	Private sStart As Point = New Point(0, 0)
	Private sEnd As Point = New Point(0, 0)
	Private cLine As Integer = 0
	Private cCol As Integer = 0
	Private textFont As Font = New Font(FontFamily.GenericMonospace, 16)
	Private buffer As BufferedGraphics
	Private isDone As Boolean = False
	Private charSize As SizeF
	Private transform As PointF = New PointF(0, 0)
	Private frames As Integer = 0
	Private mDown As Boolean = False
	Private selectionBrush As SolidBrush =
		New SolidBrush(Color.FromArgb(128, Color.SkyBlue))

	Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		SetupBuffer()
		charSize = buffer.Graphics.MeasureString("M", Font, 1000, StringFormat.GenericTypographic)
	End Sub

#End Region

#Region "    Rendering"


	Private Sub Draw(sender As Object, e As EventArgs) Handles Timer.Tick
		If Not isDone Then Exit Sub

		isDone = False
		frames += 1
		If frames > 50 Then frames = 0
		With buffer.Graphics
			.Clear(Color.White)
			.ResetTransform()
			transform = New PointF(0, -VScrollBar.Value * charSize.Height)
			.TranslateTransform(transform.X, transform.Y)
			Dim y As Single = 0
			For Each line In Lines
				.DrawString(line, Font, Brushes.Black, 0, y, StringFormat.GenericTypographic)
				y += charSize.Height
			Next

			' selection
			If selecting Then
				If sStart.Y = sEnd.Y Then
					DrawSelectionLine(sStart.Y, sStart.X, sEnd.X, buffer.Graphics)
				Else
					Dim ss As Point = IIf(sStart.Y < sEnd.Y, sStart, sEnd)
					Dim ee As Point = IIf(sStart.Y < sEnd.Y, sEnd, sStart)
					For yy As Integer = ss.Y To ee.Y
						If yy = ss.Y Then
							' first line
							DrawSelectionLine(yy, ss.X, Lines(yy).Length, buffer.Graphics)
						ElseIf yy = ee.Y Then
							' last line
							DrawSelectionLine(yy, 0, ee.X, buffer.Graphics)
						Else
							DrawSelectionLine(yy, 0, Lines(yy).Length, buffer.Graphics)
						End If
					Next
				End If
			Else
				' cursor
				If frames < 25 OrElse Not BlinkCursor Then
					Dim cx As Single = cCol * charSize.Width
					Dim cy As Single = cLine * charSize.Height
					.DrawLine(Pens.Black, cx, cy, cx, cy + charSize.Height)
				End If
			End If
		End With
		buffer.Render()

		SetupScrollBars()

		isDone = True
	End Sub

	Private Sub SetupScrollBars()
		' setup scrollbar
		If Lines.Count * charSize.Height < Me.Height Then
			VScrollBar.Enabled = False
			VScrollBar.Value = 0
		Else
			VScrollBar.Enabled = True
			VScrollBar.Maximum = Lines.Count
		End If
	End Sub

	Private Sub SetupBuffer()
		isDone = False
		Dim g = Me.CreateGraphics()
		' calculate the client rect without sliders
		Dim rect As Rectangle = Rectangle.Inflate(Me.ClientRectangle, -20, -20)
		buffer = BufferedGraphicsManager.Current.Allocate(g, Me.ClientRectangle)
		buffer.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
		isDone = True
	End Sub

	Private Sub DrawSelectionLine(line As Integer, s As Integer, e As Integer, g As Graphics)
		Dim sx As Single = s * charSize.Width
		Dim ex As Single = e * charSize.Width
		Dim y As Single = line * charSize.Height
		g.FillRectangle(selectionBrush, Math.Min(sx, ex), y, Math.Abs(ex - sx), charSize.Height)
	End Sub

#End Region

#Region "    Input Processing"

	Protected Overrides Function ProcessDialogKey(keyData As Keys) As Boolean
		Select Case keyData
			Case Keys.Left
				cCol -= 1
			Case Keys.Right
				cCol += 1
			Case Keys.Up
				cLine -= 1
			Case Keys.Down
				cLine += 1
			Case Keys.Tab
				Return False
			Case Else
				GoTo ExitDoor
		End Select



		frames = 0 ' disable cursor blinking
		If cLine < 0 Then cLine = 0
		If cLine >= Lines.Count Then cLine = Lines.Count - 1

		Dim l As String = Lines(cLine)
		If cCol < 0 Then cCol = 0
		If cCol > l.Length Then cCol = l.Length

ExitDoor:
		Return MyBase.ProcessDialogKey(keyData)
	End Function

	Private Sub UserControl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

		Select Case e.KeyChar
			Case vbBack
				If selecting Then
					DelSelection()
				Else
					Dim l As String = Lines(cLine)
					If cCol > 0 Then
						l = l.Remove(cCol - 1, 1)
						cCol -= 1
						Lines(cLine) = l
					ElseIf cCol = 0 AndAlso cLine > 0 Then
						' concat this line to pervious line
						Lines(cLine - 1) &= l
						Lines.RemoveAt(cLine)
						cCol = Lines(cLine - 1).Length
						cLine -= 1
					End If
				End If

			Case vbCr
				If selecting Then DelSelection()
				NewLineAt(cCol)

			Case vbLf

			Case vbTab
				If selecting Then DelSelection()
				InsertStringAt(cCol, "    ")

			Case Else
				If selecting Then DelSelection()
				InsertStringAt(cCol, e.KeyChar)
		End Select
	End Sub

	Private Sub DelSelection()
		Dim startSel As Point = IIf(sStart.Y < sEnd.Y, sStart, sEnd)
		Dim endSel As Point = IIf(sStart.Y < sEnd.Y, sEnd, sStart)
		If startSel.Y = endSel.Y Then
			Lines(startSel.Y) = Lines(startSel.Y).Remove(Math.Min(startSel.X, endSel.X), Math.Abs(endSel.X - startSel.X))
			cLine = startSel.Y
			cCol = Math.Min(startSel.X, endSel.X)
		Else
			For y = endSel.Y To startSel.Y Step -1
				If y = startSel.Y Then
					' first line
					Lines(y) = Lines(y).Remove(startSel.X)
				ElseIf y = endSel.Y Then
					' last line
					Lines(y) = Lines(y).Remove(0, endSel.X)
				Else
					Lines.RemoveAt(y)
				End If
			Next
			If startSel.Y < Lines.Count - 1 Then
				Lines(startSel.Y) &= Lines(startSel.Y + 1)
				Lines.RemoveAt(startSel.Y + 1)
			End If

			cLine = startSel.Y
			cCol = startSel.X
		End If


		selecting = False
	End Sub

	Private Sub NewLineAt(index As Integer)
		' truncate this line and concat chars after cursor to a new line

		Dim l As String = Strings.Left(Lines(cLine), index)
		Dim newl As String = Strings.Right(Lines(cLine), Lines(cLine).Length - index)
		cLine += 1
		cCol = 0
		If cLine >= Lines.Count Then
			cLine = Lines.Count
			Lines(cLine - 1) = l
			Lines.Add(newl)
		Else
			Lines(cLine - 1) = l
			Lines.Insert(cLine, newl)
		End If
	End Sub

	Private Sub InsertStringAt(index As Integer, str As String)
		Dim l As String = Lines(cLine)
		If index >= l.Length Then
			cCol = l.Length
			l = l & str
		Else
			cCol = index
			l = l.Insert(index, str)
		End If
		Me.cCol += str.Length
		Lines(cLine) = l
	End Sub

#End Region

#Region "    Event Processing"

	Private Sub UserControl_Resize(sender As Object, e As EventArgs) Handles Me.Resize
		SetupBuffer()
	End Sub

	Private Sub UserControl1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
		If e.Button = MouseButtons.Left Then
			mDown = True
			frames = 0
			selecting = False

			Dim p As Point = ParseMouseToChar(e)
			cCol = p.X
			cLine = p.Y
			sStart = p
		ElseIf e.Button = MouseButtons.Right Then
			mDown = True
			frames = 0
			selecting = False

			Dim p As Point = ParseMouseToChar(e)
			cCol = p.X
			cLine = p.Y
			sStart = p

			If Not selecting Then
				CopyMenu.Enabled = False
				CutMenu.Enabled = False
			Else
				CopyMenu.Enabled = True
				CutMenu.Enabled = True
			End If

			Menu.Show(Me, New Point(e.Location))
		End If
	End Sub

	Private Sub UserControl1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
		If e.Button = MouseButtons.Left Then
			mDown = False
		End If
	End Sub

	Private Sub UserControl1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
		If mDown Then
			Dim p As Point = ParseMouseToChar(e)
			If p <> sStart Then
				sEnd = p
				selecting = True
			Else
				selecting = False
			End If
		End If
	End Sub

	Private Function ParseMouseToChar(e As MouseEventArgs) As Point
		Dim x, y As Integer
		y = Int((e.Y - transform.Y) / charSize.Height)
		x = Math.Round((e.X - transform.X) / charSize.Width)
		If y < 0 Then y = 0
		If x < 0 Then x = 0
		If y >= Lines.Count Then y = Lines.Count - 1
		If x >= Lines(y).Length Then x = Lines(y).Length

		Return New Point(x, y)
	End Function

	Private Sub UserControl1_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
		Dim v As Integer = VScrollBar.Value - Int(e.Delta / 40)
		If v <= VScrollBar.Maximum AndAlso v >= 0 Then VScrollBar.Value = v
	End Sub

	Private Sub PasteMenu_Click(sender As Object, e As EventArgs) Handles PasteMenu.Click
		If Not My.Computer.Clipboard.ContainsText Then Exit Sub

		Dim texts As String() = My.Computer.Clipboard.GetText().Replace(vbTab, "    ").Split({vbCrLf}, StringSplitOptions.None)

		For Each line In texts
			InsertStringAt(cCol, line)
			NewLineAt(cCol)
		Next
	End Sub

	Private Sub CopyMenu_Click(sender As Object, e As EventArgs) Handles CopyMenu.Click
		My.Computer.Clipboard.SetText(SelectionText)
	End Sub

	Private Sub CutMenu_Click(sender As Object, e As EventArgs) Handles CutMenu.Click
		My.Computer.Clipboard.SetText(SelectionText)
		DelSelection()
	End Sub

	Private Sub SelectAllMenu_Click(sender As Object, e As EventArgs) Handles SelectAllMenu.Click
		Dim index As Integer = Lines.Count - 1
		sStart = New Point(0, 0)
		sEnd = New Point(index, Lines(index).Length)
		selecting = True
	End Sub
#End Region

End Class