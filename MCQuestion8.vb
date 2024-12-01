Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Media
Imports TheArtOfDevHtmlRenderer.Core

Public Class MCQuestion8

    Private connectionString As String = "Server=localhost;Database=quizgame_db;Uid=root;Pwd=mysql_admin081105;"

    Private flickerCount As Integer = 0
    Private flickerTimer As New Timer() With {.Interval = 100}
    Private transitionTimer As New Timer() With {.Interval = 2000} 
    Private currentPhase As Integer = 0 
    Private buttonsClickable As Boolean = True 
    Private correctSound As New SoundPlayer("C:\Users\johnk\Downloads\Untitled video - Made with Clipchamp (1).wav")
    Private wrongSound As New SoundPlayer("C:\Users\johnk\Downloads\Untitled video - Made with Clipchamp (2).wav")
    Private Sub UpdatePanelColor(panelName As String, newColor As Color)
        If PanelColors.ContainsKey(panelName) Then
            PanelColors(panelName) = newColor 

            
            Select Case panelName
                Case "Q8Panel"
                    QuestionScores.Q8Panel.FillColor = newColor
            End Select
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        HandleWrongAnswer(Guna2Button1)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
       
        If Not buttonsClickable Then Return
        buttonsClickable = False

        
        CorrectAnswers.CorrectAnswersCount += 1
        AnsClass.AddCorrectAnswer(True)

        
        UpdateScore(UserSession.Username, 20)

        
        flickerCount = 0
        Guna2Button2.FillColor = Color.LightGreen
        UpdatePanelColor("Q8Panel", Color.LightGreen)
        QuestionScores.Q8Panel.FillColor = Color.LightGreen 
        flickerTimer.Start()
        correctSound.Play()
        
        Dim correctForm As New CorrectForm()
        correctForm.Show()
        transitionTimer.Start() 
    End Sub


    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        HandleWrongAnswer(Guna2Button3)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        HandleWrongAnswer(Guna2Button4)
    End Sub

    Private Sub HandleWrongAnswer(button As Guna.UI2.WinForms.Guna2Button)
        If Not buttonsClickable Then Return

        buttonsClickable = False

        flickerCount = 0
        button.FillColor = Color.Red
        UpdatePanelColor("Q8Panel", Color.FromArgb(255, 51, 52))
        QuestionScores.Q8Panel.FillColor = Color.FromArgb(255, 51, 52)
        flickerTimer.Start()
        wrongSound.Play()
        ShowWrongForm()
    End Sub

    Private Sub ShowWrongForm()
        Dim wrongForm As New WrongForm()
        wrongForm.Show()
        transitionTimer.Start()
    End Sub

    Private Sub UpdateScore(username As String, scoreToAdd As Integer)
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

    Private Sub FlickerEffect(sender As Object, e As EventArgs)
        If flickerCount < 20 Then
            flickerCount += 1
            Dim flickerColor As Color = If(flickerCount Mod 2 = 0, Color.Transparent, Color.LightGreen)
            Guna2Button2.FillColor = flickerColor
        Else
            flickerTimer.Stop()
            Guna2Button2.FillColor = Color.LightGreen
            QuestionScores.Q8Panel.FillColor = Color.LightGreen 
            currentPhase = 1
        End If
    End Sub

    Private Sub TransitionSequence(sender As Object, e As EventArgs)
        Select Case currentPhase
            Case 1
              
                Dim correctForm As CorrectForm = Application.OpenForms.OfType(Of CorrectForm)().FirstOrDefault()
                Dim wrongForm As WrongForm = Application.OpenForms.OfType(Of WrongForm)().FirstOrDefault()

                If wrongForm IsNot Nothing Then
                    wrongForm.Close()
                ElseIf correctForm IsNot Nothing Then
                    correctForm.Close()
                End If

              
                Dim questionScores As QuestionScores = Application.OpenForms.OfType(Of QuestionScores)().FirstOrDefault()
                If questionScores Is Nothing Then
                    questionScores = New QuestionScores()
                    questionScores.Q8Panel.FillColor = Color.Gray
                    questionScores.Show()
                Else
                    questionScores.Q8Panel.FillColor = Color.Gray 
                End If

                
                currentPhase = 2

            Case 2
                
                Dim questionScores As QuestionScores = Application.OpenForms.OfType(Of QuestionScores)().FirstOrDefault()
                If questionScores IsNot Nothing Then
                    questionScores.Close()
                End If

               
                Dim mcInterface As MCInterface = Application.OpenForms.OfType(Of MCInterface)().FirstOrDefault()
                If mcInterface IsNot Nothing Then
                    mcInterface.Guna2Panel1.Controls.Clear()
                    Dim mcQuestion9 As New MCQuestion9() 
                    mcQuestion9.TopLevel = False
                    mcInterface.Guna2Panel1.Controls.Add(mcQuestion9)
                    mcQuestion9.Show()
                End If

               
                buttonsClickable = True

               
                transitionTimer.Stop()
        End Select
    End Sub

   
    Private Sub MCQuestion8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler flickerTimer.Tick, AddressOf FlickerEffect
        AddHandler transitionTimer.Tick, AddressOf TransitionSequence
        MCInterface.QuestionLbl.Text = "8" 
    End Sub

End Class
