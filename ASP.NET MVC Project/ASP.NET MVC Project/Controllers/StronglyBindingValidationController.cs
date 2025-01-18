using ASP.NET_MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Project.Controllers
{
    public class StronglyBindingValidationController : Controller
    {
        // GET: StronglyBindingValidation
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult stronglybinding(Students data)
        {
            return View();
        }
    }
}