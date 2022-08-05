using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModulDesignExample.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ModulDesignExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var images = new List<string> { "img1.jpg", "img2.jpg" };
            return View(images);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
