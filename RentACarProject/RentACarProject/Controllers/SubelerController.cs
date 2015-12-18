using RentACarProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACarProject.Controllers
{
    public class SubelerController : Controller
    {
        //
        // GET: /Subeler/

        public ActionResult Index()
        {
            var entities = new RentACarDBEntities();
            var liste = entities.Subeler.ToList();
            return View(liste);

        }

    }
}
