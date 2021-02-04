Imports System.Data.SqlClient

Public Class Connection

    Public Shared Property connection As New SqlConnection
    Public Shared Property command As New SqlCommand

    Public Shared Sub connect()
        connection.ConnectionString = "Data Source=YAZILIM4\MEGA;Initial Catalog=Education;Integrated Security=True;Persist Security Info=True;User ID=sa"
        connection.Open()
        command.Connection = connection
    End Sub

    Public Shared Sub disconnect()
        connection.Close()
    End Sub


End Class
