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
    public partial class UpdateStationeryAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            MsStationery stat = StationeryController.getStatById(id);
            stationeryNameTBox.Text = stat.StationeryName;
            stationeryPriceTBox.Text = stat.StationeryPrice.ToString();
        }

        protected void updateStationeryButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            String name = stationeryNameTBox.Text;
            string price = stationeryPriceTBox.Text;
            String update = StationeryController.updateStationery(id, name, price, (MsUser)Session["user_session"]);
            if (update != null)
            {
                errorLbl.Text = update;
            }
            else
            {
                Response.Redirect("~/Views/Admin/AdminHome.aspx");
            }
        }
    }
}