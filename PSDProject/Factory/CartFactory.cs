using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Factory
{
    public class CartFactory
    {
        public static Cart Create(int userID, int stationeryID, int quantity)
        {
            Cart cart = new Cart();
            cart.UserID = userID;
            cart.StationeryID = stationeryID;   
            cart.Quantity = quantity;
            return cart;
        }
    }
}