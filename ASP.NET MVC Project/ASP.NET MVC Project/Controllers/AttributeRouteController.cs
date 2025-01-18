using ASP.NET_MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP.NET_MVC_Project.Controllers
{
    //For taking out common part
    [RoutePrefix("allstudents")]

    public class AttributeRouteController : Controller
    {
        //[Route("allstudents")]
        [Route("")]
        public ActionResult Getallstudents()
        {
            var data = Students();
            return View(data);
        }

        //[Route("allstudents/{id}")]
        [Route("{id:int}")]
        public ActionResult Getsinglestudent(int id)
        {
            var data = Students().Where(s => s.Id == id).FirstOrDefault();
            return View(data);
        }

        [Route("{id}")]
        public string kucbhi(string id)
        {
            return id;
        }

        [Route("~/newmethod")]
        public string Aboutmethod(string id)
        {
            return "About Method";
        }

        private List<Students> Students()
        {
            return new List<Students>()
            {
                new Students()
                {
                    Id = 100,
                    Name = "Name1",
                    Address = "Add1"
                },
                new Students()
                {
                    Id = 101,
                    Name = "Name2",
                    Address = "Add2"
                },
                new Students()
                {
                    Id = 102,
                    Name = "Name3",
                    Address = "Add3"
                },
            };
        }
    }
}