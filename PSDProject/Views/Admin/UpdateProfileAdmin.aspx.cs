using PSDProject.Controller;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.Views.Admin
{
    public partial class UpdateProfileAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MsUser user = UserController.getUserByName("Admin");
                usernameTb.Text = user.Username;
                passwordTb.Text = user.UserPassword;
                dobTb.Text = user.UserDOB.ToString("yyyy-MM-dd");
                genderDDL.Text = user.UserGender;
                addressTb.Text = user.UserAddress;
                phoneTb.Text = user.UserPhone;
            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            MsUser user = UserController.getUserByName("Admin");
            String usernameBefore = user.Username;
            String username = usernameTb.Text.Trim();
            String password = passwordTb.Text.Trim();
            String address = addressTb.Text.Trim();
            String phone = phoneTb.Text.Trim();
            DateTime dob = Convert.ToDateTime(dobTb.Text);
            String gender = genderDDL.SelectedValue;
            String update = UserController.updateUser(user.UserID, username,password,dob, gender, address,phone);
            if (update != null)
            {
                errorLbl.Text = update;
            }
            else
            {
                Response.Redirect("~/Views/Customer/AdminHomePage.aspx");
            }
        }
    }
}