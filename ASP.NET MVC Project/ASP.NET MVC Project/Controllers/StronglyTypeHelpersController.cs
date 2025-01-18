using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP.NET_MVC_Project.Models;
using System.Web.Mvc;

namespace ASP.NET_MVC_Project.Controllers
{
    public class StronglyTypeHelpersController : Controller
    {
       
        public ActionResult Index()
        {
            StronglyType obj = new StronglyType();
            obj.No = 100;
            obj.Address = "XYZ";
            obj.Name = "Rudra";
            return View(obj);
        }

        [HttpPost]

        public ActionResult Index(string name = null)
        {
            return View();
        }
    }
}