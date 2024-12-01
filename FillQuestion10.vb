Imports System.Media
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class FillQuestion10
    Private connectionString As String = "Server=localhost;Database=quizgame_db;Uid=root;Pwd=mysql_admin081105;"
    Private username As String 
    Private db As New MY_DB()
    Private correctAnswers As String() = {"[5]", "sizeof"} 
    Private transitionTimer As New Timer() 
    Private Const TransitionTime As Integer = 2000 
    Private correctSound As New SoundPlayer("C:\Users\johnk\Downloads\Untitled video - Made with Clipchamp (1).wav")
    Private wrongSound As New SoundPlayer("C:\Users\johnk\Downloads\Untitled video - Made with Clipchamp (2).wav")
    Private bgSound As New SoundPlayer("C:\Users\johnk\Downloads\Game Show Countdown _ ROYALTY FREE Background Music [ ezmp3.cc ].wav")
    Private Sub FillQuestion10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        Guna2TextBox1.MaxLength = 3
        Guna2TextBox2.MaxLength = 6 

        
        AddHandler transitionTimer.Tick, AddressOf OnTransitionTimerTick
        FillInterface.QuestionLbl.Text = "10"
    End Sub

    Private Sub Guna2TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox1.KeyDown, Guna2TextBox2.KeyDown
       
        If e.KeyCode = Keys.Enter Then
            ValidateAnswers() ' Validate answers when Enter is pressed
            e.Handled = True ' Suppress default Enter behavior
        End If
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        
        If Guna2TextBox1.Text.Length = 3 Then ' When 3 characters are typed in
            Guna2TextBox2.Focus()
        End If
    End Sub

    Private Sub ValidateAnswers()
        Dim correct1 As Boolean = Guna2TextBox1.Text = correctAnswers(0) ' Check TextBox1 answer
        Dim correct2 As Boolean = Guna2TextBox2.Text = correctAnswers(1) ' Check TextBox2 answer (correct answer "sizeof")

       
        Guna2TextBox1.ForeColor = If(correct1, Color.Green, Color.Red)
        Guna2TextBox2.ForeColor = If(correct2, Color.Green, Color.Red)

        
        If correct1 AndAlso correct2 Then
            
            Dim pointsToAdd As Integer = 50
            UpdateUserScore(UserSession.Username, pointsToAdd)

            
            UpdateScoreLabel(UserSession.Username)

           
            UpdatePanelColor("F10Panel", Color.Gray)
            correctSound.Play()
           
            Dim correctForm As New CorrectForm()
            correctForm.Show()

           
            Dim correctFormTimer As New Timer()
            correctFormTimer.Interval = TransitionTime
            AddHandler correctFormTimer.Tick, Sub()
                                                  correctForm.Close()
                                                  correctForm.Dispose()
                                                  correctFormTimer.Stop()
                                                  correctFormTimer.Dispose()

                                                  
                                                  transitionTimer.Start()
                                              End Sub
            correctFormTimer.Start()
        Else
           
            ShowWrongForm()
            bgSound.PlayLooping()
        End If
    End Sub

    Private Sub ShowWrongForm()
        Dim wrongForm As New WrongForm()
        wrongForm.Show()

       
        Dim wrongFormTimer As New Timer()
        wrongFormTimer.Interval = 1000 ' 1 second
        AddHandler wrongFormTimer.Tick, Sub()
                                            wrongForm.Close()
                                            wrongForm.Dispose()
                                            wrongFormTimer.Stop()
                                            wrongFormTimer.Dispose()

                                            
                                            Guna2TextBox1.Clear()
                                            Guna2TextBox2.Clear()
                                            Guna2TextBox1.ForeColor = Color.Black
                                            Guna2TextBox2.ForeColor = Color.Black
                                            Guna2TextBox1.Focus() ' Focus on the first textbox
                                        End Sub
        wrongFormTimer.Start()
    End Sub

   
    Private Sub OnTransitionTimerTick(sender As Object, e As EventArgs)
        
        transitionTimer.Stop()

        
        Dim fillScoresForm As New FillScores()
        fillScoresForm.Show()

        
        Dim fillScoresTimer As New Timer()
        fillScoresTimer.Interval = TransitionTime
        AddHandler fillScoresTimer.Tick, Sub()
                                             fillScoresForm.Close()
                                             fillScoresForm.Dispose()
                                             fillScoresTimer.Stop()
                                             fillScoresTimer.Dispose()

                                            
                                             ShowFinishForm()
                                         End Sub
        fillScoresTimer.Start()
    End Sub

    Private Sub ShowFinishForm()
        
        Me.Close()

        Dim fillInterface As FillInterface = Application.OpenForms.OfType(Of FillInterface)().FirstOrDefault()
        If fillInterface IsNot Nothing Then
            fillInterface.Close() ' Close FillInterface
        End If

       
        Dim finishForm As New FillFinishForm()
        finishForm.Show()
    End Sub

   
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

    
    Public Sub UpdateScoreLabel(username As String)
        Dim db As New MY_DB()
        db.openConnection()

        
        Dim playerId As Integer = 0
        Dim getPlayerIdQuery As String = "SELECT player_id FROM players_tb WHERE Username = @username"
        Dim playerIdCommand As New MySqlCommand(getPlayerIdQuery, db.getConnection)
        playerIdCommand.Parameters.AddWithValue("@username", username)

        Dim playerIdReader As MySqlDataReader = playerIdCommand.ExecuteReader()
        If playerIdReader.Read() Then
            playerId = Convert.ToInt32(playerIdReader("player_id"))
        End If
        playerIdReader.Close()

        
        If playerId > 0 Then
            Dim getScoreQuery As String = "SELECT Score FROM scores_tb WHERE player_id = @player_id"
            Dim scoreCommand As New MySqlCommand(getScoreQuery, db.getConnection)
            scoreCommand.Parameters.AddWithValue("@player_id", playerId)

            Dim scoreReader As MySqlDataReader = scoreCommand.ExecuteReader()
            If scoreReader.Read() Then
               
                Dim score As Integer = If(IsDBNull(scoreReader("Score")), 0, Convert.ToInt32(scoreReader("Score")))
                FillInterface.FScoreLabel.Text = score.ToString()
            End If
            scoreReader.Close()
        End If

        db.closeConnection()
    End Sub

   
    Private Sub UpdatePanelColor(panelName As String, newColor As Color)
        If PanelColors.ContainsKey(panelName) Then
            PanelColors(panelName) = newColor ' Update the global dictionary
            
            Select Case panelName
                Case "F10Panel"
                    FillScores.F10Panel.FillColor = newColor
            End Select
        End If
    End Sub
End Class
