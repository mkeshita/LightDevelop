' TypeResolver.vb
' This file contains:
'
' Class Develop.Editing.TypeResolver
' |
' |== Class TypeResolver.SpaceMember
' |
' \== Enum TypeResolver.ElementKind

Imports System.Reflection

Namespace Editing
	''' <summary>
	''' Class to identify a name to a type.
	''' </summary>
	Public Class TypeResolver
		Public ImportedPrefix As String()
		Public LoadedAssembly As New List(Of Assembly)
		Public Namespaces As New Dictionary(Of String, List(Of SpaceMember))

		''' <summary>
		''' Loads an assembly to build database later.
		''' </summary>
		''' <param name="t">The assembly to load</param>
		Public Sub LoadAssembly(t As Type)
			LoadedAssembly.Add(Assembly.GetAssembly(t))
		End Sub

		''' <summary>
		''' Builds the database after loading assemblies.
		''' </summary>
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
		
		Private Sub ProcessAssembly(a As Assembly)
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

		''' <summary>
		''' Resolves a name to a namespace containing members.
		''' </summary>
		''' <param name="name">The name to resolve, like "IO" or "System.IO"</param>
		''' <returns>List of namespace members</returns>
		Public Function ResolveNamespace(name As String) As List(Of SpaceMember)
			Dim res As List(Of SpaceMember)
			res = tryGet(name)
			If res IsNot Nothing Then Return res

			For Each perfix As String In ImportedPrefix
				res = tryGet(perfix + "." + name)
				If res IsNot Nothing Then Return res
			Next

			Return Nothing
		End Function

		Private Function tryGet(name As String) As List(Of SpaceMember)
			If Not Namespaces.ContainsKey(name) Then Return Nothing

			Return Namespaces(name)
		End Function

		''' <summary>
		''' Resolves a name to a type.
		''' </summary>
		''' <param name="name">
		''' The name to resolve, like "System.String" or just "String"
		''' </param>
		''' <returns>The resolved type as a SpaceMember</returns>
		Public Function ResolveType(name As String) As SpaceMember
			Dim space, tname As String
			If name.Contains(".") Then
				space = Left(name, name.LastIndexOf("."))
				tname = Right(name, name.Length - name.LastIndexOf(".") - 1)
			Else
				space = "" : tname = name
			End If
			Dim r As List(Of SpaceMember)

			r = tryGet(space)
			If r IsNot Nothing Then
				Dim match = r.FirstOrDefault(Function(n) n.Name = tname)
				If match IsNot Nothing Then Return match
			End If

			For Each perfix As String In ImportedPrefix
				If space = "" Then
					r = tryGet(perfix)
				Else
					r = tryGet(perfix + space)
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
