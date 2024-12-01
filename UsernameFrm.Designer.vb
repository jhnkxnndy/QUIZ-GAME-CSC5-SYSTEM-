<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsernameFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsernameFrm))
        NewUsername = New Guna.UI2.WinForms.Guna2TextBox()
        CurrentUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Label2 = New Label()
        Label1 = New Label()
        PasswordTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Label3 = New Label()
        SaveBtn = New Guna.UI2.WinForms.Guna2Button()
        Guna2CheckBox1 = New Guna.UI2.WinForms.Guna2CheckBox()
        SuspendLayout()
        ' 
        ' NewUsername
        ' 
        NewUsername.BorderColor = Color.Black
        NewUsername.BorderRadius = 5
        NewUsername.BorderThickness = 3
        NewUsername.CustomizableEdges = CustomizableEdges1
        NewUsername.DefaultText = ""
        NewUsername.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        NewUsername.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        NewUsername.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        NewUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        NewUsername.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        NewUsername.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NewUsername.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        NewUsername.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        NewUsername.Location = New Point(370, 237)
        NewUsername.Margin = New Padding(7)
        NewUsername.Name = "NewUsername"
        NewUsername.PasswordChar = ChrW(0)
        NewUsername.PlaceholderText = ""
        NewUsername.SelectedText = ""
        NewUsername.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        NewUsername.Size = New Size(416, 49)
        NewUsername.TabIndex = 25
        ' 
        ' CurrentUsername
        ' 
        CurrentUsername.BorderColor = Color.Black
        CurrentUsername.BorderRadius = 5
        CurrentUsername.BorderThickness = 3
        CurrentUsername.CustomizableEdges = CustomizableEdges3
        CurrentUsername.DefaultText = ""
        CurrentUsername.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        CurrentUsername.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        CurrentUsername.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        CurrentUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        CurrentUsername.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        CurrentUsername.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CurrentUsername.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        CurrentUsername.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        CurrentUsername.Location = New Point(370, 153)
        CurrentUsername.Margin = New Padding(7)
        CurrentUsername.Name = "CurrentUsername"
        CurrentUsername.PasswordChar = ChrW(0)
        CurrentUsername.PlaceholderText = ""
        CurrentUsername.SelectedText = ""
        CurrentUsername.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        CurrentUsername.Size = New Size(416, 49)
        CurrentUsername.TabIndex = 24
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Location = New Point(370, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(218, 25)
        Label2.TabIndex = 26
        Label2.Text = "CURRENT USERNAME:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(371, 211)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 25)
        Label1.TabIndex = 27
        Label1.Text = "NEW USERNAME:"
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.BorderColor = Color.Black
        PasswordTextBox.BorderRadius = 5
        PasswordTextBox.BorderThickness = 3
        PasswordTextBox.CustomizableEdges = CustomizableEdges5
        PasswordTextBox.DefaultText = ""
        PasswordTextBox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        PasswordTextBox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        PasswordTextBox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        PasswordTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        PasswordTextBox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        PasswordTextBox.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PasswordTextBox.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        PasswordTextBox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        PasswordTextBox.Location = New Point(370, 320)
        PasswordTextBox.Margin = New Padding(7)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "*"c
        PasswordTextBox.PlaceholderText = ""
        PasswordTextBox.SelectedText = ""
        PasswordTextBox.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        PasswordTextBox.Size = New Size(416, 49)
        PasswordTextBox.TabIndex = 28
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(372, 296)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 25)
        Label3.TabIndex = 29
        Label3.Text = "PASSWORD:"
        ' 
        ' SaveBtn
        ' 
        SaveBtn.BorderRadius = 5
        SaveBtn.BorderThickness = 2
        SaveBtn.CustomizableEdges = CustomizableEdges7
        SaveBtn.DisabledState.BorderColor = Color.DarkGray
        SaveBtn.DisabledState.CustomBorderColor = Color.DarkGray
        SaveBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        SaveBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        SaveBtn.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SaveBtn.ForeColor = Color.White
        SaveBtn.Location = New Point(372, 405)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        SaveBtn.Size = New Size(414, 57)
        SaveBtn.TabIndex = 30
        SaveBtn.Text = "SAVE CHANGES"
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
        Guna2CheckBox1.Location = New Point(375, 373)
        Guna2CheckBox1.Name = "Guna2CheckBox1"
        Guna2CheckBox1.Size = New Size(126, 21)
        Guna2CheckBox1.TabIndex = 31
        Guna2CheckBox1.Text = "Show Password"
        Guna2CheckBox1.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2CheckBox1.UncheckedState.BorderRadius = 0
        Guna2CheckBox1.UncheckedState.BorderThickness = 0
        Guna2CheckBox1.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' UsernameFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1148, 511)
        Controls.Add(Guna2CheckBox1)
        Controls.Add(SaveBtn)
        Controls.Add(Label3)
        Controls.Add(PasswordTextBox)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(NewUsername)
        Controls.Add(CurrentUsername)
        FormBorderStyle = FormBorderStyle.None
        Name = "UsernameFrm"
        Text = "UsernameFrm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NewUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CurrentUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PasswordTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SaveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CheckBox1 As Guna.UI2.WinForms.Guna2CheckBox
End Class
