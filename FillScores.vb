Imports System.Media
Imports System.Numerics

Public Class FillScores
    Private player As New SoundPlayer()
    Private Sub FillScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyPanelColors()
        player = New SoundPlayer("C:\Users\johnk\Downloads\Game Show Countdown _ ROYALTY FREE Background Music [ ezmp3.cc ].wav")
        player.PlayLooping()
    End Sub

    Public Sub ApplyPanelColors()
        If GlobalState.PanelColors.ContainsKey("F1Panel") Then
            F1Panel.FillColor = GlobalState.PanelColors("F1Panel")
        End If

        If GlobalState.PanelColors.ContainsKey("F2Panel") Then
            F2Panel.FillColor = GlobalState.PanelColors("F2Panel")
        End If

        If GlobalState.PanelColors.ContainsKey("F3Panel") Then
            F3Panel.FillColor = GlobalState.PanelColors("F3Panel")
        End If

        If GlobalState.PanelColors.ContainsKey("F4Panel") Then
            F4Panel.FillColor = GlobalState.PanelColors("F4Panel")
        End If

        If GlobalState.PanelColors.ContainsKey("F5Panel") Then
            F5Panel.FillColor = GlobalState.PanelColors("F5Panel")
        End If

        If GlobalState.PanelColors.ContainsKey("F6Panel") Then
            F6Panel.FillColor = GlobalState.PanelColors("F6Panel")
        End If

        If GlobalState.PanelColors.ContainsKey("F7Panel") Then
            F7Panel.FillColor = GlobalState.PanelColors("F7Panel")
        End If

        If GlobalState.PanelColors.ContainsKey("F8Panel") Then
            F8Panel.FillColor = GlobalState.PanelColors("F8Panel")
        End If

        If GlobalState.PanelColors.ContainsKey("F9Panel") Then
            F9Panel.FillColor = GlobalState.PanelColors("F9Panel")
        End If

        If GlobalState.PanelColors.ContainsKey("F10Panel") Then
            F10Panel.FillColor = GlobalState.PanelColors("F10Panel")
        End If
    End Sub

End Class