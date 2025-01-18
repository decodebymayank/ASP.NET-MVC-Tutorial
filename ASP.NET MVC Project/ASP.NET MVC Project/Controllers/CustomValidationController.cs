using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_MVC_Project.Models;

namespace ASP.NET_MVC_Project.Controllers
{
    public class CustomValidationController : Controller
    {
        // GET: CustomValidation
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Postmethod(Customclas data)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                return View();
            }
            return View("Index");
        }
    }
}