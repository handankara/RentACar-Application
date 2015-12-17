using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CodeFirstExample.Controllers
{
    public class CreateController : Controller
    {
        //
        // GET: /Create/
        DuyuruEntities db = new DuyuruEntities();
        public ActionResult Create()
        {

            return View();
        }

        
        

    }
}
