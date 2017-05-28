Namespace Editing

	Public MustInherit Class EditingSupporter
		Public WithEvents TextBox As RichTextBox

		Sub New(box As RichTextBox)
			If box Is Nothing Then Throw New ArgumentNullException()
			TextBox = box
		End Sub
	End Class

End Namespace


