using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementDemo
{
    public partial class Sessionsource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            Session["username"] = txtUsername.Text;
            Session["password"] = txtPassword.Text;
            txtUsername.Text = txtPassword.Text = String.Empty;
            Response.Redirect("SessionDestination.aspx");
                
        }
    }
}