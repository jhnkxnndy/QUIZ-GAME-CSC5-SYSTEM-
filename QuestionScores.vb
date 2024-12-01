Imports System.Media
Imports System.Numerics
Imports Guna.UI2.WinForms

Public Class QuestionScores

    Private player As New SoundPlayer()
    Public Sub StartFlickering(isCorrect As Boolean)


    End Sub
    Private Sub AnswerButton_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Q1Panel_Paint(sender As Object, e As PaintEventArgs) Handles Q1Panel.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub QuestionScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyPanelColors()

        player = New SoundPlayer("C:\Users\johnk\Downloads\Game Show Countdown _ ROYALTY FREE Background Music [ ezmp3.cc ].wav")
        player.PlayLooping()
    End Sub
    Public Sub ApplyPanelColors()
        If GlobalState.PanelColors.ContainsKey("Q1Panel") Then
            Q1Panel.FillColor = GlobalState.PanelColors("Q1Panel") 
        End If

        If GlobalState.PanelColors.ContainsKey("Q2Panel") Then
            Q2Panel.FillColor = GlobalState.PanelColors("Q2Panel")
        End If

        If GlobalState.PanelColors.ContainsKey("Q3Panel") Then
            Q3Panel.FillColor = GlobalState.PanelColors("Q3Panel")
        End If

        If GlobalState.PanelColors.ContainsKey("Q4Panel") Then
            Q4Panel.FillColor = GlobalState.PanelColors("Q4Panel")
        End If

        If GlobalState.PanelColors.ContainsKey("Q5Panel") Then
            Q5Panel.FillColor = GlobalState.PanelColors("Q5Panel")
        End If

        If GlobalState.PanelColors.ContainsKey("Q6Panel") Then
            Q6Panel.FillColor = GlobalState.PanelColors("Q6Panel")
        End If

        If GlobalState.PanelColors.ContainsKey("Q7Panel") Then
            Q7Panel.FillColor = GlobalState.PanelColors("Q7Panel")
        End If

        If GlobalState.PanelColors.ContainsKey("Q8Panel") Then
            Q8Panel.FillColor = GlobalState.PanelColors("Q8Panel")
        End If

        If GlobalState.PanelColors.ContainsKey("Q9Panel") Then
            Q9Panel.FillColor = GlobalState.PanelColors("Q9Panel")
        End If

        If GlobalState.PanelColors.ContainsKey("Q10Panel") Then
            Q10Panel.FillColor = GlobalState.PanelColors("Q10Panel")
        End If
    End Sub

End Class
