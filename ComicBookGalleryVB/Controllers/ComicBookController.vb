Imports System.Web.Mvc
Imports ComicBookGalleryVB.Models
Imports ComicBookGalleryVB.Data

Namespace Controllers
    Public Class ComicBookController
        Inherits Controller

        Private _comicBookRepository As ComicBookRepository = Nothing

        Public Sub New()
            _comicBookRepository = New ComicBookRepository()
        End Sub

        Function Index() As ActionResult
            Dim comicBooks = _comicBookRepository.GetComicBooks()

            Return View(comicBooks)
        End Function

        Function Detail(ByVal id As Integer?) As ActionResult
            If id Is Nothing Then
                Return HttpNotFound()
            End If

            Dim comicBook = _comicBookRepository.GetComicBook(id)

            Return View(comicBook)
        End Function

    End Class
End Namespace
