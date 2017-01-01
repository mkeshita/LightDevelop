Module Keywords
	
    ' fifth
    Friend Strings As String =
        """.*"""
    ' fourth
    Friend Comment As String =
        "'.*"
    ' third
    Friend Keys As String = 
        "\b(Inherits|Implements|Continue|Return|#Const|Handles|AddHandler|Try|Catch|Finally|Throw|AddressOf|Const|Int32|Int64|Int16|#If|Then|#Else|#Region|Delegate|Imports|Namespace|Class|End|Friend|Partial|Module|Interface|Enum|Shared|Overrides|Overloads|Structure|Let|Const|Dim|As|Private|Public|New|Static|Option|Private|Module|IsArray|IsDate|IsEmpty|IsError|IsMissing|IsNull|IsNumeric|IsObject|TypeName|VarType|Me|Option|Explicit|Eqv|Imp|Clear|Error|Raise|Error|Err|CVErr|On|Error|Resume|IsError|Collection|Add|Remove|Item|Do|Loop|For|Next|For|Each|Next|While|With|If|Then|Else|Select|Case|Switch|Call|Function|Property|Get|Let|Sub|Date|Now|Time|Timer|CBool|CByte|CDate|CDbl|CDec|CInt|CLng|CSng|CStr|CObj|Int|Boolean|Byte|Currency|Date|Double|Integer|Long|Object|Single|String|Object|Randomize|Rnd|Int|IsArray|Array|Option|Base|Dim|Private|Public|ReDim|Static|LBound|UBound|Erase|ReDim|Chr|Format|Hex|Oct|Format|Str|Fix|Int|Day|Month|Weekday|Year|Hour|Minute|Second|Asc|Val|TimeSerial|TimeValue|StrComp|StrConv|Format|LCase|UCase|Space|String|Len|Format|LSet|RSet|InStr|Left|LTrim|Mid|Right|RTrim|Trim|Option|Compare|Asc|Chr|AppActivate|Shell|SendKeys|Beep|Command)\b"
    ' second
    Friend Operators As String =
        "((?<=(\d|\s))(Mod|Like|Is|Not|And|Or|Xor)(?=(\d|\s))|[+\-*/=])"
    ' first
    Friend Numbers As String = 
        "\b[0-9.]+\b"

    Friend KeyTable As KeyValuePair(Of String, Color)() = {
            New KeyValuePair(Of　String, Color)(Numbers,     Color.DarkCyan  ),
            New KeyValuePair(Of　String, Color)(Operators,   Color.Red       ),
            New KeyValuePair(Of　String, Color)(Keys,        Color.Blue      ),
            New KeyValuePair(Of　String, Color)(Comment,     Color.DarkGreen ),
            New KeyValuePair(Of　String, Color)(Strings,     Color.Brown     )
        }
End Module
