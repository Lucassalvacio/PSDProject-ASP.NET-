using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.Views
{
    public partial class Navbar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Home.aspx");
        }

        protected void login_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Login.aspx");
        }

        protected void register_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Register.aspx");
        }
    }
}