using Microsoft.AspNetCore.Mvc;

namespace DevBlog.Controllers;

public class AboutController : Controller
{
    [Route("/about")]
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}