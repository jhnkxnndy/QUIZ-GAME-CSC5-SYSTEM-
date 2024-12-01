Imports System.Media
Imports MySql.Data.MySqlClient

Public Class FillQuestion1
    Private connectionString As String = "Server=localhost;Database=quizgame_db;Uid=root;Pwd=mysql_admin081105;"
    Private username As String ' Store the username when the user logs in
    Private db As New MY_DB()
    Private correctAnswers As String() = {"if", ">"}
    Private transitionTimer As New Timer() ' Timer for transitioning to the next form
    Private Const TransitionTime As Integer = 2000 ' 2 seconds in milliseconds
    Private correctSound As New SoundPlayer("C:\Users\johnk\Downloads\Untitled video - Made with Clipchamp (1).wav")
    Private wrongSound As New SoundPlayer("C:\Users\johnk\Downloads\Untitled video - Made with Clipchamp (2).wav")
    Private bgSound As New SoundPlayer("C:\Users\johnk\Downloads\Game Show Countdown _ ROYALTY FREE Background Music [ ezmp3.cc ].wav")
    Private Sub FillQuestion1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize textboxes' max lengths
        Guna2TextBox1.MaxLength = 2
        Guna2TextBox2.MaxLength = 1

        ' Set up the transition timer
        AddHandler transitionTimer.Tick, AddressOf OnTransitionTimerTick
        FillInterface.QuestionLbl.Text = "1"
    End Sub

    Private Sub Guna2TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox1.KeyDown, Guna2TextBox2.KeyDown
        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            ValidateAnswers() ' Validate answers when Enter is pressed
            e.Handled = True ' Suppress default Enter behavior
        End If
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        ' If the user types in the first textbox, move focus to the second textbox
        If Guna2TextBox1.Text.Length = 2 Then ' When 2 characters are typed in
            Guna2TextBox2.Focus()
        End If
    End Sub

    Private Sub ValidateAnswers()
        Dim correct1 As Boolean = Guna2TextBox1.Text = correctAnswers(0) ' Check TextBox1 answer
        Dim correct2 As Boolean = Guna2TextBox2.Text = correctAnswers(1) ' Check TextBox2 answer

        ' Highlight answers with appropriate colors
        Guna2TextBox1.ForeColor = If(correct1, Color.Green, Color.Red)

        ' If TextBox2 is blank, make it red. Otherwise, check for correct answer.
        If String.IsNullOrEmpty(Guna2TextBox2.Text) Then
            Guna2TextBox2.ForeColor = Color.Red
        Else
            Guna2TextBox2.ForeColor = If(correct2, Color.Green, Color.Red)
        End If

        ' If all answers are correct
        If correct1 AndAlso correct2 Then
            ' Add points to the user
            Dim pointsToAdd As Integer = 50
            UpdateUserScore(UserSession.Username, pointsToAdd)

            ' Refresh score label
            UpdateScoreLabel(UserSession.Username)

            ' Change panel color to gray
            UpdatePanelColor("F1Panel", Color.Gray)
            correctSound.Play()
            ' Show the CorrectForm
            Dim correctForm As New CorrectForm()
            correctForm.Show()

            ' Close CorrectForm after 2 seconds and start transition to next question
            Dim correctFormTimer As New Timer()
            correctFormTimer.Interval = TransitionTime
            AddHandler correctFormTimer.Tick, Sub()
                                                  correctForm.Close()
                                                  correctForm.Dispose()
                                                  correctFormTimer.Stop()
                                                  correctFormTimer.Dispose()

                                                  ' Start transition timer to move to the next question after the correct form closes
                                                  transitionTimer.Start()
                                              End Sub
            correctFormTimer.Start()
        Else
            ' If any answer is wrong, show the wrong form
            ShowWrongForm()
            bgSound.PlayLooping()
        End If
    End Sub

    Private Sub ShowWrongForm()
        Dim wrongForm As New WrongForm()
        wrongForm.Show()

        ' Close WrongForm after 1 second
        Dim wrongFormTimer As New Timer()
        wrongFormTimer.Interval = 1000 ' 1 second
        AddHandler wrongFormTimer.Tick, Sub()
                                            wrongForm.Close()
                                            wrongForm.Dispose()
                                            wrongFormTimer.Stop()
                                            wrongFormTimer.Dispose()

                                            ' Clear the textboxes and reset for new attempt
                                            Guna2TextBox1.Clear()
                                            Guna2TextBox2.Clear()
                                            Guna2TextBox1.ForeColor = Color.Black
                                            Guna2TextBox2.ForeColor = Color.Black
                                            Guna2TextBox1.Focus() ' Focus on the first textbox
                                        End Sub
        wrongFormTimer.Start()
    End Sub

    ' Transition to next question after correct answer
    Private Sub OnTransitionTimerTick(sender As Object, e As EventArgs)
        ' Stop the transition timer
        transitionTimer.Stop()

        ' Show FillScores form
        Dim fillScoresForm As New FillScores()
        fillScoresForm.Show()

        ' Close FillScores after 2 seconds
        Dim fillScoresTimer As New Timer()
        fillScoresTimer.Interval = TransitionTime
        AddHandler fillScoresTimer.Tick, Sub()
                                             fillScoresForm.Close()
                                             fillScoresForm.Dispose()
                                             fillScoresTimer.Stop()
                                             fillScoresTimer.Dispose()

                                             ' Transition to FillQuestion2
                                             ShowNextQuestion()
                                         End Sub
        fillScoresTimer.Start()
    End Sub

    Private Sub ShowNextQuestion()
        ' Embed FillQuestion2 into the Guna2Panel1 of FillInterface
        Dim fillInterface As FillInterface = Application.OpenForms.OfType(Of FillInterface)().FirstOrDefault()
        If fillInterface IsNot Nothing Then
            fillInterface.Guna2Panel1.Controls.Clear()
            Dim fillQuestion2 As New FillQuestion2()
            fillQuestion2.TopLevel = False
            fillInterface.Guna2Panel1.Controls.Add(fillQuestion2)
            fillQuestion2.Show()
        End If
    End Sub

    ' Updates the score in the database
    Private Sub UpdateUserScore(username As String, scoreToAdd As Integer)
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()


                Dim playerId As Integer
                Dim getPlayerIdQuery As String = "SELECT player_id FROM players_tb WHERE username = @Username"
                Using getPlayerIdCommand As New MySqlCommand(getPlayerIdQuery, connection)
                    getPlayerIdCommand.Parameters.AddWithValue("@Username", username)
                    Dim result As Object = getPlayerIdCommand.ExecuteScalar()
                    If result IsNot Nothing Then
                        playerId = Convert.ToInt32(result)
                    Else
                        MessageBox.Show("Player not found.")
                        Return
                    End If
                End Using


                Dim updateScoreQuery As String = "UPDATE scores_tb SET score = COALESCE(score, 0) + @ScoreToAdd WHERE player_id = @PlayerID"
                Using updateScoreCommand As New MySqlCommand(updateScoreQuery, connection)
                    updateScoreCommand.Parameters.AddWithValue("@ScoreToAdd", scoreToAdd)
                    updateScoreCommand.Parameters.AddWithValue("@PlayerID", playerId)
                    updateScoreCommand.ExecuteNonQuery()
                End Using


                Dim updateLeaderboardQuery As String = "UPDATE leaderboard_tb SET score = COALESCE(score, 0) + @ScoreToAdd WHERE player_id = @PlayerID"
                Using updateLeaderboardCommand As New MySqlCommand(updateLeaderboardQuery, connection)
                    updateLeaderboardCommand.Parameters.AddWithValue("@ScoreToAdd", scoreToAdd)
                    updateLeaderboardCommand.Parameters.AddWithValue("@PlayerID", playerId)
                    updateLeaderboardCommand.ExecuteNonQuery()
                End Using


                Dim getUpdatedScoreQuery As String = "SELECT score FROM scores_tb WHERE player_id = @PlayerID"
                Using getUpdatedScoreCommand As New MySqlCommand(getUpdatedScoreQuery, connection)
                    getUpdatedScoreCommand.Parameters.AddWithValue("@PlayerID", playerId)
                    Dim updatedScore As Object = getUpdatedScoreCommand.ExecuteScalar()


                    If updatedScore IsNot Nothing Then
                        Dim mcInterface As MCInterface = Application.OpenForms.OfType(Of MCInterface)().FirstOrDefault()
                        If mcInterface IsNot Nothing Then
                            mcInterface.ScoreLabel.Text = updatedScore.ToString()
                        End If
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    ' Refreshes the score label in the interface
    Public Sub UpdateScoreLabel(username As String)
        Dim db As New MY_DB()
        db.openConnection()

        ' Step 1: Get the player_id from players_tb based on username
        Dim playerId As Integer = 0
        Dim getPlayerIdQuery As String = "SELECT player_id FROM players_tb WHERE Username = @username"
        Dim playerIdCommand As New MySqlCommand(getPlayerIdQuery, db.getConnection)
        playerIdCommand.Parameters.AddWithValue("@username", username)

        Dim playerIdReader As MySqlDataReader = playerIdCommand.ExecuteReader()
        If playerIdReader.Read() Then
            playerId = Convert.ToInt32(playerIdReader("player_id"))
        End If
        playerIdReader.Close()

        ' Step 2: Get the score from scores_tb using player_id
        If playerId > 0 Then
            Dim getScoreQuery As String = "SELECT Score FROM scores_tb WHERE player_id = @player_id"
            Dim scoreCommand As New MySqlCommand(getScoreQuery, db.getConnection)
            scoreCommand.Parameters.AddWithValue("@player_id", playerId)

            Dim scoreReader As MySqlDataReader = scoreCommand.ExecuteReader()
            If scoreReader.Read() Then
                ' If score is found, update the score label
                Dim score As Integer = If(IsDBNull(scoreReader("Score")), 0, Convert.ToInt32(scoreReader("Score")))
                FillInterface.FScoreLabel.Text = score.ToString()
            End If
            scoreReader.Close()
        End If

        db.closeConnection()
    End Sub


    ' Updates the color of a specific panel
    Private Sub UpdatePanelColor(panelName As String, newColor As Color)
        If PanelColors.ContainsKey(panelName) Then
            PanelColors(panelName) = newColor ' Update the global dictionary
            ' Apply the color to the actual panel
            Select Case panelName
                Case "F1Panel"
                    FillScores.F1Panel.FillColor = newColor
            End Select
        End If
    End Sub
End Class
