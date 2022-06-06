using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp1
{
    public partial class EmployeeRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Calendar1.Visible = false;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = true;
                
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtDOB.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            tblEmployee employee = new tblEmployee();
            employee.Name = txtName.Text;
            employee.DOB =Convert.ToDateTime(txtDOB.Text);
            employee.Address=txtAddress.Text;   
            employee.Email=txtEmail.Text;
            employee.AdharNo=Convert.ToInt64(txtAdharNumber.Text);
            employee.Contactno= Convert.ToInt64(txtContactNumber.Text);
            employee.pincode =Convert.ToInt32(txtPincode.Text);
            employee.Gender = rbtnGender.SelectedValue;
            employee.Department = ddlDepartment.SelectedValue;

            using(UserEntities entities = new UserEntities())
            {
                entities.tblEmployees.Add(employee);
                entities.SaveChanges();
            }
        }
    }
}