﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FillQuestion5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FillQuestion5))
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
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
        ' Guna2TextBox2
        ' 
        Guna2TextBox2.BorderColor = Color.Black
        Guna2TextBox2.CustomizableEdges = CustomizableEdges1
        Guna2TextBox2.DefaultText = ""
        Guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox2.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2TextBox2.ForeColor = Color.Black
        Guna2TextBox2.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.Location = New Point(62, 505)
        Guna2TextBox2.Margin = New Padding(15, 16, 15, 16)
        Guna2TextBox2.Name = "Guna2TextBox2"
        Guna2TextBox2.PasswordChar = ChrW(0)
        Guna2TextBox2.PlaceholderText = ""
        Guna2TextBox2.SelectedText = ""
        Guna2TextBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2TextBox2.Size = New Size(126, 47)
        Guna2TextBox2.TabIndex = 6
        Guna2TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.BorderColor = Color.Black
        Guna2TextBox1.CustomizableEdges = CustomizableEdges3
        Guna2TextBox1.DefaultText = ""
        Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2TextBox1.ForeColor = Color.Black
        Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Location = New Point(200, 463)
        Guna2TextBox1.Margin = New Padding(19, 16, 19, 16)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderText = ""
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2TextBox1.Size = New Size(80, 44)
        Guna2TextBox1.TabIndex = 5
        Guna2TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' FillQuestion5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1129, 682)
        Controls.Add(Guna2TextBox2)
        Controls.Add(Guna2TextBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FillQuestion5"
        Text = "FillQuestion5"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
End Class