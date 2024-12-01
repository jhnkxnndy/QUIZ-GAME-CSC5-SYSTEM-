﻿Imports MySql.Data.MySqlClient

Public Class TutorialInterface

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
    Private Sub TutorialInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TutorialForm.TopLevel = False
        Guna2Panel1.Controls.Add(TutorialForm)
        TutorialForm.Show()
        TutorialForm.BringToFront()
    End Sub



    Public Sub UpdateScoreLabel(username As String)
        Dim db As New MY_DB()
        db.openConnection()

        ' SQL query to get the user's score
        Dim query As String = "SELECT Score FROM players_tb WHERE Username = @username"
        Dim command As New MySqlCommand(query, db.getConnection)

        ' Add parameters to the query
        command.Parameters.AddWithValue("@username", username)

        ' Execute the query and read the score
        Dim reader As MySqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            Dim score As Integer = If(IsDBNull(reader("Score")), 0, Convert.ToInt32(reader("Score")))

            ' Make sure to update the PointsLbl on MainInterface
            Dim mainInterface As MainInterface = Application.OpenForms.OfType(Of MainInterface)().FirstOrDefault()

            If mainInterface IsNot Nothing Then
                mainInterface.UpdatePointsLbl(score)
            End If
        End If

        ' Clean up
        reader.Close()
        db.closeConnection()
    End Sub


    Private Function LoadUserProfileImage(username As String) As Byte()
        Dim imageBytes As Byte() = Nothing
        Dim query As String = "SELECT picture FROM players_tb WHERE Username = @Username"

        Using sqlConn As New MySqlConnection(connectionString)
            Using sqlCmd As New MySqlCommand(query, sqlConn)
                sqlCmd.Parameters.AddWithValue("@Username", username)
                sqlConn.Open()
                Using reader As MySqlDataReader = sqlCmd.ExecuteReader()
                    If reader.Read() AndAlso Not IsDBNull(reader("picture")) Then
                        imageBytes = CType(reader("picture"), Byte()) ' Get the profile picture as byte array

                    End If
                End Using

                sqlConn.Close()

            End Using
        End Using

        Return imageBytes
    End Function


    Private Sub ResetPanelColors()
        ' Loop through all panels and reset their colors to white
        For Each panelName As String In GlobalState.PanelColors.Keys.ToList()
            ' Assuming the panels are named Q1Panel, Q2Panel, etc.
            Dim panelControl As Control = Me.Controls.Find(panelName, True).FirstOrDefault()
            If panelControl IsNot Nothing Then
                panelControl.BackColor = Color.White ' Reset the panel color to white
            End If

            ' Optionally, reset the color in the dictionary to ensure consistency
            GlobalState.PanelColors(panelName) = Color.White
        Next
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class