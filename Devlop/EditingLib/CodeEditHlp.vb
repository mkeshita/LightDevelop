Imports System.Text.RegularExpressions
Imports System.Runtime.InteropServices

Module CodeEditHlp

    Private ass, vbass As Reflection.Assembly ' the assembly of mscorlib.dll
    Private types As Type(), vbtypes As Type()

    Sub New()
        ass = Reflection.Assembly.GetAssembly(GetType(System.Object))
        vbass = Reflection.Assembly.GetAssembly(GetType(Microsoft.VisualBasic.Collection))
        types = ass.GetTypes()
        vbtypes = vbass.GetTypes()
    End Sub

    ''' <summary>
    ''' Get the last word of given text until a character limit.
    ''' </summary>
    ''' <param name="s">The text which we find the word in. </param>
    ''' <param name="i">The limit of the word, all search stopped after that count of character. </param>
    ''' <returns></returns>
    Public Function GetLastWord(s As String, i As Integer) As String
        ' Get the last word.
        Dim x = Left(s, i)
        x = Regex.Match(x, "\s*[a-zA-Z]+\s*", RegexOptions.RightToLeft).Value

        ' Remove all whitespaces.
        x = Regex.Replace(x, "\s", "")

        Return x
    End Function

    Private sepr As Char() = {"+", "-", "*", "/", " ", "(", ")", "{", "}", ",", "&", "^", "="}

    ''' <summary>
    ''' The kind of a Type.
    ''' </summary>
    Public Enum ElementKind
        KindClass
        KindEnum
        KindInterface
        KindUnknown
    End Enum

    ''' <summary>
    ''' Get all Types in the namespace.
    ''' </summary>
    ''' <param name="space">The given namespace. </param>
    ''' <returns>All Types detected. </returns>
    Public Function GetTypesInNamespace(space As String) As Dictionary(Of Type, ElementKind)
        Dim l As New Dictionary(Of Type, ElementKind)
        Dim ti = Now
        For Each t In types
            On Error Resume Next
            If t.IsNotPublic Or t.Namespace <> space Then Continue For
            Dim kind As ElementKind = ElementKind.KindUnknown
            If t.IsClass Then kind = ElementKind.KindClass

            If t.IsEnum Then kind = ElementKind.KindEnum
            If t.IsInterface Then kind = ElementKind.KindInterface
            If kind = ElementKind.KindUnknown Then Continue For

            l.Add(t, kind)
            If (Now - ti).Seconds > 3 Then Exit For
        Next
        If l.Count = 0 Then
            ' if there is no such thing in mscorlib...
            ' search it in microsoft namespace!
            For Each t In vbtypes
                On Error Resume Next
                If t.IsNotPublic Or t.Namespace <> space Then Continue For
                Dim kind As ElementKind = ElementKind.KindUnknown
                If t.IsClass Then kind = ElementKind.KindClass
                If t.IsEnum Then kind = ElementKind.KindEnum
                If t.IsInterface Then kind = ElementKind.KindInterface

                If kind = ElementKind.KindUnknown Then Continue For

                l.Add(t, kind)
                If (Now - ti).Seconds > 3 Then Exit For
            Next

        End If
        Return l
    End Function

    ''' <summary>
    ''' Get the editing name from the cursor in the RichTextBox.
    ''' </summary>
    ''' <param name="rt">The RTB that find in. </param>
    ''' <param name="editChar">While doing this in a KeyPress event, the editing char will not appends to the textbox. So I need this char. </param>
    ''' <returns>The detected name. </returns>
    Public Function GetName(rt As RichTextBox, editChar As Char) As String
        Dim reftxt As String
        reftxt = rt.Lines(rt.GetLineFromCharIndex(rt.SelectionStart)) & editChar
        Dim pos = reftxt.LastIndexOf(".")
        If pos >= 0 Then reftxt = Left(reftxt, pos)
        reftxt = Trim(reftxt)

        For Each sep In sepr
            Dim npos = reftxt.LastIndexOf(sep)
            If npos >= 0 Then reftxt = reftxt.Substring(npos + 1)
        Next
        Return reftxt
    End Function

    ''' <summary>
    ''' "Guess" the Type that near the cursor. 
    ''' </summary>
    ''' <param name="rt">The RTB that find in. </param>
    ''' <param name="editChar">While doing this in a KeyPress event, the editing char will not appends to the textbox. So I need this char. </param>
    ''' <param name="assms"></param>
    ''' <returns></returns>
    Public Function GuessType(rt As RichTextBox, editChar As Char, assms As _
                              Collections.Specialized.StringCollection) As Reflection.MemberInfo()
        Dim reftxt = GetName(rt, editChar)
        Dim res = GuessTypeN(assms, reftxt, ass)
        If res.Length = 0 Then
            res = GuessTypeN(assms, reftxt, vbass)
        End If

        Return res
    End Function
    Private Function GuessTypeN(assms As Collections.Specialized.StringCollection, reftxt As String,
                                asse As Reflection.Assembly) As Reflection.MemberInfo()
		Dim cls As Type
		cls = asse.GetType(reftxt)
		If cls IsNot Nothing Then Return cls.GetMembers()

		For Each assm In assms
			cls = asse.GetType(assm.Substring(0, assm.Length - 3) & reftxt)

			If cls IsNot Nothing Then Exit For
		Next

		If cls Is Nothing Then Return {}

		Return cls.GetMembers()
    End Function

    Public Sub Highlight(tb As RichTextBox, word As String, c As Color)
        Dim oldSS = tb.SelectionStart
        tb.Select(oldSS - word.Length, word.Length)
        tb.SelectionColor = c

        ' Restore
        tb.Select(oldSS, 0)
        tb.SelectionColor = Color.Black
    End Sub


    <DllImport("user32.dll")>
    Function SendMessage(hwnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As IntPtr) As Integer
    End Function

    Sub EnableRedraw(c As Control)
        SendMessage(c.Handle, &HB, 1, IntPtr.Zero)
    End Sub

    Sub DisableRedraw(c As Control)
        SendMessage(c.Handle, &HB, 0, IntPtr.Zero)
        c.Refresh()
    End Sub
End Module
