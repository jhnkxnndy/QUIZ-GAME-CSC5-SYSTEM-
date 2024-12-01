<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MCInterface
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MCInterface))
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        ScoreLabel = New Label()
        Label3 = New Label()
        QuestionLbl = New Label()
        Label4 = New Label()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Label2 = New Label()
        Label1 = New Label()
        Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Panel2.SuspendLayout()
        Guna2Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.Transparent
        Guna2Panel1.BorderRadius = 20
        Guna2Panel1.CustomizableEdges = CustomizableEdges1
        Guna2Panel1.Location = New Point(171, 84)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Panel1.Size = New Size(914, 695)
        Guna2Panel1.TabIndex = 0
        ' 
        ' ScoreLabel
        ' 
        ScoreLabel.AutoSize = True
        ScoreLabel.BackColor = Color.Transparent
        ScoreLabel.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ScoreLabel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ScoreLabel.Location = New Point(147, 15)
        ScoreLabel.Name = "ScoreLabel"
        ScoreLabel.Size = New Size(41, 47)
        ScoreLabel.TabIndex = 1
        ScoreLabel.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(73, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(176, 47)
        Label3.TabIndex = 0
        Label3.Text = "Question"
        ' 
        ' QuestionLbl
        ' 
        QuestionLbl.AutoSize = True
        QuestionLbl.BackColor = Color.Transparent
        QuestionLbl.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        QuestionLbl.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        QuestionLbl.Location = New Point(255, 15)
        QuestionLbl.Name = "QuestionLbl"
        QuestionLbl.Size = New Size(41, 47)
        QuestionLbl.TabIndex = 2
        QuestionLbl.Text = "0"
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
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.BorderRadius = 30
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.DragForm = False
        Guna2BorderlessForm1.ResizeForm = False
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' Guna2AnimateWindow1
        ' 
        Guna2AnimateWindow1.Interval = 250
        Guna2AnimateWindow1.TargetForm = Me
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.BackColor = Color.Transparent
        Guna2Panel2.BorderRadius = 20
        Guna2Panel2.Controls.Add(Label2)
        Guna2Panel2.Controls.Add(Label1)
        Guna2Panel2.Controls.Add(Label3)
        Guna2Panel2.Controls.Add(QuestionLbl)
        Guna2Panel2.CustomizableEdges = CustomizableEdges7
        Guna2Panel2.FillColor = Color.WhiteSmoke
        Guna2Panel2.Location = New Point(367, -6)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Panel2.Size = New Size(485, 76)
        Guna2Panel2.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Location = New Point(345, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 47)
        Label2.TabIndex = 4
        Label2.Text = "10"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(302, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 47)
        Label1.TabIndex = 3
        Label1.Text = "/"
        ' 
        ' Guna2Panel3
        ' 
        Guna2Panel3.BackColor = Color.Transparent
        Guna2Panel3.BorderRadius = 20
        Guna2Panel3.Controls.Add(Label4)
        Guna2Panel3.Controls.Add(ScoreLabel)
        Guna2Panel3.CustomizableEdges = CustomizableEdges5
        Guna2Panel3.FillColor = Color.WhiteSmoke
        Guna2Panel3.Location = New Point(972, -15)
        Guna2Panel3.Name = "Guna2Panel3"
        Guna2Panel3.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Panel3.Size = New Size(244, 71)
        Guna2Panel3.TabIndex = 6
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
        Guna2Button2.Location = New Point(35, 11)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button2.Size = New Size(137, 45)
        Guna2Button2.TabIndex = 36
        Guna2Button2.Text = "GO BACK"
        Guna2Button2.TextAlign = HorizontalAlignment.Right
        ' 
        ' MCInterface
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1228, 799)
        Controls.Add(Guna2Button2)
        Controls.Add(Guna2Panel3)
        Controls.Add(Guna2Panel2)
        Controls.Add(Guna2Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "MCInterface"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MCInterface"
        Guna2Panel2.ResumeLayout(False)
        Guna2Panel2.PerformLayout()
        Guna2Panel3.ResumeLayout(False)
        Guna2Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents QuestionLbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
