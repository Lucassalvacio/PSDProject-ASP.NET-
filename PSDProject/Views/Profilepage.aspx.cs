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
    public partial class Profilepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitRegisterBtn_Click(object sender, EventArgs e)
        {
            string username = usernameRegisterTBox.Text;
            string password = passwordRegisterTBox.Text;
            DateTime dateOB = DOBRegisterCal.SelectedDate;
            string gender = genderRadioButtonList.SelectedValue;
            string address = addressRegisterTBox.Text;
            string phone = phoneRegisterTBox.Text;

            

            string auth = UserController.updateUser(((MsUser)Session["user_session"]).UserID ,username, password, dateOB, gender, address, phone);

            if (auth == null)
            {
                Response.Redirect("~/Views/ProfilePage.aspx");
            }
            else
            {
                registerErrorLbl.ForeColor = System.Drawing.Color.Red;
                registerErrorLbl.Text = auth;
            }
        }
    }
}