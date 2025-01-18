using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult WithoutView()
        {
            return View();
        }
        public ActionResult Namechange()
        {
            //If view name change , then pass name of it 
            return View("ReNameChange");
        }

        public ActionResult FolderNameChange()
        {
            //If name of folder is also change 
            //path of our view which is in different folder
            return View("~/View/NewView/myview.cshtml");
        }
    }
}