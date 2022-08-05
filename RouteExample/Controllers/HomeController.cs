using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RouteExample.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RouteExample.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [Route("[action]")]
        public IActionResult Index(int id,string x,int y)
        {
            return View();
        }
        [Route("[action]")]
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
