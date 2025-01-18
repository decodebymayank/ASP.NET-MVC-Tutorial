using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_MVC_Project.Models;

namespace ASP.NET_MVC_Project.Controllers
{
    public class RoutefileController : Controller
    {
        
        public ActionResult Getallstudents()
        {
            var data = Students();
            return View(data);
        }

        public ActionResult Getsinglestudent(int id)
        {
            var data = Students().Where(s=>s.Id == id).FirstOrDefault();
            return View(data);
        }


        public ActionResult Getstudentaddress(int id)
        {
            var data = Students().Where(s=>s.Id==id).Select(s=>s.Address);
            return View(data);
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