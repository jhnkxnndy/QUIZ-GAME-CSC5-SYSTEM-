Imports System.Media
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class MainInterface

    Public mainInterfacePlayer As SoundPlayer
    Public Sub UpdateUsernameLabel(username As String)

        If Not String.IsNullOrEmpty(username) Then
            UserLabel.Text = username
        End If
    End Sub
    Public Property ProfileImageBytes As Byte()

    Public Sub SetProfilePicture()
        If ProfileImageBytes IsNot Nothing AndAlso ProfileImageBytes.Length > 0 Then
            Dim ms As New IO.MemoryStream(ProfileImageBytes)
            Try
                Dim img As Image = Image.FromStream(ms)
                UserProfile.Image = img
            Catch ex As Exception
                
                UserProfile.Image = Image.FromFile("C:\Users\johnk\Downloads\user.png")
            End Try
        Else
           
            UserProfile.Image = Image.FromFile("C:\Users\johnk\Downloads\user.png")
        End If
    End Sub

    Public Sub UpdateProfilePicture(image As Image)
        UserProfile.Image = image 
    End Sub
    Public Property UserLabelText As String
        Get
            Return UserLabel.Text
        End Get
        Set(value As String)
            UserLabel.Text = value
        End Set
    End Property
    Public Property UserProfileImage As Image
        Get
            Return UserProfile.Image
        End Get
        Set(value As Image)
            UserProfile.Image = value
        End Set
    End Property

    Public Property PointsLabelText As String
        Set(value As String)
            
            PointsLbl.Text = value
        End Set
        Get
            Return PointsLbl.Text
        End Get
    End Property


    Private Sub MainInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModeSelection.TopLevel = False
        MainPanel.Controls.Add(ModeSelection)
        ModeSelection.Show()
        ModeSelection.BringToFront()
        HomeBtn.FillColor = Color.FromArgb(252, 118, 62)
        Try
            mainInterfacePlayer = New SoundPlayer("C:\Users\johnk\Downloads\Game Show Theme Style Music. [ ezmp3.cc ].wav")
            mainInterfacePlayer.PlayLooping() 
        Catch ex As Exception
            MessageBox.Show("Error playing sound: " & ex.Message)
        End Try

        If UserProfile.Image Is Nothing Then
            If ProfileImageBytes IsNot Nothing Then
                Using ms As New IO.MemoryStream(ProfileImageBytes)
                    UserProfile.Image = Image.FromStream(ms)
                End Using
            Else
               
                UserProfile.Image = Image.FromFile("C:\Users\johnk\Downloads\user.png")
            End If
        End If
    End Sub
    Public Sub UpdatePointsLbl(score As Integer)
        PointsLbl.Text = score.ToString() 
    End Sub



    Private Sub MainPanel_Paint(sender As Object, e As PaintEventArgs) Handles MainPanel.Paint

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        LeaderboardsBtn.FillColor = Color.White
        HomeBtn.FillColor = Color.FromArgb(252, 118, 62)
        TutorialBtn.FillColor = Color.White
        SettingsBtn.FillColor = Color.White

        ModeSelection.TopLevel = False
        MainPanel.Controls.Add(ModeSelection)
        ModeSelection.Show()
        ModeSelection.BringToFront()
    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles LeaderboardsBtn.Click
        Dim leaderboards As New LeaderbordsFrm()
        leaderboards.LoadTopScores()

        LeaderboardsBtn.FillColor = Color.FromArgb(252, 118, 62)
        HomeBtn.FillColor = Color.White
        TutorialBtn.FillColor = Color.White
        SettingsBtn.FillColor = Color.White

        LeaderbordsFrm.TopLevel = False
        MainPanel.Controls.Add(LeaderbordsFrm)
        LeaderbordsFrm.Show()
        LeaderbordsFrm.BringToFront()


    End Sub

    Private Sub TutorialBtn_Click(sender As Object, e As EventArgs) Handles TutorialBtn.Click
        LeaderboardsBtn.FillColor = Color.White
        HomeBtn.FillColor = Color.White
        TutorialBtn.FillColor = Color.FromArgb(252, 118, 62)
        SettingsBtn.FillColor = Color.White

        TutorialInterface.TopLevel = False
        MainPanel.Controls.Add(TutorialInterface)
        TutorialInterface.Show()
        TutorialInterface.BringToFront()
    End Sub

    Private Sub SettingsBtn_Click(sender As Object, e As EventArgs) Handles SettingsBtn.Click
        LeaderboardsBtn.FillColor = Color.White
        HomeBtn.FillColor = Color.White
        TutorialBtn.FillColor = Color.White
        SettingsBtn.FillColor = Color.FromArgb(252, 118, 62)

        SettingsInterface.TopLevel = False
        MainPanel.Controls.Add(SettingsInterface)
        SettingsInterface.Show()
        SettingsInterface.BringToFront()
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
            UserLabel.Text = String.Empty
            PointsLbl.Text = String.Empty

            
            Dim signInPage As New SignInForm()
            signInPage.Show()

          
        End If
    End Sub

End Class
