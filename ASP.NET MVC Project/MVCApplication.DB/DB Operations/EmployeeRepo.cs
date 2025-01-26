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

        public bool UpdateEmpData(int id , EmployeeModel model)
        {
            using (var context = new EmployeeDBEntities())
            {
                var getdata = context.Employees.FirstOrDefault(s=>s.id == id);
                if(getdata!=null)
                {
                    getdata.FirstName = model.FirstName;
                    getdata.LastName = model.LastName;
                    
                }
                else
                {
                    return false;
                }

                context.SaveChanges();

                return true;
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

        public bool DeleteEmployee(int id)
        {
            using (var context = new EmployeeDBEntities())
            {
                //    var getdata = context.Employees.Where(s => s.id == id).FirstOrDefault();
                //    if(getdata!=null)
                //    {
                //        context.Employees.Remove(getdata);
                //        context.SaveChanges();
                //        return true;
                //    }
                //}

                var emp = new Employee()
                {
                    id = id,
                   
                   
                };
                emp.Address = new Address();
                emp.Address.Id = Convert.ToInt32(emp.AddressId);
                context.Entry(emp).State = System.Data.Entity.EntityState.Deleted;
                


                context.SaveChanges();
                return true;
            }
            
        }
    }
}
