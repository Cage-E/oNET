using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03_WebApplication
{
    public partial class _02_jsWithAspNet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton lb = (LinkButton)e.Row.FindControl("LinkButton1");
                lb.Attributes.Add("onclick","return confirm('Are you sure to delete data record with ID = "+ DataBinder.Eval(e.Row.DataItem, "ID") +"');");
            }
        }
    }
}