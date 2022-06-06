using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp1
{
    public partial class DropDownListDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDropDownListItem();
                LoadEmployeeNames();
            }

        }
        private void LoadEmployeeNames()
        {
            List<string> EmployeeNames = new List<string>();
            using(UserEntities entities = new UserEntities())
            {
                EmployeeNames= entities.tblEmployees.Select(e => e.Name).ToList();
                
            }
            DropDownList2.DataSource = EmployeeNames;
            DropDownList2.DataBind();
        }
        private void LoadDropDownListItem()
        {
            ddlCountry.Items.Add("India");
            ddlCountry.Items.Add("France");
            ddlCountry.Items.Add("Italy");
            ddlCountry.Items.Add("German");
            ddlCountry.Items.Add("Japan");
            ddlCountry.Items.Add("USA");

        }

        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelectedCountry.Text = ddlCountry.SelectedValue;
            Response.Write($"<script> alert('{ddlCountry.SelectedItem.Text}');</script>");
        }
    }
}