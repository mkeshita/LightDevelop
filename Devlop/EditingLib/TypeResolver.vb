Imports System.Reflection

Namespace Editing
	Public Class TypeResolver
		Public ImportedPrefix As String()
		Public LoadedAssembly As New List(Of Assembly)
		Public Namespaces As New Dictionary(Of String, List(Of SpaceMember))

		Public Sub LoadAssembly(t As Type)
			LoadedAssembly.Add(Assembly.GetAssembly(t))
		End Sub

		Public Sub BuildList()
			Namespaces.Clear()
			Dim d As New LoadingDialog()
			d.Show()

			Dim i As Integer = 1
			For Each a As Assembly In LoadedAssembly
				d.Prompt.Text = "Building Database... " & i & " / " & LoadedAssembly.Count
				d.Progress.Value = (i - 1) / LoadedAssembly.Count * 100

				ProcessAssembly(a)
			Next

			d.Close()
		End Sub

		Public Sub ProcessAssembly(a As Assembly)
			Dim types As Type() = a.GetTypes()
			For Each t As Type In types
				If Not t.IsPublic Then Continue For
				If t.Namespace Is Nothing Then Continue For

				If Not Namespaces.ContainsKey(t.Namespace) Then _
				Namespaces.Add(t.Namespace, New List(Of SpaceMember))

				Dim k As ElementKind = ElementKind.KindUnknown
				If t.IsClass Then k = ElementKind.KindClass
				If t.IsInterface Then k = ElementKind.KindInterface
				If t.IsEnum Then k = ElementKind.KindEnum

				Namespaces(t.Namespace).Add(New SpaceMember(k, t.Name, t))

				My.Application.DoEvents()
			Next
		End Sub

		Public Function ResolveNamespace(name As String) As List(Of SpaceMember)
			' for example:
			' name = "IO", perfix = "System",
			' resolved = "System.IO", returned = list of members

			Dim res As List(Of SpaceMember)
			res = TryGet(name)
			If res IsNot Nothing Then Return res

			For Each perfix As String In ImportedPrefix
				res = TryGet(perfix + "." + name)
				If res IsNot Nothing Then Return res
			Next

			Return Nothing
		End Function

		Private Function TryGet(name As String) As List(Of SpaceMember)
			If Not Namespaces.ContainsKey(name) Then Return Nothing

			Return Namespaces(name)
		End Function

		Public Function ResolveType(name As String) As SpaceMember
			' example:
			' name = "IO.File" or "System.IO.File" or "System.String" or "String"
			' split string at dot; last item is the type name; other is the namespace.
			Dim space, tname As String
			If name.Contains(".") Then
				space = Left(name, name.LastIndexOf("."))
				tname = Right(name, name.Length - name.LastIndexOf(".") - 1)
			Else
				space = "" : tname = name
			End If
			Dim r As List(Of SpaceMember)

			r = TryGet(space)
			If r IsNot Nothing Then
				Dim match = r.FirstOrDefault(Function(n) n.Name = tname)
				If match IsNot Nothing Then Return match
			End If

			For Each perfix As String In ImportedPrefix
				If space = "" Then
					r = TryGet(perfix)
				Else
					r = TryGet(perfix + space)
				End If
				If r Is Nothing Then Continue For

				Dim match = r.FirstOrDefault(Function(n) n.Name = tname)
				If match IsNot Nothing Then Return match
			Next

			Return Nothing
		End Function

		Public Class SpaceMember
			Public ReadOnly Kind As ElementKind
			Public ReadOnly Name As String
			Public ReadOnly Type As Type

			Public Sub New(k As ElementKind, n As String, Optional t As Type = Nothing)
				Kind = k
				Name = n
				Type = t
			End Sub
		End Class

		Public Enum ElementKind
			KindClass
			KindEnum
			KindInterface
			KindNamespace
			KindUnknown
		End Enum
	End Class

End Namespace
