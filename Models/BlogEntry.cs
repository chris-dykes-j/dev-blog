namespace DevBlog.Models;

public class BlogEntry
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public string Content { get; set; }
}