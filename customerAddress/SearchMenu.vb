Public Class SearchMenu

    Public txtBoxList As New List(Of TextBox) From {txtSId, txtSName, txtSSurname, txtSTown}

#Region "Draggable Form"
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub MainMenu_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub MainMenu_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub MainMenu_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub
#End Region

#Region "Buttons"
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim searchCriteria As String = checkTxtBox()
        MainMenu.searchRecord("Emir") 'Data gönderilecek
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
#End Region

    Private Sub SearchMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function checkTxtBox() As String

        Dim textBoxList As New List(Of TextBox) From {txtSId, txtSName, txtSSurname, txtSTown}

        For Each textBox As TextBox In textBoxList
            If textBox.Text <> Nothing Then
                Return textBox.Text
            End If
        Next
        Return ""
    End Function

End Class