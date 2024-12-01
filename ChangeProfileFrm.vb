Imports MySql.Data.MySqlClient
Imports System.IO

Public Class ChangeProfileFrm
    Private connectionString As String = "Server=localhost;Database=quizgame_db;Uid=root;Pwd=mysql_admin081105;"
    Private currentUsername As String = UserSession.Username
    Private imageBytes() As Byte
    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles ProfilePicture.Click

    End Sub

    Private Sub ChangeProfileFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UploadBtn_Click(sender As Object, e As EventArgs) Handles UploadBtn.Click
        Dim openFileDialog As New OpenFileDialog With {
           .Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
       }
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ProfilePicture.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Using connection As New MySqlConnection(connectionString)

            If ProfilePicture.Image Is Nothing Then
                MessageBox.Show("Please upload a picture first.", "No Image Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return ' Exit the function if no image is selected
            End If

            Try
                connection.Open()

                ' Update Profile Picture
                Dim imageData As Byte() = Nothing
                If ProfilePicture.Image IsNot Nothing Then
                    Dim ms As New MemoryStream()
                    ProfilePicture.Image.Save(ms, ProfilePicture.Image.RawFormat)
                    imageData = ms.ToArray()

                    Dim query As String = "UPDATE players_tb SET picture = @Picture WHERE Username = @Username"
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Picture", imageData)
                        command.Parameters.AddWithValue("@Username", currentUsername)
                        command.ExecuteNonQuery()
                    End Using
                End If

                ' Show success message
                MessageBox.Show("Profile successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Load the updated profile image and update MainInterface
                If Not String.IsNullOrEmpty(UserSession.Username) Then
                    Dim profileImage As Byte() = LoadUserProfileImage(UserSession.Username) ' Load updated image
                    If profileImage IsNot Nothing Then
                        Dim ms As New IO.MemoryStream(profileImage)
                        Dim newProfileImage As Image = Image.FromStream(ms)

                        ' Update MainInterface with the new profile image
                        Dim mainInterface As MainInterface = Application.OpenForms.OfType(Of MainInterface)().FirstOrDefault()
                        If mainInterface IsNot Nothing Then
                            mainInterface.UpdateProfilePicture(newProfileImage)
                        End If
                    End If
                End If

                ' Clear the picture box after the update
                ProfilePicture.Image = Nothing

                ' Navigate back to SettingsFrm
                Me.Hide()
                SettingsFrm.TopLevel = False
                SettingsInterface.Guna2Panel1.Controls.Add(SettingsFrm)
                SettingsFrm.Show()
                SettingsFrm.BringToFront()

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub



    Private Function LoadUserProfileImage(username As String) As Byte()
        Dim imageBytes As Byte() = Nothing
        Dim query As String = "SELECT picture FROM players_tb WHERE Username = @Username"

        Using sqlConn As New MySqlConnection(connectionString)
            Using sqlCmd As New MySqlCommand(query, sqlConn)
                sqlCmd.Parameters.AddWithValue("@Username", username)
                sqlConn.Open()
                Using reader As MySqlDataReader = sqlCmd.ExecuteReader()
                    If reader.Read() AndAlso Not IsDBNull(reader("picture")) Then
                        imageBytes = CType(reader("picture"), Byte()) ' Get the profile picture as byte array

                    End If
                End Using

                sqlConn.Close()

            End Using
        End Using

        Return imageBytes
    End Function

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        SettingsFrm.TopLevel = False
        SettingsInterface.Guna2Panel1.Controls.Add(SettingsFrm)
        SettingsFrm.Show()
        SettingsFrm.BringToFront()
    End Sub
End Class