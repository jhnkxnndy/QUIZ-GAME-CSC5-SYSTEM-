Imports MySql.Data.MySqlClient

Public Class LeaderbordsFrm
    ' Replace with your actual connection string
    Private connectionString As String = "Server=localhost;Database=quizgame_db;Uid=root;Pwd=mysql_admin081105;"

    Private Sub LeaderbordsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTopScores() ' Load scores when the form is first opened

    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        LoadTopScores() ' Refresh scores when the button is clicked
    End Sub

    Public Sub LoadTopScores()
        Dim query As String = "SELECT p.username, l.player_id, l.score, p.picture FROM players_tb p " &
                       "INNER JOIN leaderboard_tb l ON p.player_id = l.player_id " &
                       "ORDER BY l.score DESC"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)
            connection.Open()

            Using reader As MySqlDataReader = command.ExecuteReader()
                Dim rank As Integer = 1

                ' Update leaderboard ranks and populate labels/images
                While reader.Read()
                    Dim username As String = reader("username").ToString()
                    Dim score As String = reader("score").ToString()
                    Dim playerId As Integer = CInt(reader("player_id"))
                    Dim imageBytes As Byte() = If(IsDBNull(reader("picture")), Nothing, CType(reader("picture"), Byte()))

                    ' Update rank in leaderboard_tb using a separate connection
                    Using updateConnection As New MySqlConnection(connectionString)
                        updateConnection.Open()
                        Dim updateRankQuery As String = "UPDATE leaderboard_tb SET `rank` = @rank WHERE player_id = @player_id"
                        Using updateCommand As New MySqlCommand(updateRankQuery, updateConnection)
                            updateCommand.Parameters.AddWithValue("@rank", rank)
                            updateCommand.Parameters.AddWithValue("@player_id", playerId)
                            updateCommand.ExecuteNonQuery()
                        End Using
                    End Using

                    ' Update UI based on rank
                    Select Case rank
                        Case 1
                            TopUserLbl.Text = username
                            TopScoreLbl.Text = score
                            LoadImageIntoPictureBox(Top1Image, imageBytes)
                        Case 2
                            SecondUserLbl.Text = username
                            SecondScoreLbl.Text = score
                            LoadImageIntoPictureBox(Top2Image, imageBytes)
                        Case 3
                            ThirdUserLbl.Text = username
                            ThirdScoreLbl.Text = score
                            LoadImageIntoPictureBox(Top3Image, imageBytes)
                        Case 4
                            FourthUserLbl.Text = username
                            FourthScoreLbl.Text = score
                            LoadImageIntoPictureBox(Top4Image, imageBytes)
                        Case 5
                            FifthUserLbl.Text = username
                            FifthScoreLbl.Text = score
                            LoadImageIntoPictureBox(Top5Image, imageBytes)
                        Case 6
                            SixthUserLbl.Text = username
                            SixthScoreLbl.Text = score
                            LoadImageIntoPictureBox(Top6Image, imageBytes)
                        Case 7
                            SeventhUserLbl.Text = username
                            SeventhScoreLbl.Text = score
                            LoadImageIntoPictureBox(Top7Image, imageBytes)
                        Case 8
                            EighthUserLbl.Text = username
                            EighthScoreLbl.Text = score
                            LoadImageIntoPictureBox(Top8Image, imageBytes)
                        Case 9
                            NinthUserLbl.Text = username
                            NinthScoreLbl.Text = score
                            LoadImageIntoPictureBox(Top9Image, imageBytes)
                        Case 10
                            TenthUserLbl.Text = username
                            TenthScoreLbl.Text = score
                            LoadImageIntoPictureBox(Top10Image, imageBytes)
                    End Select
                    rank += 1
                End While

                ' Handle remaining labels/images for ranks with no data
                For i As Integer = rank To 10
                    Select Case i
                        Case 2
                            SecondUserLbl.Text = "No players"
                            SecondScoreLbl.Text = "0"
                            Top2Image.Image = Nothing
                        Case 3
                            ThirdUserLbl.Text = "No players"
                            ThirdScoreLbl.Text = "0"
                            Top3Image.Image = Nothing
                        Case 4
                            FourthUserLbl.Text = "No players"
                            FourthScoreLbl.Text = "0"
                            Top4Image.Image = Nothing
                        Case 5
                            FifthUserLbl.Text = "No players"
                            FifthScoreLbl.Text = "0"
                            Top5Image.Image = Nothing
                        Case 6
                            SixthUserLbl.Text = "No players"
                            SixthScoreLbl.Text = "0"
                            Top6Image.Image = Nothing
                        Case 7
                            SeventhUserLbl.Text = "No players"
                            SeventhScoreLbl.Text = "0"
                            Top7Image.Image = Nothing
                        Case 8
                            EighthUserLbl.Text = "No players"
                            EighthScoreLbl.Text = "0"
                            Top8Image.Image = Nothing
                        Case 9
                            NinthUserLbl.Text = "No players"
                            NinthScoreLbl.Text = "0"
                            Top9Image.Image = Nothing
                        Case 10
                            TenthUserLbl.Text = "No players"
                            TenthScoreLbl.Text = "0"
                            Top10Image.Image = Nothing
                    End Select
                Next
            End Using

            connection.Close()
        End Using

    End Sub

    Private Sub LoadImageIntoPictureBox(pictureBox As PictureBox, imageBytes As Byte())
        If imageBytes IsNot Nothing Then
            Using ms As New IO.MemoryStream(imageBytes)
                pictureBox.Image = Image.FromStream(ms)
            End Using
        Else
            pictureBox.Image = Image.FromFile("C:\Users\johnk\Downloads\user.png")
        End If
    End Sub



    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Top1Image.Click

    End Sub

    Private Sub Guna2CirclePictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Top6Image_Click(sender As Object, e As EventArgs) Handles Top6Image.Click

    End Sub
End Class