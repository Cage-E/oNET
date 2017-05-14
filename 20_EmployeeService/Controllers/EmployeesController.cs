using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webAPIDBAccess;
namespace _20_EmployeeService.Controllers
{
    public class EmployeesController : ApiController
    {
        [Authorize]
        public IEnumerable<Employee> Get()
        {
            using (WebAPILearningEntities entities = new WebAPILearningEntities())
            {
                return entities.Employees.ToList();
            }
        }
    }
}
