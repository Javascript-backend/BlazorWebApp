namespace BlazorWebApp.Models;

public class CourseCardModel
{
    public string? Id { get; set; }
    public string? Title { get; set; }
    public bool IsBestSeller { get; set; }
    public bool IsDigital { get; set; }
    public List<string>? Categories { get; set; }
    public string? ImageUri { get; set; }
    public List<Author>? Authors { get; set; }
    public Prices? Prices { get; set; }
    public string? Hours { get; set; }
    public string? Likes { get; set; }
    public string? LikesInPercent { get; set; }
}

public class Author
{
    public string? Name { get; set; }
}

public class Prices
{
    public decimal Price { get; set; }
    public decimal Discount { get; set; }
}
