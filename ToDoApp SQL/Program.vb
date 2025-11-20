Imports System.Data.SqlClient

Public Class TasksRepository
    Private connectionString As String = "Data Source=.;Initial Catalog=ToDoapp;Integrated Security=True;"

    Public Function GetAllTasks() As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim cmd As New SqlCommand("SELECT * FROM Tasks", con)
            dt.Load(cmd.ExecuteReader())
        End Using
        Return dt
    End Function

    Public Sub AddTask(title As String, desc As String)
        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim cmd As New SqlCommand("INSERT INTO Tasks (Title, Description)VALUES (@t, @d)", con)
            cmd.Parameters.AddWithValue("@t", title)
            cmd.Parameters.AddWithValue("@d", desc)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class