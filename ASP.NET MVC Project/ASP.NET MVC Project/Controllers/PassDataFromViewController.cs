using ASP.NET_MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_MVC_Project.Models;

namespace ASP.NET_MVC_Project.Controllers
{
    public class PassDataFromViewController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        /*Parameters name should not be different which u have passed in a view*/

        [HttpPost]
        public string PostUsingParameters(string FirstName, string LastName)
        {
            return "Your first name is : " + FirstName + " And last name is : " + LastName;
        }

        [HttpPost]
        public string PostUsingRequest()
        {
            //key need to be same which is in view
            string firstname = Request["FirstName"];
            string lastname = Request["LastName"];
            return "Your first name is : " + firstname + " And last name is : " + lastname;

        }

        [HttpPost]
        public string PostUsingFormCollection(FormCollection form)
        {
            //key need to be same which is in view
            string firstname = form["FirstName"];
            string lastname = form["LastName"];
            return "Data using Form Collection";

        }


        [HttpPost]
        public string PostUsingStronglyBinding(Students data)
        {
            
            return "Data using Strongly Type Binding : " + data.Name + data.Id;

        }
    }
}