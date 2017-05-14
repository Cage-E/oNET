using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using webAPIDBAccess;

namespace EmployeeService.Controllers
{
    public class EmployeesController : ApiController
    {
        [BasicAuthentication]
        public HttpResponseMessage Get(string gender="all")
        {
            string username = Thread.CurrentPrincipal.Identity.Name;
            using (WebAPILearningEntities entities = new WebAPILearningEntities())
            {
                switch (username)
                {
                    case "male":
                        return Request.CreateResponse(HttpStatusCode.OK, entities.Employees.Where(e => e.Gender.ToLower() == "male").ToList());
                    case "female":
                        return Request.CreateResponse(HttpStatusCode.OK, entities.Employees.Where(e => e.Gender.ToLower() == "female").ToList());
                    default:
                        return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
            }
        }

        public HttpResponseMessage Get(int id)
        {
            try
            {
                using (WebAPILearningEntities entities = new WebAPILearningEntities())
                {
                    var entity = entities.Employees.FirstOrDefault(e => e.ID == id);
                    if (entity != null)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, entity);
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound, "Emoloyee with ID = " + id.ToString() + " was not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        public HttpResponseMessage Post([FromBody] Employee employee)
        {
            using (WebAPILearningEntities entities = new WebAPILearningEntities())
            {
                entities.Employees.Add(employee);
                entities.SaveChanges();

                var message = Request.CreateResponse(HttpStatusCode.Created, employee);
                message.Headers.Location = new Uri(Request.RequestUri + employee.ID.ToString());
                return message;
            }
        }

        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (WebAPILearningEntities entities = new WebAPILearningEntities())
                {
                    var entity = entities.Employees.FirstOrDefault(x => x.ID == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with ID = " + id.ToString() + "was not found.");
                    }
                    else
                    {
                        entities.Employees.Remove(entity);
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        public HttpResponseMessage PUT(int id, Employee empoloyee)
        {
            try
            {
                using (WebAPILearningEntities entities = new WebAPILearningEntities())
                {
                    var entity = entities.Employees.FirstOrDefault(x => x.ID == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with ID = " + id.ToString() + "was not found.");
                    }
                    else
                    {
                        entity.FirstName = empoloyee.FirstName;
                        entity.LastName = empoloyee.LastName;
                        entity.Gender = empoloyee.Gender;
                        entity.Salary = empoloyee.Salary;

                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
