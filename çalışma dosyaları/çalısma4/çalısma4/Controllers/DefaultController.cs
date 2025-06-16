using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace çalısma4.Controllers
{
    public class DefaultController : Controller
    {
        mvc_dbfirstEntities db= new mvc_dbfirstEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View(db.Table_1.ToList());
        }
        public ActionResult Kaydet()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Kaydet(Table_1 table_1)
        {
            db.Table_1.Add(table_1);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Table_1 table_1)
        {
            db.Table_1.Add(table_1);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}