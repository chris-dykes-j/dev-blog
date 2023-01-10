using System.ComponentModel;
using DevBlog.Context;
using DevBlog.Models;
using Microsoft.EntityFrameworkCore;

namespace DevBlog.Repository;

public class BlogRepository : IBlogRepository
{
    private readonly BlogDbContext _context;

    public BlogRepository(BlogDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }
    
    public IEnumerable<BlogEntry> GetAllEntries()
    {
        return _context.BlogEntries.OrderByDescending(x => x.Date);
    }

    public BlogEntry GetBlogEntry(int id)
    {
        if (BlogEntryExists(id))
            return _context.BlogEntries.FirstOrDefault(x => x.Id == id)!;
        
        throw new ArgumentException();
    }

    private bool BlogEntryExists(int id)
    {
        return _context.BlogEntries.Any(x => x.Id == id);
    }
}