using DevBlog.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DevBlog.Controllers;

public class BlogEntryController : Controller
{
    private readonly IBlogRepository _blogRepository;

    public BlogEntryController(IBlogRepository blogRepository)
    {
        _blogRepository = blogRepository;
    }
    
    [Route("/{id:int}")]
    [HttpGet]
    public IActionResult Index(int id)
    {
        var blogEntry = _blogRepository.GetBlogEntry(id);
        return View(blogEntry);
    }
}