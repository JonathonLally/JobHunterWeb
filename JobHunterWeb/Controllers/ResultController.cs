using JobHunterWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobHunterWeb.Controllers
{
    public class ResultController : Controller
    {
        // GET: Result
        public ActionResult ResultView()
        {
            var search = new Search() { Name = "Test" };
            return View();
        }
    }
}