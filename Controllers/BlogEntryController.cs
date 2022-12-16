using DevBlog.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DevBlog.Controllers;

public class BlogEntryController : Controller
{
    private IBlogRepository _blogRepository;

    public BlogEntryController(IBlogRepository blogRepository)
    {
        _blogRepository = blogRepository;
    }
    
    [Route("/{id:int}")]
    public IActionResult Index(int id)
    {
        var blogEntry = _blogRepository.GetBlogEntryById(id);
        return View(blogEntry);
    }
}