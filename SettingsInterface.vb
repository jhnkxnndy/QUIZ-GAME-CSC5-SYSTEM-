Public Class SettingsInterface
    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub SettingsInterface_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        SettingsFrm.TopLevel = False
        Guna2Panel1.Controls.Add(SettingsFrm)
        SettingsFrm.Show()
        SettingsFrm.BringToFront()
    End Sub
End Class