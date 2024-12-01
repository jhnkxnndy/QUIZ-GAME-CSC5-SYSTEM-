<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuessInterface
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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GuessInterface))
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        Timer1 = New Timer(components)
        Label3 = New Label()
        QuestionLbl = New Label()
        Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Label5 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        GScoreLabel = New Label()
        Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Label1 = New Label()
        Guna2Panel5.SuspendLayout()
        Guna2Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.BorderRadius = 50
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(122, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 47)
        Label3.TabIndex = 0
        Label3.Text = "Level"
        ' 
        ' QuestionLbl
        ' 
        QuestionLbl.AutoSize = True
        QuestionLbl.BackColor = Color.Transparent
        QuestionLbl.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        QuestionLbl.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        QuestionLbl.Location = New Point(239, 19)
        QuestionLbl.Name = "QuestionLbl"
        QuestionLbl.Size = New Size(41, 47)
        QuestionLbl.TabIndex = 2
        QuestionLbl.Text = "0"
        ' 
        ' Guna2Panel5
        ' 
        Guna2Panel5.BackColor = Color.Transparent
        Guna2Panel5.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2Panel5.BorderRadius = 20
        Guna2Panel5.BorderThickness = 2
        Guna2Panel5.Controls.Add(Label5)
        Guna2Panel5.Controls.Add(Label2)
        Guna2Panel5.Controls.Add(Label3)
        Guna2Panel5.Controls.Add(QuestionLbl)
        Guna2Panel5.CustomizableEdges = CustomizableEdges5
        Guna2Panel5.FillColor = Color.WhiteSmoke
        Guna2Panel5.Location = New Point(411, -12)
        Guna2Panel5.Name = "Guna2Panel5"
        Guna2Panel5.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Panel5.Size = New Size(485, 76)
        Guna2Panel5.TabIndex = 33
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label5.Location = New Point(329, 18)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 47)
        Label5.TabIndex = 4
        Label5.Text = "10"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Location = New Point(289, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 47)
        Label2.TabIndex = 3
        Label2.Text = "/"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label4.Location = New Point(27, 15)
        Label4.Name = "Label4"
        Label4.Size = New Size(125, 47)
        Label4.TabIndex = 4
        Label4.Text = "Score:"
        ' 
        ' GScoreLabel
        ' 
        GScoreLabel.AutoSize = True
        GScoreLabel.BackColor = Color.Transparent
        GScoreLabel.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GScoreLabel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        GScoreLabel.Location = New Point(147, 15)
        GScoreLabel.Name = "GScoreLabel"
        GScoreLabel.Size = New Size(41, 47)
        GScoreLabel.TabIndex = 1
        GScoreLabel.Text = "0"
        ' 
        ' Guna2Panel6
        ' 
        Guna2Panel6.BackColor = Color.Transparent
        Guna2Panel6.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2Panel6.BorderRadius = 20
        Guna2Panel6.BorderThickness = 2
        Guna2Panel6.Controls.Add(Label4)
        Guna2Panel6.Controls.Add(GScoreLabel)
        Guna2Panel6.CustomizableEdges = CustomizableEdges7
        Guna2Panel6.FillColor = Color.WhiteSmoke
        Guna2Panel6.Location = New Point(990, -15)
        Guna2Panel6.Name = "Guna2Panel6"
        Guna2Panel6.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Panel6.Size = New Size(260, 76)
        Guna2Panel6.TabIndex = 34
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.BackColor = Color.Transparent
        Guna2Button2.BorderRadius = 10
        Guna2Button2.CustomizableEdges = CustomizableEdges3
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = Color.FromArgb(CByte(255), CByte(69), CByte(69))
        Guna2Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button2.ForeColor = Color.White
        Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), Image)
        Guna2Button2.ImageAlign = HorizontalAlignment.Left
        Guna2Button2.ImageSize = New Size(30, 30)
        Guna2Button2.Location = New Point(35, 19)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button2.Size = New Size(137, 45)
        Guna2Button2.TabIndex = 35
        Guna2Button2.Text = "GO BACK"
        Guna2Button2.TextAlign = HorizontalAlignment.Right
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.Transparent
        Guna2Panel1.BorderRadius = 20
        Guna2Panel1.CustomizableEdges = CustomizableEdges1
        Guna2Panel1.Location = New Point(98, 76)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Panel1.Size = New Size(1129, 682)
        Guna2Panel1.TabIndex = 36
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(345, 762)
        Label1.Name = "Label1"
        Label1.Size = New Size(677, 47)
        Label1.TabIndex = 37
        Label1.Text = "Press enter to submit your answer . . ."
        ' 
        ' GuessInterface
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1274, 818)
        Controls.Add(Label1)
        Controls.Add(Guna2Panel1)
        Controls.Add(Guna2Button2)
        Controls.Add(Guna2Panel5)
        Controls.Add(Guna2Panel6)
        FormBorderStyle = FormBorderStyle.None
        Name = "GuessInterface"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GuessInterface"
        Guna2Panel5.ResumeLayout(False)
        Guna2Panel5.PerformLayout()
        Guna2Panel6.ResumeLayout(False)
        Guna2Panel6.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents QuestionLbl As Label
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents GScoreLabel As Label
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
End Class
