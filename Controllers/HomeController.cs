﻿using Microsoft.AspNetCore.Mvc;

namespace DevBlog.Controllers;

public class HomeController : Controller
{
    [Route("/")]
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    } 
}