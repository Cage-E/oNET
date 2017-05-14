using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ADOdotNET
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LocalDBConnection"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();


                cmd.CommandText = "insert into tblEmployee values(8, 'Kian', 'Male', 1)";
                int rowsAffected = cmd.ExecuteNonQuery();
                Response.Write("Total number of rows inserted: " + rowsAffected + "<br/>");

                cmd.CommandText = "update tblEmployee set Name = 'Calara' where Id = 5";
                rowsAffected = cmd.ExecuteNonQuery();
                Response.Write("Total number of rows updated: " + rowsAffected + "<br/>");

                cmd.CommandText = "select count(Id)from tblEmployee";
                int numberOfRows = (int)cmd.ExecuteScalar();
                Response.Write("Total number of current rows: " + numberOfRows + "<br/>");

                cmd.CommandText = "Select * from tblEmployee";
                GridView1.DataSource = cmd.ExecuteReader(); ;
                GridView1.DataBind();
            }
            
            
        }
    }
}