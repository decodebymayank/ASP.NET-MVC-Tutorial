
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP.NET_MVC_Project
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();
            //routes.MapRoute
            //    (
            //        name :"allstudents",
            //        url : "RouteFile",
            //        defaults : new {Controller = "Routefile" , Action= "Getallstudents" }
            //    );

            //routes.MapRoute
            //    (
            //        name: "student",
            //        url: "RouteFile/{id}",
            //        defaults: new { Controller = "Routefile", Action = "Getsinglestudent" }
            //    );

            //routes.MapRoute
            //   (
            //       name: "students",
            //       url: "RouteFile/{id}",
            //       defaults: new { Controller = "Routefile", Action = "Getstudentaddress" }
            //   );



            

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Parameter", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
