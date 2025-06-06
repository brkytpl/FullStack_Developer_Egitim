﻿using mvc_modelfirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace mvc_modelfirst.Controllers
{
    [AllowAnonymous]
    public class AdminController : Controller
    {

        Model1Container db= new Model1Container();
        // GET: Admin
       
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(Kullanicilar kullanici)
        {
            var sorgu = from x in db.KullanicilarSet where x.KullaniciAdi == kullanici.KullaniciAdi && x.Sifre == kullanici.Sifre select x;
            if(sorgu.Count() > 0)
            {
                FormsAuthentication.SetAuthCookie(kullanici.KullaniciAdi,false);
                return RedirectToAction("AdminPanel");
            }
            else
            {
                TempData["Mesaj"] = "Hatalı giriş yapılmaya çalışıldı";
                return RedirectToAction("Index");
            }

            
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index","Admin");
        }
        [Authorize]
        public ActionResult AdminPanel()
        {
            return View();
        }

    }
}