using kurtProje.ToDo.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kurtProje.ToDo.Web.ViewComponents
{
    public class Urunler : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Yeni",new List<MusteriViewModel>()  {
                new MusteriViewModel(){Ad="Fatih1"},
                new MusteriViewModel(){Ad="Fatih1"},
                new MusteriViewModel(){Ad="Fatih1"},
                new MusteriViewModel(){Ad="Fatih1"},
                new MusteriViewModel(){Ad="Fatih1"},


               });
        }
    }
}
