' XmlSaver.vb
' This file contains:
'
' Class Develop.Core.XmlSaver

Namespace Core
	''' <summary>
	''' Writes the project to a Xml file.
	''' </summary>
	Public Class XmlSaver
		Private _manager As Manager

		Sub New(m As Manager)
			_manager = m
		End Sub

		Public Function CompileToXml() As String
			Dim writer As New IO.StringWriter()
			Dim x = Xml.XmlWriter.Create(writer, 
						New Xml.XmlWriterSettings() With {
							.Indent = True, .ConformanceLevel = Xml.ConformanceLevel.Fragment})
			x.WriteRaw("<?xml version=""1.0"" ?>")
			x.WriteStartElement("projData")
			  x.WriteStartElement("formData")
				x.WriteStartElement("formAttr")
				  x.WriteAttributeString("name", _manager.DesignerForm.Text)
				  WriteAttrDeclXml(x, _manager.DesignerForm)
				x.WriteEndElement()

				For Each c In _manager.SizerCtrlDictionary
					x.WriteStartElement("controlAttr")
					x.WriteAttributeString("name", _manager.CtrlNameDictionary(c.Key))
					x.WriteAttributeString("controlKind", c.Key.GetType().Name)
					WriteAttrDeclXml(x, c.Key)
					x.WriteEndElement()
				Next
			  x.WriteEndElement()

			  x.WriteStartElement("projSettings")
				x.WriteStartElement("references")
			  	  For Each ref In _manager.References
					  x.WriteElementString("refItem", ref)
				  Next
				x.WriteEndElement()

				x.WriteStartElement("imports")
				  For Each imp In _manager.ImportStatments
			  		  x.WriteElementString("importItem", imp)
				  Next
				x.WriteEndElement()
			  x.WriteEndElement()

			  ' these <userCode> writes normally but reads incorrectly
			  x.WriteStartElement("userCode")
			  x.WriteString(_manager.UserCode)
			  x.WriteEndElement()
			x.WriteEndElement()

			x.Flush()
			writer.Flush()

			Return writer.ToString()
		End Function

		Public Sub WriteAttrDeclXml(x As Xml.XmlWriter, c As Control)
			For Each p In c.GetType().GetProperties()
				Dim value = p.GetValue(c, Nothing), defaultVal = GetDefault(p)
				If Not ((value Is Nothing AndAlso defaultVal Is Nothing) OrElse
						(value.Equals(defaultVal) OrElse Not p.CanWrite)) Then
					Select Case p.PropertyType.Name
						Case "String"
							x.WriteStartElement("property")
							x.WriteAttributeString("name", p.Name)
							x.WriteAttributeString("type", "string")
							x.WriteString(CStr(value))
							x.WriteEndElement()

						Case "Integer", "Double", "Short", "UInteger", "UDouble", _
							 "UShort", "Int16", "Int32", "Int64", "UInt16", _
							 "UInt32", "UInt64", "Boolean"
							x.WriteStartElement("property")
							x.WriteAttributeString("name", p.Name)
							x.WriteAttributeString("type", "direct")
							x.WriteString(value.ToString())
							x.WriteEndElement()

						Case "Point"
							Dim val = CType(value, Point)
							x.WriteStartElement("property")
							x.WriteAttributeString("name", p.Name)
							x.WriteAttributeString("type", "point")
							x.WriteAttributeString("x", val.X.ToString())
							x.WriteAttributeString("y", val.Y.ToString())
							x.WriteEndElement()

						Case "Size"
							Dim val = CType(value, Size)
							x.WriteStartElement("property")
							x.WriteAttributeString("name", p.Name)
							x.WriteAttributeString("type", "size")
							x.WriteAttributeString("w", val.Width.ToString())
							x.WriteAttributeString("h", val.Height.ToString())
							x.WriteEndElement()

						Case "Color"
							Dim val = CType(value, Color)
							x.WriteStartElement("property")
							x.WriteAttributeString("name", p.Name)
							x.WriteAttributeString("type", "color")
							x.WriteAttributeString("r", val.R.ToString())
							x.WriteAttributeString("g", val.G.ToString())
							x.WriteAttributeString("b", val.B.ToString())
							x.WriteAttributeString("a", val.A.ToString())
							x.WriteEndElement()

						Case Else
							If p.PropertyType.IsEnum Then
								' Now support Enumerate.
								Dim val = CType(value, [Enum])
								x.WriteStartElement("property")
								x.WriteAttributeString("name", p.Name)
								x.WriteAttributeString("type", "enum")
								x.WriteString(val.ToString())
								x.WriteEndElement()
							End If
					End Select
				End If
			Next
		End Sub

		Private Function GetDefault(prop As Reflection.PropertyInfo) As Object
			Try
				Dim c As New Control()
				Return prop.GetValue(c, Nothing)
			Catch x As Exception
				Return Nothing
			End Try
		End Function
	End Class
End Namespace

