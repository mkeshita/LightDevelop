' XmlLoader.vb
' This file contains:
'
' Class Develop.Core.XmlLoader

Namespace Core
	''' <summary>
	''' Reads a Xml project file to the manager.
	''' </summary>
	Public Class XmlLoader
		Private _manager As Manager

		Sub New(m As Manager)
			_manager = m
		End Sub

		Sub LoadXml(file As String)
			If _manager.SizerCtrlDictionary.Count > 0 Then
				If MessageBox.Show("Do you really want to Overwrite? ", "Warning", 
								MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then Exit Sub
			End If
			Dim co As New Dictionary(Of Control, Control)(_manager.SizerCtrlDictionary)
			
			Try
				Dim x = Xml.XmlReader.Create(file)
				x.ReadToFollowing("formAttr")
				_manager.DesignerForm.Text = x.GetAttribute("name")
				ReadControlDecl(x, _manager.DesignerForm)

				Do While x.ReadToNextSibling("controlAttr")
					Dim name = x.GetAttribute("name"),
						type = x.GetAttribute("controlKind")

					Dim c = ControlCreater.CreatControlToContainer(type, _manager.DesignerForm)
					_manager.AddControl(c)
					_manager.CtrlNameDictionary(c) = name

					ReadControlDecl(x, c)
				Loop

				Dim ref As New Specialized.StringCollection, imp As New List(Of String)
				x.ReadToFollowing("projSettings")
				x.ReadToFollowing("refItem")
				Do
					ref.Add(x.ReadString())
				Loop While x.ReadToNextSibling("refItem")

				x.ReadToFollowing("importItem")
				Do
					imp.Add(x.ReadString())
				Loop While x.ReadToNextSibling("importItem")

				'If x.ReadToFollowing("userCode") Then _
				'	_manager.UserCode = x.ReadString()

				x.Close()

				_manager.References = ref
				_manager.ImportStatments = imp
			Catch ex As Exception
				MessageBox.Show("Bad project file format! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Exit Sub
			End Try

			For Each c In co
				_manager.RemoveControl(c.Key)
			Next
		End Sub

		Sub ReadControlDecl(x As Xml.XmlReader, c As Control)
			x.ReadToFollowing("property")
			Do
				Dim name = x.GetAttribute("name"),
					type = x.GetAttribute("type"),
					p = c.GetType.GetProperty(name),
					val As Object

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
					Case "enum"
						Dim str As String = x.ReadString()
						val = [Enum].Parse(p.PropertyType, str)
					Case Else
						Continue Do
				End Select

				p.SetValue(c, val, Nothing)
			Loop While x.ReadToNextSibling("property")
		End Sub
	End Class
End Namespace
