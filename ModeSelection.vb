Public Class ModeSelection

    Private Sub ModeSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize if needed
    End Sub

    Private Sub CloseMainInterface()
        ' Get the instance of MainInterface or find it in open forms
        Dim mainInterface As MainInterface = Application.OpenForms.OfType(Of MainInterface)().FirstOrDefault()

        If mainInterface IsNot Nothing Then
            ' If MainInterface is open, close it
            mainInterface.Close()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
        CloseMainInterface()
        MCInterface.Show()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
        CloseMainInterface()
        GuessInterface.Show()

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Close()
        CloseMainInterface()
        FillInterface.Show()

    End Sub

End Class
