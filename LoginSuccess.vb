Public Class LoginSuccess
    Public Property Username As String ' Property to store the username

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ' Create a new instance of MainInterface
        Dim mainInterface As New MainInterface()

        ' Set the UserLabel text to the username
        mainInterface.UserLabel.Text = Username

        mainInterface.Show() ' Show the MainInterface
        Me.Hide() ' Hide the LoginSuccess form
        SignInForm.Hide()
    End Sub
End Class
