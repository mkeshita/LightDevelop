' CodeCompiler.vb
' This file contains:
'
' Class Develop.Core.CodeCompiler

Namespace Core
	''' <summary>
	''' Compiles the whole generated source code.
	''' </summary>
	Public Class CodeCompiler
		Private _source, _entClass, _entMethod As String
		Private _manager As Manager
		Private _results As CodeDom.Compiler.CompilerResults
		Private _compiled As Boolean

		Public ReadOnly Property Errors() As CodeDom.Compiler.CompilerErrorCollection
			Get
				Return _results.Errors
			End Get
		End Property

		Public Sub New(sourceCode As String, entClass As String, m As Manager, Optional entMethod As String = "Main")
			_source = sourceCode
			_entClass = entClass
			_entMethod = entMethod
			_manager = m
		End Sub

		Sub Compile(output As String)
			Dim v As New VBCodeProvider()
			Dim p As New CodeDom.Compiler.CompilerParameters()
			p.GenerateExecutable = True
			p.MainClass = _entClass
			p.OutputAssembly = output
			p.TreatWarningsAsErrors = False
			For Each s In _manager.References
				p.ReferencedAssemblies.Add(s)
			Next
			_results = v.CompileAssemblyFromSource(p, _source)
		End Sub
	End Class
End Namespace