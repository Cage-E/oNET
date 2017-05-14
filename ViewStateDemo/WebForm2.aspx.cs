using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateDemo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        int clickCount = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ViewState["Clicks"] != null)
            {
                clickCount = (int)ViewState["Clicks"] + 1;
            }
            TextBox1.Text = clickCount.ToString();
            ViewState["Clicks"] = clickCount;
        }
    }
}