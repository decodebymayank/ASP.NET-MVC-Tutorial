using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Project.Controllers
{
    public class HttpVerbsController : Controller
    {
        [HttpGet]
        public ActionResult Index(int id)
        {
            return View();
        }


        [HttpPost]
        public ActionResult Pmethod(int id)
        {
            return View();
        }

        [HttpPut]
        public ActionResult updatemethod(int id)
        {
            return View();
        }

        [HttpDelete]
        public ActionResult deletemethod(int id)
        {
            return View();
        }

    }
}