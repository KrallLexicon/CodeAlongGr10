﻿using Microsoft.AspNetCore.Mvc;

namespace CodeAlongGr10.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Message = "This is a message from the controller!";
            return View();
        }
    }
}
