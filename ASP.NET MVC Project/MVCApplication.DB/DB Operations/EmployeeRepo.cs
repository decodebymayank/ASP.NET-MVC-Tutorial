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
    }
}
