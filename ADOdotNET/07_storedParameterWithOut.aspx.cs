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
    public partial class storedParameterWithOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LocalDBConnection"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddEmployee", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", txtEmployeeName.Text);
                cmd.Parameters.AddWithValue("@Gender", ddlGender.SelectedValue);
                cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);

                SqlParameter outputParameter = new SqlParameter();
                outputParameter.ParameterName = "@newId";
                outputParameter.SqlDbType = System.Data.SqlDbType.Int;
                outputParameter.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outputParameter);

                con.Open();
                cmd.ExecuteNonQuery();

                string newEmployeeId = outputParameter.Value.ToString();
                lblMessage.Text = "New employee with ID = " + newEmployeeId + " added."; 
            }
        }
    }
}