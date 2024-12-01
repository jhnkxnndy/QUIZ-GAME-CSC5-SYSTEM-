Public Class TutorialForm
    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        MCTutorial.TopLevel = False
        TutorialInterface.Guna2Panel1.Controls.Add(MCTutorial)
        MCTutorial.Show()
        MCTutorial.BringToFront()
    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        GuessTutorial.TopLevel = False
        TutorialInterface.Guna2Panel1.Controls.Add(GuessTutorial)
        GuessTutorial.Show()
        GuessTutorial.BringToFront()
    End Sub

    Private Sub Guna2CircleButton3_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton3.Click
        FillTutorial.TopLevel = False
        TutorialInterface.Guna2Panel1.Controls.Add(FillTutorial)
        FillTutorial.Show()
        FillTutorial.BringToFront()
    End Sub
End Class