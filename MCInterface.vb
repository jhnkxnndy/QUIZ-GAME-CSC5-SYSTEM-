Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports System.Media


Public Class MCInterface
    Private connectionString As String = "Server=localhost;Database=quizgame_db;Uid=root;Pwd=mysql_admin081105;"
    Private username As String ' Store the username when the user logs in
    Private db As New MY_DB()
    Dim player As SoundPlayer

    Private Sub MCInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username As String = UserSession.Username ' Get the logged-in username
        UpdateScoreLabel(username) ' Display the user's current score on load

        LoadUserScore()
        MCQuestion1.TopLevel = False
        Guna2Panel1.Controls.Add(MCQuestion1)
        MCQuestion1.Show()
        MCQuestion1.BringToFront()

        player = New SoundPlayer("C:\Users\johnk\Downloads\Game Show Countdown _ ROYALTY FREE Background Music [ ezmp3.cc ].wav")
        player.PlayLooping()

    End Sub
    Public Sub UpdateScoreLabel(username As String)
        Dim db As New MY_DB()
        db.openConnection()

        ' SQL query to get the user's score from scores_tb
        Dim query As String = "SELECT s.score FROM scores_tb s " &
                          "INNER JOIN players_tb p ON s.player_id = p.player_id " &
                          "WHERE p.username = @username"
        Dim command As New MySqlCommand(query, db.getConnection)

        ' Add parameters to the query
        command.Parameters.AddWithValue("@username", username)

        ' Execute the query and read the score
        Dim reader As MySqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            Dim score As Integer = If(IsDBNull(reader("score")), 0, Convert.ToInt32(reader("score")))

            ' Make sure to update the PointsLbl on MainInterface
            Dim mainInterface As MainInterface = Application.OpenForms.OfType(Of MainInterface)().FirstOrDefault()

            If mainInterface IsNot Nothing Then
                mainInterface.UpdatePointsLbl(score)
            End If
        End If

        ' Clean up
        reader.Close()
        db.closeConnection()
    End Sub

    ' Load the user's score based on their username
    Public Sub LoadUserScore()
        Dim username As String = UserSession.Username ' Get the logged-in username

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' SQL query to get the user's score from scores_tb
                Dim query As String = "SELECT s.score FROM scores_tb s " &
                                  "INNER JOIN players_tb p ON s.player_id = p.player_id " &
                                  "WHERE p.username = @Username"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)

                ' Execute the query and get the score
                Dim score As Object = command.ExecuteScalar()
                If score IsNot DBNull.Value AndAlso score IsNot Nothing Then
                    ScoreLabel.Text = score.ToString() ' Display score in ScoreLabel
                Else
                    ScoreLabel.Text = "0" ' Default to 0 if no score is found
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred while loading the score: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    ' This method can be called to update the username after login
    Public Sub SetUsername(user As String)
        username = user
    End Sub

    Private Sub ScoreLabel_Click(sender As Object, e As EventArgs) Handles ScoreLabel.Click

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to end your current game?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
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

            ' Update the score label and username on MainInterface
            UpdateScoreLabel(UserSession.Username) ' Update the score on MainInterface
            If Not String.IsNullOrEmpty(UserSession.Username) Then
                mainInterface.UpdateUsernameLabel(UserSession.Username) ' Make sure username is displayed
            End If

            If Not String.IsNullOrEmpty(UserSession.Username) Then
                mainInterface.UpdateUsernameLabel(UserSession.Username)
                Dim profileImage As Byte() = LoadUserProfileImage(UserSession.Username)
                If profileImage IsNot Nothing Then
                    Dim ms As New IO.MemoryStream(profileImage)
                    mainInterface.UpdateProfilePicture(Image.FromStream(ms))
                End If
            End If

            mainInterface.MainPanel.Refresh()
            mainInterface.Refresh()
            Me.Dispose()
        End If
    End Sub

    Private Function LoadUserProfileImage(username As String) As Byte()
        Dim imageBytes As Byte() = Nothing
        Dim query As String = "SELECT picture FROM players_tb WHERE Username = @Username"

        Using sqlConn As New MySqlConnection(connectionString)
            Using sqlCmd As New MySqlCommand(query, sqlConn)
                sqlCmd.Parameters.AddWithValue("@Username", username)
                sqlConn.Open()
                Using reader As MySqlDataReader = sqlCmd.ExecuteReader()
                    If reader.Read() AndAlso Not IsDBNull(reader("picture")) Then
                        imageBytes = CType(reader("picture"), Byte()) ' Get the profile picture as byte array

                    End If
                End Using

                sqlConn.Close()

            End Using
        End Using

        Return imageBytes
    End Function


    Private Sub ResetPanelColors()
        ' Loop through all panels and reset their colors to white
        For Each panelName As String In GlobalState.PanelColors.Keys.ToList()
            ' Assuming the panels are named Q1Panel, Q2Panel, etc.
            Dim panelControl As Control = Me.Controls.Find(panelName, True).FirstOrDefault()
            If panelControl IsNot Nothing Then
                panelControl.BackColor = Color.White ' Reset the panel color to white
            End If

            ' Optionally, reset the color in the dictionary to ensure consistency
            GlobalState.PanelColors(panelName) = Color.White
        Next
    End Sub

End Class
