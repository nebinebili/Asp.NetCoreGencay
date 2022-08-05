using GencayExample.Models;
using GencayExample.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace GencayExample.Controllers
{
    public class ProductController : Controller
    {
        #region Contollera datanin gonderilmesi
        /*
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product{ Id=1, ProductName="A product", Quantity=10},
                new Product{ Id=2, ProductName="B product", Quantity=15},
                new Product{ Id=3, ProductName="C product", Quantity=20}
            };

            #region Model əsaslı məlumat ötürülməsi

            //return View(products);

            #endregion

            #region Data oturme kontrolleri

            #region ViewBag
            ViewBag.Mehsullar = products;
            #endregion

            #region ViewData
            ViewData["Mehsullar"] = products;
            #endregion

            string data = JsonSerializer.Serialize(products);
            #region TempData
            TempData["Mehsullar"] = data;
            #endregion
            

            #endregion


            return RedirectToAction("Index2");
        }

        public IActionResult Index2()
        {
            var data = TempData["Mehsullar"].ToString();

            var products = JsonSerializer.Deserialize<List<Product>>(data);

            return View();
        }
        */
        #endregion

        #region Bir nece obyekti viewa gonderilmesi


        //public IActionResult GetProducts()
        //{
        //    Product product = new Product
        //    {
        //        Id = 1,
        //        ProductName = "A Product",
        //        Quantity = 15
        //    };

        //    User user = new User
        //    {
        //        Id = 1,
        //        Name = "Nabi",
        //        LastName = "Nabili"
        //    };

        //    // ViewModel vasitesile
        //    /*UserProduct userProduct = new UserProduct
        //    {
        //        User = user,
        //        Product = product
        //    };
        //    */

        //    //return View(userProduct);

        //    // Tuple vasitesi ile
        //    var userProduct = (product, user);

        //    return View(userProduct);
        //}
        #endregion

        public IActionResult GetProducts()
        {
            return View();
        }
    }
}
