namespace BlazorWebApp.Models;

public class FullCourseModel
{
    public string Id { get; set; } = null!;
    public string? ImageUri { get; set; }
    public string? ImageHeaderUri { get; set; }
    public bool IsBestSeller { get; set; }
    public bool IsDigital { get; set; }
    public string[]? Categories { get; set; }
    public string? Title { get; set; }
    public string? Ingress { get; set; }
    public decimal StarRating { get; set; }
    public string? Reviews { get; set; }
    public string? LikesInPercent { get; set; }
    public string? Likes { get; set; }
    public string? Hours { get; set; }
    public  List<Author>? Authors { get; set; }
    public Prices? Prices { get; set; }
    public Content? Content { get; set; }
}


public class Content
{
    public string? Description { get; set; }
    public string[]? Includes { get; set; }
    public virtual List<ProgramDetailItem>? ProgramDetails { get; set; }
}

public class ProgramDetailItem
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}
