using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.Views.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void homeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/AdminHome.aspx");
        }

        protected void transactionBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin");
        }

        protected void updateprofBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/UpdateProfileAdmin.aspx");
        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            Session["user_session"] = null;
            Session.Abandon();
            Response.Redirect("~/Views/Login.aspx");
        }
    }
}