Imports MySql.Data.MySqlClient

Public Class ChangePassFrm

    Private connectionString As String = "Server=localhost;Database=quizgame_db;Uid=root;Pwd=mysql_admin081105;"

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click

        If String.IsNullOrEmpty(OldPassTxt.Text) OrElse String.IsNullOrEmpty(NewPassTxt.Text) Then
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        If Not VerifyPassword(OldPassTxt.Text) Then
            MessageBox.Show("The old password is incorrect. Please try again.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        If UpdatePassword(NewPassTxt.Text) Then
            MessageBox.Show("Password successfully changed. You will be logged out.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            OldPassTxt.Clear()
            NewPassTxt.Clear()
            Guna2CheckBox1.Checked = False
            Guna2CheckBox2.Checked = False
            Me.Hide()
            CloseMainInterface()
            SignInForm.Show()
        Else
            MessageBox.Show("An error occurred while updating the password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Function VerifyPassword(oldPassword As String) As Boolean
        Dim query As String = "SELECT Password FROM players_tb WHERE Username = @Username"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)

                Dim currentUsername As String = UserSession.Username
                command.Parameters.AddWithValue("@Username", currentUsername)
                connection.Open()
                Dim result = command.ExecuteScalar()
                If result IsNot Nothing AndAlso result.ToString() = oldPassword Then
                    Return True
                End If
            End Using
        End Using
        Return False
    End Function


    Private Function UpdatePassword(newPassword As String) As Boolean
        Dim query As String = "UPDATE players_tb SET Password = @NewPassword WHERE Username = @Username"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)

                Dim currentUsername As String = UserSession.Username
                command.Parameters.AddWithValue("@Username", currentUsername)
                command.Parameters.AddWithValue("@NewPassword", newPassword)
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                Return rowsAffected > 0
            End Using
        End Using
    End Function


    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged
        If OldPassTxt.PasswordChar = "*"c Then
            OldPassTxt.PasswordChar = ""
        Else
            OldPassTxt.PasswordChar = "*"c
        End If
    End Sub


    Private Sub Guna2CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox2.CheckedChanged
        If NewPassTxt.PasswordChar = "*"c Then
            NewPassTxt.PasswordChar = ""
        Else
            NewPassTxt.PasswordChar = "*"c
        End If
    End Sub

    Private Sub OldPassTxt_TextChanged(sender As Object, e As EventArgs) Handles OldPassTxt.TextChanged

    End Sub

    Private Sub NewPassTxt_TextChanged(sender As Object, e As EventArgs) Handles NewPassTxt.TextChanged

    End Sub

    Private Sub CloseMainInterface()

        Dim mainInterface As MainInterface = Application.OpenForms.OfType(Of MainInterface)().FirstOrDefault()

        If mainInterface IsNot Nothing Then

            mainInterface.Close()
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        SettingsFrm.TopLevel = False
        SettingsInterface.Guna2Panel1.Controls.Add(SettingsFrm)
        SettingsFrm.Show()
        SettingsFrm.BringToFront()

        OldPassTxt.Clear()
        NewPassTxt.Clear()
        Guna2CheckBox1.Checked = False
        Guna2CheckBox2.Checked = False
    End Sub

    Private Sub ChangePassFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
