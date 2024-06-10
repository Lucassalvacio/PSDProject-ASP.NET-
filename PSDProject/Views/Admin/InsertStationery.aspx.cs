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
    public partial class InsertStationery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (((MsUser)Session["user_session"]).UserRole != "Admin") Response.Redirect("~/Views/Home.aspx");
        }

        protected void insertStationeryButton_Click(object sender, EventArgs e)
        {
            string name = stationeryNameTBox.Text;
            string price = stationeryPriceTBox.Text;

            StationeryController.insertStationery(name, price, (MsUser)Session["user_session"]);
            Response.Redirect("~/Views/Home.aspx");
        }
    }
}