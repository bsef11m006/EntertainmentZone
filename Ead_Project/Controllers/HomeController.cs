using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ead_Project.Models;

namespace Ead_Project.Controllers
{
    public class HomeController : Controller
    {
        private EntertainmentEntities1 db = new EntertainmentEntities1();
        //

        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public JsonResult CheckLogin()
        {
            string u = Request["U"];
            string p = Request["P"];
            List<User> user = new List<User>();
            user.Add(db.Users.Find(u));
            if (user[0] != null)
                return this.Json(true, JsonRequestBehavior.AllowGet);
            return this.Json(false, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult MainPage()
        {
            string u = Request["Username"];
            string p = Request["Password"];
            List<User> user = new List<User>();
            user.Add(db.Users.Find(u));
            bool pwd=db.Users.Any(c=>c.Password.Equals(p));
            if (user[0] != null)
            {
                if(pwd)
                { 
                ViewBag.u = u;
                return Redirect("/Main/MainPage?u="+u);
                    }
                else
                    return View("Index");

            }
            else
                return View("Index");

        }

    }
}
