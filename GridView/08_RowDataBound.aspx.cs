using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Globalization;

namespace GridView
{
    public partial class _08_RowDataBound : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
            //{
            //    Response.Write(ci.Name + " => " + ci.DisplayName + "<br/>");
            //}
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            int salary;
            string formattedString;

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.Cells[5].Text == "US")
                {
                    salary = Convert.ToInt32(e.Row.Cells[4].Text);
                    formattedString = string.Format(new System.Globalization.CultureInfo("en-US"), "{0:c}", salary);
                    e.Row.Cells[4].Text = formattedString;
                }
                else if (e.Row.Cells[5].Text == "UK")
                {
                    salary = Convert.ToInt32(e.Row.Cells[4].Text);
                    formattedString = string.Format(new System.Globalization.CultureInfo("en-GB"), "{0:c}", salary);
                    e.Row.Cells[4].Text = formattedString;
                }
                else if (e.Row.Cells[5].Text == "Sweden")
                {
                    salary = Convert.ToInt32(e.Row.Cells[4].Text);
                    formattedString = string.Format(new System.Globalization.CultureInfo("sv-SE"), "{0:c}", salary);
                    e.Row.Cells[4].Text = formattedString;
                }
                else if (e.Row.Cells[5].Text == "Iran")
                {
                    salary = Convert.ToInt32(e.Row.Cells[4].Text);
                    formattedString = string.Format(new System.Globalization.CultureInfo("fa-IR"), "{0:c}", salary);
                    e.Row.Cells[4].Text = formattedString;
                }
                else if (e.Row.Cells[5].Text == "India")
                {
                    salary = Convert.ToInt32(e.Row.Cells[4].Text);
                    formattedString = string.Format(new System.Globalization.CultureInfo("en-IN"), "{0:c}", salary);
                    e.Row.Cells[4].Text = formattedString;
                }
            }
        }
    }
}