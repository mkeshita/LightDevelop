Namespace Core
	Public Class CodeGenerater
		Dim outline As String = String.Format(
				"[IMPORTS]{0}" &
				"Public Class [NAME]{0}" &
				"    Inherits System.Windows.Forms.Form{0}" &
				"    Sub New(){0}" &
				"        MyBase.New(){0}" &
				"        InitializeComponent(){0}" &
				"    End Sub{0}" &
				"    Protected Overrides Sub Dispose(ByVal disposing As Boolean){0}" &
				"        Try{0}" &
				"            If disposing AndAlso components IsNot Nothing Then{0}" &
				"                components.Dispose(){0}" &
				"            End If{0}" &
				"        Finally{0}" &
				"            MyBase.Dispose(disposing){0}" &
				"        End Try{0}" &
				"    End Sub{0}" &
				"    Private components As System.ComponentModel.IContainer{0}" &
				"    Private Sub InitializeComponent(){0}" &
				"        Me.components = New System.ComponentModel.Container(){0}" &
				"        [CODE]{0}" &
				"    End Sub{0}" &
				"[DECLARES]{0}" &
				"End Class{0}" &
				"[USERCODE]{0}",
				vbCrLf)

		Dim _m As Manager

		Sub New(m As Manager)
			_m = m
		End Sub

		Function Compile() As String
			Dim comp As String
			comp = outline.Replace("[NAME]", _m.DesignerForm.Text)

			Dim str = ""
			For Each s In _m.ImportStatments
				' Remove the ".dll"
				str &= "Imports " & s & vbCrLf
			Next
			comp = comp.Replace("[IMPORTS]", str)
			str = ""

			WriteNames(str)

			str &= String.Format("{0}        Me.SuspendLayout(){0}", vbCrLf)

			str &= String.Format("{0}        ' {1}{0}{0}", vbCrLf, _m.DesignerForm.Text)
			str &= GetAttuDelcare(_m.DesignerForm, True)
			For Each ctrls In _m.DictControlSizer
				str &= String.Format("{0}        ' {1}{0}{0}", vbCrLf, _m.DictControlName(ctrls.Key))
				str &= GetAttuDelcare(ctrls.Key)
			Next
			comp = comp.Replace("[CODE]", str)

			str = ""
			WriteDelcares(str)

			comp = comp.Replace("[DECLARES]", str)
			comp = comp.Replace("[USERCODE]", _m.UserCode)
			Return comp
		End Function

		Sub WriteNames(ByRef s As String)
			s &= String.Format("{0}        ' Create Instances{0}{0}", vbCrLf)
			For Each ctrls In _m.DictControlSizer
				s &= "        "
				Dim str = "Me.{0} = New {1}(){2}"
				Dim name = _m.DictControlName(ctrls.Key)
				Dim cls = ctrls.Key.GetType.FullName
				str = String.Format(str, name, cls, vbCrLf)
				s &= str
			Next
			s &= vbCrLf
		End Sub


		Sub WriteDelcares(ByRef s As String)
			For Each ctrls In _m.DictControlSizer
				s &= "    "
				Dim str = "WithEvents Friend {0} As {1}{2}"
				Dim name = _m.DictControlName(ctrls.Key)
				Dim cls = ctrls.Key.GetType.FullName
				str = String.Format(str, name, cls, vbCrLf)
				s &= str
			Next
			s &= vbCrLf
		End Sub

		Function GetAttuDelcare(c As Control, Optional f As Boolean = False) As String
			Dim prop = GetType(Control).GetProperties
			Dim s = ""

			For Each p In prop
				Dim val = p.GetValue(c, Nothing)

				If Not ((val Is Nothing And GetDefault(p) Is Nothing) OrElse
							(val.Equals(GetDefault(p))) OrElse
							(Not p.CanWrite)) Then
					Dim thisType = p.PropertyType
					Dim dec = String.Format("        Me.{0}.{1} = ", _m.DictControlName(c), p.Name)
					If f Then dec = String.Format("        Me.{0} = ", p.Name)
					Select Case thisType.Name
						Case "String"
							dec &=
									"""" & CStr(val) & """" & vbCrLf

						Case "Integer", "Double", "Short", "UInteger", "UDouble", "UShort", "Int16", "Int32", "Int64",
									"UInt16", "UInt32", "UInt64", "Boolean"
							dec &=
									val.ToString & vbCrLf

						Case "Point"
							dec &=
									"New System.Drawing.Point(" & CType(val, Point).X & ", " &
										CType(val, Point).Y & ")" & vbCrLf

						Case "Size"
							dec &=
									"New System.Drawing.Size(" & CType(val, Size).Width & ", " &
										CType(val, Size).Height & ")" & vbCrLf

						Case "Color"
							Dim a, r, g, b As Integer
							a = CType(val, Color).A
							r = CType(val, Color).R
							g = CType(val, Color).G
							b = CType(val, Color).B
							dec &=
									"Color.FromArgb(" & a & ", " & r & ", " & g & ", " & b & ")" & vbCrLf


						Case Else
							dec = ""
							' Does Nothing

					End Select
					s &= dec
				End If
			Next

			If Not f Then
				s &= String.Format("        Me.Controls.Add({0}){1}", _m.DictControlName(c), vbCrLf)
			End If

			Return s
		End Function


		Private Function GetDefault(prop As Reflection.PropertyInfo)
			Try
				Dim c As New Control()
				Return prop.GetValue(c, Nothing)
			Catch x As Exception
				MsgBox(x.Message & x.Source & x.StackTrace)
				End
			End Try
		End Function
	End Class
End Namespace
