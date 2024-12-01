<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePassFrm))
        Guna2CheckBox2 = New Guna.UI2.WinForms.Guna2CheckBox()
        SaveBtn = New Guna.UI2.WinForms.Guna2Button()
        Label3 = New Label()
        NewPassTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Label1 = New Label()
        OldPassTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2CheckBox1 = New Guna.UI2.WinForms.Guna2CheckBox()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' Guna2CheckBox2
        ' 
        Guna2CheckBox2.AutoSize = True
        Guna2CheckBox2.BackColor = Color.Transparent
        Guna2CheckBox2.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2CheckBox2.CheckedState.BorderRadius = 0
        Guna2CheckBox2.CheckedState.BorderThickness = 0
        Guna2CheckBox2.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2CheckBox2.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2CheckBox2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2CheckBox2.Location = New Point(365, 345)
        Guna2CheckBox2.Name = "Guna2CheckBox2"
        Guna2CheckBox2.Size = New Size(126, 21)
        Guna2CheckBox2.TabIndex = 37
        Guna2CheckBox2.Text = "Show Password"
        Guna2CheckBox2.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2CheckBox2.UncheckedState.BorderRadius = 0
        Guna2CheckBox2.UncheckedState.BorderThickness = 0
        Guna2CheckBox2.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2CheckBox2.UseVisualStyleBackColor = False
        ' 
        ' SaveBtn
        ' 
        SaveBtn.BorderRadius = 5
        SaveBtn.BorderThickness = 2
        SaveBtn.CustomizableEdges = CustomizableEdges1
        SaveBtn.DisabledState.BorderColor = Color.DarkGray
        SaveBtn.DisabledState.CustomBorderColor = Color.DarkGray
        SaveBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        SaveBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        SaveBtn.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SaveBtn.ForeColor = Color.White
        SaveBtn.Location = New Point(362, 402)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        SaveBtn.Size = New Size(414, 57)
        SaveBtn.TabIndex = 36
        SaveBtn.Text = "SAVE CHANGES"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(358, 268)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 25)
        Label3.TabIndex = 35
        Label3.Text = "New Password:"
        ' 
        ' NewPassTxt
        ' 
        NewPassTxt.BorderColor = Color.Black
        NewPassTxt.BorderRadius = 5
        NewPassTxt.BorderThickness = 3
        NewPassTxt.CustomizableEdges = CustomizableEdges3
        NewPassTxt.DefaultText = ""
        NewPassTxt.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        NewPassTxt.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        NewPassTxt.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        NewPassTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        NewPassTxt.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        NewPassTxt.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NewPassTxt.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        NewPassTxt.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        NewPassTxt.Location = New Point(360, 292)
        NewPassTxt.Margin = New Padding(7)
        NewPassTxt.Name = "NewPassTxt"
        NewPassTxt.PasswordChar = "*"c
        NewPassTxt.PlaceholderText = ""
        NewPassTxt.SelectedText = ""
        NewPassTxt.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        NewPassTxt.Size = New Size(416, 49)
        NewPassTxt.TabIndex = 34
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(357, 156)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 25)
        Label1.TabIndex = 33
        Label1.Text = "Old Password:"
        ' 
        ' OldPassTxt
        ' 
        OldPassTxt.BorderColor = Color.Black
        OldPassTxt.BorderRadius = 5
        OldPassTxt.BorderThickness = 3
        OldPassTxt.CustomizableEdges = CustomizableEdges5
        OldPassTxt.DefaultText = ""
        OldPassTxt.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        OldPassTxt.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        OldPassTxt.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        OldPassTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        OldPassTxt.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        OldPassTxt.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OldPassTxt.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        OldPassTxt.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        OldPassTxt.Location = New Point(360, 182)
        OldPassTxt.Margin = New Padding(7)
        OldPassTxt.Name = "OldPassTxt"
        OldPassTxt.PasswordChar = "*"c
        OldPassTxt.PlaceholderText = ""
        OldPassTxt.SelectedText = ""
        OldPassTxt.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        OldPassTxt.Size = New Size(416, 49)
        OldPassTxt.TabIndex = 32
        ' 
        ' Guna2CheckBox1
        ' 
        Guna2CheckBox1.AutoSize = True
        Guna2CheckBox1.BackColor = Color.Transparent
        Guna2CheckBox1.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2CheckBox1.CheckedState.BorderRadius = 0
        Guna2CheckBox1.CheckedState.BorderThickness = 0
        Guna2CheckBox1.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2CheckBox1.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2CheckBox1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2CheckBox1.Location = New Point(363, 233)
        Guna2CheckBox1.Name = "Guna2CheckBox1"
        Guna2CheckBox1.Size = New Size(126, 21)
        Guna2CheckBox1.TabIndex = 38
        Guna2CheckBox1.Text = "Show Password"
        Guna2CheckBox1.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2CheckBox1.UncheckedState.BorderRadius = 0
        Guna2CheckBox1.UncheckedState.BorderThickness = 0
        Guna2CheckBox1.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2CheckBox1.UseVisualStyleBackColor = False
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
        Guna2Button2.TabIndex = 39
        Guna2Button2.Text = "GO BACK"
        ' 
        ' ChangePassFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1148, 511)
        Controls.Add(Guna2Button2)
        Controls.Add(Guna2CheckBox1)
        Controls.Add(Guna2CheckBox2)
        Controls.Add(SaveBtn)
        Controls.Add(Label3)
        Controls.Add(NewPassTxt)
        Controls.Add(Label1)
        Controls.Add(OldPassTxt)
        FormBorderStyle = FormBorderStyle.None
        Name = "ChangePassFrm"
        Text = "ChangePassFrm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2CheckBox2 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents SaveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents NewPassTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OldPassTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2CheckBox1 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
End Class
