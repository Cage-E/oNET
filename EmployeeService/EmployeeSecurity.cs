using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webAPIDBAccess;

namespace EmployeeService
{
    public class EmployeeSecurity
    {
        public static bool Login(string username, string password)
        {
            using (WebAPILearningEntities entities = new WebAPILearningEntities())
            {
                return entities.Users.Any(user => user.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && user.Password == password);
            }
        }
    }
}