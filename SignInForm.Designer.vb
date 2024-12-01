<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignInForm
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignInForm))
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Label1 = New Label()
        SIUser = New Guna.UI2.WinForms.Guna2TextBox()
        Label2 = New Label()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2CheckBox1 = New Guna.UI2.WinForms.Guna2CheckBox()
        SIPW = New Guna.UI2.WinForms.Guna2TextBox()
        SIBtn = New Guna.UI2.WinForms.Guna2Button()
        Label3 = New Label()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        Label4 = New Label()
        LinkLabel1 = New LinkLabel()
        Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2Panel2.SuspendLayout()
        Guna2Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.BackColor = Color.Transparent
        Guna2Panel2.BorderColor = Color.Black
        Guna2Panel2.BorderRadius = 3
        Guna2Panel2.BorderThickness = 2
        Guna2Panel2.Controls.Add(Label1)
        Guna2Panel2.CustomizableEdges = CustomizableEdges1
        Guna2Panel2.FillColor = Color.White
        Guna2Panel2.Location = New Point(340, 244)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Panel2.Size = New Size(512, 63)
        Guna2Panel2.TabIndex = 24
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(183, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 40)
        Label1.TabIndex = 22
        Label1.Text = "SIGN IN"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' SIUser
        ' 
        SIUser.BorderColor = Color.Black
        SIUser.BorderRadius = 5
        SIUser.BorderThickness = 3
        SIUser.CustomizableEdges = CustomizableEdges3
        SIUser.DefaultText = ""
        SIUser.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        SIUser.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        SIUser.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        SIUser.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        SIUser.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SIUser.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SIUser.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        SIUser.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SIUser.Location = New Point(187, 51)
        SIUser.Margin = New Padding(7)
        SIUser.Name = "SIUser"
        SIUser.PasswordChar = ChrW(0)
        SIUser.PlaceholderText = ""
        SIUser.SelectedText = ""
        SIUser.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        SIUser.Size = New Size(270, 47)
        SIUser.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Location = New Point(52, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 25)
        Label2.TabIndex = 17
        Label2.Text = "USERNAME:"
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.Transparent
        Guna2Panel1.BorderColor = Color.Black
        Guna2Panel1.BorderRadius = 3
        Guna2Panel1.BorderThickness = 2
        Guna2Panel1.Controls.Add(Guna2CheckBox1)
        Guna2Panel1.Controls.Add(SIPW)
        Guna2Panel1.Controls.Add(SIBtn)
        Guna2Panel1.Controls.Add(Label3)
        Guna2Panel1.Controls.Add(SIUser)
        Guna2Panel1.Controls.Add(Label2)
        Guna2Panel1.CustomizableEdges = CustomizableEdges9
        Guna2Panel1.FillColor = Color.White
        Guna2Panel1.Location = New Point(340, 313)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2Panel1.Size = New Size(512, 283)
        Guna2Panel1.TabIndex = 23
        ' 
        ' Guna2CheckBox1
        ' 
        Guna2CheckBox1.AutoSize = True
        Guna2CheckBox1.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2CheckBox1.CheckedState.BorderRadius = 0
        Guna2CheckBox1.CheckedState.BorderThickness = 0
        Guna2CheckBox1.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2CheckBox1.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2CheckBox1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2CheckBox1.Location = New Point(187, 169)
        Guna2CheckBox1.Name = "Guna2CheckBox1"
        Guna2CheckBox1.Size = New Size(126, 21)
        Guna2CheckBox1.TabIndex = 24
        Guna2CheckBox1.Text = "Show Password"
        Guna2CheckBox1.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2CheckBox1.UncheckedState.BorderRadius = 0
        Guna2CheckBox1.UncheckedState.BorderThickness = 0
        Guna2CheckBox1.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        ' 
        ' SIPW
        ' 
        SIPW.BorderColor = Color.Black
        SIPW.BorderRadius = 5
        SIPW.BorderThickness = 3
        SIPW.CustomizableEdges = CustomizableEdges5
        SIPW.DefaultText = ""
        SIPW.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        SIPW.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        SIPW.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        SIPW.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        SIPW.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SIPW.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SIPW.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        SIPW.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SIPW.Location = New Point(187, 112)
        SIPW.Margin = New Padding(7)
        SIPW.Name = "SIPW"
        SIPW.PasswordChar = "*"c
        SIPW.PlaceholderText = ""
        SIPW.SelectedText = ""
        SIPW.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        SIPW.Size = New Size(270, 47)
        SIPW.TabIndex = 21
        ' 
        ' SIBtn
        ' 
        SIBtn.BorderRadius = 10
        SIBtn.BorderThickness = 2
        SIBtn.CustomizableEdges = CustomizableEdges7
        SIBtn.DisabledState.BorderColor = Color.DarkGray
        SIBtn.DisabledState.CustomBorderColor = Color.DarkGray
        SIBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        SIBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        SIBtn.FillColor = Color.DarkOrchid
        SIBtn.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SIBtn.ForeColor = Color.White
        SIBtn.Location = New Point(183, 210)
        SIBtn.Name = "SIBtn"
        SIBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        SIBtn.Size = New Size(183, 58)
        SIBtn.TabIndex = 20
        SIBtn.Text = "Sign In"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(52, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 25)
        Label3.TabIndex = 19
        Label3.Text = "PASSWORD:"
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
        Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND
        Guna2AnimateWindow1.TargetForm = Me
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(429, 612)
        Label4.Name = "Label4"
        Label4.Size = New Size(195, 40)
        Label4.TabIndex = 23
        Label4.Text = "No Account?"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.White
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkColor = Color.Plum
        LinkLabel1.Location = New Point(630, 612)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(119, 37)
        LinkLabel1.TabIndex = 25
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Sign Up"
        ' 
        ' Guna2ControlBox3
        ' 
        Guna2ControlBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox3.BackColor = Color.Transparent
        Guna2ControlBox3.BorderRadius = 5
        Guna2ControlBox3.BorderThickness = 1
        Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Guna2ControlBox3.CustomizableEdges = CustomizableEdges11
        Guna2ControlBox3.FillColor = Color.White
        Guna2ControlBox3.IconColor = Color.Black
        Guna2ControlBox3.Location = New Point(1058, 12)
        Guna2ControlBox3.Name = "Guna2ControlBox3"
        Guna2ControlBox3.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2ControlBox3.Size = New Size(48, 38)
        Guna2ControlBox3.TabIndex = 27
        ' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.BackColor = Color.Transparent
        Guna2ControlBox1.BorderRadius = 5
        Guna2ControlBox1.BorderThickness = 1
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges13
        Guna2ControlBox1.FillColor = Color.White
        Guna2ControlBox1.IconColor = Color.Black
        Guna2ControlBox1.Location = New Point(1110, 12)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        Guna2ControlBox1.Size = New Size(48, 38)
        Guna2ControlBox1.TabIndex = 26
        ' 
        ' SignInForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1172, 667)
        Controls.Add(Guna2ControlBox3)
        Controls.Add(Guna2ControlBox1)
        Controls.Add(LinkLabel1)
        Controls.Add(Label4)
        Controls.Add(Guna2Panel2)
        Controls.Add(Guna2Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "SignInForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SignInForm"
        Guna2Panel2.ResumeLayout(False)
        Guna2Panel2.PerformLayout()
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents SIUser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents SIPW As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SIBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Guna2CheckBox1 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
End Class
