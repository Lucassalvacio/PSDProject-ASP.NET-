using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail Create(int transactionID, int stationeryID, int quantity)
        {
            TransactionDetail td = new TransactionDetail();
            td.TransactionID = transactionID;
            td.StationeryID = stationeryID; 
            td.Quantity = quantity; 
            return td;
        }
    }
}