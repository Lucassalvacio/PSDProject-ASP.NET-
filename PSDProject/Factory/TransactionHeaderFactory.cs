using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader Create(int userID, DateTime transactionDate)
        {
            TransactionHeader th = new TransactionHeader();
            th.UserID = userID;
            th.TransactionDate = transactionDate;
            return th;
        }
    }
}