Imports MySql.Data.MySqlClient

Public Class SignUpForm
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlDR As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim dtA As New MySqlDataAdapter

    Dim server As String = "localhost"
    Dim username As String = "root"
    Dim password As String = "mysql_admin081105"
    Dim database As String = "quizgame_db"
    Dim sqlquery As String

    Dim placeholderImagePath As String = "C:\Users\johnk\Downloads\user.png"
    Dim selectedImagePath As String = ""


    Private imageBytes() As Byte
    Private bitmap As Bitmap
    Private WithEvents closeTimer As New Timer() ' Timer to handle form closure

    Private Sub SIBtn_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If String.IsNullOrWhiteSpace(UserTxt.Text) OrElse String.IsNullOrWhiteSpace(PWTxt.Text) Then
            MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If PWTxt.Text.Length < 8 Then
            MessageBox.Show("The password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Define the queries
        Dim insertPlayerQuery As String = "INSERT INTO players_tb (username, password, picture) VALUES (@Username, @Password, @Picture);"
        Dim insertScoreQuery As String = "INSERT INTO scores_tb (player_id, username, score) VALUES (@PlayerID, @Username, 0);"
        Dim insertLeaderboardQuery As String = "INSERT INTO leaderboard_tb (player_id, username, score) VALUES (@PlayerID, @Username, 0);"
        Dim lastInsertedIDQuery As String = "SELECT LAST_INSERT_ID();"

        Using sqlConn As New MySqlConnection("server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database)
            Try
                sqlConn.Open()

                ' Start a transaction
                Dim transaction = sqlConn.BeginTransaction()

                ' Insert into players_tb
                Using sqlCmd As New MySqlCommand(insertPlayerQuery, sqlConn, transaction)
                    sqlCmd.Parameters.AddWithValue("@Username", UserTxt.Text.Trim())
                    sqlCmd.Parameters.AddWithValue("@Password", PWTxt.Text)

                    ' Add image data or NULL
                    If imageBytes IsNot Nothing Then
                        sqlCmd.Parameters.Add("@Picture", MySqlDbType.LongBlob).Value = imageBytes
                    Else
                        sqlCmd.Parameters.Add("@Picture", MySqlDbType.LongBlob).Value = DBNull.Value
                    End If

                    sqlCmd.ExecuteNonQuery()
                End Using

                ' Get the last inserted player_id
                Dim playerID As Integer
                Using sqlCmd As New MySqlCommand(lastInsertedIDQuery, sqlConn, transaction)
                    playerID = Convert.ToInt32(sqlCmd.ExecuteScalar())
                End Using

                ' Insert into scores_tb
                Using sqlCmd As New MySqlCommand(insertScoreQuery, sqlConn, transaction)
                    sqlCmd.Parameters.AddWithValue("@PlayerID", playerID)
                    sqlCmd.Parameters.AddWithValue("@Username", UserTxt.Text.Trim())
                    sqlCmd.ExecuteNonQuery()
                End Using

                ' Insert into leaderboard_tb
                Using sqlCmd As New MySqlCommand(insertLeaderboardQuery, sqlConn, transaction)
                    sqlCmd.Parameters.AddWithValue("@PlayerID", playerID)
                    sqlCmd.Parameters.AddWithValue("@Username", UserTxt.Text.Trim())
                    sqlCmd.ExecuteNonQuery()
                End Using

                ' Commit the transaction
                transaction.Commit()

                ' Set session variables and UI updates
                UserSession.Username = UserTxt.Text.Trim()
                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Clear fields and navigate to the main interface
                UserTxt.Clear()
                PWTxt.Clear()
                Guna2CheckBox1.Checked = False

                Dim mainInterface As New MainInterface()
                mainInterface.UserLabelText = UserSession.Username
                mainInterface.PointsLabelText = "0"
                mainInterface.ProfileImageBytes = imageBytes
                mainInterface.Show()
                Me.Hide()
                mainInterface.SetProfilePicture()

            Catch ex As MySqlException
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub





    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        SignInForm.Show()
        Me.Hide()

        UserTxt.Clear()
        PWTxt.Clear()
        Guna2CheckBox1.Checked = False
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged
        If PWTxt.PasswordChar = "*"c Then
            PWTxt.PasswordChar = ""
        Else
            PWTxt.PasswordChar = "*"c
        End If
    End Sub

    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UploadBtn_Click(sender As Object, e As EventArgs) Handles UploadBtn.Click
        Using openFileDialog As New OpenFileDialog
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"
            openFileDialog.Title = "Select Profile Picture"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim imagePath As String = openFileDialog.FileName
                ImageFile.Text = imagePath ' Show file path in the textbox

                ' Convert the image to a byte array
                imageBytes = IO.File.ReadAllBytes(imagePath)
            End If
        End Using
    End Sub

    Private Sub ImageFile_TextChanged(sender As Object, e As EventArgs) Handles ImageFile.TextChanged

    End Sub
End Class