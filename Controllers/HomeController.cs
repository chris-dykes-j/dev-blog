using Microsoft.AspNetCore.Mvc;

namespace DevBlog.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    } 
}