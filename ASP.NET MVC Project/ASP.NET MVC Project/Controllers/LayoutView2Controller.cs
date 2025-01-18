using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Project.Controllers
{
    public class LayoutView2Controller : Controller
    {
        // GET: LayoutView2
        [Route("GetList")]
        public ActionResult GetList()
        {
            return View("GetList" , "_NewLayout");
        }

        [Route("AddList")]
        public ActionResult AddList()
        {
            return View("AddList" , "_NewLayout");
        }
    }
}