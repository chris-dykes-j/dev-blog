using DevBlog.Models;
using Microsoft.EntityFrameworkCore;

namespace DevBlog.Context;

public class BlogDbContext : DbContext
{
    public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options) { }
    
    public DbSet<BlogEntry> BlogEntries { get; set; }
}