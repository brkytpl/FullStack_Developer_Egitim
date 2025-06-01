using mvc_modelfirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace mvc_modelfirst.Controllers
{
    [Authorize]
    public class UrunlerController : Controller
    {
        Model1Container db=new Model1Container();
        // GET: Urunler
        public ActionResult Index()
        {
            return View(db.UrunlerSet.ToList());
        }
        [HttpGet]//yazmasakta get oluyor
        public ActionResult Kaydet()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Kaydet(Urunler urun)
        {
            db.UrunlerSet.Add(urun);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        // Güncelle
        public ActionResult Guncelle(int id)
        {
            var guncelle=db.UrunlerSet.Where(x=>x.Id==id).FirstOrDefault();
            return View(guncelle);
        }
        [HttpPost]
        public ActionResult Guncelle(Urunler urun)
        {
            db.UrunlerSet.AddOrUpdate(urun);
            db.SaveChanges ();
            return RedirectToAction("Index");

        }
        //Sil
        public ActionResult Sil(int id)
        {
            var sıl = db.UrunlerSet.Where(x => x.Id == id).FirstOrDefault();
            db.UrunlerSet.Remove(sıl);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}