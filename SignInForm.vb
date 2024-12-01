Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class SignInForm
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


    Private Sub SIUser_TextChanged(sender As Object, e As EventArgs) Handles SIUser.TextChanged

    End Sub

    Private Sub SIBtn_Click(sender As Object, e As EventArgs) Handles SIBtn.Click
        Dim db As New MY_DB()
        db.openConnection()

        ' SQL query to check if the username and password match in players_tb
        Dim query As String = "SELECT player_id, Username, Password, Picture FROM `players_tb` WHERE `Username` = @username AND `Password` = @pass"
        Dim command As New MySqlCommand(query, db.getConnection)

        ' Add parameters to the query
        command.Parameters.AddWithValue("@username", SIUser.Text)
        command.Parameters.AddWithValue("@pass", SIPW.Text)

        ' Execute the query and check for matching rows
        Dim reader As MySqlDataReader = command.ExecuteReader()

        Dim username As String = ""
        Dim playerId As Integer = 0
        Dim score As Object = Nothing
        Dim profileImageBytes As Byte() = Nothing

        If reader.HasRows Then
            ' Login success
            reader.Read()

            ' Retrieve the player_id, username, and profile picture from players_tb
            playerId = Convert.ToInt32(reader("player_id"))
            username = reader("Username").ToString()

            ' Check if the profile picture column is not null
            If Not IsDBNull(reader("Picture")) Then
                profileImageBytes = CType(reader("Picture"), Byte())
            End If

            ' Close the reader before executing another command on the same connection
            reader.Close()

            ' Now, query the score from the scores_tb table using player_id
            Dim scoreQuery As String = "SELECT Score FROM `scores_tb` WHERE `player_id` = @playerId"
            Dim scoreCommand As New MySqlCommand(scoreQuery, db.getConnection)
            scoreCommand.Parameters.AddWithValue("@playerId", playerId)

            ' Execute the query to get the score
            Dim scoreReader As MySqlDataReader = scoreCommand.ExecuteReader()

            If scoreReader.HasRows Then
                scoreReader.Read()

                ' Retrieve the score
                score = If(IsDBNull(scoreReader("Score")), 0, scoreReader("Score"))
            Else
                ' If no score exists, initialize to 0 and insert it into scores_tb
                score = 0
                Dim initializeScoreQuery As String = "INSERT INTO scores_tb (player_id, Score) VALUES (@player_id, @Score)"
                Using initScoreCommand As New MySqlCommand(initializeScoreQuery, db.getConnection)
                    initScoreCommand.Parameters.AddWithValue("@player_id", playerId)
                    initScoreCommand.Parameters.AddWithValue("@Score", score)
                    initScoreCommand.ExecuteNonQuery()
                End Using
            End If

            ' Close the score reader
            scoreReader.Close()

            ' Clear the text boxes after login
            SIUser.Text = ""
            SIPW.Text = ""

            MessageBox.Show("Account Login Successful!", "Log in Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Open the MainInterface form and pass the username, score, and profile picture
            Dim mainInterface As New MainInterface()
            mainInterface.UserLabelText = username ' Set the username
            mainInterface.PointsLabelText = score.ToString() ' Set the score

            ' Load and set the profile picture
            If profileImageBytes IsNot Nothing Then
                mainInterface.ProfileImageBytes = profileImageBytes
                Using ms As New IO.MemoryStream(profileImageBytes)
                    mainInterface.UserProfileImage = Image.FromStream(ms)
                End Using
            Else
                mainInterface.ProfileImageBytes = Nothing ' Explicitly set it to nothing for clarity
            End If

            ' Set the logged-in username
            UserSession.Username = username

            mainInterface.Show()
            Me.Hide()
            SIUser.Text = ""
            SIPW.Text = ""
            Guna2CheckBox1.Checked = False

        Else
            ' Login failed
            MessageBox.Show("Account Login Failed: Check your account credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Clear the text boxes after failed login
            SIUser.Text = ""
            SIPW.Text = ""
            Guna2CheckBox1.Checked = False
            ' Close the reader if no rows were found
            reader.Close()
        End If

        ' Close the database connection
        db.closeConnection()
    End Sub


    Private Sub SignInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        SignUpForm.Show()
        Me.Hide()

        SIUser.Clear()
        SIPW.Clear()
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged
        If SIPW.PasswordChar = "*"c Then

            SIPW.PasswordChar = ""
        Else

            SIPW.PasswordChar = "*"c

        End If
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub
End Class