using PSDProject.Factory;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Repository
{
    public static class CartRepo
    {
        UserDatabaseEntities db = DatabaseSingleton.GetInstance();

        public List<Cart> getCart()
        {
            return (from x in  db.Carts select x).ToList();
        }

        public Cart getCartByUserId(int userId, int stationeryId)
        {
            return (from x in db.Carts where x.UserID == userId && x.StationeryID == stationeryId select x).FirstOrDefault();
        }

        public void createCart(int userId, int stationeryId, int quantity)
        {
            Cart temp = CartFactory.Create(userId, stationeryId, quantity);
            db.Carts.Add(temp);
            db.SaveChanges();
        }

        public void updateCart(int userId, int stationeryId, int quantity)
        {
            Cart updateTemp = getCartByUserId(userId, stationeryId);
            updateTemp.Quantity = quantity;
            db.SaveChanges();
        }

        public void deleteCart(int userId, int stationeryId) 
        {
            Cart deleteTemp = getCartByUserId(userId, stationeryId);
            db.Carts.Remove(deleteTemp);
            db.SaveChanges();
        }
    }
}