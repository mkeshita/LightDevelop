Public Class CodeRunner
    Dim _source, _entC, _entM As String
    Dim _m As Manager
    Dim _assm As CodeDom.Compiler.CompilerResults
    Dim compiled As Boolean
    Public Sub New(sourceCode As String, entClass As String, m As Manager, Optional entMethod As String = "Main")
        _source = sourceCode
        _entC   = entClass
        _entM   = entMethod
        _m      = m
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

    Public ReadOnly Property Errors() As CodeDom.Compiler.CompilerErrorCollection
        Get
            Return _assm.Errors
        End Get
    End Property

End Class
