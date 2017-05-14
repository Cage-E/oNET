using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LinqDataContext dataContext = new LinqDataContext();

            GridView1.DataSource = from student in dataContext.Students
                                   where student.Gender == "Male"
                                   select student;
            GridView1.DataBind();
        }
    }
}