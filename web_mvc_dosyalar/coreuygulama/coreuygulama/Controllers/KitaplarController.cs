using coreuygulama.Data;
using coreuygulama.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreuygulama.Controllers
{
    public class KitaplarController : Controller
    {
        private readonly ApplicationDbContext _db;
        public KitaplarController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Kitaplars.ToList());
        }
        public IActionResult Kaydet()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Kaydet(Kitaplar kitaplar)
        {
            _db.Kitaplars.Add(kitaplar);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
