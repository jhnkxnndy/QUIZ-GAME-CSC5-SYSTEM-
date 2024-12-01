Public Class UserSession
    Private Shared _username As String

    Public Shared Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property
End Class
