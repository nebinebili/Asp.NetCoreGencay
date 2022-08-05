using GencayExample2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GencayExample2.Controllers
{
 
    public class ProductController : Controller
    {
        #region Clientdan datalarin alinmasi
        //[HttpPost]
        //public IActionResult GiveData(IFormCollection datas) //IFormCollection ile formdan gelen datalari goturmek olur

        //public IActionResult GiveData(string txtValue1,string txtValue2,string txtValue3) // ve ya input name ile eyni olara deyisenler ile

        //public IActionResult GiveData(Product product) // Classin properylerine bind edilib goturmek mumkundu.
        #endregion

        #region Tuple ile post edilms datanin goturulmesi
        /*public IActionResult CreateProduct()
        {
            var tuple = (new Product(), new User());
            return View(tuple);
        }

        [HttpPost]
        public IActionResult CreateProduct([Bind(Prefix = "Item1")]Product product, [Bind(Prefix = "Item2")] User user)
        {
            return View();
        }
        */
        #endregion

        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                var errormessage = ModelState.ToList(); // key value ile error mesajlarini gosderir

                return View(product);
            }
            // Doing something


            return View();
        }
    }
}
