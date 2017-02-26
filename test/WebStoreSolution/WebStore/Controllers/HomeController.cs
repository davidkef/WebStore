using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            ViewBag.Message = "Your Product page.";

            return View();
        }
        public ActionResult CreateNew()
        {
            ViewBag.Message = "Your Product page.";

            return View();
        }
    }
}