using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_Demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SampleDataContext dbContext = new _01_Demo.SampleDataContext();
            GridView1.DataSource = dbContext.Employees.Where(emp => emp.Gender == "Male").OrderBy(emp => emp.Salary);
                //from employee in dbContext.Employees
                //                   where employee.Gender == "Male"
                //                   orderby employee.Salary
                //                   select employee;
            GridView1.DataBind();
        }
    }
}