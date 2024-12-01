Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Media
Imports System.Numerics


Public Class FillFinishForm
    Private connectionString As String = "Server=localhost;Database=quizgame_db;Uid=root;Pwd=mysql_admin081105;"
    Private player As New SoundPlayer()

    Private Sub FillFinishForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Username.Text = UserSession.Username
        Dim profileImage As Byte() = LoadUserProfile(UserSession.Username)

        If profileImage IsNot Nothing AndAlso profileImage.Length > 0 Then
            Using ms As New IO.MemoryStream(profileImage)
                ProfilePicture.Image = Image.FromStream(ms)
            End Using
        Else
           
            ProfilePicture.Image = Image.FromFile("C:\Users\johnk\Downloads\user.png")
        End If

        player = New SoundPlayer("C:\Users\johnk\Downloads\Game Show Theme Style Music. [ ezmp3.cc ].wav")
        player.PlayLooping()
    End Sub

    Private Sub ResetPanelColors()
        
        For Each panelName As String In GlobalState.PanelColors.Keys.ToList()
            
            Dim panelControl As Control = Me.Controls.Find(panelName, True).FirstOrDefault()
            If panelControl IsNot Nothing Then
                panelControl.BackColor = Color.White 
            End If

           
            GlobalState.PanelColors(panelName) = Color.White
        Next
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        FillInterface.Close()
        UpdateScoreLabel(UserSession.Username)
        ResetPanelColors()

        For i As Integer = 1 To 10
            Dim questionForm As Form = Application.OpenForms.OfType(Of Form)().FirstOrDefault(Function(f) f.Name = "FillQuestion" & i.ToString())
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
                        imageBytes = CType(reader("picture"), Byte()) ' Get the profile picture as byte array

                    End If
                End Using

                sqlConn.Close()

            End Using
        End Using

        Return imageBytes
    End Function

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

End Class
