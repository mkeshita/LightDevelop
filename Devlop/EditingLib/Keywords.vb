' Keywords.vb
' This file contains:
'
' Class Develop.Editing.Keywords

Namespace Editing
	''' <summary>
	''' Static class containing the highlighting rules.
	''' </summary>
	Public Class Keywords
		' fifth
		Public Shared Strings As String =
				""".*"""
		' fourth
		Public Shared Comment As String =
				"'.*"
		' third
		Public Shared Keys As String =
				"\b(Inherits|Implements|Continue|Return|#Const|Handles|AddHandler|Try|" & _
				"Catch|Finally|Throw|AddressOf|Const|Int32|Int64|Int16|#If|Then|#Else|" & _ 
				"#Region|Delegate|Imports|Namespace|Class|End|Friend|Partial|Module|" & _
				"Interface|Enum|Shared|Overrides|Overloads|Structure|Let|Const|Dim|As|" & _ 
				"Private|Public|New|Static|Option|Private|Module|IsArray|IsDate|" & _ 
				"IsEmpty|IsError|IsMissing|IsNull|IsNumeric|IsObject|TypeName|VarType|" & _
				"Me|Option|Explicit|Do|Loop|For|Next|For|Each|" & _ 
				"Next|While|With|If|Then|Else|Select|Case|Switch|Call|Function|Property|" & _ 
				"Get|Let|Sub|CBool|CByte|CDate|CDbl|CDec|CInt|CLng|" & _
				"CSng|CStr|CObj|Int|Boolean|Byte|Double|Integer|Long|" & _ 
				"Object|Single|String|Object|Randomize|Rnd|Int|IsArray|Array|Option|" & _ 
				"Dim|Private|Public|ReDim|String|Option|Compare)\b"

		' second
		Public Shared Operators As String =
				"((?<=(\d|\s))(Mod|Like|Is|Not|And|Or|Xor)(?=(\d|\s))|[+\-*/=])"
		' first
		Public Shared Numbers As String =
				"\b[0-9.]+\b"

		Public Shared ColorTable As Color() = { 
				Color.Black, 
				Color.DarkCyan, 
				Color.Red, 
				Color.Blue, 
				Color.DarkGreen, 
				Color.Brown}

		Public Shared RuleTable As KeyValuePair(Of String, Integer)() = {
					New KeyValuePair(Of String, Integer)(Numbers, 1),
					New KeyValuePair(Of String, Integer)(Operators, 2),
					New KeyValuePair(Of String, Integer)(Keys, 3),
					New KeyValuePair(Of String, Integer)(Comment, 4),
					New KeyValuePair(Of String, Integer)(Strings, 5)
				}
	End Class
End Namespace

