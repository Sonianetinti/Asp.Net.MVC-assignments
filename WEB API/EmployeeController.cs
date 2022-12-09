using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ASPWEBApiTest.Models;

namespace ASPWEBApiTest.Controllers
{
    public class EmployeeController : ApiController
    {
        Entities db=new Entities();
        
        //Add post request
        public string Post(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return "Employee Added";
        }
        //Get  All records
        public IEnumerable<Employee> Get()
        {
            return db.Employees.ToList();
        }
        //get single employee detail
        public Employee Get(int id)
        {
           Employee employee= db.Employees.Find(id);
            return employee;
        }
        //updating the record
        public string Put(int id,Employee employee)
        {
            var employee_ = db.Employees.Find(id);
            employee_.FirstName = employee.FirstName;
            employee_.LastName = employee.LastName;
            employee_.City = employee.City;
            db.Entry(employee_).State=System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return "Employee Updated ";
        }
        public string Delete(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return "Deleted";
        }
    }
}
