<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TutorialForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TutorialForm))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Guna2CircleButton2 = New Guna.UI2.WinForms.Guna2CircleButton()
        Guna2CircleButton3 = New Guna.UI2.WinForms.Guna2CircleButton()
        SuspendLayout()
        ' 
        ' Guna2CircleButton1
        ' 
        Guna2CircleButton1.BackColor = Color.Transparent
        Guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray
        Guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2CircleButton1.FillColor = Color.Transparent
        Guna2CircleButton1.Font = New Font("Segoe UI", 9F)
        Guna2CircleButton1.ForeColor = Color.White
        Guna2CircleButton1.Image = CType(resources.GetObject("Guna2CircleButton1.Image"), Image)
        Guna2CircleButton1.ImageSize = New Size(70, 70)
        Guna2CircleButton1.Location = New Point(927, 141)
        Guna2CircleButton1.Name = "Guna2CircleButton1"
        Guna2CircleButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CircleButton1.Size = New Size(74, 71)
        Guna2CircleButton1.TabIndex = 5
        ' 
        ' Guna2CircleButton2
        ' 
        Guna2CircleButton2.BackColor = Color.Transparent
        Guna2CircleButton2.DisabledState.BorderColor = Color.DarkGray
        Guna2CircleButton2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2CircleButton2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2CircleButton2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2CircleButton2.FillColor = Color.Transparent
        Guna2CircleButton2.Font = New Font("Segoe UI", 9F)
        Guna2CircleButton2.ForeColor = Color.White
        Guna2CircleButton2.Image = CType(resources.GetObject("Guna2CircleButton2.Image"), Image)
        Guna2CircleButton2.ImageSize = New Size(70, 70)
        Guna2CircleButton2.Location = New Point(927, 246)
        Guna2CircleButton2.Name = "Guna2CircleButton2"
        Guna2CircleButton2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CircleButton2.Size = New Size(74, 71)
        Guna2CircleButton2.TabIndex = 9
        ' 
        ' Guna2CircleButton3
        ' 
        Guna2CircleButton3.BackColor = Color.Transparent
        Guna2CircleButton3.DisabledState.BorderColor = Color.DarkGray
        Guna2CircleButton3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2CircleButton3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2CircleButton3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2CircleButton3.FillColor = Color.Transparent
        Guna2CircleButton3.Font = New Font("Segoe UI", 9F)
        Guna2CircleButton3.ForeColor = Color.White
        Guna2CircleButton3.Image = CType(resources.GetObject("Guna2CircleButton3.Image"), Image)
        Guna2CircleButton3.ImageSize = New Size(70, 70)
        Guna2CircleButton3.Location = New Point(927, 350)
        Guna2CircleButton3.Name = "Guna2CircleButton3"
        Guna2CircleButton3.ShadowDecoration.CustomizableEdges = CustomizableEdges3
        Guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CircleButton3.Size = New Size(74, 71)
        Guna2CircleButton3.TabIndex = 10
        ' 
        ' TutorialForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1148, 511)
        Controls.Add(Guna2CircleButton3)
        Controls.Add(Guna2CircleButton2)
        Controls.Add(Guna2CircleButton1)
        FormBorderStyle = FormBorderStyle.None
        Name = "TutorialForm"
        Text = "TutorialForm"
        ResumeLayout(False)
    End Sub
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2CircleButton2 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2CircleButton3 As Guna.UI2.WinForms.Guna2CircleButton
End Class
