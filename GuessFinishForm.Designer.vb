<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuessFinishForm
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GuessFinishForm))
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        TotalScore = New Label()
        Label1 = New Label()
        Username = New Label()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        ProfilePicture = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(ProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
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
        Guna2AnimateWindow1.Interval = 250
        Guna2AnimateWindow1.TargetForm = Me
        ' 
        ' TotalScore
        ' 
        TotalScore.AutoSize = True
        TotalScore.BackColor = Color.Transparent
        TotalScore.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold)
        TotalScore.ForeColor = Color.White
        TotalScore.Location = New Point(500, 353)
        TotalScore.Name = "TotalScore"
        TotalScore.Size = New Size(83, 47)
        TotalScore.TabIndex = 11
        TotalScore.Text = "300"
        TotalScore.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(477, 306)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 47)
        Label1.TabIndex = 10
        Label1.Text = "Score:"
        ' 
        ' Username
        ' 
        Username.AutoSize = True
        Username.BackColor = Color.Transparent
        Username.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Username.ForeColor = Color.White
        Username.Location = New Point(455, 211)
        Username.Name = "Username"
        Username.Size = New Size(54, 45)
        Username.TabIndex = 9
        Username.Text = "10"
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BorderRadius = 7
        Guna2Button1.CustomizableEdges = CustomizableEdges3
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.FromArgb(CByte(252), CByte(118), CByte(62))
        Guna2Button1.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(278, 570)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button1.Size = New Size(516, 41)
        Guna2Button1.TabIndex = 8
        Guna2Button1.Text = "Back to Main Menu"
        ' 
        ' ProfilePicture
        ' 
        ProfilePicture.BackColor = Color.Transparent
        ProfilePicture.BorderRadius = 20
        ProfilePicture.CustomizableEdges = CustomizableEdges1
        ProfilePicture.ImageRotate = 0F
        ProfilePicture.Location = New Point(473, 77)
        ProfilePicture.Name = "ProfilePicture"
        ProfilePicture.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        ProfilePicture.Size = New Size(127, 124)
        ProfilePicture.SizeMode = PictureBoxSizeMode.Zoom
        ProfilePicture.TabIndex = 17
        ProfilePicture.TabStop = False
        ' 
        ' GuessFinishForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1072, 640)
        Controls.Add(ProfilePicture)
        Controls.Add(TotalScore)
        Controls.Add(Label1)
        Controls.Add(Username)
        Controls.Add(Guna2Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "GuessFinishForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GuessFinishForm"
        CType(ProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents TotalScore As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Username As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ProfilePicture As Guna.UI2.WinForms.Guna2PictureBox
End Class
