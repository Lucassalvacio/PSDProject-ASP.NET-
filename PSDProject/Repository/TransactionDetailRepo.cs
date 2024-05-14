using PSDProject.Factory;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Repository
{
    public static class TransactionDetailRepo
    {
        static UserDatabaseEntities db = DatabaseSingleton.GetInstance();

        public static List<TransactionDetail> getTransactionDetails()
        {
            return (from x in db.TransactionDetails select x).ToList();
        }

        public static List<TransactionDetail> getTransactionDetailsByTransactionId(int transactionId) 
        {
            return (from x in db.TransactionDetails where x.TransactionID == transactionId select x).ToList();
        }

        public static void createTransactionDetail(int transactionId, int stationeryId, int quantity) 
        {
            TransactionDetail transactionDetail = TransactionDetailFactory.Create(transactionId, stationeryId, quantity);
            db.TransactionDetails.Add(transactionDetail);
            db.SaveChanges();
        }
    }
}