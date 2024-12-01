Public Class LoginSuccess
    Public Property Username As String 

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        
        Dim mainInterface As New MainInterface()

       
        mainInterface.UserLabel.Text = Username

        mainInterface.Show() 
        Me.Hide()
        SignInForm.Hide()
    End Sub
End Class
