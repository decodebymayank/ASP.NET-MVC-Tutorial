using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_MVC_Project.Models;

namespace ASP.NET_MVC_Project.Controllers
{
    public class TemplatedHtmlHelpersController : Controller
    {
        
        public ActionResult Index()
        {
            TemplatedHtmlHelpers obj = new TemplatedHtmlHelpers();
            obj.Name = "Omkara";
            obj.num = 1000000;
            return View(obj);
        }



        public ActionResult Edit()
        {
            TemplatedHtmlHelpers obj = new TemplatedHtmlHelpers();
            obj.Name = "Omkara";
            obj.num = 1000000;
            return View(obj);
            
        }
    }
}