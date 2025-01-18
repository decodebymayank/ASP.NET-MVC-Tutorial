using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Project.Controllers
{
    public class LayoutViewController : Controller
    {
        // GET: LayoutView
        public ActionResult Index()
        {
            return View("Index","NLayout");
        }
    }
}