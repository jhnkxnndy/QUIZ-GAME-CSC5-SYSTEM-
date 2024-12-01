Module ScoreModule
    ' Points per correct answer
    Public PointsPerCorrectAnswer As Integer = 20

    ' Function to calculate total score
    Public Function CalculateTotalScore() As Integer
        ' Get the count of correct answers from AnsClass
        Dim correctCount As Integer = AnsClass.CorrectAnswersCount()
        ' Return the total score (correct answers * points per correct answer)
        Return correctCount * PointsPerCorrectAnswer
    End Function
End Module
