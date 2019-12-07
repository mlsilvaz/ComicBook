@modeltype ComicBookGalleryVB.Models.ComicBook

@Code
    ViewBag.Title = Model.DisplayText
    ViewBag.ShowBackBar = True
End Code

<!DOCTYPE html>

<h2>@Model.DisplayText</h2>

<div class="row">
    <div class="col-md-6">
        <div class="well">
            <h5><label>Series Title:</label> @Model.SeriesTitle</h5>
            <h5><label>Issue #:</label> @Model.IssueNumber</h5>
            <h5><label>Favorite:  </label> @(If(Model.Favorite = True, "Yes", "No"))</h5>
            @If Model.Artists.Length > 0 Then
                @<h5>Artrists :  </h5>
                @<div>
                    <ul>
                        @For Each artist In Model.Artists
                            @<li>@artist.Role: @artist.Name</li>
                        Next
                    </ul>
                </div>
            End If
        </div>
        <h5>Description</h5>
        <div>@Html.Raw(Model.DescriptionHtml)</div>
    </div>
    <div Class="col-md-6">
        <img src = "/Images/@Model.CoverImageFileName"
             alt="@Model.DisplayText" class="img-responsive" />
    </div>
</div>


<h1>@Model.SeriesTitle</h1>
<h2>Issue #@Model.IssueNumber</h2>