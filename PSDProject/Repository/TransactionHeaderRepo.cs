﻿using PSDProject.Factory;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Repository
{
    public class TransactionHeaderRepo
    {
        UserDatabaseEntities db = DatabaseSingleton.GetInstance();

        public List<TransactionHeader> GetTransactionHeaders()
        {
            return (from x in db.TransactionHeaders select x).ToList();
        }

        public List<TransactionHeader> GetTransactionHeadersByUserId(int userId) 
        {
            return (from x in db.TransactionHeaders where x.UserID == userId select x).ToList();
        }

        public void createTransactionHeader(int userId)
        {
            TransactionHeader th = TransactionHeaderFactory.Create(userId, DateTime.Now);
            db.TransactionHeaders.Add(th);
            db.SaveChanges();
        }

    }
}