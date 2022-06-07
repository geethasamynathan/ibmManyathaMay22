using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementDemo
{
    public partial class CookieSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGoNext_Click(object sender, EventArgs e)
        {

            ////Normal Cookie
            //Response.Cookies["cname"].Value = txtCountryName.Text;
            //Response.Cookies["ccode"].Value = txtCountryCode.Text;
            //Response.Redirect("CookieDestination.aspx");

            //HttpCookie

            HttpCookie cookie = new HttpCookie("Mycookie");
            cookie["name"]=txtCountryName.Text;
            cookie["code"]=txtCountryCode.Text;
            Response.Cookies.Add(cookie);
            cookie.Expires = DateTime.Now.AddSeconds(10);
            Response.Redirect("CookieDestination.aspx");
            
        }
    }
}