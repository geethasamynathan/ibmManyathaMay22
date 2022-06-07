using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementDemo
{
    public partial class ViewStateDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnStore_Click(object sender, EventArgs e)
        {
            ViewState["info"] = txtInfo1.Text;
            ViewState["Mobile"] = txtMobileno.Text;
            txtInfo1.Text = txtMobileno.Text = "";

        }
        protected void btnLoad_Click(object sender, EventArgs e)
        {
            Label1.Text=ViewState["info"].ToString() +"- -"+ViewState["Mobile"].ToString();
        }
    }
}