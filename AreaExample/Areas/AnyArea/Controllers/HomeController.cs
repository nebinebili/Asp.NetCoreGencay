using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaExample.Areas.AnyArea.Controllers
{
    [Area("any_area")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var data = TempData["data"];
            return View();
        }
    }
}
