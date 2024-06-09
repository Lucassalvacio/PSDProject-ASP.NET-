using PSDProject.Controller;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTBox.Text;
            string password = passwordTBox.Text;

            MsUser auth = UserController.authenticateUser(username, password);
            if (auth != null)
            {
                Session["user_session"] = auth;

                Response.Redirect("~/Views/Home.aspx");
            }
            else
            {
                loginErrorLbl.ForeColor = System.Drawing.Color.Red;
                loginErrorLbl.Text = "Login Credentials Invalid!";
            }
        }

        protected void NoAcc_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Register.aspx");
        }

        protected void dontWantToBeHere_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Home.aspx");
        }
    }
}