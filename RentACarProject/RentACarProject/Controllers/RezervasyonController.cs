using RentACarProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace RentACarProject.Controllers
{
    public class RezervasyonController : Controller
    {
        //
        // GET: /Rezervasyon/

        public ActionResult Index()
        {
            return View();
        }

<<<<<<< HEAD
=======
        [HttpPost]
        public ActionResult Yeni(ViewModel.RezervasyonVM model)//veritabanına kayıt işlemi
        {
            model.Rec.uyeID = Convert.ToInt32(Session["sessionUyeID"]);//Sessiondan aldık. 
            model.Rec.aracID = Convert.ToInt32(Session["sessionAracID"]);//Sessiondan aldık. 

            RentACarDBEntities db = new RentACarDBEntities();//tarih,saat değerlerini Yeni View dan alıyoruz.
            db.Rezervasyonlar.Add(model.Rec);
            db.SaveChanges();

            //return View("RezervasyonBasarili", model);
           
            return RedirectToAction("Index", "FilterAndList");
        }

>>>>>>> origin/master
        public ActionResult Yeni(int aracId)//bu action çalıştırdığımızda Yeni View daki alanları dolduracak kısım
        {
            ViewModel.RezervasyonVM model = new ViewModel.RezervasyonVM();

            Session["sessionAracID"] = aracId.ToString();

            model.Rec = new Models.Rezervasyonlar();

            model.Rec.rezTarih = DateTime.Today;
            //model.Rec.rezSaat = DateTime.Now;
            //model.Rec.aracID = aracId;

            RentACarDBEntities db = new RentACarDBEntities();
            var arac = db.Araclar.Where(c => c.aracID == aracId).SingleOrDefault();

            if (arac != null)
            {
                model.AracMarka = arac.aracMarka;
                model.AracModel = arac.aracModel;
                model.YakıtTipi = arac.aracYakitTipi;
                model.AracVitesTipi = arac.aracVitesTipi;
            }

            return View(model);
        }


        [HttpPost]
        public ActionResult Yeni(ViewModel.RezervasyonVM model)//veritabanına kayıt işlemi
        {
            model.Rec.uyeID = Convert.ToInt32(Session["sessionUyeID"]);//Sessiondan aldık. 
            model.Rec.aracID = Convert.ToInt32(Session["sessionAracID"]);//Sessiondan aldık. 

            RentACarDBEntities db = new RentACarDBEntities();//tarih,saat değerlerini Yeni actiondan alıyoruz.
            db.Rezervasyonlar.Add(model.Rec);
            db.SaveChanges();

            return RedirectToAction("Index", "FilterAndList");
        }

    }
}
