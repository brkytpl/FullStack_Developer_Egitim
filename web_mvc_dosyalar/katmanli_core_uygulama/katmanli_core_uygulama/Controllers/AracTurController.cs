using Data;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace katmanli_core_uygulama.Controllers
{
    public class AracTurController : Controller
    {
        private readonly MyContext _db;
        public AracTurController(MyContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.AracTuru.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AracTuru aracturu)
        {
           _db.AracTuru.Add(aracturu);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)

        {
            var sorgu = _db.AracTuru.Find(id);
            return View(sorgu);
        }
        [HttpPost]
        public IActionResult Edit(AracTuru aracturu)
        {
            _db.Update(aracturu);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id) 
        {
            var sorgu = _db.AracTuru.Find(id);
            _db.AracTuru.Remove(sorgu);
            _db.SaveChanges();
            return RedirectToAction("index");
        }

    }
}
