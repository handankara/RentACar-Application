using RentACarProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACarProject.Controllers
{
    public class AracListeleController : Controller
    {
        //
        // GET: /AracListele/

        public ActionResult Index()
        {
            var entities = new RentACarDBEntities();
            var liste = entities.Araclar.ToList();
            return View(liste);
        }

    }
}
