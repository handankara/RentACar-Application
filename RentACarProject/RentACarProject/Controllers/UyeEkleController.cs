using RentACarProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACarProject.Controllers
{
    public class UyeEkleController : Controller
    {
        //
        // GET: /UyeEkle/
        RentACarDBEntities db = new RentACarDBEntities();

        public ActionResult UyeEkle()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult UyeEkle(Uyeler u)
        {
            using(db)
            {
                db.Uyeler.Add(u);
                db.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
