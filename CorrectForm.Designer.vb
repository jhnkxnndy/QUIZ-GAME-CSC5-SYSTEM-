﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CorrectForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CorrectForm))
        Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Timer1 = New Timer(components)
        Label1 = New Label()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Panel1.SuspendLayout()
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Black", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(98, -9)
        Label1.Name = "Label1"
        Label1.Size = New Size(330, 86)
        Label1.TabIndex = 1
        Label1.Text = "CORRECT"
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.Transparent
        Guna2Panel1.Controls.Add(Label1)
        Guna2Panel1.CustomizableEdges = CustomizableEdges1
        Guna2Panel1.Location = New Point(78, 28)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Panel1.Size = New Size(513, 77)
        Guna2Panel1.TabIndex = 0
        ' 
        ' CorrectForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(676, 137)
        Controls.Add(Guna2Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "CorrectForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CorrectForm"
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
End Class