using DevBlog.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DevBlog.Controllers;

public class HomeController : Controller
{
    private IBlogRepository _blogRepository;

    public HomeController(IBlogRepository blogRepository)
    {
        _blogRepository = blogRepository;
    }
    
    [Route("/")]
    [HttpGet]
    public IActionResult Index()
    {
        return View(_blogRepository.GetAllEntries());
    } 
}