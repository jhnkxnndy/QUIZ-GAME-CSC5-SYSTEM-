<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        StartBtn = New Guna.UI2.WinForms.Guna2Button()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        SuspendLayout()
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER
        Guna2BorderlessForm1.BorderRadius = 50
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' StartBtn
        ' 
        StartBtn.BackColor = Color.Transparent
        StartBtn.BorderRadius = 30
        StartBtn.BorderThickness = 2
        StartBtn.Cursor = Cursors.Hand
        StartBtn.CustomizableEdges = CustomizableEdges5
        StartBtn.DisabledState.BorderColor = Color.DarkGray
        StartBtn.DisabledState.CustomBorderColor = Color.DarkGray
        StartBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        StartBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        StartBtn.FillColor = Color.White
        StartBtn.Font = New Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StartBtn.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        StartBtn.Location = New Point(441, 508)
        StartBtn.Name = "StartBtn"
        StartBtn.PressedColor = Color.FromArgb(CByte(16), CByte(193), CByte(224))
        StartBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        StartBtn.Size = New Size(318, 81)
        StartBtn.TabIndex = 1
        StartBtn.Text = "START"
        StartBtn.UseTransparentBackground = True
        ' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.BackColor = Color.Transparent
        Guna2ControlBox1.BorderRadius = 5
        Guna2ControlBox1.BorderThickness = 1
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges3
        Guna2ControlBox1.FillColor = Color.White
        Guna2ControlBox1.IconColor = Color.Black
        Guna2ControlBox1.Location = New Point(1110, 12)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2ControlBox1.Size = New Size(48, 38)
        Guna2ControlBox1.TabIndex = 2
        ' 
        ' Guna2ControlBox3
        ' 
        Guna2ControlBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox3.BackColor = Color.Transparent
        Guna2ControlBox3.BorderRadius = 5
        Guna2ControlBox3.BorderThickness = 1
        Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Guna2ControlBox3.CustomizableEdges = CustomizableEdges1
        Guna2ControlBox3.FillColor = Color.White
        Guna2ControlBox3.IconColor = Color.Black
        Guna2ControlBox3.Location = New Point(1058, 12)
        Guna2ControlBox3.Name = "Guna2ControlBox3"
        Guna2ControlBox3.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2ControlBox3.Size = New Size(48, 38)
        Guna2ControlBox3.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1172, 667)
        Controls.Add(Guna2ControlBox3)
        Controls.Add(Guna2ControlBox1)
        Controls.Add(StartBtn)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents StartBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow

End Class
