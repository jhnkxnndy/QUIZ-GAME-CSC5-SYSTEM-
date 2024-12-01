Imports MySql.Data.MySqlClient

Public Class UsernameFrm
    Private connectionString As String = "Server=localhost;Database=quizgame_db;Uid=root;Pwd=mysql_admin081105;"

    Private Sub UsernameFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub

    Private Function VerifyPassword(username As String, password As String) As Boolean
        Dim query As String = "SELECT Password FROM players_tb WHERE Username = @Username"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                connection.Open()
                Dim result = command.ExecuteScalar()
                If result IsNot Nothing AndAlso result.ToString() = password Then
                    Return True
                End If
            End Using
        End Using
        Return False
    End Function

    Private Function IsUsernameAvailable(username As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM players_tb WHERE Username = @Username"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                connection.Open()
                Dim count = Convert.ToInt32(command.ExecuteScalar())
                Return count = 0 
            End Using
        End Using
    End Function

    Private Function UpdateUsername(currentUsername As String, newUsername As String) As Boolean
        Dim query As String = "UPDATE players_tb SET Username = @NewUsername WHERE Username = @CurrentUsername"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@NewUsername", newUsername)
                command.Parameters.AddWithValue("@CurrentUsername", currentUsername)
                connection.Open()
                Dim result = command.ExecuteNonQuery()
                Return result > 0 
            End Using
        End Using
    End Function

    Private Sub SaveBtn_Click_1(sender As Object, e As EventArgs) Handles SaveBtn.Click
      
        If String.IsNullOrEmpty(CurrentUsername.Text) OrElse String.IsNullOrEmpty(NewUsername.Text) OrElse String.IsNullOrEmpty(PasswordTextBox.Text) Then
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 
        End If

       
        If Not VerifyPassword(CurrentUsername.Text, PasswordTextBox.Text) Then
            MessageBox.Show("Incorrect password. Please try again.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 
        End If

        If Not IsUsernameAvailable(NewUsername.Text) Then
            MessageBox.Show("The new username is already taken. Please choose another one.", "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 
        End If

        
        If UpdateUsername(CurrentUsername.Text, NewUsername.Text) Then
            MessageBox.Show("Username successfully changed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            
            MainInterface.UpdateUsernameLabel(NewUsername.Text)

           
            CurrentUsername.Clear()
            NewUsername.Clear()
            PasswordTextBox.Clear()

            
            Hide()
            SettingsFrm.Show()
        Else
            MessageBox.Show("An error occurred while updating the username. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged

    End Sub
End Class
