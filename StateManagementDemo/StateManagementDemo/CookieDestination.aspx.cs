using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementDemo
{
    public partial class CookieDestination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoadCookieInfo_Click(object sender, EventArgs e)
        {
            //Label1.Text = Request.Cookies["cname"].Value.ToString() 
            //    + " - " + Request.Cookies["ccode"].Value;

            HttpCookie cookie= Request.Cookies["Mycookie"];
            if (cookie != null)
            {
                Label1.Text = cookie["name"].ToString() + " - " + cookie["code"].ToString();
            }
            else
                Label1.Text = "cookie Expired";
        }
    }
}