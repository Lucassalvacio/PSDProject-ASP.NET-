using PSDProject.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.Views
{
    public partial class Register : System.Web.UI.Page
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

            string auth = UserController.register(username, password, dateOB, gender, address, phone);

            if(auth == null)
            {
                Response.Redirect("~/Views/Login.aspx");
            }
            else
            {
                registerErrorLbl.ForeColor = System.Drawing.Color.Red;
                registerErrorLbl.Text = auth;
            }
        }

        protected void alrHaveAcc_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Login.aspx");
        }

        protected void dontWantToBeHere_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Home.aspx");
        }
    }
}