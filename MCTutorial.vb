﻿Public Class MCTutorial
    Private connectionString As String = "Server=localhost;Database=quizgame_db;Uid=root;Pwd=mysql_admin081105;"
    Private username As String ' Store the username when the user logs in
    Private db As New MY_DB()

    Private Sub CloseMainInterface()
        ' Get the instance of MainInterface or find it in open forms
        Dim mainInterface As MainInterface = Application.OpenForms.OfType(Of MainInterface)().FirstOrDefault()

        If mainInterface IsNot Nothing Then
            ' If MainInterface is open, close it
            mainInterface.Close()
        End If
    End Sub


    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        TutorialForm.TopLevel = False
        MainInterface.MainPanel.Controls.Add(TutorialForm)
        TutorialForm.Show()
        TutorialForm.BringToFront()
    End Sub

    Private Sub MCTutorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button2_Click_1(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        TutorialForm.TopLevel = False
        TutorialInterface.Guna2Panel1.Controls.Add(TutorialForm)
        TutorialForm.Show()
        TutorialForm.BringToFront()
    End Sub
End Class