using DevBlog.Models;

namespace DevBlog.Repository;

public class MockBlogRepository : IBlogRepository
{
    private readonly List<BlogEntry> _entries = new()
        {
            new BlogEntry
            {
                Id = 0,
                Title = "Why PHP sucks",
                Date = new DateTime(2022, 12, 16),
                Description = "Why PHP is terrible and other mean things to say.",
                Content = "Php is really bad because I personally don't like it."
            },
            new BlogEntry
            {
                Id = 1,
                Title = "JavaScript for Dummies",
                Date = new DateTime(2022, 10, 28),
                Description = "This won't help",
                Content = "Why on earth are there two different types of null in JavaScript?!" 
            }
        };

    public IEnumerable<BlogEntry> GetAllEntries()
    {
        return _entries;
    }

    public BlogEntry GetBlogEntryById(int id)
    {
        return _entries[id];
    }
}