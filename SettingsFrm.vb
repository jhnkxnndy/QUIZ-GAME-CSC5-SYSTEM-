Public Class SettingsFrm
    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        ChangeProfileFrm.TopLevel = False
        SettingsInterface.Guna2Panel1.Controls.Add(ChangeProfileFrm)
        ChangeProfileFrm.Show()
        ChangeProfileFrm.BringToFront()
    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        ChangePassFrm.TopLevel = False
        SettingsInterface.Guna2Panel1.Controls.Add(ChangePassFrm)
        ChangePassFrm.Show()
        ChangePassFrm.BringToFront()
    End Sub

    Private Sub Guna2CircleButton3_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton3.Click
        CreditsFrm.TopLevel = False
        SettingsInterface.Guna2Panel1.Controls.Add(CreditsFrm)
        CreditsFrm.Show()
        CreditsFrm.BringToFront()
    End Sub

    Private Sub Guna2CircleButton5_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton5.Click
        AboutGame.TopLevel = False
        SettingsInterface.Guna2Panel1.Controls.Add(AboutGame)
        AboutGame.Show()
        AboutGame.BringToFront()
    End Sub

    Private Sub Guna2CircleButton4_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton4.Click
        AboutUs.TopLevel = False
        SettingsInterface.Guna2Panel1.Controls.Add(AboutUs)
        AboutUs.Show()
        AboutUs.BringToFront()
    End Sub
End Class