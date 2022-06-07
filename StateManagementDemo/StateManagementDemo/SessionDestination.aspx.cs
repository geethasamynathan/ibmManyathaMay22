using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementDemo
{
    public partial class SessionDestination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null && Session["password"] != null)
            {
                
                Label1.Text = Session["username"].ToString() + "- " + Session["password"].ToString();
            }
            else
            {
                Response.Redirect("SessionSource.aspx");
            }

        }

       
    }
}