using RentACarProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACarProject.Controllers
{
    public class AracEkleController : Controller
    {
     
        // GET: /AracEkle/

        RentACarDBEntities db = new RentACarDBEntities();

        public ActionResult AracEkle()
        {
           
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult AracEkle(Araclar a)
        {
            using (db)
            {
                db.Araclar.Add(a);
                db.SaveChanges();
            }
            return RedirectToAction("Index", "AracListele");
        }

    }
}
