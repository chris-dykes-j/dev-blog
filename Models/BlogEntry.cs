using System.ComponentModel.DataAnnotations.Schema;

namespace DevBlog.Models;

[Table("blogentry")]
public class BlogEntry
{
    [Column("id")]
    public int Id { get; set; }
    
    [Column("title")]
    public string Title { get; set; } = null!;
    
    [Column("date")]
    public DateTime Date { get; set; }
    
    [Column("description")]
    public string Description { get; set; } = null!;
    
    [Column("content")]
    public string Content { get; set; } = null!;
}