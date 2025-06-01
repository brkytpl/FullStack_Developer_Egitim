using mvc_modelfirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_modelfirst.Controllers
{
    [Authorize(Roles ="Admin")]
    public class KullanicilarController : Controller
    {
        Model1Container db=new Model1Container();
        // GET: Kullanicilar
        public ActionResult Index()
        {
            return View(db.KullanicilarSet.ToList());
        }
        //kaydet
        public ActionResult Kaydet()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Kaydet(Kullanicilar kullanici)
        {
            db.KullanicilarSet.Add(kullanici);
            db.SaveChanges();
            return RedirectToAction("Kaydet");
        }
    }
}