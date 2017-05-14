using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Demo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EntityDataSource1_Selecting(object sender, Microsoft.AspNet.EntityDataSource.EntityDataSourceSelectingEventArgs e)
        {

        }

        protected void EntityDataSource1_Selecting1(object sender, Microsoft.AspNet.EntityDataSource.EntityDataSourceSelectingEventArgs e)
        {
            //using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeDBContext"].ConnectionString))
            //{
            //    SqlCommand cmd = new SqlCommand("select * from Departments", con);

            //    GridView1.DataSource = cmd.ExecuteReader();
            //    GridView1.DataBind();
            }

        protected void EntityDataSource1_Selecting2(object sender, Microsoft.AspNet.EntityDataSource.EntityDataSourceSelectingEventArgs e)
        {

        }

        protected void EntityDataSource1_Selecting3(object sender, Microsoft.AspNet.EntityDataSource.EntityDataSourceSelectingEventArgs e)
        {

        }
    }
    }
