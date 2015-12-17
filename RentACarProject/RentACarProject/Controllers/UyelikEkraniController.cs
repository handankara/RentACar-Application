using RentACarProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACarProject.Controllers
{
    public class UyelikEkraniController : Controller
    {
        //
        // GET: /UyelikEkrani/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {

            RentACarDBEntities db = new RentACarDBEntities();
            Uyeler uye = new Uyeler();

            uye.uyeAd = form["ad"].Trim();
            uye.uyeSoyad = form["soyad"].Trim();
            uye.uyeEmail = form["email"].Trim();
            uye.uyeSifre = form["sifre"].Trim();

            db.Uyeler.Add(uye);
            db.SaveChanges();

            return View();
        }
    
    }
}
