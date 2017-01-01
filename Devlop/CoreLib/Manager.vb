'----------------------------------
' Class Manager

' Usage: 
'  Dim ss As New Manager(Form1)
'  ss.AddControl(Button1)
'
'::::::::::::::::::::::::::::::::::

'   The Manger class is the top con-
' troller of the Support classes.
'   It can control support classes 
' with dictionaries, and it's easy
' for users. And, I designed it easy
' to send in my Objects.
'

Public Class Manager

    Dim ctrlCount As Integer = 0

    Friend _conts As Dictionary(Of Control, Control)   'This is the Main-control to Sizer dict.
    Friend _cToDs As Dictionary(Of Control, DragSup)   'This is the Main-control to Drag-Support class dict.
    Friend _cToSs As Dictionary(Of Control, SizeSup)   'This is the Main-control to Size-Support class dict.
    Friend _cTNam As Dictionary(Of Control, String)    'This is the dict. of Main-control to its Name

    Friend _f As Form
    Friend userCode As String
    Friend referencesAssm As New Collections.Specialized.StringCollection
    Dim _prop As PropertyGrid
    Dim _active As Control
    Dim WithEvents _txtnam As TextBox

    Public Sub New(F As Form, Prop As PropertyGrid, Txt As TextBox)
        _f = F
        _prop = Prop
        _txtnam = Txt

        _conts = New Dictionary(Of Control, Control)
        _cToDs = New Dictionary(Of Control, DragSup)
        _cToSs = New Dictionary(Of Control, SizeSup)
        _cTNam = New Dictionary(Of Control, String)

        AddHandler _f.Click, AddressOf ctrl_Click
        _cTNam.Add(_f, "Blank")

        userCode = String.Format("Partial Class " & F.Name & "{0}" & _
                                 "    {0}" & _
                                 "End Class", vbCrLf)
        
        referencesAssm.AddRange({"System.dll", 
                                 "System.Drawing.dll",
                                 "System.Windows.Forms.dll",
                                 "System.Data.dll",
                                 "Microsoft.VisualBasic.dll"})
    End Sub

    Public Sub AddControl(c As Control)
        If c Is Nothing Then Throw New ArgumentNullException
        If Not _f.Controls.Contains(c) Then Throw New ArgumentException

        Dim sizer As New Button()
        sizer.Top = c.Top + c.Height
        sizer.Left = c.Left + c.Width
        sizer.Size = New Size(10, 10)
        sizer.Text = ""

        Dim ds As New DragSup(c)
        Dim ss As New SizeSup(c, sizer)

        AddHandler c.MouseUp, AddressOf ctrl_Click

        _f.Controls.Add(sizer)
        _conts.Add(c, sizer)
        _cToDs.Add(c, ds)
        _cToSs.Add(c, ss)
        _cTNam.Add(c, "Control" & ctrlCount.ToString)

        ctrlCount += 1
    End Sub

    Public Function RemoveControl(c As Control) As Boolean
        Try
            _f.Controls.Remove(c)
            _f.Controls.Remove(_conts(c))

            _conts.Remove(c)
            _cToDs.Remove(c)
            _cToSs.Remove(c)
            _cTNam.Remove(c)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Private Sub ctrl_Click(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            _prop.SelectedObject = sender
            _active = sender
            _txtnam.Text = _cTNam(sender)
        Else If e.Button = MouseButtons.Right Then
            If Not RemoveControl(sender) Then MsgBox("Error in removing control")
        End If
    End Sub

    Public Property DragEnable(c As Control) As Boolean
        Get
            If Not _cToDs.ContainsKey(c) Then Throw New KeyNotFoundException
            Return _cToDs(c).Enabled
        End Get
        Set(ByVal value As Boolean)
            _cToDs(c).Enabled = value
        End Set
    End Property

    Public Property SizeEnable(c As Control) As Boolean
        Get
            If Not _cToSs.ContainsKey(c) Then Throw New KeyNotFoundException
            Return _cToSs(c).Enabled
        End Get
        Set(ByVal value As Boolean)
            _cToSs(c).Enabled = value
        End Set
    End Property

    'Private Sub ctrl_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If e.KeyChar = "D" Then                      ' Delete
    '        Try
    '            RemoveControl(sender)
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End If
    'End Sub


    Private Sub _txtnam_TextChanged(sender As Object, e As EventArgs) Handles _txtnam.TextChanged
        If _active Is Nothing Then Exit Sub
        _cTNam(_active) = _txtnam.Text
    End Sub
End Class
