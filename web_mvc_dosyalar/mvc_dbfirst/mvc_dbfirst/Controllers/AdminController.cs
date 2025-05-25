using mvc_dbfirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_dbfirst.Controllers
{
    public class AdminController : Controller
    {
        mvc_dbfirstEntities db=new mvc_dbfirstEntities();
        // GET: Admin Listeleme
        public ActionResult Index()
        {
            return View(db.Table_1.ToList());
        }
        //Veri Kaydetme
        public ActionResult Kaydet()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Kaydet(Table_1 urun)
        {
            db.Table_1.Add(urun);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //Veri Güncelleme
        public ActionResult Düzenle(int id)
        {
            //var guncelle=db.Table_1.Where(x=>x.id==id).FirstOrDefault();
            //return View(guncelle);
            return View(db.Table_1.Where(x => x.id == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Düzenle(Table_1 urun)
        {
            db.Table_1.AddOrUpdate(urun);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //Veri Silme
        public ActionResult Sil(int id)
        {
            return View(db.Table_1.Where(x => x.id == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Sil(int id,Table_1 urun)
        {
            var silinen=db.Table_1.Where(x=>x.id == id).FirstOrDefault();
            db.Table_1.Remove(silinen);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}