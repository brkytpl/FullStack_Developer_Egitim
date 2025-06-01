using mvc_modelfirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace mvc_modelfirst.Controllers
{
    public class HomeController : Controller
    {
        Model1Container db= new Model1Container();
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.x = "Ali";
            ViewData["y"] = 100;
            TempData["z"] = "Merhaba";
            Session["t"] = "nasılsın";
            Session.Timeout = 30;

            List<SelectListItem> kullanicilar = (from x in db.KullanicilarSet.ToList() select new SelectListItem
            {
                Text=x.KullaniciAdi, Value=x.Id.ToString()
            }).ToList();

            ViewBag.kullanici=kullanicilar;

            return View(db.UrunlerSet.ToList());
        }
    }
}