using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobHunterWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A C# .NET Solution to Job Searching";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Me";

            return View();
        }

        public ActionResult Search()
        {
            ViewBag.Message = " Job Search";

            return View();
        }

        //All Code here should be in Search Controller, Move at some point
        public void TestButton()
        {
            Console.WriteLine("Testing Button");
        }
    }
}