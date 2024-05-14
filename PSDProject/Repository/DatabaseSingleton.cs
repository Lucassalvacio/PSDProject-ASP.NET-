using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Repository
{
    public class DatabaseSingleton
    {
        private static UserDatabaseEntities db = null;
        public static UserDatabaseEntities GetInstance()
        {
            if (db == null)
            {
                db = new UserDatabaseEntities();
            }
            return db;
        }


    }
}