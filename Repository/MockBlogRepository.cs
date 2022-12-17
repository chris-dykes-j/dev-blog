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
                Description = "Why on earth are there two different types of null in JavaScript?!", 
                Content = "Why on earth are there two different types of null in JavaScript?!" 
            },
            new BlogEntry
            {
                Id = 2,
                Title = "COBOL is a sin against humanity",
                Date = new DateTime(2022, 12, 17),
                Description = "COBOL is terrible and other hot takes.",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque fermentum purus " +
                          "at odio venenatis dapibus. Sed congue odio at neque tempor, nec placerat ante suscipit. " +
                          "Etiam laoreet tortor ut magna tempus interdum. Pellentesque quis imperdiet quam, non imperdiet neque. " +
                          "Aenean maximus tellus sed posuere pretium. Aenean semper nec nisl eu ullamcorper.\n\n" +
                          "Integer accumsan, ante ut faucibus porttitor, tortor lacus vestibulum massa, ut vehicula tortor dolor " +
                          "ultricies erat. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus." +
                          " Mauris commodo, sem quis accumsan cursus, est libero bibendum eros, id ultricies diam sem eget sem. " +
                          "Ut nec ornare mauris, a blandit libero. Duis non euismod urna. Curabitur pellentesque libero " +
                          "at elit convallis ornare.\n\n" +
                          "<img src='images/logo.png' class='entry-image'/> \n\n" +
                          "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque fermentum purus " +
                          "at odio venenatis dapibus. Sed congue odio at neque tempor, nec placerat ante suscipit. " +
                          "Etiam laoreet tortor ut magna tempus interdum. Pellentesque quis imperdiet quam, non imperdiet neque. " +
                          "Aenean maximus tellus sed posuere pretium. Aenean semper nec nisl eu ullamcorper.\n\n" +
                          "Integer accumsan, ante ut faucibus porttitor, tortor lacus vestibulum massa, ut vehicula tortor dolor " +
                          "ultricies erat. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus." +
                          " Mauris commodo, sem quis accumsan cursus, est libero bibendum eros, id ultricies diam sem eget sem. " +
                          "Ut nec ornare mauris, a blandit libero. Duis non euismod urna. Curabitur pellentesque libero " +
                          "at elit convallis ornare." 
            }
        };

    public IEnumerable<BlogEntry> GetAllEntries()
    {
        return _entries.OrderByDescending(x => x.Date);
    }

    public BlogEntry GetBlogEntryById(int id)
    {
        return _entries[id];
    }
}