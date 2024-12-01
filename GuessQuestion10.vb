Imports System.Media
Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class GuessQuestion10

    Private connectionString As String = "Server=localhost;Database=quizgame_db;Uid=root;Pwd=mysql_admin081105;"
    Private username As String ' Store the username when the user logs in
    Private db As New MY_DB()

    Private letterBoxes() As Guna.UI2.WinForms.Guna2TextBox
    Private correctAnswer As String = "scala" ' Set the correct answer for Question 10 (Scala)
    Private correctSound As New SoundPlayer("C:\Users\johnk\Downloads\Untitled video - Made with Clipchamp (1).wav")
    Private wrongSound As New SoundPlayer("C:\Users\johnk\Downloads\Untitled video - Made with Clipchamp (2).wav")
    Private bgSound As New SoundPlayer("C:\Users\johnk\Downloads\Game Show Countdown _ ROYALTY FREE Background Music [ ezmp3.cc ].wav")
    Private Sub GuessQuestion10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GuessInterface.QuestionLbl.Text = "10"

        ' Initialize the Guna2TextBox array
        letterBoxes = New Guna.UI2.WinForms.Guna2TextBox() {
            Guna2TextBox1, Guna2TextBox2, Guna2TextBox3, Guna2TextBox4, Guna2TextBox5
        }

        ' Set MaxLength to 1 for each Guna2TextBox
        For Each tb In letterBoxes
            tb.MaxLength = 1
            tb.ReadOnly = False ' Ensure textboxes are editable initially
            AddHandler tb.TextChanged, AddressOf Guna2TextBox_TextChanged ' Use TextChanged event handler
            AddHandler tb.KeyDown, AddressOf Guna2TextBox_KeyDown ' Keep the KeyDown event handler for backspace
        Next

        ' Set focus back to the first textbox when the form loads
        letterBoxes(0).Focus()
    End Sub

    Private Sub Guna2TextBox_TextChanged(sender As Object, e As EventArgs)
        Dim currentTextBox As Guna.UI2.WinForms.Guna2TextBox = CType(sender, Guna.UI2.WinForms.Guna2TextBox)
        Dim index As Integer = Array.IndexOf(letterBoxes, currentTextBox)

        ' If the user enters a letter and the textbox is filled (MaxLength is 1), move the focus to the next textbox
        If currentTextBox.Text.Length = 1 And index < letterBoxes.Length - 1 Then
            letterBoxes(index + 1).Focus() ' Move focus to the next textbox
        End If
    End Sub

    Private Sub Guna2TextBox_KeyDown(sender As Object, e As KeyEventArgs)
        Dim currentTextBox As Guna.UI2.WinForms.Guna2TextBox = CType(sender, Guna.UI2.WinForms.Guna2TextBox)
        Dim index As Integer = Array.IndexOf(letterBoxes, currentTextBox) ' Find the index of the current textbox

        If e.KeyCode = Keys.Enter Then
            ' Concatenate all textbox values to form the user's input
            Dim userInput As String = String.Concat(letterBoxes.Select(Function(tb) tb.Text))

            If userInput.ToLower() = correctAnswer Then
                Dim pointsToAdd As Integer = 30 ' Points to add for the correct answer
                UpdateUserScore(UserSession.Username, pointsToAdd) ' Update the user's score

                ' Refresh the score display after updating
                UpdateScoreLabel(UserSession.Username)
                UpdatePanelColor("L10Panel", Color.Gray)
                correctSound.Play()
                ' Show the CorrectForm for 2 seconds
                Dim correctForm As New CorrectForm()
                correctForm.Show()

                Dim correctFormTimer As New Timer()
                correctFormTimer.Interval = 2000 ' 2 seconds
                AddHandler correctFormTimer.Tick, Sub()
                                                      correctForm.Close()
                                                      correctForm.Dispose()
                                                      correctFormTimer.Stop()

                                                      ' Close the current question form
                                                      Me.Close()

                                                      ' Show the GuessScores form
                                                      ShowGuessScores()
                                                  End Sub
                correctFormTimer.Start()
            Else
                ' Show the WrongForm if the answer is incorrect
                ShowWrongForm()
                bgSound.PlayLooping()
            End If

            e.Handled = True ' Prevent further processing of the key press
        ElseIf e.KeyCode = Keys.Back Then
            ' Handle Backspace behavior
            If currentTextBox.Text.Length = 1 Then
                currentTextBox.Clear()
                currentTextBox.ReadOnly = False

                ' Move focus to the previous textbox if the current one is empty
                If index > 0 Then
                    letterBoxes(index - 1).Focus()
                End If
            End If

            ' If the textbox is empty, move the focus to the previous textbox
            If currentTextBox.Text.Length = 0 And index > 0 Then
                letterBoxes(index - 1).Focus()
            End If

            e.Handled = True
        End If
    End Sub

    Private Sub UpdatePanelColor(panelName As String, newColor As Color)
        If PanelColors.ContainsKey(panelName) Then
            PanelColors(panelName) = newColor ' Update the global dictionary
            ' Apply the color to the actual panel
            Select Case panelName
                Case "L10Panel"
                    GuessScores.L1Panel.FillColor = newColor
            End Select
        End If
    End Sub
    Private Sub ShowWrongForm()
        WrongForm.Show() ' Show the wrong form
        Dim wrongFormTimer As New Timer()
        wrongFormTimer.Interval = 1000 ' Set to 1 second
        AddHandler wrongFormTimer.Tick, Sub()
                                            WrongForm.Close()
                                            wrongFormTimer.Stop()
                                            ResetTextBoxes()
                                        End Sub
        wrongFormTimer.Start()
    End Sub

    Private Sub ResetTextBoxes()
        ' Reset the text in each Guna2TextBox to allow for new input
        For Each tb In letterBoxes
            tb.Clear()
            tb.ReadOnly = False ' Allow editing again
        Next

        ' Set focus back to the first textbox after clearing
        letterBoxes(0).Focus()
    End Sub

    Private Sub ShowGuessScores()
        Dim guessScoresForm As New GuessScores()
        guessScoresForm.Show()

        Dim guessScoresTimer As New Timer()
        guessScoresTimer.Interval = 2000 ' 2 seconds
        AddHandler guessScoresTimer.Tick, Sub()
                                              guessScoresForm.Close()
                                              guessScoresTimer.Stop()

                                              ' Close the GuessInterface form
                                              GuessInterface.Close()
                                              MainInterface.Close()

                                              ' Show the GuessFinishForm after closing GuessScores
                                              ShowGuessFinishForm()
                                          End Sub
        guessScoresTimer.Start()
    End Sub


    Private Sub ShowGuessFinishForm()
        Dim finishForm As New GuessFinishForm()
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
                GuessInterface.GScoreLabel.Text = score.ToString()
            End If
            scoreReader.Close()
        End If

        db.closeConnection()
    End Sub
End Class
