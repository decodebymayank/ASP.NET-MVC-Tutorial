using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Project.Controllers
{
    public class StandardHelperController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(string name = null)
        {
            return View();
        }
    }
}