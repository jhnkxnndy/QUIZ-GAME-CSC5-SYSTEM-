<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinishForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinishForm))
        Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        CorrectAns = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Username = New Label()
        Label1 = New Label()
        TotalScore = New Label()
        ProfilePicture = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(ProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2AnimateWindow1
        ' 
        Guna2AnimateWindow1.Interval = 250
        Guna2AnimateWindow1.TargetForm = Me
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.BorderRadius = 20
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
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
        Guna2Button1.Location = New Point(294, 573)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button1.Size = New Size(516, 41)
        Guna2Button1.TabIndex = 1
        Guna2Button1.Text = "Back to Main Menu"
        ' 
        ' CorrectAns
        ' 
        CorrectAns.AutoSize = True
        CorrectAns.BackColor = Color.Transparent
        CorrectAns.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CorrectAns.ForeColor = Color.White
        CorrectAns.Location = New Point(442, 25)
        CorrectAns.Name = "CorrectAns"
        CorrectAns.Size = New Size(28, 32)
        CorrectAns.TabIndex = 2
        CorrectAns.Text = "0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(477, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(26, 32)
        Label2.TabIndex = 3
        Label2.Text = "/"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(508, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 32)
        Label3.TabIndex = 4
        Label3.Text = "10"
        ' 
        ' Username
        ' 
        Username.AutoSize = True
        Username.BackColor = Color.Transparent
        Username.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Username.ForeColor = Color.White
        Username.Location = New Point(461, 211)
        Username.Name = "Username"
        Username.Size = New Size(54, 45)
        Username.TabIndex = 5
        Username.Text = "10"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(473, 300)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 47)
        Label1.TabIndex = 6
        Label1.Text = "Score:"
        ' 
        ' TotalScore
        ' 
        TotalScore.AutoSize = True
        TotalScore.BackColor = Color.Transparent
        TotalScore.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold)
        TotalScore.ForeColor = Color.White
        TotalScore.Location = New Point(504, 347)
        TotalScore.Name = "TotalScore"
        TotalScore.Size = New Size(58, 47)
        TotalScore.TabIndex = 7
        TotalScore.Text = "10"
        TotalScore.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ProfilePicture
        ' 
        ProfilePicture.BackColor = Color.Transparent
        ProfilePicture.BorderRadius = 20
        ProfilePicture.CustomizableEdges = CustomizableEdges1
        ProfilePicture.ImageRotate = 0F
        ProfilePicture.Location = New Point(473, 79)
        ProfilePicture.Name = "ProfilePicture"
        ProfilePicture.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        ProfilePicture.Size = New Size(127, 124)
        ProfilePicture.SizeMode = PictureBoxSizeMode.Zoom
        ProfilePicture.TabIndex = 17
        ProfilePicture.TabStop = False
        ' 
        ' FinishForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1072, 640)
        Controls.Add(ProfilePicture)
        Controls.Add(TotalScore)
        Controls.Add(Label1)
        Controls.Add(Username)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(CorrectAns)
        Controls.Add(Guna2Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FinishForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FinishForm"
        CType(ProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Username As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CorrectAns As Label
    Friend WithEvents TotalScore As Label
    Friend WithEvents ProfilePicture As Guna.UI2.WinForms.Guna2PictureBox
End Class
