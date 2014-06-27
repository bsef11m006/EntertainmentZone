using Ead_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ead_Project.Controllers
{
    public class SignUpController : Controller
    {
        private EntertainmentEntities1 db = new EntertainmentEntities1();

        IUserRepository iu;


        public SignUpController(IUserRepository u)
        {
            iu = u;
        }

        //
        // GET: /SignUp/
        public ActionResult CreateAccount()
        {
            return View();
        }
        public ActionResult Intrests()
        {
            return View();
        }

        public ActionResult CheckInterest() 
        {
            int a=0 ;
            int s=0 ;
            int o=0 ;
            int m =0;
            int t =0;
            int q = 0;
            int c =0;
            if (Request["text1"] != null)
                s = 1;
            if (Request["text2"] != null)
                a = 1;
            if (Request["text3"] != null)
                c = 1;
            if (Request["text4"] != null)
                o = 1;
            if (Request["text5"] != null)
                q = 1;
            if (Request["text6"] != null)
                t = 1;
            if (Request["text7"] != null)
                m = 1;
            string usr = Request["usr"];
            ViewBag.us = usr;
            Interest i= new Interest();
            i.Username = usr;
            i.Action = a;
            i.Cell = c;
            i.Games = o;
            i.Music = m;
            i.Sports = s;
            i.Technology = t;
            i.Quote = q;
            iu.SaveInterest(i);
            return Redirect("/Main/MainPage?u="+usr);
                





        }
        public JsonResult CheckUser()
        {
            string u = Request["U"];
            if(iu.checkUser(u))
                return this.Json(true, JsonRequestBehavior.AllowGet);
            return this.Json(false, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult AddUser(User u)
        {
            //string n = Request["Name"];
            //string u = Request["Username"];
            //string e = Request["Email"];
            //string p = Request["Password"];
            //string d = Request["DOB"];
            //string g = Request["Gender"];
            //string i = Request["Image"];
            
            //User us = new User();
            //us.Name = n;
            //us.Username = u;
            //us.Email = e;
            //us.Password = p;
            //us.DOB = d;
            //us.Gender = g;
            //us.Image = i;
            

            if (ModelState.IsValid)
            {
                for (int j = 0; j < Request.Files.Count; j++)
                {
                    HttpPostedFileBase file = Request.Files[0];
                    string path = System.IO.Path.GetFileName(file.FileName);
                    file.SaveAs(Server.MapPath(@"~\Images" + file.FileName));
                    u.Image = path;
                }

                ViewBag.usr = u.Username;
                iu.Save(u);
                //return Redirect("/Main/MainPage");
                return View("Intrests");
            }
            return View("CreateAccount");
                
        }
       
    }
}
