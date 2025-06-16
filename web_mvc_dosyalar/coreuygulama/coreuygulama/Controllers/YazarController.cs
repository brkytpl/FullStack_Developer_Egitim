using coreuygulama.Data;
using coreuygulama.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreuygulama.Controllers
{
    public class YazarlarController : Controller
    {
        private readonly ApplicationDbContext _db;
        public YazarlarController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Yazarlars.ToList());
        }
        public IActionResult Kaydet()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Kaydet(Yazarlar yazarlar)
        {
            _db.Yazarlars.Add(yazarlar);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
