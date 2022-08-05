using Microsoft.AspNetCore.Mvc;
using ModulDesignExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModulDesignExample.ViewComponets
{
    public class PersonellerViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Personel> datas = new List<Personel>
            {
                new Personel{ Name="Nabi",LastName="Nabili"},
                new Personel{ Name="Kamal",LastName="Aliyev"},
                new Personel{ Name="Farhad",LastName="Aliyev"},
            };
            return View(datas);
        }
    }
}
