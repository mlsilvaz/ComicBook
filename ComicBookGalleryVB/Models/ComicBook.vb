Namespace Models
    Public Class ComicBook
        Public Id As Integer
        Public SeriesTitle As String
        Public IssueNumber As Integer
        Public DescriptionHtml As String
        Public Artists As Artist()
        Public Favorite As Boolean
        Private newPropertyValue As String

        Public ReadOnly Property DisplayText() As String
            Get
                Return SeriesTitle & " #" & IssueNumber
            End Get
        End Property

        Public ReadOnly Property CoverImageFileName()
            Get
                Return StrConv(Replace(SeriesTitle, " ", "-"), vbLowerCase) & "-" & IssueNumber & ".jpg"
            End Get
        End Property
    End Class
End Namespace