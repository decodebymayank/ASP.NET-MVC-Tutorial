using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_MVC_Project.Models;
namespace ASP.NET_MVC_Project.Controllers
{
    public class MController : Controller
    {
       
        public ActionResult Index()
        {
            var data = getemp();
            return View(data);
            
            //If need to use different view
            //return View("viewname",data)
        }

        private mymodel getemp()
        {
            return new mymodel()
            {
                Id = 1,
                Name = "Test"
            };
        }
    }
}