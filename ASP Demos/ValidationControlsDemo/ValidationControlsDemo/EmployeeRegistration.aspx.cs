using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidationControlsDemo
{
    public partial class EmployeeRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void UserCustomValidator(object source, ServerValidateEventArgs args)
        {
            string str = args.Value;
            args.IsValid = false;
            if(str.Length <6 || str.Length>25)
            {
                return;
            }
            args.IsValid = true;
        }
    }
}