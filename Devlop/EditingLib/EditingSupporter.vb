Namespace Editing
	Public MustInherit Class EditingSupporter
		Public WithEvents EditTextBox As RichTextBox

		Sub New(box As RichTextBox)
			If box Is Nothing Then Throw New ArgumentNullException()
			EditTextBox = box
		End Sub

	End Class
End Namespace


