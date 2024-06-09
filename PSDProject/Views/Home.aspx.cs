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
    public partial class Home : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            insertStationeryButton.Visible = false;


            MsUser curr = null;
            string welcomeTxt;
            if (Session["user_session"] == null) welcomeTxt = "Welcome, Guest";
            else
            {
                curr = (MsUser)Session["user_session"];
                welcomeTxt = "Welcome, " + curr.Username;

                if (curr.UserRole == "Admin")
                {
                    insertStationeryButton.Visible = true;
                }
            }

            welcomeText.Text = welcomeTxt;

            stationeryGV.DataSource = StationeryController.getAll();
            stationeryGV.DataBind();

            
        }

        protected void insertStationeryButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/InsertStationery.aspx");
        }

        protected void stationeryGV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //Redirect to Details
        }

        protected void stationeryGV_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void stationeryGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}