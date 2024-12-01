Imports MySql.Data.MySqlClient
Imports System.Media
Imports System.Numerics
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class GuessInterface

    Private connectionString As String = "Server=localhost;Database=quizgame_db;Uid=root;Pwd=mysql_admin081105;"
    Private username As String 
    Private db As New MY_DB()
    Private WithEvents flickerTimer As New Timer()
    Private WithEvents wrongFormTimer As New Timer()
    Private player As New SoundPlayer()
    Public Sub LoadUserScore()
        Dim username As String = UserSession.Username 

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                
                Dim query As String = "SELECT s.score FROM scores_tb s " &
                                  "INNER JOIN players_tb p ON s.player_id = p.player_id " &
                                  "WHERE p.username = @Username"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)

               
                Dim score As Object = command.ExecuteScalar()
                If score IsNot DBNull.Value AndAlso score IsNot Nothing Then
                    GScoreLabel.Text = score.ToString() 
                Else
                    GScoreLabel.Text = "0" 
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred while loading the score: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
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

    
    Public Sub SetUsername(user As String)
        username = user
    End Sub

    Private Sub GuessInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        flickerTimer.Interval = 500 
        flickerTimer.Start()
        Label1.Visible = True

        UpdateScoreLabel(username)
        LoadUserScore()

        
        GuessQuestion1.TopLevel = False
        Guna2Panel1.Controls.Add(GuessQuestion1)
        GuessQuestion1.Show()
        GuessQuestion1.BringToFront()

        player = New SoundPlayer("C:\Users\johnk\Downloads\Game Show Countdown _ ROYALTY FREE Background Music [ ezmp3.cc ].wav")
        player.PlayLooping()

    End Sub

    Private Sub flickerTimer_Tick(sender As Object, e As EventArgs) Handles flickerTimer.Tick
        
        Label1.Visible = Not Label1.Visible
    End Sub


    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to end your current game?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            UpdateScoreLabel(UserSession.Username)
            ResetPanelColors()

            For i As Integer = 1 To 10
                Dim questionForm As Form = Application.OpenForms.OfType(Of Form)().FirstOrDefault(Function(f) f.Name = "GuessQuestion" & i.ToString())
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
        
        For Each panelName As String In GlobalState.PanelColors.Keys.ToList()
            
            Dim panelControl As Control = Me.Controls.Find(panelName, True).FirstOrDefault()
            If panelControl IsNot Nothing Then
                panelControl.BackColor = Color.White 
            End If

           
            GlobalState.PanelColors(panelName) = Color.White
        Next
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
