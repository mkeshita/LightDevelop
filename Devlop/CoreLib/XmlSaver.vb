Public Class XmlSaver
	Private _m As Manager

	Sub New(m As Manager)
		_m = m
	End Sub

	Public Function CompileToXml() As String
		Dim sb As New IO.StringWriter()
		Dim x = Xml.XmlWriter.Create(sb, New Xml.XmlWriterSettings() With {
											.Indent = True, .ConformanceLevel = Xml.ConformanceLevel.Fragment})
		x.WriteRaw("<?xml version=""1.0"" ?>")
		x.WriteStartElement("projData")
			x.WriteStartElement("formData")
				x.WriteStartElement("formAttr")
				x.WriteAttributeString("name", _m.DesignerForm.Text)
					WriteAttrDeclXml(x, _m.DesignerForm)
				x.WriteEndElement()

				For Each c In _m.DictControlSizer
					x.WriteStartElement("controlAttr")
					x.WriteAttributeString("name", _m.DictControlName(c.Key))
					x.WriteAttributeString("controlKind", c.Key.GetType().Name)
						WriteAttrDeclXml(x, c.Key)
					x.WriteEndElement()
				Next
			x.WriteEndElement()

			x.WriteStartElement("projSettings")
				x.WriteStartElement("references")
					For Each ref In _m.References
						x.WriteElementString("refItem", ref)
					Next
				x.WriteEndElement()

				x.WriteStartElement("imports")
					For Each imp In _m.ImportStatments
						x.WriteElementString("importItem", imp)
					Next
				x.WriteEndElement()
			x.WriteEndElement()
		x.WriteEndElement

		x.Flush
		sb.Flush
		Return sb.ToString()
	End Function

	Public Sub WriteAttrDeclXml(x As Xml.XmlWriter, c As Control)
		For Each p In c.GetType().GetProperties()
			Dim v = p.GetValue(c, Nothing), d = GetDefault(p)
			If Not ((v Is Nothing AndAlso d Is Nothing) OrElse 
					(v.Equals(d) OrElse Not p.CanWrite)) Then
				Select Case p.PropertyType.Name
				Case "String"
					x.WriteStartElement("property")
						x.WriteAttributeString("name", p.Name)
						x.WriteAttributeString("type", "string")
						x.WriteString(CStr(v))
					x.WriteEndElement()

				Case "Integer", "Double", "Short", "UInteger", "UDouble", "UShort", "Int16", "Int32", "Int64", _
                            "UInt16", "UInt32", "UInt64", "Boolean"
					x.WriteStartElement("property")
						x.WriteAttributeString("name", p.Name)
						x.WriteAttributeString("type", "direct")
						x.WriteString(v.ToString())
					x.WriteEndElement()

				Case "Point"
					Dim val = CType(v, Point)
					x.WriteStartElement("property")
						x.WriteAttributeString("name", p.Name)
						x.WriteAttributeString("type", "point")
						x.WriteAttributeString("x", val.X.ToString())
						x.WriteAttributeString("y", val.Y.ToString())
					x.WriteEndElement()

				Case "Size"
					Dim val = CType(v, Size)
					x.WriteStartElement("property")
						x.WriteAttributeString("name", p.Name)
						x.WriteAttributeString("type", "size")
						x.WriteAttributeString("w", val.Width.ToString())
						x.WriteAttributeString("h", val.Height.ToString())
					x.WriteEndElement()

				Case "Color"
					Dim val = CType(v, Color)
					x.WriteStartElement("property")
						x.WriteAttributeString("name", p.Name)
						x.WriteAttributeString("type", "color")
						x.WriteAttributeString("r", val.R.ToString())
						x.WriteAttributeString("g", val.G.ToString())
						x.WriteAttributeString("b", val.B.ToString())
						x.WriteAttributeString("a", val.A.ToString())
					x.WriteEndElement()
				End Select
			End If
		Next
	End Sub

	Private Function GetDefault(prop As Reflection.PropertyInfo)
        Try
            Dim c As New Control()
            Return prop.GetValue(c, Nothing)
        Catch x As Exception
            Return Nothing
        End try
    End Function
End Class
