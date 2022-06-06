using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace WebApp1
{
    public partial class FileUploadDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAttach_Click(object sender, EventArgs e)
        {
            string folderpath = Server.MapPath("~/Uploads/");
            if (!Directory.Exists(folderpath))
                Directory.CreateDirectory(folderpath);
            string filename = Path.GetFileName(fileupload1.FileName);
            string fileextension = filename.Substring(filename.LastIndexOf("."), 4);
            if (fileextension == ".pdf")
            {
                fileupload1.SaveAs(folderpath + Path.GetFileName(fileupload1.FileName));
                lblResult.Text = Path.GetFileName(fileupload1.FileName) + "has uploaded succeessfully";
                lblResult.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblResult.Text ="Choose only pdf File Format";
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
       
        }
    }
}