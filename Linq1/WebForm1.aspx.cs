﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext dataContext = new Linq1.DataClasses1DataContext();
            GridView1.DataSource = from student in dataContext.Students
                                   where student.Gender == "Male"
                                   select student;
            GridView1.DataBind();
        }
    }
}