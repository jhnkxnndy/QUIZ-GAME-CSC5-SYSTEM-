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

       
        Dim query As String = "SELECT player_id, Username, Password, Picture FROM `players_tb` WHERE `Username` = @username AND `Password` = @pass"
        Dim command As New MySqlCommand(query, db.getConnection)

       
        command.Parameters.AddWithValue("@username", SIUser.Text)
        command.Parameters.AddWithValue("@pass", SIPW.Text)

       
        Dim reader As MySqlDataReader = command.ExecuteReader()

        Dim username As String = ""
        Dim playerId As Integer = 0
        Dim score As Object = Nothing
        Dim profileImageBytes As Byte() = Nothing

        If reader.HasRows Then
            reader.Read()

            playerId = Convert.ToInt32(reader("player_id"))
            username = reader("Username").ToString()

            
            If Not IsDBNull(reader("Picture")) Then
                profileImageBytes = CType(reader("Picture"), Byte())
            End If
            reader.Close()

           
            Dim scoreQuery As String = "SELECT Score FROM `scores_tb` WHERE `player_id` = @playerId"
            Dim scoreCommand As New MySqlCommand(scoreQuery, db.getConnection)
            scoreCommand.Parameters.AddWithValue("@playerId", playerId)

            
            Dim scoreReader As MySqlDataReader = scoreCommand.ExecuteReader()

            If scoreReader.HasRows Then
                scoreReader.Read()

               
                score = If(IsDBNull(scoreReader("Score")), 0, scoreReader("Score"))
            Else
               
                score = 0
                Dim initializeScoreQuery As String = "INSERT INTO scores_tb (player_id, Score) VALUES (@player_id, @Score)"
                Using initScoreCommand As New MySqlCommand(initializeScoreQuery, db.getConnection)
                    initScoreCommand.Parameters.AddWithValue("@player_id", playerId)
                    initScoreCommand.Parameters.AddWithValue("@Score", score)
                    initScoreCommand.ExecuteNonQuery()
                End Using
            End If

            
            scoreReader.Close()

           
            SIUser.Text = ""
            SIPW.Text = ""

            MessageBox.Show("Account Login Successful!", "Log in Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

           
            Dim mainInterface As New MainInterface()
            mainInterface.UserLabelText = username 
            mainInterface.PointsLabelText = score.ToString()

            
            If profileImageBytes IsNot Nothing Then
                mainInterface.ProfileImageBytes = profileImageBytes
                Using ms As New IO.MemoryStream(profileImageBytes)
                    mainInterface.UserProfileImage = Image.FromStream(ms)
                End Using
            Else
                mainInterface.ProfileImageBytes = Nothing 
            End If

            
            UserSession.Username = username

            mainInterface.Show()
            Me.Hide()
            SIUser.Text = ""
            SIPW.Text = ""
            Guna2CheckBox1.Checked = False

        Else
           
            MessageBox.Show("Account Login Failed: Check your account credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

           
            SIUser.Text = ""
            SIPW.Text = ""
            Guna2CheckBox1.Checked = False
            
            reader.Close()
        End If

        
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
