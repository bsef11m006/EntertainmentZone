using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ead_Project.Models;

namespace Ead_Project.Controllers
{
    public class MainController : Controller
    {
        IUserRepository iu;
        public MainController(IUserRepository i)
        {
            iu = i;
        }
        private EntertainmentEntities1 db = new EntertainmentEntities1();
        //
        // GET: /Main/

        public JsonResult GetLink()
        {
            string val = Request["L"];
            string link = iu.getLink(val);
            return this.Json(link, JsonRequestBehavior.AllowGet);
        }
        public ActionResult MainPage()
        {
            string usr = Request["u"];
            ViewBag.u = usr;
            List<string> intr = new List<string>();
            List<Interest> li = new List<Interest>();
            li.Add(db.Interests.Find(usr));
            if (li[0] != null)
            {
                if (li[0].Action == 1)
                    intr.Add("Action");

                if (li[0].Cell == 1)
                    intr.Add("Cell Phone");

                if (li[0].Games == 1)
                    intr.Add("Online Games");

                if (li[0].Music == 1)
                    intr.Add("Music");

                if (li[0].Quote == 1)
                    intr.Add("Quotes");

                if (li[0].Technology == 1)
                    intr.Add("Technology");

                if (li[0].Sports == 1)
                    intr.Add("Sports");
            }

            ViewBag.inter = intr ;
                return View();
        }
        public ActionResult FirstPage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LinkAdd()
        {
            string intr = Request["interest"];
            string usr = Request["usr"];
            string l = Request["link"];
            if (intr.Equals("Action Movies"))
            {
                Models.Action a = new Models.Action();
                a.Link = l;
                db.Actions.Add(a);
                db.SaveChanges();
            }
            if (intr.Equals("Online Games"))
            {
                Models.Game a = new Models.Game();
                a.Link = l;
                db.Games.Add(a);
                db.SaveChanges();

            }
            if (intr.Equals("Sports"))
            {
                Models.Sport a = new Models.Sport();
                a.Link = l;
                db.Sports.Add(a);
                db.SaveChanges();

            }
            if (intr.Equals("Technology"))
            {
                Models.Technology a = new Models.Technology();
                a.Link = l;
                db.Technologies.Add(a);
                db.SaveChanges();

            }
            if (intr.Equals("Quotes"))
            {
                Models.Quote a = new Models.Quote();
                a.Link = l;
                db.Quotes.Add(a);
                db.SaveChanges();

            }
            if (intr.Equals("Music"))
            {
                Models.Muzic a = new Models.Muzic();
                a.Link = l;
                db.Muzics.Add(a);
                db.SaveChanges();

            }
            if (intr.Equals("Cell Phones"))
            {
                Models.Cell_Phone a = new Models.Cell_Phone();
                a.Link = l;
                db.Cell_Phone.Add(a);
                db.SaveChanges();

            }
            return Redirect("/Main/MainPage?u="+usr);
        }
        [HttpPost]
        public ActionResult LinkSearch()
        {
            return View();
        }
        public ActionResult SearchLink()
        {
            return View();
        }
        public ActionResult AddLink()
        {
            string us = Request["us"];
            ViewBag.u = us;
            return View();
        }
        public ActionResult UserProfile()
        {
            string u = Request["u"];
            ViewBag.u = u;
            List<User> user = new List<User>();
            user.Add(db.Users.Find(u));
            if (user[0] != null)
            {
                ViewBag.n = user[0].Name;
                ViewBag.d = user[0].DOB;
                ViewBag.e = user[0].Email;
                ViewBag.p = user[0].Password;
                ViewBag.g = user[0].Gender;
                ViewBag.i = user[0].Image;
            }

            return View();
        }
        

    }
}
