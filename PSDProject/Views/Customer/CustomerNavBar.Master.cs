using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.Views.Customer
{
    public partial class CustomerNavBar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Home.aspx");
        }

        protected void cart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Customer/CartPake.aspx");
        }

        protected void profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Profilepage.aspx");
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Session["user_session"] = null;
            Session.Abandon();
            Response.Redirect("~/Views/Login.aspx");
        }

        protected void transaction_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Customer/TransactionHistory.aspx");
        }
    }
}