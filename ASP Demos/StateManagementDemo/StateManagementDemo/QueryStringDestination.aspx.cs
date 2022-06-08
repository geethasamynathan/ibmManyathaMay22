using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementDemo
{
    public partial class QueryStringDestination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoadPreviousPageData_Click(object sender, EventArgs e)
        {
            string tempdata = Request.QueryString["name"].ToString();
            tempdata += "- " + Request.QueryString["companyname"].ToString();
            Label1.Text = tempdata;
        }
    }
}