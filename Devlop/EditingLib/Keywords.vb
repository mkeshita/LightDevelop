Namespace Editing
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
				"Me|Option|Explicit|Eqv|Imp|Clear|Error|Raise|Error|Err|CVErr|On|Error|" & _ 
				"Resume|IsError|Collection|Add|Remove|Item|Do|Loop|For|Next|For|Each|" & _ 
				"Next|While|With|If|Then|Else|Select|Case|Switch|Call|Function|Property|" & _ 
				"Get|Let|Sub|Date|Now|Time|Timer|CBool|CByte|CDate|CDbl|CDec|CInt|CLng|" & _
				"CSng|CStr|CObj|Int|Boolean|Byte|Currency|Date|Double|Integer|Long|" & _ 
				"Object|Single|String|Object|Randomize|Rnd|Int|IsArray|Array|Option|" & _ 
				"Base|Dim|Private|Public|ReDim|Static|LBound|UBound|Erase|ReDim|Chr|" & _ 
				"Format|Hex|Oct|Format|Str|Fix|Int|Day|Month|Weekday|Year|Hour|Minute|" & _ 
				"Second|Asc|Val|TimeSerial|TimeValue|StrComp|StrConv|Format|LCase|UCase|" & _ 
				"Space|String|Len|Format|LSet|RSet|InStr|Left|LTrim|Mid|Right|RTrim|" & _ 
				"Trim|Option|Compare|Asc|Chr|AppActivate|Shell|SendKeys|Beep|Command)\b"

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

