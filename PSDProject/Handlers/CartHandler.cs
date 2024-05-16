using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Handler
{
    public class CartHandler
    {
        
        public List<Cart> GetAllCarts()
        {
            return CartRepo.getCart();
        }

        
        public Cart GetCartByUserId(int userId, int stationeryId)
        {
            return CartRepo.getCartByUserId(userId, stationeryId);
        }

        
        public void CreateCart(int userId, int stationeryId, int quantity)
        {
            
            CartRepo.createCart(userId, stationeryId, quantity);
        }

        
        public void UpdateCart(int userId, int stationeryId, int quantity)
        {
            
            CartRepo.updateCart(userId, stationeryId, quantity);
        }

        
        public void DeleteCart(int userId, int stationeryId)
        {
            
            CartRepo.deleteCart(userId, stationeryId);
        }
    }
}