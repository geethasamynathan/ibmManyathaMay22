using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp1
{
    public partial class MultiViewDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                MultiView1.ActiveViewIndex = 0;
            }
        }

        protected void btnNext1_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void btnNext2_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
        }

        protected void btnNext3_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 3;
            lblFname.Text = txtFirstName.Text;
            lblLname.Text = txtLastName.Text;
            lblCourse1.Text = txtCourse.Text;
            lblBranch1.Text = txtBranch.Text;
            lblEmail1.Text = txtEmail.Text;
            lblContactNO.Text = txtContactNo.Text;
            lblCity.Text = txtCity.Text;

              
        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }
    }
}