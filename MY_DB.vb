Imports MySql.Data.MySqlClient

Public Class MY_DB
    Private connection As New MySqlConnection("server=localhost;user id=root;password=mysql_admin081105;database=quizgame_db")

    Public Function getConnection() As MySqlConnection
        Return connection
    End Function

    Public Sub openConnection()
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    Public Sub closeConnection()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    ' Method to execute parameterized queries (INSERT, UPDATE, DELETE)
    Public Sub ExecuteQuery(query As String, parameters As Dictionary(Of String, Object))
        Try
            ' Open the connection
            openConnection()

            ' Create the command
            Using command As New MySqlCommand(query, connection)
                ' Add the parameters to the query
                For Each param In parameters
                    command.Parameters.AddWithValue(param.Key, param.Value)
                Next

                ' Execute the query
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("Database error: " & ex.Message)
        Finally
            ' Close the connection
            closeConnection()
        End Try
    End Sub
End Class
