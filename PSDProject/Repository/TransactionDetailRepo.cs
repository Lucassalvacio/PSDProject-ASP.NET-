using PSDProject.Factory;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Repository
{
    public class TransactionDetailRepo
    {
        UserDatabaseEntities db = DatabaseSingleton.GetInstance();

        public List<TransactionDetail> getTransactionDetails()
        {
            return (from x in db.TransactionDetails select x).ToList();
        }

        public List<TransactionDetail> getTransactionDetailsByTransactionId(int transactionId) 
        {
            return (from x in db.TransactionDetails where x.TransactionID == transactionId select x).ToList();
        }

        public void createTransactionDetail(int transactionId, int stationeryId, int quantity) 
        {
            TransactionDetail transactionDetail = TransactionDetailFactory.Create(transactionId, stationeryId, quantity);
            db.TransactionDetails.Add(transactionDetail);
            db.SaveChanges();
        }
    }
}