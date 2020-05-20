Imports System.Data.SqlClient

Module Module1

    Public StringConnection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Wintarefa.mdf;Integrated Security=True"

    Function ExecuteSQL(sql As String) As DataTable

        Try

            Dim connection As New SqlConnection
            Dim adapter As SqlDataAdapter
            Dim dt As New DataTable

            connection.ConnectionString = StringConnection
            connection.Open()

            adapter = New SqlDataAdapter(sql, connection)
            adapter.Fill(dt)

            connection.Close()
            connection = Nothing

            Return dt

        Catch ex As Exception
            ' An error occured!
        End Try

    End Function



End Module
