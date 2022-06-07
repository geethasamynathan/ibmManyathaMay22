using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementDemo
{
    public partial class HiddenFieldDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLoad_Click(object sender, EventArgs e)
        {
            Label1.Text = HiddenField1.Value;
        }

        protected void btnStore_Click(object sender, EventArgs e)
        {
            HiddenField1.Value=txtInfo.Text;
            txtInfo.Text=String.Empty;
        }
    }
}