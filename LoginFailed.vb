Public Class LoginFailed
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        SignInForm.SIUser.Text = ""
        SignInForm.SIPW.Text = ""
        Hide
        SignInForm.Show
    End Sub
End Class