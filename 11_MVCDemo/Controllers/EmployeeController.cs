using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _11_BusinessLayer;

namespace _11_MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            List<Employee> employees = employeeBusinessLayer.Employees.ToList();

            return View(employees);
        }
        
        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {
            //Employee newEmployee = new Employee();
            //newEmployee.Name = formCollection["Name"];
            //newEmployee.Gender = formCollection["Gender"];
            //newEmployee.City = formCollection["City"];
            //newEmployee.DateOfBirth = Convert.ToDateTime( formCollection["DateOfBirth"]);
            if (ModelState.IsValid)
            {
                Employee newEmployee = new Employee();
                UpdateModel<Employee>(newEmployee);

                EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
                employeeBusinessLayer.AddEmployee(newEmployee);

                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            EmployeeBusinessLayer ebl = new EmployeeBusinessLayer();
            Employee employee = ebl.Employees.Single(emp => emp.ID == id);

            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                EmployeeBusinessLayer ebl = new EmployeeBusinessLayer();
                ebl.UpdateEmployee(employee);

                return RedirectToAction("Index");
            }

            return View(employee);
        }
    }
}