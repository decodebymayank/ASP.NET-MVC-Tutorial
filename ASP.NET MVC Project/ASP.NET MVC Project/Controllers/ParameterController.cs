using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Project.Controllers
{
    public class ParameterController : Controller
    {
        public string ID(int no)
        {
            return "String Type Method";
        }

        //Parameters which are mandatory
        public string Newmethod(int num , string name)
        {
            return "My Age is " + num + " And My name is " + name;
        }

        //Nullable parameter
        public string nparameter(int no , int ? val=null)
        {
            return "Id is " + no;
        }
    }
}