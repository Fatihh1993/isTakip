using kurtProje.ToDo.Web.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
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

            SetCookie();
            ViewBag.Cookie = GetCookie();

            return View();

        }
        [Route("kisiler/[action]")]
        public IActionResult Sonuc()
        {
            return View();
        }

        public IActionResult KayitOl()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KayitOl2(KullaniciKayitViewModel model)
        {
            //string ad= HttpContext.Request.Form["Ad"].ToString();
            // ViewBag.Ad = ad;
            if (ModelState.IsValid)
            {

            }
            ModelState.AddModelError(nameof(KullaniciKayitViewModel.Ad), "Ad Alanı gereklidir");
            ModelState.AddModelError("", "Modelle ilgili hata");
            ModelState.AddModelError("", "ikinci hata");
            return View("KayitOl", model);
        }

        public void SetCookie()
        {
            HttpContext.Response.Cookies.Append("kisi", "yavuz", new
                Microsoft.AspNetCore.Http.CookieOptions()
            {
                Expires = DateTime.Now.AddDays(20),
                HttpOnly = true,
                SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict
            });
        }

        public string GetCookie()
        {
            return HttpContext.Request.Cookies["kisi"];
        }

        public IActionResult PageError(int code)
        {
            @ViewBag.Code = code;
            if (code == 404)
            {
                ViewBag.ErrorMessage = "sayfa bulanamadı";
            }
            return View();
        }


        public IActionResult Error()
        {
            var exceptionHandlerPathFeature =
            HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            ViewBag.Path = exceptionHandlerPathFeature.Path;
            ViewBag.MEssage = exceptionHandlerPathFeature.Error.Message;
            return View();
        }

        public IActionResult Hata()
        {
            throw new Exception("Hata Oluştu");
        }



    }
}
