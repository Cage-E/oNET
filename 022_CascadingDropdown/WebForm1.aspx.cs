using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Configuration;
using System.Data.SqlClient;

namespace _022_CascadingDropdown
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateContinentsDropdown();
            }
        }

        private void PopulateContinentsDropdown()
        {
            DropDownContinents.DataSource = GetData("spGetContinents", null);
            DropDownContinents.DataBind();

            ListItem selectContinent = new ListItem("Select a continent", "-1");
            DropDownContinents.Items.Insert(0, selectContinent);

            ListItem selectCountry = new ListItem("Select a country", "-1");
            DropDownCountries.Items.Insert(0, selectCountry);

            ListItem selectCity = new ListItem("Select a city", "-1");
            DropDownCities.Items.Insert(0, selectCity);

            DropDownCountries.Enabled = false;
            DropDownCities.Enabled = false;
        }
        private DataSet GetData (string StoreProcedure, SqlParameter inParameter )
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(StoreProcedure, con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                if (inParameter != null)
                {
                    da.SelectCommand.Parameters.Add(inParameter);
                }
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        protected void DropDownContinents_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownCities.Enabled = false;

            if (DropDownContinents.SelectedIndex == 0)
            {
                DropDownCountries.SelectedIndex = 0;
                DropDownCities.SelectedIndex = 0;
                DropDownCountries.Enabled = false;
                DropDownCities.Enabled = false;
            }
            else
            {
                DropDownCountries.Enabled = true;

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@ContinentId";
                parameter.Value = DropDownContinents.SelectedValue;
                DropDownCountries.DataSource= GetData("spGetCountriesByContinentId", parameter);
                DropDownCountries.DataBind();

                ListItem selectCountry = new ListItem("Select a country", "-1");
                DropDownCountries.Items.Insert(0, selectCountry);
            }
        }

        protected void DropDownCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownCountries.SelectedIndex == 0)
            {
                DropDownCities.SelectedIndex = 0;
                DropDownCities.Enabled = false;
            }
            else
            {
                DropDownCities.Enabled = true;

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@CountryId";
                parameter.Value = DropDownContinents.SelectedValue;
                DropDownCities.DataSource = GetData("spGetCitiesByCountryId", parameter);
                DropDownCities.DataBind();

                ListItem selectCity = new ListItem("Select a city", "-1");
                DropDownCities.Items.Insert(0, selectCity);
            }
        }
    }
}