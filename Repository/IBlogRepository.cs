using DevBlog.Models;

namespace DevBlog.Repository;

public interface IBlogRepository
{
    IEnumerable<BlogEntry> GetAllEntries();
    BlogEntry GetBlogEntry(int id); 
}