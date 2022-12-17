namespace DevBlog.Models;

public class BlogEntry
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public DateTime Date { get; set; }
    public string Description { get; set; } = null!;
    public string Content { get; set; } = null!;
}