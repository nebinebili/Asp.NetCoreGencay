using ConfigurationExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly MailInfo _mailInfo;

        public HomeController(IConfiguration configuration,IOptions<MailInfo> mailInfo)
        {
            _configuration = configuration;

            // Option Pattern
            _mailInfo = mailInfo.Value; // mailinfo ile bagli butun melumatlar bunun icinde olacaq
        }

        public IActionResult Index()
        {
            // GetSection ile oxumaq
            MailInfo mailInfo=_configuration.GetSection("MailInfo").Get<MailInfo>();

            return View();
        }

        public IActionResult Privacy()
        {
            // Indexer ile oxumaq
            var examplestring= _configuration["Example"];
            var value = _configuration["Logging:LogLevel:Microsoft.Hosting.Lifetime"];

            //Get moetodu ile oxumaq
            var person = _configuration.GetSection("Person").Get(typeof(Person));
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
