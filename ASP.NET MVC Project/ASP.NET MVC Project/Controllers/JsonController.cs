using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_MVC_Project.Models;
using Newtonsoft.Json;

namespace ASP.NET_MVC_Project.Controllers
{
    public class JsonController : Controller
    {
        // GET: Json
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult JsonMethod()
        {
            JsonModel obj = new JsonModel()
            {
               Email = "omkaraob@gmail.com",
               Name = "Omkara Oberoi"
            };
            var jsondata = JsonConvert.SerializeObject(obj);

            return Json(jsondata,JsonRequestBehavior.AllowGet);
        }
    }
}