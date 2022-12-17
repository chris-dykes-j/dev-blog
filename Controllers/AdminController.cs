using DevBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevBlog.Controllers;

public class AdminController : Controller
{
    [Route("/admin")]
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(BlogEntry entry)
    {
        return Ok();
    }
}