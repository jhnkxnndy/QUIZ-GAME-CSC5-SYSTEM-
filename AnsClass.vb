Public Class AnsClass
    ' A list to store correct answers, where True means correct and False means incorrect.
    Private Shared CorrectAnswers As New List(Of Boolean)()

    ' Add a correct answer to the list
    Public Shared Sub AddCorrectAnswer(isCorrect As Boolean)
        CorrectAnswers.Add(isCorrect)
    End Sub

    ' Get the number of correct answers by manually counting them
    Public Shared Function CorrectAnswersCount() As Integer
        Dim correctCount As Integer = 0
        ' Loop through the list and count the True values (correct answers)
        For Each answer As Boolean In CorrectAnswers
            If answer = True Then
                correctCount += 1
            End If
        Next
        Return correctCount
    End Function

    ' Reset the correct answers list (for when starting a new round or session)
    Public Shared Sub ResetAnswers()
        CorrectAnswers.Clear()
    End Sub
End Class
