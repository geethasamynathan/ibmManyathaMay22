using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementDemo
{
    public partial class ApplicationstateDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Application Title : " + Application["Title"];
            Label2.Text = "Application Execution Count= " + Application["ExecutionCount"];
            Label3.Text = "Application User's Count = " + Application["UserCount"];
        }
    }
}