Friend Class Settings
	Public Shared EnableHighlight As Boolean = True
	Public Shared EnableAutoFinish As Boolean = True
	Public Shared EnableCodeSnippets As Boolean = True
	Public Shared TabLength As Integer = 4
	Public Shared CodeSnippetsLocation As String = "D:\snippets.xml"

	Public Shared Sub Initialize()
		EnableHighlight = GetBool("Highlight", EnableHighlight)
		EnableAutoFinish = GetBool("AutoFinish", EnableAutoFinish)
		EnableCodeSnippets = GetBool("Snippets", EnableCodeSnippets)
		TabLength = GetInteger("TabLength", TabLength)
		CodeSnippetsLocation = GetString("SnippetsLoc", CodeSnippetsLocation)
	End Sub

	Public Shared Sub SaveAll()
		SaveSetting("Develop", "Settings", "Highlight", EnableHighlight.ToString)
		SaveSetting("Develop", "Settings", "AutoFinish", EnableAutoFinish.ToString)
		SaveSetting("Develop", "Settings", "Snippets", EnableCodeSnippets.ToString)
		SaveSetting("Develop", "Settings", "TabLength", TabLength.ToString)
		SaveSetting("Develop", "Settings", "SnippetsLoc", CodeSnippetsLocation)
	End Sub

	Private Shared Function GetString(name As String, def As String) As String
		Dim str = GetSetting("Develop", "Settings", name)
		If str = "" Then Return def
		Return str
	End Function

	Private Shared Function GetBool(name As String, def As Boolean) As Boolean
		Dim str = GetSetting("Develop", "Settings", name)
		If str = "" Then Return def
		Return IIf(str = "True", True, False)
	End Function

	Private Shared Function GetInteger(name As String, def As Integer) As Integer
		Dim res As Integer
		If Not Integer.TryParse(GetSetting("Develop", "Settings", name), res) Then Return def
		Return res
	End Function

	Private Shared Function GetFloat(name As String, def As Double) As Double
		Dim res As Double
		If Not Double.TryParse(GetSetting("Develop", "Settings", name), res) Then Return def
		Return res
	End Function
End Class
