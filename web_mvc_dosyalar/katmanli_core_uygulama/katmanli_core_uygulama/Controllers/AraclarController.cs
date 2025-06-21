using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Model;

namespace katmanli_core_uygulama.Controllers
{
    public class AraclarController : Controller
    {
        private readonly MyContext _db;
        public AraclarController(MyContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Araclars.ToList());
        }

        public IActionResult Create()
        {
            List<SelectListItem> liste = (from x in _db.AracTuru select new SelectListItem
            {
                Text = x.AracTur,
                Value = x.Id.ToString()
            }).ToList();

            ViewBag.TurId = liste;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Araclar arac)
        {
            _db.Araclars.Add(arac);
            _db.SaveChanges();
             return RedirectToAction("index");
        }
        public IActionResult Edit(int id)
        {
            List<SelectListItem> liste = (from x in _db.AracTuru
                                          select new SelectListItem
                                          {
                                              Text = x.AracTur,
                                              Value = x.Id.ToString()
                                          }).ToList();

            ViewBag.TurId = liste;
            var sorgu= _db.Araclars.Find(id);
            return View(sorgu);
        }
        [HttpPost]
        public IActionResult Edit(Araclar arac)
        {
            _db.Araclars.Update(arac);
            _db.SaveChanges();
            return RedirectToAction("index");

        }
        public IActionResult Delete(int id)
        {
            var sorgu = _db.Araclars.Find(id);
            _db.Araclars.Remove(sorgu);
            _db.SaveChanges();
            return RedirectToAction("index");
        
        }
    }
}
