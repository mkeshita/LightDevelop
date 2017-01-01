Public Class CodeRunner
    Dim _source, _name, _entC, _entM As String
    Dim _m As Manager
    Dim _assm As CodeDom.Compiler.CompilerResults
    Dim compiled As Boolean
    Public Sub New(name As String, t As String, entClass As String, m As Manager, Optional entMethod As String = "Main")
        _source = t
        _name   = name
        _entC   = entClass
        _entM   = entMethod
        _m      = m
    End Sub

    Sub Compile()
        Dim v As New VBCodeProvider()
        Dim p As New CodeDom.Compiler.CompilerParameters()
        p.TreatWarningsAsErrors = False
        For Each s In _m.References
            p.ReferencedAssemblies.Add(s)
        Next
        _assm = v.CompileAssemblyFromSource(p, _source)
    End Sub

    Sub Compile(output As String)
        Dim v As New VBCodeProvider()
        Dim p As New CodeDom.Compiler.CompilerParameters()
        p.GenerateExecutable = True
        p.MainClass = _entC
        p.OutputAssembly = output
        p.TreatWarningsAsErrors = False
        For Each s In _m.References
            p.ReferencedAssemblies.Add(s)
        Next
        _assm = v.CompileAssemblyFromSource(p, _source)
    End Sub

    Sub Run()
        If compiled AndAlso _assm.Errors.Count = 0 Then
            Dim assm = _assm.CompiledAssembly.GetType(_entC)
            Dim obj As Object = _assm.CompiledAssembly.CreateInstance(_entC)
            assm.GetMethod(_entM).Invoke(obj, {})
        Else: Throw New InvalidOperationException
        End If
    End Sub

    Public ReadOnly Property Errors() As CodeDom.Compiler.CompilerErrorCollection
        Get
            Return _assm.Errors
        End Get
    End Property

End Class
