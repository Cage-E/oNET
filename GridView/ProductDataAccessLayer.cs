using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace GridView
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public class ProductDataAccessLayer
    {
        public static List<Products> GetAllProducts()
        {
            List<Products> productList = new List<Products>();

            string CS = ConfigurationManager.ConnectionStrings["LDBC"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("select * from tblProductInventory", con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Products product = new Products();

                    product.Id = Convert.ToInt32(reader["ProductId"]);
                    product.Name = reader["ProductName"].ToString();
                    product.Price = Convert.ToInt32(reader["UnitPrice"]);

                    productList.Add(product);
                }
            }
            return productList;
        }
    }
}