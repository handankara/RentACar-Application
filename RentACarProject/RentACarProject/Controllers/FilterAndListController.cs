using RentACarProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACarProject.Controllers
{
    public class FilterAndListController : Controller
    {
        //
        // GET: /FilterAndList/
       RentACarDBEntities db = new RentACarDBEntities();

       public ActionResult Index(string sortOrder, string searchString)
       {
           ViewBag.MarkaSortParm = String.IsNullOrEmpty(sortOrder) ? "forMarka" : "";
           ViewBag.ModelSortParm = String.IsNullOrEmpty(sortOrder) ? "forModel" : "";
           ViewBag.YakitTipiSortParm = String.IsNullOrEmpty(sortOrder) ? "forYakitTipi" : "";

           var araclar = from s in db.Araclar select s;
                          
           if (!String.IsNullOrEmpty(searchString))
           {
               araclar = araclar.Where(s => s.aracMarka.Contains(searchString) || 
                                            s.aracModel.Contains(searchString) || 
                                            s.aracYakitTipi.Contains(searchString));
           }

           switch (sortOrder)
           {
               case "forMarka":
                   araclar = araclar.OrderByDescending(s => s.aracMarka);
                   break;

               case "forModel":
                   araclar = araclar.OrderByDescending(s => s.aracModel);
                   break;

               case "forYakitTipi":
                   araclar = araclar.OrderByDescending(s => s.aracYakitTipi);
                   break;

               default:
                   araclar = araclar.OrderBy(s => s.aracMarka);
                   break;
           }
           return View(araclar.ToList());
       }
     }
}
