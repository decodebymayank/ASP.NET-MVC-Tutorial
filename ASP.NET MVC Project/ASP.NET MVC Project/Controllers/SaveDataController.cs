using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyApp.Models;

using MVCApplication.DB.DB_Operations;

namespace ASP.NET_MVC_Project.Controllers
{
    public class SaveDataController : Controller
    {
        EmployeeRepo repo = null;
        public SaveDataController()
        {
             repo = new EmployeeRepo();

        }
        // GET: SaveData
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel model)
        {
            if(ModelState.IsValid)
            {
                int id = repo.AddEmployee(model);
                if(id>0)
                {
                    ModelState.Clear();
                    ViewBag.IsSuccess = "Data Added";
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult GetEmpData()
        {
            var getempdata = repo.GetAllEmployees();
            return View(getempdata);
        }
        [HttpGet]
        public ActionResult GetEmpDataById(int id)
        {
            var getempdata = repo.GetEmployeeData(id);
            return View(getempdata);
        }
    }
}