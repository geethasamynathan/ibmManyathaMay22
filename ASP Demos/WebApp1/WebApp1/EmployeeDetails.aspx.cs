using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp1
{
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<tblEmployee> EmployeeList;

            using(UserEntities entities = new UserEntities())
            {
                EmployeeList = entities.tblEmployees.ToList();
                GridView1.DataSource = EmployeeList;
                GridView1.DataBind();

            }
        }
    }
}