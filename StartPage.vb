Imports System.Media
Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim player As New SoundPlayer("C:\Users\johnk\Downloads\Game Show Theme Style Music. [ ezmp3.cc ].wav")
        player.Play()
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles StartBtn.Click
        SignInForm.Show()
        Me.Hide()
    End Sub
End Class
