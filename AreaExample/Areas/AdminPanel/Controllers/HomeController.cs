using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaExample.Areas.AdminPanel.Controllers
{
    [Area("admin_panel")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            TempData["data"] = "Men fexr edirem Azerbaycanliyam";
            return RedirectToAction("Index","Home",new {area="any_area"});
        }
    }
}
