Public Class FillTutorial
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        TutorialForm.TopLevel = False
        TutorialInterface.Guna2Panel1.Controls.Add(TutorialForm)
        TutorialForm.Show()
        TutorialForm.BringToFront()
    End Sub
End Class