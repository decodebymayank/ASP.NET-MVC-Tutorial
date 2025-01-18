using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_MVC_Project.Models;

namespace ASP.NET_MVC_Project.Controllers
{
    public class LooselyBindingValidationController : Controller
    {
        // GET: LooselyBindingValidation
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult submitdata(Students data)
        {
            if(ModelState.IsValid)
            {
                return View();
            }
            return View("Index");
        }
    }
}