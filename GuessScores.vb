Imports System.Media
Imports System.Numerics

Public Class GuessScores
    Private player As New SoundPlayer()
    Private Sub GuessScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyPanelColors()
        player = New SoundPlayer("C:\Users\johnk\Downloads\Game Show Countdown _ ROYALTY FREE Background Music [ ezmp3.cc ].wav")
        player.PlayLooping()
    End Sub

    Public Sub ApplyPanelColors()
        If GlobalState.PanelColors.ContainsKey("L1Panel") Then
            L1Panel.FillColor = GlobalState.PanelColors("L1Panel") ' Apply the color stored in the dictionary
        End If

        If GlobalState.PanelColors.ContainsKey("L2Panel") Then
            L2Panel.FillColor = GlobalState.PanelColors("L2Panel")
        End If

        If GlobalState.PanelColors.ContainsKey("L3Panel") Then
            L3Panel.FillColor = GlobalState.PanelColors("L3Panel")
        End If

        If GlobalState.PanelColors.ContainsKey("L4Panel") Then
            L4Panel.FillColor = GlobalState.PanelColors("L4Panel")
        End If

        If GlobalState.PanelColors.ContainsKey("L5Panel") Then
            L5Panel.FillColor = GlobalState.PanelColors("L5Panel")
        End If

        If GlobalState.PanelColors.ContainsKey("L6Panel") Then
            L6Panel.FillColor = GlobalState.PanelColors("L6Panel")
        End If

        If GlobalState.PanelColors.ContainsKey("L7Panel") Then
            L7Panel.FillColor = GlobalState.PanelColors("L7Panel")
        End If

        If GlobalState.PanelColors.ContainsKey("L8Panel") Then
            L8Panel.FillColor = GlobalState.PanelColors("L8Panel")
        End If

        If GlobalState.PanelColors.ContainsKey("L9Panel") Then
            L9Panel.FillColor = GlobalState.PanelColors("L9Panel")
        End If

        If GlobalState.PanelColors.ContainsKey("L10Panel") Then
            L10Panel.FillColor = GlobalState.PanelColors("L10Panel")
        End If
    End Sub


End Class