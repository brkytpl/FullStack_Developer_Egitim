using coreuygulama.Data;
using coreuygulama.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreuygulama.Controllers
{
    public class KitapturController : Controller
    {
        private readonly ApplicationDbContext _db;
        public KitapturController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Turlers.ToList());
        }
        public IActionResult Kaydet()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Kaydet(Turler turler)
        {
            _db.Turlers.Add(turler);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Guncelle(int id)
        {
            var sorgu=_db.Turlers.Where(x=>x.id==id).FirstOrDefault();
            //var sorgu1 = _db.Turlers.Find(id);
            return View(sorgu);

        }
        [HttpPost]
        public IActionResult Guncelle(Turler turler)
        {
            _db.Update(turler);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Sil(int id)
        {
            var sorgu=_db.Turlers.Find(id);
            return View(sorgu);
        }
        [HttpPost]
        public IActionResult Sil(Turler turler)
        {
            _db.Turlers.Remove(turler);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
