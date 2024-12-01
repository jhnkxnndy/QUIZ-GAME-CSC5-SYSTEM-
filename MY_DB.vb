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

   
    Public Sub ExecuteQuery(query As String, parameters As Dictionary(Of String, Object))
        Try
            openConnection()

            Using command As New MySqlCommand(query, connection)
                
                For Each param In parameters
                    command.Parameters.AddWithValue(param.Key, param.Value)
                Next

                command.ExecuteNonQuery()
            End Using
        
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message)
        Finally
           
            closeConnection()
        End Try
    End Sub
End Class
