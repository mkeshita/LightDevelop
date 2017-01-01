Public Class XmlLoader
	Private _m As Manager

	Sub New(m As Manager)
		_m = m
	End Sub

	Sub LoadXml(file As String)
		If _m._conts.Count > 0 Then
			If MessageBox.Show("All applied changes will lost. ", "Do you really want to load? ",
							MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then Exit Sub
		End If
		Dim co As New Dictionary(Of Control, Control)(_m._conts)
		
		Try
			Dim x = Xml.XmlReader.Create(file)
			x.ReadToFollowing("formAttr")
			_m._f.Text = x.GetAttribute("name")
			ReadControlDecl(x, _m._f)
			Do While x.ReadToNextSibling("controlAttr")
				Dim name = x.GetAttribute("name"),
					type = x.GetAttribute("controlKind")
			
				Dim c = AddControlHelper.CreatControlToContainer(type, _m._f)
				_m.AddControl(c)
				_m._cTNam(c) = name

				ReadControlDecl(x, c)
			Loop
			x.Close
		Catch ex As Exception
			MessageBox.Show("Bad form file format! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Exit Sub
		End Try

		For Each c In co
			_m.RemoveControl(c.Key)
		Next
	End Sub

	Sub ReadControlDecl(x As Xml.XmlReader, c As Control)
		x.ReadToFollowing("property")
		Do
			Dim name = x.GetAttribute("name"), 
				type = x.GetAttribute("type"), 
				p    = c.GetType.GetProperty(name), 
				val  As Object

			Select Case type
			Case "string"
				val = x.ReadString()
			Case "direct"
				val = p.PropertyType.GetMethod("Parse", {GetType(String)}).Invoke(Nothing, {x.ReadString()})
			Case "point"
				Dim xx = x.GetAttribute("x"), yy = x.GetAttribute("y")
				val = New Point(xx, yy)
			Case "size"
				Dim ww = x.GetAttribute("w"), hh = x.GetAttribute("h")
				val = New Size(ww, hh)
			Case "color"
				Dim r = x.GetAttribute("r"), g = x.GetAttribute("g"), 
					b = x.GetAttribute("b"), a = x.GetAttribute("a")
				val = Color.FromArgb(a, r, g, b)
			Case Else
				Continue Do
			End Select

			p.SetValue(c, val, Nothing)
		Loop While x.ReadToNextSibling("property")
	End Sub
End Class
