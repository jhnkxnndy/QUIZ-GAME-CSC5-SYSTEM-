<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainInterface
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges27 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges28 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges23 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges24 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges25 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges26 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges21 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges22 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainInterface))
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        UserLabel = New Label()
        UserProfile = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Points = New Label()
        PointsLbl = New Label()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        SettingsBtn = New Guna.UI2.WinForms.Guna2CircleButton()
        HomeBtn = New Guna.UI2.WinForms.Guna2CircleButton()
        TutorialBtn = New Guna.UI2.WinForms.Guna2CircleButton()
        LeaderboardsBtn = New Guna.UI2.WinForms.Guna2CircleButton()
        MainPanel = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        LogoutBtn = New Guna.UI2.WinForms.Guna2CircleButton()
        Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        CType(UserProfile, ComponentModel.ISupportInitialize).BeginInit()
        Guna2Panel1.SuspendLayout()
        Guna2Panel2.SuspendLayout()
        Guna2Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.BorderRadius = 20
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.DragForm = False
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' Guna2AnimateWindow1
        ' 
        Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_SLIDE
        Guna2AnimateWindow1.TargetForm = Me
        ' 
        ' UserLabel
        ' 
        UserLabel.AutoSize = True
        UserLabel.BackColor = Color.Transparent
        UserLabel.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UserLabel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UserLabel.Location = New Point(97, 9)
        UserLabel.Name = "UserLabel"
        UserLabel.Size = New Size(133, 30)
        UserLabel.TabIndex = 7
        UserLabel.Text = "USERNAME"
        ' 
        ' UserProfile
        ' 
        UserProfile.BackColor = Color.Transparent
        UserProfile.FillColor = Color.Transparent
        UserProfile.Image = CType(resources.GetObject("UserProfile.Image"), Image)
        UserProfile.ImageRotate = 0F
        UserProfile.Location = New Point(16, 9)
        UserProfile.Name = "UserProfile"
        UserProfile.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        UserProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        UserProfile.Size = New Size(75, 72)
        UserProfile.SizeMode = PictureBoxSizeMode.Zoom
        UserProfile.TabIndex = 8
        UserProfile.TabStop = False
        ' 
        ' Points
        ' 
        Points.AutoSize = True
        Points.BackColor = Color.Transparent
        Points.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Points.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Points.Location = New Point(97, 39)
        Points.Name = "Points"
        Points.Size = New Size(85, 30)
        Points.TabIndex = 9
        Points.Text = "Points:"
        ' 
        ' PointsLbl
        ' 
        PointsLbl.AutoSize = True
        PointsLbl.BackColor = Color.Transparent
        PointsLbl.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PointsLbl.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        PointsLbl.Location = New Point(178, 39)
        PointsLbl.Name = "PointsLbl"
        PointsLbl.Size = New Size(26, 30)
        PointsLbl.TabIndex = 10
        PointsLbl.Text = "0"
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.Transparent
        Guna2Panel1.BackgroundImage = CType(resources.GetObject("Guna2Panel1.BackgroundImage"), Image)
        Guna2Panel1.BackgroundImageLayout = ImageLayout.Zoom
        Guna2Panel1.BorderColor = Color.Indigo
        Guna2Panel1.Controls.Add(SettingsBtn)
        Guna2Panel1.Controls.Add(HomeBtn)
        Guna2Panel1.Controls.Add(TutorialBtn)
        Guna2Panel1.Controls.Add(LeaderboardsBtn)
        Guna2Panel1.CustomizableEdges = CustomizableEdges27
        Guna2Panel1.FillColor = Color.Transparent
        Guna2Panel1.Location = New Point(12, 631)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges28
        Guna2Panel1.Size = New Size(1148, 145)
        Guna2Panel1.TabIndex = 11
        ' 
        ' SettingsBtn
        ' 
        SettingsBtn.BackColor = Color.Transparent
        SettingsBtn.BorderThickness = 1
        SettingsBtn.DisabledState.BorderColor = Color.DarkGray
        SettingsBtn.DisabledState.CustomBorderColor = Color.DarkGray
        SettingsBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        SettingsBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        SettingsBtn.FillColor = Color.White
        SettingsBtn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SettingsBtn.ForeColor = Color.Black
        SettingsBtn.Image = CType(resources.GetObject("SettingsBtn.Image"), Image)
        SettingsBtn.ImageSize = New Size(30, 30)
        SettingsBtn.Location = New Point(1029, 8)
        SettingsBtn.Name = "SettingsBtn"
        SettingsBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges23
        SettingsBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        SettingsBtn.Size = New Size(97, 99)
        SettingsBtn.TabIndex = 3
        ' 
        ' HomeBtn
        ' 
        HomeBtn.BackColor = Color.Transparent
        HomeBtn.BorderThickness = 1
        HomeBtn.DisabledState.BorderColor = Color.DarkGray
        HomeBtn.DisabledState.CustomBorderColor = Color.DarkGray
        HomeBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        HomeBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        HomeBtn.FillColor = Color.White
        HomeBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HomeBtn.ForeColor = Color.Black
        HomeBtn.Image = CType(resources.GetObject("HomeBtn.Image"), Image)
        HomeBtn.ImageSize = New Size(35, 35)
        HomeBtn.Location = New Point(27, 8)
        HomeBtn.Name = "HomeBtn"
        HomeBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges24
        HomeBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        HomeBtn.Size = New Size(106, 104)
        HomeBtn.TabIndex = 0
        ' 
        ' TutorialBtn
        ' 
        TutorialBtn.BackColor = Color.Transparent
        TutorialBtn.BorderThickness = 1
        TutorialBtn.DisabledState.BorderColor = Color.DarkGray
        TutorialBtn.DisabledState.CustomBorderColor = Color.DarkGray
        TutorialBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        TutorialBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        TutorialBtn.FillColor = Color.White
        TutorialBtn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TutorialBtn.ForeColor = Color.Black
        TutorialBtn.Image = CType(resources.GetObject("TutorialBtn.Image"), Image)
        TutorialBtn.ImageSize = New Size(40, 40)
        TutorialBtn.Location = New Point(686, 8)
        TutorialBtn.Name = "TutorialBtn"
        TutorialBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges25
        TutorialBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        TutorialBtn.Size = New Size(104, 99)
        TutorialBtn.TabIndex = 2
        ' 
        ' LeaderboardsBtn
        ' 
        LeaderboardsBtn.BackColor = Color.Transparent
        LeaderboardsBtn.BorderThickness = 1
        LeaderboardsBtn.DisabledState.BorderColor = Color.DarkGray
        LeaderboardsBtn.DisabledState.CustomBorderColor = Color.DarkGray
        LeaderboardsBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        LeaderboardsBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        LeaderboardsBtn.FillColor = Color.White
        LeaderboardsBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LeaderboardsBtn.ForeColor = Color.Black
        LeaderboardsBtn.Image = CType(resources.GetObject("LeaderboardsBtn.Image"), Image)
        LeaderboardsBtn.ImageSize = New Size(40, 40)
        LeaderboardsBtn.Location = New Point(333, 8)
        LeaderboardsBtn.Name = "LeaderboardsBtn"
        LeaderboardsBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges26
        LeaderboardsBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        LeaderboardsBtn.Size = New Size(104, 99)
        LeaderboardsBtn.TabIndex = 1
        ' 
        ' MainPanel
        ' 
        MainPanel.BackColor = Color.Transparent
        MainPanel.BorderColor = Color.Indigo
        MainPanel.BorderThickness = 2
        MainPanel.CustomizableEdges = CustomizableEdges21
        MainPanel.FillColor = Color.WhiteSmoke
        MainPanel.Location = New Point(12, 114)
        MainPanel.Name = "MainPanel"
        MainPanel.ShadowDecoration.CustomizableEdges = CustomizableEdges22
        MainPanel.Size = New Size(1148, 511)
        MainPanel.TabIndex = 12
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.BackColor = Color.Transparent
        Guna2Panel2.BorderColor = Color.Indigo
        Guna2Panel2.BorderRadius = 10
        Guna2Panel2.BorderThickness = 3
        Guna2Panel2.Controls.Add(UserLabel)
        Guna2Panel2.Controls.Add(PointsLbl)
        Guna2Panel2.Controls.Add(Points)
        Guna2Panel2.Controls.Add(UserProfile)
        Guna2Panel2.CustomizableEdges = CustomizableEdges19
        Guna2Panel2.FillColor = Color.White
        Guna2Panel2.Location = New Point(12, 12)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        Guna2Panel2.Size = New Size(314, 87)
        Guna2Panel2.TabIndex = 13
        ' 
        ' LogoutBtn
        ' 
        LogoutBtn.DisabledState.BorderColor = Color.DarkGray
        LogoutBtn.DisabledState.CustomBorderColor = Color.DarkGray
        LogoutBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        LogoutBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        LogoutBtn.FillColor = Color.Transparent
        LogoutBtn.Font = New Font("Segoe UI", 9F)
        LogoutBtn.ForeColor = Color.White
        LogoutBtn.Image = CType(resources.GetObject("LogoutBtn.Image"), Image)
        LogoutBtn.ImageSize = New Size(25, 25)
        LogoutBtn.Location = New Point(0, 0)
        LogoutBtn.Name = "LogoutBtn"
        LogoutBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges15
        LogoutBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        LogoutBtn.Size = New Size(66, 65)
        LogoutBtn.TabIndex = 0
        ' 
        ' Guna2Panel3
        ' 
        Guna2Panel3.BackColor = Color.Transparent
        Guna2Panel3.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2Panel3.BorderRadius = 10
        Guna2Panel3.BorderThickness = 2
        Guna2Panel3.Controls.Add(LogoutBtn)
        Guna2Panel3.CustomizableEdges = CustomizableEdges16
        Guna2Panel3.FillColor = Color.Red
        Guna2Panel3.Location = New Point(1084, 21)
        Guna2Panel3.Name = "Guna2Panel3"
        Guna2Panel3.ShadowDecoration.CustomizableEdges = CustomizableEdges17
        Guna2Panel3.Size = New Size(64, 60)
        Guna2Panel3.TabIndex = 14
        ' 
        ' MainInterface
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(132), CByte(53), CByte(222))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1172, 772)
        Controls.Add(Guna2Panel3)
        Controls.Add(Guna2Panel2)
        Controls.Add(MainPanel)
        Controls.Add(Guna2Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "MainInterface"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainInterface"
        CType(UserProfile, ComponentModel.ISupportInitialize).EndInit()
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel2.ResumeLayout(False)
        Guna2Panel2.PerformLayout()
        Guna2Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents UserLabel As Label
    Friend WithEvents PointsLbl As Label
    Friend WithEvents Points As Label
    Friend WithEvents UserProfile As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents HomeBtn As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents MainPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents SettingsBtn As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents TutorialBtn As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents LeaderboardsBtn As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LogoutBtn As Guna.UI2.WinForms.Guna2CircleButton
End Class
