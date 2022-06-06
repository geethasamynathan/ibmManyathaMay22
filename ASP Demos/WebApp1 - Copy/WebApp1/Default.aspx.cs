using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            tblLogin tbl = new tblLogin();
            using(UserEntities entities = new UserEntities())
            {
                tbl = entities.tblLogins.FirstOrDefault(u => u.Username == txtUsername.Text 
                && u.Password == txtPassword.Text);
                if(tbl!=null)
                {
                    Response.Write("<script> alert('Login Success');</script>");
                }
                else
                {
                    Response.Write("<script> alert('Invalid credentials');</script>");
                }
            }
        }
    }
}