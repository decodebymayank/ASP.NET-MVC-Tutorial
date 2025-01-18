using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Project.Controllers
{
    public class TempDataFileController : Controller
    {
        
        public ActionResult M1()
        {
            TempData["nokey"] = "First Method";
            TempData.Keep();
            return View();
        }

        public ActionResult M2()
        {
            ViewBag.m2val = TempData["nokey"];
            TempData.Keep("nokey");
            return View();
        }

        public ActionResult M3()
        {
            ViewBag.m3val = TempData["key1"];
            return View();
        }
    }
}