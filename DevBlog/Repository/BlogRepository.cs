using DevBlog.Models;

namespace DevBlog.Repository;

public class BlogRepository : IBlogRepository
{
    public IEnumerable<BlogEntry> GetAllEntries()
    {
        var result = new List<BlogEntry>();
        var entries = Directory.GetFiles("/run/media/chris/Extra/blog-entries");
        foreach (var entry in entries)
        {
            var id = Path.GetFileName(entry)[..^4];
            result.Add(GetBlogEntry(int.Parse(id)));
        }
        return result.OrderByDescending(x => x.Id);
    }

    public BlogEntry GetBlogEntry(int id)
    {
        var file = File.ReadAllLines($"/run/media/chris/Extra/blog-entries/{id}.txt");
        
        return new BlogEntry
        {
            Id = id,
            Title = file[0],
            Description = file[1],
            Date = GetBlogDate(file[2]),
            Content = GetBlogContent(file)
        };
    }
    
    #region Helper Methods

    private DateTime GetBlogDate(string date)
    {
        var year = int.Parse(date[6..10]);
        var month = int.Parse(date[3..5]);
        var day = int.Parse(date[..2]);
        var hour = int.Parse(date[11..13]);
        var minute = int.Parse(date[14..]);
        return new DateTime(year, month, day, hour, minute, 0);
    }

    private string GetBlogContent(string[] file)
    {
        var content = "";
        for (var i = 3; i < file.Length; i++)
            content += file[i];
        return content;
    }
    
    #endregion
}