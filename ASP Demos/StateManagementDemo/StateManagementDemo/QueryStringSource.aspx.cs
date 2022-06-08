using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementDemo
{
    public partial class QueryStringSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            string url = "QueryStringDestination.aspx?name="+Server.UrlEncode(txtName.Text)
                +"&companyname="+Server.UrlEncode(txtCompanyName.Text);
            Response.Redirect(url);
        }
    }
}