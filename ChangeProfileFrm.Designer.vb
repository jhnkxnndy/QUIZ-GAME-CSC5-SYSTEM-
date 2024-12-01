<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeProfileFrm
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangeProfileFrm))
        ProfilePicture = New Guna.UI2.WinForms.Guna2PictureBox()
        UploadBtn = New Guna.UI2.WinForms.Guna2Button()
        SaveBtn = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        CType(ProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ProfilePicture
        ' 
        ProfilePicture.BackColor = Color.Transparent
        ProfilePicture.BorderRadius = 10
        ProfilePicture.CustomizableEdges = CustomizableEdges1
        ProfilePicture.ImageRotate = 0F
        ProfilePicture.Location = New Point(425, 115)
        ProfilePicture.Name = "ProfilePicture"
        ProfilePicture.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        ProfilePicture.Size = New Size(300, 229)
        ProfilePicture.SizeMode = PictureBoxSizeMode.Zoom
        ProfilePicture.TabIndex = 0
        ProfilePicture.TabStop = False
        ' 
        ' UploadBtn
        ' 
        UploadBtn.BorderRadius = 5
        UploadBtn.BorderThickness = 2
        UploadBtn.CustomizableEdges = CustomizableEdges3
        UploadBtn.DisabledState.BorderColor = Color.DarkGray
        UploadBtn.DisabledState.CustomBorderColor = Color.DarkGray
        UploadBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        UploadBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        UploadBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UploadBtn.ForeColor = Color.White
        UploadBtn.Location = New Point(495, 355)
        UploadBtn.Name = "UploadBtn"
        UploadBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        UploadBtn.Size = New Size(175, 52)
        UploadBtn.TabIndex = 34
        UploadBtn.Text = "Upload File"
        ' 
        ' SaveBtn
        ' 
        SaveBtn.BorderRadius = 5
        SaveBtn.BorderThickness = 2
        SaveBtn.CustomizableEdges = CustomizableEdges5
        SaveBtn.DisabledState.BorderColor = Color.DarkGray
        SaveBtn.DisabledState.CustomBorderColor = Color.DarkGray
        SaveBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        SaveBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        SaveBtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SaveBtn.ForeColor = Color.White
        SaveBtn.Location = New Point(495, 413)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        SaveBtn.Size = New Size(175, 52)
        SaveBtn.TabIndex = 35
        SaveBtn.Text = "Save Changes"
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.BackColor = Color.Transparent
        Guna2Button2.BorderColor = Color.White
        Guna2Button2.BorderRadius = 20
        Guna2Button2.BorderThickness = 3
        Guna2Button2.CustomizableEdges = CustomizableEdges7
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button2.ForeColor = Color.White
        Guna2Button2.Location = New Point(942, 25)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Button2.Size = New Size(167, 45)
        Guna2Button2.TabIndex = 36
        Guna2Button2.Text = "GO BACK"
        ' 
        ' ChangeProfileFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1148, 511)
        Controls.Add(Guna2Button2)
        Controls.Add(SaveBtn)
        Controls.Add(UploadBtn)
        Controls.Add(ProfilePicture)
        FormBorderStyle = FormBorderStyle.None
        Name = "ChangeProfileFrm"
        Text = "ChangeProfileFrm"
        CType(ProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ProfilePicture As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents UploadBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SaveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
End Class
