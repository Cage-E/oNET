using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index(int departmentId)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employees = employeeContext.Employees.Where(emp => emp.DepartmentId == departmentId).ToList();

            //{ "Invalid column name 'Department_DeptId'."} : had to remove the list<Employee> property from department model

            return View(employees);
        }


        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.Employees.Single(x => x.EmployeeId == id);

            return View(employee);
        }
    }
}