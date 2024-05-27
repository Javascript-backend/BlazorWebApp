namespace BlazorWebApp.Models;

public class SaveCourseModel
{
    public string UserId { get; set; } = null!;
    public string CourseId { get; set; } = null!;

    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Title { get; set; } = null!;
}
