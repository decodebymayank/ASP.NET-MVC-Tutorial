using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Models;


namespace MVCApplication.DB.DB_Operations
{
    public class EmployeeRepo
    {
        public int AddEmployee(EmployeeModel model)
        {
            using(var context = new EmployeeDBEntities())
            {
                Employee emp = new Employee()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Code = model.Code
                    
                };
                if(model.Address!=null)
                {
                    emp.Address = new Address()
                    {
                        Detail = model.Address.Detail,
                        Country = model.Address.Country,
                        State = model.Address.State,
                    };
                }
                context.Employees.Add(emp);
                context.SaveChanges();

                return emp.id;
            }
        }

        public List<EmployeeModel> GetAllEmployees()
        {
            using(var context = new EmployeeDBEntities())
            {
                var getdata = context.Employees.Select(s=>new EmployeeModel()
                {
                    id = s.id,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    Email = s.Email,
                    Code = s.Code,
                    Address = new AddressModel()
                    {
                        Id = s.id,
                        Detail = s.Address.Detail,
                        Country = s.Address.Country,
                        State = s.Address.State,
                    }
                }).ToList();

                return getdata;
            }
        }

        public EmployeeModel GetEmployeeData(int id)
        {
            using(var context = new EmployeeDBEntities())
            {
                var getdata = context.Employees.Where(s=>s.id == id).
                    Select(s => new EmployeeModel()
                {
                    id = s.id,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    Email = s.Email,
                    Code = s.Code,
                    Address = new AddressModel()
                    {
                        Id = s.id,
                        Detail = s.Address.Detail,
                        Country = s.Address.Country,
                        State = s.Address.State,
                    }
                }).FirstOrDefault();
                return getdata;
            }
        }
    }
}
