using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SQLite;
using SQLitePCL;
using MobileHackathon2017.Models;

namespace MobileHackathon2017.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            var db = new SQLiteConnection("VLog");
            db.CreateTable<VisitorLog>();
        }
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public static void AddVisitor(SQLiteConnection db, int DL, string n, string TO)
        {
            var s = db.Insert(new VisitorLog()
            {
                DLID = 0,
                TimeIn = DateTime.Now,
                Name = n,
                TimeOut = TO
            });
        }
    }
}