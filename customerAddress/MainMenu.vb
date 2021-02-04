Imports System.Data.SqlClient

Public Class MainMenu

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

#Region "Variables And Objects"

    Dim connection As New Connection
    Dim dbName As String = "customerInfo"
    Dim getID As Integer
    Dim selectString As String = "SELECT * FROM customerInfo ORDER BY id"
    Dim refreshCommand As New SqlCommand(selectString, Connection.connection)
    Dim adapter As SqlDataAdapter = New SqlDataAdapter(refreshCommand)
    Dim totalID As Integer

#End Region

#Region "UI Buttons"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Minimized
        End If
    End Sub
#End Region

    Private Sub insertRecord(ByVal dbName)
        Try
            generateID()

            Connection.command.CommandText = "INSERT INTO " & dbName & " " & "(id, customerName, customerSurname, customerGender, customerYearOfBirth,
                                    customerStreetAddress, customerNeighbourhoodName, customerBuildingNumber, customerFlatNumber,
                                    customerPostalCode, customerTown, customerProvince, customerCreationDate) 
                                    VALUES('" & totalID + 1 & "', '" & txtCName.Text & "', '" & txtCSurname.Text & "', '" & cbCGender.Text & "',
                                           '" & txtCBirth.Text & "', '" & txtCStreet.Text & "', '" & txtCNeighbourhood.Text & "',
                                           '" & txtCBuilding.Text & "', '" & txtCFlat.Text & "', '" & txtCPostal.Text & "',
                                           '" & txtCTown.Text & "', '" & txtCProvince.Text & "', '" & dpCreation.Text & "')"

            Connection.command.ExecuteNonQuery()

            emptyGrid()
            refreshGrid()

            MessageBox.Show("Record has been created successfully", "Info")
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table." & Environment.NewLine & ex.Message, "Insert Records")
        Finally
            Connection.disconnect()
        End Try
    End Sub

    Private Sub updateRecord(ByVal dbName)

        getID = CustomerInfoDataGridView.Item(0, CustomerInfoDataGridView.CurrentCell.RowIndex).Value

        Try
            Connection.command.CommandText = "UPDATE " & dbName & " SET 
                                   customerName = '" & txtCName.Text & "', 
                                   customerSurname = '" & txtCSurname.Text & "',
                                   customerGender = '" & cbCGender.Text & "',
                                   customerYearOfBirth = '" & txtCBirth.Text & "',
                                   customerStreetAddress = '" & txtCStreet.Text & "',
                                   customerNeighbourhoodName = '" & txtCNeighbourhood.Text & "',
                                   customerBuildingNumber = '" & txtCBuilding.Text & "',
                                   customerFlatNumber = '" & txtCFlat.Text & "',
                                   customerPostalCode = '" & txtCPostal.Text & "',
                                   customerTown = '" & txtCTown.Text & "',
                                   customerProvince = '" & txtCProvince.Text & "', 
                                   customerUpdateDate = '" & DateTime.Today.ToString("yyyy/MM/dd") & "'
                                   WHERE id = '" & getID & "'"

            Connection.command.ExecuteNonQuery()

            emptyGrid()
            refreshGrid()

            MessageBox.Show("Record has been updated successfully", "Info")
        Catch ex As Exception
            MessageBox.Show("Error while updating record on table." & Environment.NewLine & ex.Message, "Update Records")
        Finally
            Connection.disconnect()
        End Try
    End Sub

    Private Sub deleteRecord(ByVal dbName)

        getID = CustomerInfoDataGridView.Item(0, CustomerInfoDataGridView.CurrentCell.RowIndex).Value

        Try
            Connection.command.CommandText = "DELETE FROM " & dbName & " WHERE id = '" & getID & "'"

            Connection.command.ExecuteNonQuery()

            emptyGrid()
            refreshGrid()

            MessageBox.Show("Record has been deleted successfully", "Info")
        Catch ex As Exception
            MessageBox.Show("Error while deleting record on table." & Environment.NewLine & ex.Message, "Delete Records")
        Finally
            Connection.disconnect()
        End Try
    End Sub

    Public Sub searchRecord(ByVal searchCriteria As String)

        Connection.connect()

        Try

            Dim searchString As String = "SELECT * FROM " & dbName & " WHERE '" & "customerName" & "' = '" & searchCriteria & "'"
            Dim searchCommand As New SqlCommand(searchString, Connection.connection)

            Using searchCommand
                Using adapter As New SqlDataAdapter

                    Dim refreshTable As New DataTable
                    adapter.SelectCommand = searchCommand
                    adapter.Fill(refreshTable)
                    CustomerInfoDataGridView.DataSource = refreshTable
                    Dim affectedRows As Integer = refreshTable.Rows.Count

                    If affectedRows > 0 Then
                        MessageBox.Show(affectedRows & " records has been found.", "Search Records")
                    Else
                        MessageBox.Show("No record has been found", "Search Records")
                    End If

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error while searching record on table." & Environment.NewLine & ex.Message, "Search Records")
        Finally
            Connection.disconnect()
        End Try

    End Sub

    Private Sub refreshGrid()
        Using refreshCommand
            Using adapter
                Dim refreshTable As New DataTable
                adapter.SelectCommand = refreshCommand
                adapter.Fill(refreshTable)
                CustomerInfoDataGridView.DataSource = refreshTable
            End Using
        End Using
    End Sub

    Private Sub emptyGrid()
        CustomerInfoDataGridView.DataSource = Nothing
        CustomerInfoDataGridView.Refresh()
    End Sub

    Private Sub generateID()

        Connection.command.CommandText = "SELECT MAX(id) FROM " & dbName & "" 'Silinen ID'lerin yerleri boş kaldığı için Sıra No kullanarak desteklenebilir.
        totalID = Connection.command.ExecuteScalar()

    End Sub

#Region "DB Buttons"

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Connection.connect()
        insertRecord(dbName)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Connection.connect()
        updateRecord(dbName)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Connection.connect()
        deleteRecord(dbName)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchForm As New SearchMenu
        searchForm.ShowDialog()
    End Sub

#End Region

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EducationDataSet.customerInfo' table. You can move, or remove it, as needed.
        CustomerInfoTableAdapter.Fill(EducationDataSet.customerInfo)
        dpCreation.Value = Now.ToString("yyyy/MM/dd")
        dpUpdate.Value = Now.ToString("yyyy/MM/dd")
    End Sub

End Class