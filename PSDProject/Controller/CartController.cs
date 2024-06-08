using PSDProject.Handler;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Controller
{
    public class CartController
    {
        public static string CreatetoCart(int userId, int statId, int quantity)
        {
            if (quantity <= 0)
            {
                return "Quantity needs to be at least 1!";
            }

            CartHandler.CreateCart(userId, statId, quantity);
            return null;
        }

        public static string UpdateCart(int userId, int statId, int quantity)
        {
            Cart cart = CartHandler.GetCartByUserId(userId, statId);
            if (cart == null)
            {
                return "Item not found!";
            }
            if (quantity <= 0)
            {
                return "Quantity needs to be at least 1!";
            }

            CartHandler.UpdateCart(userId, statId, quantity);
            return null;
        }

        public static string DeleteCart(int userId, int statId)
        {
            Cart cart = CartHandler.GetCartByUserId(userId, statId);
            if (cart == null)
            {
                return "Item not found!";
            }

            CartHandler.DeleteCart(userId, statId);
            return null;
        }

        public static List<Cart> GetCarts()
        {
            return CartHandler.GetAllCarts();
        }
    }
}