Imports System.Media
Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Public Class FinishForm
    Private connectionString As String = "Server=localhost;Database=quizgame_db;Uid=root;Pwd=mysql_admin081105;"
    Private db As New MY_DB()
    Private player As SoundPlayer
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        AnsClass.ResetAnswers()
        TotalScore.Text = "0"

        GuessInterface.Close()
        UpdateScoreLabel(UserSession.Username)
        ResetPanelColors()

        For i As Integer = 1 To 10
            Dim questionForm As Form = Application.OpenForms.OfType(Of Form)().FirstOrDefault(Function(f) f.Name = "MCQuestion" & i.ToString())
            If questionForm IsNot Nothing Then
                questionForm.Close()
            End If
        Next

        Me.Close()

        Dim mainInterface As MainInterface = Application.OpenForms.OfType(Of MainInterface)().FirstOrDefault()
        If mainInterface Is Nothing Then
            mainInterface = New MainInterface()
            mainInterface.Show()
        Else
            mainInterface.BringToFront()
        End If

        mainInterface.MainPanel.Controls.Clear()

        Dim modeSelection As New ModeSelection()
        modeSelection.TopLevel = False
        mainInterface.MainPanel.Controls.Add(modeSelection)
        modeSelection.Show()

       
        UpdateScoreLabel(UserSession.Username) 
        If Not String.IsNullOrEmpty(UserSession.Username) Then
            mainInterface.UpdateUsernameLabel(UserSession.Username) 
        End If

        If Not String.IsNullOrEmpty(UserSession.Username) Then
            mainInterface.UpdateUsernameLabel(UserSession.Username)
            Dim profileImage As Byte() = LoadUserProfile(UserSession.Username)
            If profileImage IsNot Nothing Then
                Dim ms As New IO.MemoryStream(profileImage)
                mainInterface.UpdateProfilePicture(Image.FromStream(ms))
            End If
        End If

        mainInterface.MainPanel.Refresh()
        mainInterface.Refresh()
        Me.Dispose()
    End Sub

    Private Function LoadUserProfile(username As String) As Byte()
        Dim imageBytes As Byte() = Nothing
        Dim query As String = "SELECT picture FROM players_tb WHERE Username = @Username"

        Using sqlConn As New MySqlConnection(connectionString)
            Using sqlCmd As New MySqlCommand(query, sqlConn)
                sqlCmd.Parameters.AddWithValue("@Username", username)
                sqlConn.Open()
                Using reader As MySqlDataReader = sqlCmd.ExecuteReader()
                    If reader.Read() AndAlso Not IsDBNull(reader("picture")) Then
                        imageBytes = CType(reader("picture"), Byte()) 

                    End If
                End Using

                sqlConn.Close()

            End Using
        End Using

        Return imageBytes
    End Function

    Private Sub ResetPanelColors()
        
        For Each panelName As String In GlobalState.PanelColors.Keys.ToList()
           
            Dim panelControl As Control = Me.Controls.Find(panelName, True).FirstOrDefault()
            If panelControl IsNot Nothing Then
                panelControl.BackColor = Color.White 
            End If

            
            GlobalState.PanelColors(panelName) = Color.White
        Next
    End Sub

    Public Sub UpdateScoreLabel(username As String)
        Dim db As New MY_DB()
        db.openConnection()

       
        Dim query As String = "SELECT s.score FROM scores_tb s " &
                          "INNER JOIN players_tb p ON s.player_id = p.player_id " &
                          "WHERE p.username = @username"
        Dim command As New MySqlCommand(query, db.getConnection)

        
        command.Parameters.AddWithValue("@username", username)

       
        Dim reader As MySqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            Dim score As Integer = If(IsDBNull(reader("score")), 0, Convert.ToInt32(reader("score")))

           
            Dim mainInterface As MainInterface = Application.OpenForms.OfType(Of MainInterface)().FirstOrDefault()

            If mainInterface IsNot Nothing Then
                mainInterface.UpdatePointsLbl(score)
            End If
        End If

       
        reader.Close()
        db.closeConnection()
    End Sub

    Private Sub FinishForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        player = New SoundPlayer("C:\Users\johnk\Downloads\Game Show Theme Style Music. [ ezmp3.cc ].wav")
        player.PlayLooping()

       
        CorrectAns.Text = AnsClass.CorrectAnswersCount().ToString()

        
        Username.Text = UserSession.Username

        
        TotalScore.Text = ScoreModule.CalculateTotalScore().ToString()

        Dim profileImage As Byte() = LoadUserProfile(UserSession.Username)

        If profileImage IsNot Nothing AndAlso profileImage.Length > 0 Then
            Using ms As New IO.MemoryStream(profileImage)
                ProfilePicture.Image = Image.FromStream(ms)
            End Using
        Else
           
            ProfilePicture.Image = Image.FromFile("C:\Users\johnk\Downloads\user.png")
        End If
    End Sub

    Private Function GetUserScore(username As String) As Integer
        Dim score As Integer = 0 
        Dim playerId As Integer = 0 

        
        Dim getPlayerIdQuery As String = "SELECT player_id FROM players_tb WHERE Username = @username"

        Using connection As New MySqlConnection("Server=localhost;Database=quizgame_db;Uid=root;Pwd=mysql_admin081105;")
            
            Dim playerIdCommand As New MySqlCommand(getPlayerIdQuery, connection)
            playerIdCommand.Parameters.AddWithValue("@username", username)

            Try
                connection.Open()
                Dim playerIdReader As MySqlDataReader = playerIdCommand.ExecuteReader()

                If playerIdReader.Read() Then
                   
                    playerId = Convert.ToInt32(playerIdReader("player_id"))
                End If

                playerIdReader.Close()

               
                If playerId > 0 Then
                    Dim getScoreQuery As String = "SELECT Score FROM scores_tb WHERE player_id = @player_id"
                    Dim scoreCommand As New MySqlCommand(getScoreQuery, connection)
                    scoreCommand.Parameters.AddWithValue("@player_id", playerId)

                    
                    Dim scoreReader As MySqlDataReader = scoreCommand.ExecuteReader()

                    If scoreReader.Read() Then
                       
                        score = If(IsDBNull(scoreReader("Score")), 0, Convert.ToInt32(scoreReader("Score")))
                    End If

                    scoreReader.Close()
                End If

            Catch ex As Exception
                MessageBox.Show("Error fetching score: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        Return score
    End Function


End Class
