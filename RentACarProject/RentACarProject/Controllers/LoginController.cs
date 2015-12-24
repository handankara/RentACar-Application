using RentACarProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace RentACarProject.Controllers
{
    public class LoginController : Controller
    {
        RentACarDBEntities db = new RentACarDBEntities();

      /*  public ActionResult Index()
        {
            
            return View();
        }*/

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                using (RentACarDBEntities db = new RentACarDBEntities())
                {
                    var v = db.Uyeler.Where(a => a.uyeEmail.Equals(model.Email) && a.uyeSifre.Equals(model.Sifre)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["sessionUyeID"] = v.uyeID.ToString();
                        Session["sessionUyeEmail"] = v.uyeEmail.ToString();
                        Session["sessionUyeSifre"] = v.uyeSifre.ToString();

                        return RedirectToAction("Index","Home");

                    }
                }
            }
            return View(model);
        }
        
    }
}
