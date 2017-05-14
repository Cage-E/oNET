using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace ADOdotNET
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LocalDBConnection"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                string commandText = "select * from tblEmployee where Name like @employeeName";
                cmd.CommandText = (commandText);
                cmd.Parameters.AddWithValue("@employeeName", TextBox1.Text + "%");
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();                
            }

        }
    }
}