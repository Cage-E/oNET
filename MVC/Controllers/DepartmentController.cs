using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class DepartmentController : Controller
    {
        public ActionResult Index()
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Department> departments = employeeContext.Departments.ToList();
//            One or more validation errors were detected during model generation:

//MVC.Models.Department: : EntityType 'Department' has no key defined. Define the key for this EntityType.
//Departments: EntityType: EntitySet 'Departments' is based on type 'Department' that has no keys defined.

            return View(departments);
        }
    }
}