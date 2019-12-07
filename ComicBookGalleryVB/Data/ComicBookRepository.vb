Imports ComicBookGalleryVB.Models

Namespace Data
    Public Class ComicBookRepository
        Private Shared _comicBooks As ComicBook() = New ComicBook() {New ComicBook() With
                {
                    .Id = 1,
                    .SeriesTitle = "The Amazing Spider-Man' Marco",
                    .IssueNumber = 700,
                    .DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
                    .Artists = New Artist() {New Artist() With {.Name = "Dan Slott", .Role = "Script"},
                        New Artist() With {.Name = "Humberto Ramos", .Role = "Pencils"},
                        New Artist() With {.Name = "Victor Olazaba", .Role = "Inks"},
                        New Artist() With {.Name = "Edgar Delgado", .Role = "Colors"},
                        New Artist() With {.Name = "Chris Eliopoulos", .Role = "Letters"}
                },
                .Favorite = False
            },
            New ComicBook() With
                {
                    .Id = 2,
                    .SeriesTitle = "The Amazing Spider-Man",
                    .IssueNumber = 657,
                    .DescriptionHtml = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
                    .Artists = New Artist() {New Artist() With {.Name = "Dan Slott", .Role = "Script"},
                        New Artist() With {.Name = "Marcos Martin", .Role = "Pencils"},
                        New Artist() With {.Name = "Marcos Martin", .Role = "Inks"},
                        New Artist() With {.Name = "Muntsa Vicente", .Role = "Colors"},
                        New Artist() With {.Name = "Joe Caramagna", .Role = "Letters"}
                },
            .Favorite = False
            },
            New ComicBook() With
                {
                    .Id = 3,
                    .SeriesTitle = "Bone",
                    .IssueNumber = 50,
                    .DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious ""Crown of Horns"".</p>",
                    .Artists = New Artist() {New Artist() With {.Name = "Jeff Smith", .Role = "Script"},
                        New Artist() With {.Name = "Jeff Smith", .Role = "Pencils"},
                        New Artist() With {.Name = "Jeff Smith", .Role = "Inks"},
                        New Artist() With {.Name = "Jeff Smith", .Role = "Letters"}
                },
            .Favorite = False
            }}

        Public Function GetComicBook(ByVal id As Integer) As ComicBook
            Dim comicBookToReturn As ComicBook = Nothing

            For Each comicBook As ComicBook In _comicBooks
                If comicBook.Id = id Then
                    comicBookToReturn = comicBook
                    Exit For
                End If
            Next
            Return comicBookToReturn
        End Function

        Public Function GetComicBooks() As ComicBook()
            Return _comicBooks
        End Function

    End Class
End Namespace