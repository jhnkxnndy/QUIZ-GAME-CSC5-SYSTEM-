Public Class AnsClass

    Private Shared CorrectAnswers As New List(Of Boolean)()

    Public Shared Sub AddCorrectAnswer(isCorrect As Boolean)
        CorrectAnswers.Add(isCorrect)
    End Sub

    Public Shared Function CorrectAnswersCount() As Integer
        Dim correctCount As Integer = 0
        
        For Each answer As Boolean In CorrectAnswers
            If answer = True Then
                correctCount += 1
            End If
        Next
        Return correctCount
    End Function

    
    Public Shared Sub ResetAnswers()
        CorrectAnswers.Clear()
    End Sub
End Class
