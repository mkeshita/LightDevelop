Imports System.Text.RegularExpressions

Public Class SEditor

#Region "    Properties & Varibles"
	Public Property Colors As List(Of String) = New List(Of String)({""})

	Public Property ColorTable As List(Of Color) =
			New List(Of Color)({Color.Black, Color.Brown, Color.DarkCyan})

	Public Property HighlightRules As List(Of KeyValuePair(Of String, Integer)) =
				New List(Of KeyValuePair(Of String, Integer))({
					New KeyValuePair(Of String, Integer)(""".*""", 1),
					New KeyValuePair(Of String, Integer)("\b[0-9.]+\b", 2)
				})

	Public Property BlinkCursor As Boolean = True
	Public Property LineNumber As Boolean = True
	Public Property TextRenderMethod As Drawing.Text.TextRenderingHint =
		Drawing.Text.TextRenderingHint.ClearTypeGridFit
	Public Property LineNumberColor As Color = Color.DarkCyan
	Public Property SeperatorColor As Color = Color.DarkBlue
	Public Property SeperatorWidth As Single = 2
	Public Property Antialiasing As Boolean = True
	Public Property AutoTabs As Boolean = True

	Public Property Lines As List(Of String)
		Get
			Return _lines
		End Get
		Set(value As List(Of String))
			_lines = value
			ClearColors()
		End Set
	End Property
	Public ReadOnly Property SelectionStart As Point
		Get
			Return _selStart
		End Get
	End Property
	Public ReadOnly Property SelectionEnd As Point
		Get
			Return _selEnd
		End Get
	End Property
	Public ReadOnly Property CurrentCursor As Point
		Get
			Return New Point(_currentCol, _currentLine)
		End Get
	End Property
	Public ReadOnly Property CurrentPixelPosition As Point
		Get
			Return New Point(_currentCol * _charSize.Width + _transform.X, 
							_currentLine * _charSize.Height + _transform.Y)
		End Get
	End property
	Public ReadOnly Property CurrentCharacter As Char
		Get
			If _currentCol < 1 Then Return Char.MinValue
			Return _lines(_currentLine)(_currentCol - 1)
		End Get
	End Property
	Public ReadOnly Property CurrentPressedKeyChar As Char
		Get
			Return _key
		End Get
	ENd Property
	Public ReadOnly Property IsSelecting As Boolean
		Get
			Return _selecting
		End Get
	End Property
	Public Overrides Property Font As Font
		Get
			Return _font
		End Get
		Set
			_font = Value
			_charSize = _graphicsBuf.Graphics.MeasureString("M", Font, 1000, StringFormat.GenericTypographic)
		End Set
	End Property
	Public Property AllText As String
		Get
			Dim text As String = ""
			For Each line In _lines
				text &= line & vbCrLf
			Next
			Return text
		End Get
		Set
			_currentLine = 0
			_currentCol = 0
			_lines = New List(Of String)(Value.Split({vbCrLf}, StringSplitOptions.None))
			Highlight(HighlightRules)
		End Set
	End Property
	Public ReadOnly Property SelectionText As String
		Get
			If Not _selecting Then Return ""

			If _selStart.Y = _selEnd.Y Then
				' single line
				Return Mid(_lines(_selStart.Y), Math.Min(_selStart.X, _selEnd.X), Math.Abs(_selEnd.X - _selStart.X))
			Else
				Dim startSel As Point = IIf(_selStart.Y < _selEnd.Y, _selStart, _selEnd)
				Dim endSel As Point = IIf(_selStart.Y < _selEnd.Y, _selEnd, _selStart)

				Dim text As String = Mid(_lines(startSel.Y), startSel.X) ' first line
				If endSel.Y > startSel.Y + 1 Then
					For lineNum As Integer = (startSel.Y + 1) To (endSel.Y - 1)
						text &= vbCrLf & _lines(lineNum)
					Next
				End If
				text &= vbCrLf & Strings.Left(_lines(endSel.Y), endSel.X)

				Return text
			End If
		End Get
	End Property
	Public Property SelectionColor As Color
		Get
			Return _selectionBrush.Color
		End Get
		Set
			_selectionBrush.Color = Color.FromArgb(SelectionAlpha, Value)
		End Set
	End Property
	Public Property SelectionAlpha As Byte
		Get
			Return _selectionBrush.Color.A
		End Get
		Set
			_selectionBrush.Color = Color.FromArgb(Value, _selectionBrush.Color)
		End Set
	End Property

	Public Event OnRefresh(ByVal sender As Object, ByVal e As EventArgs)
	Public Shadows Event TextChanged(ByVal sender As Object, ByVal e As EventArgs)
	Public Event SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)

	Private _lines As List(Of String) = New List(Of String)({""})
	Private _selecting As Boolean = False
	Private _selStart As Point = New Point(0, 0)
	Private _selEnd As Point = New Point(0, 0)
	Private _currentLine As Integer = 0
	Private _currentCol As Integer = 0
	Private _font As Font = New Font(FontFamily.GenericMonospace, 16)
	Private _graphicsBuf As BufferedGraphics
	Private _isDone As Boolean = False
	Private _charSize As SizeF
	Private _transform As PointF = New PointF(0, 0)
	Private _frameCount As Integer = 0
	Private _mouseDown As Boolean = False
	Private _selectionBrush As SolidBrush =
		New SolidBrush(Color.FromArgb(128, Color.SkyBlue))
	Private _focus As Boolean = False
	Private _key As Char = vbNullChar

	Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		SetupBuffer()
		_charSize = _graphicsBuf.Graphics.MeasureString("M", Font, 1000, StringFormat.GenericTypographic)
	End Sub

	Private Sub ClearColors()
		Colors.Clear
		For i = 0 To _lines.Count - 1
			Colors.Add(StrDup(_lines(i).Length, "0"))
		Next
	End Sub
#End Region

#Region "    Rendering"
	Private Sub Draw(sender As Object, e As EventArgs) Handles Timer.Tick
		If Not _isDone Then Exit Sub

		_isDone = False
		_frameCount += 1
		If _frameCount > 50 Then _frameCount = 0

		Dim bkBrush As New SolidBrush(Me.BackColor)
		Dim lineBrush As New SolidBrush(LineNumberColor)
		Dim sepPen As New Pen(SeperatorColor, SeperatorWidth)

		With _graphicsBuf.Graphics
			.TextRenderingHint = TextRenderMethod
			If Antialiasing Then
				.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
			Else
				.SmoothingMode = Drawing2D.SmoothingMode.HighSpeed
			End If

			.Clear(Me.BackColor)
			.ResetTransform()

			'If cCol * charSize.Width + transform.X < 0 Then HScrollBar.Value -= 1
			'If cCol * charSize.Width + transform.X > Me.Width Then HScrollBar.Value += 1
			'If cLine * charSize.Height + transform.Y < 0 Then VScrollBar.Value -= 1
			'If cLine * charSize.Height + transform.Y > Me.Width Then VScrollBar.Value += 1

			_transform = New PointF(-HScrollBar.Value * _charSize.Width,
									-VScrollBar.Value * _charSize.Height)
			If LineNumber Then _transform.X += 55
			.TranslateTransform(_transform.X, _transform.Y)

			' render text
			Dim y As Single = 0, n As Integer = 0
			For Each line In _lines
				' per character rendering
				Dim x As Single = 0
				For i = 0 To line.Length - 1
					.DrawString(line(i), Font,
								New SolidBrush(
											   ColorTable(Integer.Parse(Colors(n)(i)))),
											   x, y, StringFormat.GenericTypographic)
					x += _charSize.Width
				Next
				y += _charSize.Height : n += 1
			Next

			If LineNumber Then
				.FillRectangle(bkBrush, -5, 0, 0, _lines.Count * _charSize.Height)
				.DrawLine(sepPen, -5, 0, -5, _lines.Count * _charSize.Height)

				Dim nLines As Integer = 1 : y = 0
				For Each line In _lines
					.DrawString(nLines, Font, lineBrush, -50, y, StringFormat.GenericTypographic)
					y += _charSize.Height
					nLines += 1
				Next
			End If

			' selection
			If _selecting Then
				If _selStart.Y = _selEnd.Y Then
					DrawSelectionLine(_selStart.Y, _selStart.X, _selEnd.X, _graphicsBuf.Graphics)
				Else
					Dim ss As Point = IIf(_selStart.Y < _selEnd.Y, _selStart, _selEnd)
					Dim ee As Point = IIf(_selStart.Y < _selEnd.Y, _selEnd, _selStart)
					For yy As Integer = ss.Y To ee.Y
						If yy = ss.Y Then
							' first line
							DrawSelectionLine(yy, ss.X, _lines(yy).Length, _graphicsBuf.Graphics)
						ElseIf yy = ee.Y Then
							' last line
							DrawSelectionLine(yy, 0, ee.X, _graphicsBuf.Graphics)
						Else
							DrawSelectionLine(yy, 0, _lines(yy).Length, _graphicsBuf.Graphics)
						End If
					Next
				End If
				
				DrawCursor(_graphicsBuf.Graphics, _selEnd.X, _selEnd.Y)
			Else
				DrawCursor(_graphicsBuf.Graphics, _currentCol, _currentLine)
			End If
			
		End With
		_graphicsBuf.Render()

		SetupScrollBars()

		RaiseEvent OnRefresh(Me, New EventArgs)

		_isDone = True
	End Sub

	Private Sub DrawCursor(g As Graphics, c As Integer, l As Integer)
		If (_frameCount < 25 OrElse Not BlinkCursor) AndAlso _focus Then
			Dim cx As Single = c * _charSize.Width
			Dim cy As Single = l * _charSize.Height
			g.DrawLine(Pens.Black, cx, cy, cx, cy + _charSize.Height)
		End If
	End Sub

	Private Sub SetupScrollBars()
		' v-scrollbar
		If _lines.Count * _charSize.Height < Me.Height Then
			VScrollBar.Enabled = False
			VScrollBar.Value = 0
		Else
			VScrollBar.Enabled = True
			VScrollBar.Maximum = _lines.Count
		End If

		Dim longLen As Integer = _lines.Max(Function(x) x.Length)
		If longLen * _charSize.Width < Me.Width Then
			HScrollBar.Enabled = False
			HScrollBar.Value = 0
		Else
			HScrollBar.Enabled = True
			HScrollBar.Maximum = longLen
		End If
	End Sub

	Private Sub SetupBuffer()
		_isDone = False
		Dim g = Me.CreateGraphics()

		' calculate the client rect without sliders
		Dim rect As Rectangle = Rectangle.Inflate(Me.ClientRectangle, -20, -20)
		_graphicsBuf = BufferedGraphicsManager.Current.Allocate(g, Me.ClientRectangle)

		_isDone = True
	End Sub

	Private Sub DrawSelectionLine(line As Integer, s As Integer, e As Integer, g As Graphics)
		Dim sx As Single = s * _charSize.Width
		Dim ex As Single = e * _charSize.Width
		Dim y As Single = line * _charSize.Height
		g.FillRectangle(_selectionBrush, Math.Min(sx, ex), y, Math.Abs(ex - sx), _charSize.Height)
	End Sub
#End Region

#Region "    Input Processing"

	Protected Overrides Function ProcessDialogKey(keyData As Keys) As Boolean
		Select Case keyData
			Case Keys.Left
				_currentCol -= 1
			Case Keys.Right
				_currentCol += 1
			Case Keys.Up
				_currentLine -= 1
			Case Keys.Down
				_currentLine += 1
			Case Keys.Tab
				Return False
			Case Else
				Return MyBase.ProcessDialogKey(keyData)
		End Select

		_frameCount = 0 ' disable cursor blinking
		If _currentLine < 0 Then _currentLine = 0
		If _currentLine >= _lines.Count Then _currentLine = _lines.Count - 1

		Dim l As String = _lines(_currentLine)
		If _currentCol < 0 Then _currentCol = 0
		If _currentCol > l.Length Then _currentCol = l.Length

		Return False
	End Function

	Private Sub UserControl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
		Select Case e.KeyChar
			Case vbBack
				If _selecting Then
					DelSelection()
				Else
					Dim l As String = _lines(_currentLine)
					If _currentCol > 0 Then
						' deleting
						l = l.Remove(_currentCol - 1, 1)
						_currentCol -= 1
						_lines(_currentLine) = l
					ElseIf _currentCol = 0 AndAlso _currentLine > 0 Then
						' if delete at the beginning of a line, then
						' concat this line to the pervious line

						_lines(_currentLine - 1) &= l
						_lines.RemoveAt(_currentLine)
						_currentCol = _lines(_currentLine - 1).Length
						_currentLine -= 1
					End If
				End If

			Case vbCr
				If _selecting Then DelSelection()
				NewLineAt(_currentCol)

			Case vbLf
				' do nothing, do things at vbcr

			Case vbTab
				If _selecting Then DelSelection()
				InsertStringAt(_currentCol, "    ")

			Case Else
				If _selecting Then DelSelection()
				InsertStringAt(_currentCol, e.KeyChar)
		End Select

		_frameCount = 0

		_key = e.KeyChar
		RaiseEvent TextChanged(Me, New EventArgs())

		Highlight(HighlightRules)
	End Sub

	Private Sub DelSelection()
		' make the start/end point in currect order
		Dim startSel As Point = IIf(_selStart.Y < _selEnd.Y, _selStart, _selEnd)
		Dim endSel As Point = IIf(_selStart.Y < _selEnd.Y, _selEnd, _selStart)

		If startSel.Y = endSel.Y Then
			' remove inside a SINGLE line

			_lines(startSel.Y) = _lines(startSel.Y).Remove(Math.Min(startSel.X, endSel.X), Math.Abs(endSel.X - startSel.X))
			_currentLine = startSel.Y
			_currentCol = Math.Min(startSel.X, endSel.X)
		Else
			' remove between MULTIPLE lines
			' we will do it in reverse order

			For y = endSel.Y To startSel.Y Step -1
				If y = startSel.Y Then
					' at the first line: remove chars after the selection start

					If startSel.X >= _lines(y).Length Then
						' in the case which a 'new-line' character (which is 
						' not a vaild index but a special case) was selected,
						' we should NOT modify the first line, and the last line
						' will be concat to it later

					Else
						_lines(y) = _lines(y).Remove(startSel.X)						
					End If
				ElseIf y = endSel.Y Then
					' at the last line: remove chars before the selection end,
					' and other chars will be concated to the 1st line soon
					_lines(y) = _lines(y).Remove(0, endSel.X)
				Else
					_lines.RemoveAt(y)
				End If
			Next

			' concat the characters before the sel start and after the sel end
			_lines(startSel.Y) &= _lines(startSel.Y + 1)
			_lines.RemoveAt(startSel.Y + 1)
			
			_currentLine = startSel.Y
			_currentCol = startSel.X
		End If


		_selecting = False
	End Sub

	Private Sub NewLineAt(index As Integer)
		' truncate this line and concat chars after cursor to a new line
		' add tabs if tabing && it's end of line

		Dim l As String = Strings.Left(_lines(_currentLine), index)
		Dim c As String = Strings.Left(Colors(_currentLine), index)

		Dim newl As String = Strings.Right(_lines(_currentLine),
										   _lines(_currentLine).Length - index)
		Dim newc As String = Strings.Right(Colors(_currentLine),
										   Colors(_currentLine).Length - index)

		_currentLine += 1
		_currentCol = 0

		If newl = "" AndAlso AutoTabs Then
			Dim spaces As Integer = l.Length - LTrim(l).Length
			newl = StrDup(spaces, " ")
			newc = StrDup(spaces, "0")
			_currentCol += spaces
		End If

		If _currentLine >= _lines.Count Then
			_currentLine = _lines.Count
			_lines(_currentLine - 1) = l
			_lines.Add(newl)
			Colors(_currentLine - 1) = c
			Colors.Add(newc)
		Else
			_lines(_currentLine - 1) = l
			_lines.Insert(_currentLine, newl)
			Colors(_currentLine - 1) = c
			Colors.Insert(_currentLine, newc)
		End If

		_frameCount = 0
	End Sub

	Private Sub InsertStringAt(index As Integer, str As String)
		Dim l As String = _lines(_currentLine)
		Dim c As String = Colors(_currentLine)
		If index >= l.Length Then
			_currentCol = l.Length
			l = l & str
			c = c & StrDup(str.Length, "0")
		Else
			_currentCol = index
			l = l.Insert(index, str)
			c = c.Insert(index, StrDup(str.Length, "0"))
		End If
		_currentCol += str.Length
		_lines(_currentLine) = l
		Colors(_currentLine) = c
	End Sub

	Public Sub InsertSLStringAtCurrent(str As String)
		InsertStringAt(_currentCol, str)
	End Sub

#End Region

#Region "    Event Processing"
	Private Sub UserControl_Resize(sender As Object, e As EventArgs) Handles Me.Resize
		SetupBuffer()
	End Sub

	Private sub UserControl_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
		_focus = True
	End Sub

	Private sub UserControl_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
		_focus = False
	End Sub

	Private Sub UserControl1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
		If e.Button = MouseButtons.Left Then
			_mouseDown = True
			_frameCount = 0
			_selecting = False

			Dim p As Point = ParseMouseToChar(e)
			_currentCol = p.X
			_currentLine = p.Y
			_selStart = p

		ElseIf e.Button = MouseButtons.Right Then
			_mouseDown = True
			_frameCount = 0

			'Dim p As Point = ParseMouseToChar(e)
			'cCol = p.X
			'cLine = p.Y
			'sStart = p

			If Not _selecting Then
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
			_mouseDown = False
		End If
	End Sub

	Private Sub UserControl1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
		If _mouseDown Then
			Dim p As Point = ParseMouseToChar(e)
			Dim oend As Point = _selEnd
			If p <> _selStart Then
				_selEnd = p
				_selecting = True
				If p <> oend Then RaiseEvent SelectionChanged(Me, New EventArgs())
			Else
				_selEnd = Point.Empty
				_selecting = False
				RaiseEvent SelectionChanged(Me, New EventArgs())
			End If
		End If
	End Sub

	Private Function ParseMouseToChar(e As MouseEventArgs) As Point
		Dim x, y As Integer
		y = Int((e.Y - _transform.Y) / _charSize.Height)
		x = Math.Round((e.X - _transform.X) / _charSize.Width)
		If y < 0 Then y = 0
		If x < 0 Then x = 0

		' cannot select over the last line
		If y >= _lines.Count Then y = _lines.Count - 1

		' but ALLOW to select the index that AFTER the last char,
		' which should means the new-line character, althrough the
		' index may be out of range in operations
		If x >= _lines(y).Length Then x = _lines(y).Length

		Return New Point(x, y)
	End Function

	Private Sub UserControl1_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
		Dim v As Integer = VScrollBar.Value - Int(e.Delta / 40)
		VScrollBar.Value = Math.Min(Math.Max(v, 0), VScrollBar.Maximum)
	End Sub

	Private Sub PasteMenu_Click(sender As Object, e As EventArgs) Handles PasteMenu.Click
		If Not My.Computer.Clipboard.ContainsText Then Exit Sub

		Dim texts As String() = My.Computer.Clipboard.GetText().Replace(vbTab, "    ").Split({vbCrLf}, StringSplitOptions.None)

		For Each line In texts
			InsertStringAt(_currentCol, line)
			NewLineAt(_currentCol)
		Next

		RaiseEvent TextChanged(Me, New EventArgs)
	End Sub

	Private Sub CopyMenu_Click(sender As Object, e As EventArgs) Handles CopyMenu.Click
		My.Computer.Clipboard.SetText(SelectionText)
	End Sub

	Private Sub CutMenu_Click(sender As Object, e As EventArgs) Handles CutMenu.Click
		My.Computer.Clipboard.SetText(SelectionText)
		DelSelection()
	End Sub

	Private Sub SelectAllMenu_Click(sender As Object, e As EventArgs) Handles SelectAllMenu.Click
		Dim index As Integer = _lines.Count - 1
		_selStart = New Point(0, 0)
		_selEnd = New Point(index, _lines(index).Length)
		_selecting = True
	End Sub
#End Region

#Region "    Syntax Highlight"

	Private Sub Highlight(rules As IEnumerable(Of KeyValuePair(Of String, Integer)))
		ClearColors()
		For l = 0 To _lines.Count - 1
			Dim str As String = _lines(l)
			Dim color As String = Colors(l)
			For Each rule In rules
				Dim matches As MatchCollection = Regex.Matches(str, rule.Key)
				For Each match As Match In matches
					Mid(color, match.Index + 1, match.Length) = _
							StrDup(match.Length, CChar(CStr(rule.Value)))
				Next
			Next
			Colors(l) = color
		Next
	End Sub

	Public Sub HighlightNow()
		Highlight(HighlightRules)
	End Sub

#End Region

End Class