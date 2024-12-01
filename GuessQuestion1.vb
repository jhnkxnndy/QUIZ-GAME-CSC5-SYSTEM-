﻿Imports System.Media
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class GuessQuestion1

    Private connectionString As String = "Server=localhost;Database=quizgame_db;Uid=root;Pwd=mysql_admin081105;"
    Private username As String 
    Private db As New MY_DB()

    Private letterBoxes() As Guna.UI2.WinForms.Guna2TextBox
    Private correctAnswer As String = "python" 
    Private transitionTimer As New Timer() 
    Private wrongFormTimer As New Timer() 
    Private Const TransitionTime As Integer = 2000 
    Private correctSound As New SoundPlayer("C:\Users\johnk\Downloads\Untitled video - Made with Clipchamp (1).wav")
    Private wrongSound As New SoundPlayer("C:\Users\johnk\Downloads\Untitled video - Made with Clipchamp (2).wav")
    Private bgSound As New SoundPlayer("C:\Users\johnk\Downloads\Game Show Countdown _ ROYALTY FREE Background Music [ ezmp3.cc ].wav")
    Private Sub GuessQuestion1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GuessInterface.QuestionLbl.Text = "1"

        
        letterBoxes = New Guna.UI2.WinForms.Guna2TextBox() {
            Guna2TextBox1, Guna2TextBox2, Guna2TextBox3,
            Guna2TextBox4, Guna2TextBox5, Guna2TextBox6
        }

        
        For Each tb In letterBoxes
            tb.MaxLength = 1
            tb.ReadOnly = False
            AddHandler tb.TextChanged, AddressOf Guna2TextBox_TextChanged 
            AddHandler tb.KeyDown, AddressOf Guna2TextBox_KeyDown 
        Next

        
        letterBoxes(0).Focus()

        
        AddHandler transitionTimer.Tick, AddressOf OnTransitionTimerTick

        
        AddHandler wrongFormTimer.Tick, AddressOf wrongFormTimer_Tick


    End Sub

    Private Sub Guna2TextBox_TextChanged(sender As Object, e As EventArgs)
        Dim currentTextBox As Guna.UI2.WinForms.Guna2TextBox = CType(sender, Guna.UI2.WinForms.Guna2TextBox)
        Dim index As Integer = Array.IndexOf(letterBoxes, currentTextBox)

        
        If currentTextBox.Text.Length = 1 And index < letterBoxes.Length - 1 Then
            letterBoxes(index + 1).Focus() 
        End If
    End Sub

    Private Sub Guna2TextBox_KeyDown(sender As Object, e As KeyEventArgs)
        Dim currentTextBox As Guna.UI2.WinForms.Guna2TextBox = CType(sender, Guna.UI2.WinForms.Guna2TextBox)
        Dim index As Integer = Array.IndexOf(letterBoxes, currentTextBox) 

        If e.KeyCode = Keys.Enter Then
            
            Dim userInput As String = String.Concat(letterBoxes.Select(Function(tb) tb.Text))

            If userInput.ToLower() = correctAnswer Then
                Dim pointsToAdd As Integer = 30
                UpdateUserScore(UserSession.Username, pointsToAdd) 

                
                UpdateScoreLabel(UserSession.Username)

                
                UpdatePanelColor("L1Panel", Color.Gray)

                
                correctSound.Play()
                Dim correctForm As New CorrectForm()
                correctForm.Show()

                Dim closeCorrectFormTimer As New Timer()
                closeCorrectFormTimer.Interval = 2000 
                AddHandler closeCorrectFormTimer.Tick, Sub()
                                                           correctForm.Close()
                                                           correctForm.Dispose()
                                                           closeCorrectFormTimer.Stop()
                                                           closeCorrectFormTimer.Dispose()
                                                       End Sub
                closeCorrectFormTimer.Start()

               
                transitionTimer.Start()
            Else
                
                ShowWrongForm()
                wrongSound.Play()
                bgSound.PlayLooping()
            End If

            e.Handled = True 
        ElseIf e.KeyCode = Keys.Back Then

            
            If currentTextBox.Text.Length = 1 Then
                currentTextBox.Clear()
                currentTextBox.ReadOnly = False

               
                If index > 0 Then
                    letterBoxes(index - 1).Focus()
                End If
            End If

            
            If currentTextBox.Text.Length = 0 And index > 0 Then
                letterBoxes(index - 1).Focus()
            End If

            e.Handled = True
        End If
    End Sub

    Private Sub OnTransitionTimerTick(sender As Object, e As EventArgs)
       
        transitionTimer.Stop()

        
        Dim delayTimer As New Timer()
        delayTimer.Interval = 2000 
        AddHandler delayTimer.Tick, Sub()
                                       
                                        delayTimer.Stop()

                                        
                                        Me.Hide()

                                        
                                        Dim guessScoresForm As New GuessScores()
                                        guessScoresForm.Show()
                                        UpdatePanelColor("L1Panel", Color.Gray)

                                        
                                        Dim closeTimer As New Timer()
                                        closeTimer.Interval = TransitionTime
                                        AddHandler closeTimer.Tick, Sub()
                                                                        closeTimer.Stop()
                                                                        guessScoresForm.Close()

                                                                        
                                                                        ShowNextQuestion()
                                                                    End Sub
                                        closeTimer.Start()
                                    End Sub
        delayTimer.Start()
    End Sub

    Private Sub ShowWrongForm()
        WrongForm.Show() 
        wrongFormTimer.Interval = 1000 
        wrongFormTimer.Start() 
    End Sub

    Private Sub wrongFormTimer_Tick(sender As Object, e As EventArgs)
        WrongForm.Close()
        wrongFormTimer.Stop() 

        
        For Each tb In letterBoxes
            tb.Clear()
            tb.ReadOnly = False 
        Next

       
        letterBoxes(0).Focus()
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
                GuessInterface.GScoreLabel.Text = score.ToString()
            End If
            scoreReader.Close()
        End If

        db.closeConnection()
    End Sub

    Private Sub UpdatePanelColor(panelName As String, newColor As Color)
        If PanelColors.ContainsKey(panelName) Then
            PanelColors(panelName) = newColor ' Update the global dictionary
           
            Select Case panelName
                Case "L1Panel"
                    GuessScores.L1Panel.FillColor = newColor
            End Select
        End If
    End Sub

   
    Private Sub ShowNextQuestion()
       
        Dim guessInterface As GuessInterface = Application.OpenForms.OfType(Of GuessInterface)().FirstOrDefault()
        If guessInterface IsNot Nothing Then
            guessInterface.Guna2Panel1.Controls.Clear()
            Dim guessQuestion2 As New GuessQuestion2() ' Replace with the actual next question form
            guessQuestion2.TopLevel = False
            guessInterface.Guna2Panel1.Controls.Add(guessQuestion2)
            guessQuestion2.Show()
        End If
    End Sub

End Class
