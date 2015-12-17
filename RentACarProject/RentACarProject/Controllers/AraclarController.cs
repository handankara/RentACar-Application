using RentACarProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACarProject.Controllers
{
    public class AraclarController : Controller
    {
        //
        // GET: /Araclar/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {

            RentACarDBEntities db = new RentACarDBEntities();
            Araclar arac = new Araclar();

            arac.aracMarka = form["marka"].Trim();
            arac.aracModel = form["model"].Trim();
            arac.aracYakitTipi = form["yakitTipi"].Trim();
            arac.aracRenk = form["renk"].Trim();
            arac.aracVitesTipi = form["vitesTipi"].Trim();

            db.Araclar.Add(arac);
            db.SaveChanges();

            Response.Redirect("/AracListele/Index.cshtml");

            return View();
           
         }

    }
}
