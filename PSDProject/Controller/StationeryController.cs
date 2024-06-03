using PSDProject.Handler;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Controller
{
    public class StationeryController
    {
        public static string insertStationery(string name, string price, MsUser user)
        {
            if(user.UserRole != "Admin")
            {
                return "Nub";
            }
            if(name == null)
            {
                return "Name must be filled";
            }
            if(name.Length < 3 || name.Length > 50)
            {
                return "Length of name must be 3 - 50 characters";
            }
            if(price == null)
            {
                return "Price must be filled";
            }
            if (!price.All(char.IsNumber))
            {
                return "Price must be a number";
            }
            if (Convert.ToInt32(price) < 2000)
            {
                return "Price must be >= 2000";
            }

            StationeryHandler.createStationery(name, Convert.ToInt32(price));
            return null;
        }

        public static string updateStationery(int id, string name, string price, MsUser user)
        {
            if (user.UserRole != "Admin")
            {
                return "Nub";
            }
            
            MsStationery temp = StationeryHandler.getStationeryById(id);
            if(temp == null)
            {
                return "Invalid Stationery";
            }

            if (name == null)
            {
                return "Name must be filled";
            }
            if (name.Length < 3 || name.Length > 50)
            {
                return "Length of name must be 3 - 50 characters";
            }
            if (price == null)
            {
                return "Price must be filled";
            }
            if (!price.All(char.IsNumber))
            {
                return "Price must be a number";
            }
            if (Convert.ToInt32(price) < 2000)
            {
                return "Price must be >= 2000";
            }

            StationeryHandler.updateStationery(id, name, Convert.ToInt32(price));
            return null;
        }

        public static string deleteStationery(int id)
        {
            MsStationery temp = StationeryHandler.getStationeryById(id);
            if (temp != null)
            {
                return "Must select at least 1 stationery";
            }

            StationeryHandler.deleteStationery(id);

            return null;
        }

        public static List<MsStationery> getAll()
        {
            return StationeryHandler.getAllStationeries();
        }
    }
}