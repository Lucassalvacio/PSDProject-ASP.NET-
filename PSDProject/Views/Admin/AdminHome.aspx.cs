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
    public partial class AdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<MsStationery> stationery = StationeryController.getAll();
            StationeryGridView.DataSource = stationery;
            StationeryGridView.DataBind();
        }

        protected void StationeryGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = StationeryGridView.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            StationeryController.deleteStationery(id);
            List<MsStationery> stationeries = StationeryController.getAll();
            StationeryGridView.DataSource = stationeries;
            StationeryGridView.DataBind();
        }

        protected void StationeryGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = StationeryGridView.Rows[e.NewEditIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            Response.Redirect("~/Views/Admin/UpdateStationeryAdmin.aspx?id=" + id);
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/InsertStationeryAdmin.aspx");
        }
    }
}