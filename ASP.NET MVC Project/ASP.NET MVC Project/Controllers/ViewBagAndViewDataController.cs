using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Project.Controllers
{
    public class ViewBagAndViewDataController : Controller
    {
       
        public ActionResult Index()
        {
            ViewBag.myname = "Rudra";
            ViewBag.Revenue = 1000000;
            ViewData["key1"] = "Omkara";
            ViewData["Listkey"] =  new List<string>() { "name1","name2","name3", "name4" };
            return View();
        }
    }
}