using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateDemo
{
    public partial class _018_BindingDropdown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("Countries.xml"));

                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "CountryName";
                DropDownList1.DataValueField = "CountryId";
                DropDownList1.DataBind();

                ListItem li = new ListItem("Select", "-1");
                DropDownList1.Items.Insert(0, li);

            }
        }
    }
}