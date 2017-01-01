Module AddControlHelper
    Public Names As String() = {
        "Button",
        "CheckBox",
        "TextBox",
        "ComboBox",
        "ListBox,",
        "Label",
        "GroupBox",
        "ToolBar",
        "Menu"
        }

    Private ctrls As Type() = {
        GetType(Button),
        GetType(CheckBox),
        GetType(TextBox),
        GetType(ComboBox),
        GetType(ListBox),
        GetType(Label),
        GetType(GroupBox),
        GetType(ToolBar),
        GetType(ToolStripDropDownMenu)
    }

    ''' <summary>
    ''' Create a contol of given type to the given container.
    ''' </summary>
    ''' <param name="str">The type string of the control to create. </param>
    ''' <param name="cont">The container which the control will create to. </param>
    ''' <returns>The created control. </returns>
    ''' <exception cref="System.NotSupportedException"/>
    Function CreatControlToContainer(str As String, cont As Control) As Control
        Dim ctrl As Control = CreateControl(str)

        ctrl.Text = str
        ctrl.Location = New Point(10, 10)
        cont.Controls.Add(ctrl)
        Return ctrl
    End Function

    ''' <summary>
    ''' Create a contol of given type.
    ''' </summary>
    ''' <param name="str">The type string of the control to create. </param>
    ''' <returns>The created control. </returns>
    ''' <exception cref="System.NotSupportedException"/>
    Function CreateControl(str As String) As Control
        Dim ctrl As Control, index As Integer
        index = FindIn(str, Names)
        Try
            '-------------------------- Danger Zone -------------------------------------
            ctrl = DirectCast(ctrls(index).GetConstructor({}).Invoke(Nothing), Control) '|
            '-------------- Are there anything better than this? ------------------------
        Catch ex As Exception
            Throw New NotSupportedException
        End Try

        Return ctrl
    End Function

    Private Function FindIn(str As String, arr As String()) As Integer
        For i As Integer = 0 To arr.Count - 1
            If arr(i) = str Then Return i
        Next
        Return -1
    End Function
End Module
