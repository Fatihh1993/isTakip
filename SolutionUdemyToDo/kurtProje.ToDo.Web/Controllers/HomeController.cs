﻿using kurtProje.ToDo.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kurtProje.ToDo.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Isim = "Fatih";
            TempData["Isim"] = "Fatih";
            ViewData["Isim"] = "Fatih";
            return View(new List<MusteriViewModel>()  {
                new MusteriViewModel(){Ad="Fatih1"},
                new MusteriViewModel(){Ad="Fatih1"},
                new MusteriViewModel(){Ad="Fatih1"},
                new MusteriViewModel(){Ad="Fatih1"},
                new MusteriViewModel(){Ad="Fatih1"},


               });
        }
    }
}
