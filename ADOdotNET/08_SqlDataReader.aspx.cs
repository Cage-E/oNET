using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace ADOdotNET
{
    public partial class SqlDataReader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //this is an excercise and correct way to do is to get the discounted price directly from table

            string DC = ConfigurationManager.ConnectionStrings["LocalDBConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(DC))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tblProductInventory", con);
                using (var reader = cmd.ExecuteReader())
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ID");
                    table.Columns.Add("Name");
                    table.Columns.Add("Price");
                    table.Columns.Add("Discounted price");

                    while (reader.Read())
                    {
                        int originalPrice = Convert.ToInt32(reader["UnitPrice"]);
                        double discountedPrice = 0.9 * originalPrice;

                        DataRow dataRow = table.NewRow();
                        dataRow["ID"] = reader["ProductID"];
                        dataRow["Name"] = reader["ProductName"];
                        dataRow["Price"] = originalPrice;
                        dataRow["Discounted Price"] = discountedPrice;

                        table.Rows.Add(dataRow);
                    }
                    GridView1.DataSource = table;
                    GridView1.DataBind();

                }
            }
        }
    }
}