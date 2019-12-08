@modeltype ComicBookGalleryVB.Models.ComicBook()

@Code
    ViewBag.Title = "ComicBooks-UNMSM"
End Code

<h2>@ViewBag.Title</h2>

<div class="row">
    @For Each comicBook In Model
        @<div Class="col-md-3">
            <h4>@Html.ActionLink(comicBook.DisplayText, "Detail",
                     New With {.id = comicBook.Id})</h4>
            <a href="@Url.Action("Detail", New With {.id = comicBook.Id})">
                <img src="/Images/@comicBook.CoverImageFileName"
                     alt="@comicBook.DisplayText"
                     Class="img-responsive" />
            </a>
        </div>
    Next
</div>
