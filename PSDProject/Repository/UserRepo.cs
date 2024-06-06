using PSDProject.Factory;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Repository
{
    public static class UserRepo
    {
        static UserDatabaseEntities db = DatabaseSingleton.GetInstance();
        
        public static List<MsUser> getUsers()
        {
            return (from x in db.MsUsers select x).ToList();
        }

        public static bool CheckNameUnique(string username)
        {
            MsUser temp = getUserByName(username);

            if (temp == null) return true;
            return false;
        }

        public static MsUser getUserById(int id)
        {
            return (from x in db.MsUsers where x.UserID == id select x).FirstOrDefault();
        }

        public static MsUser getUserByName(string name) 
        {
            return (from x in db.MsUsers where x.Username.Equals(name) select x).FirstOrDefault();
        }

        public static void createUser(string username, string userGender, DateTime userDOB, string userPhone, string userAddress, string userPassword, string userRole) 
        {
            MsUser user;
            if(username == "admin")
            {
                user = UserFactory.CreateAdmin(username, userGender, userDOB, userPhone, userAddress, userPassword, userRole);
            }
            else
            {
                user = UserFactory.Create(username, userGender, userDOB, userPhone, userAddress, userPassword, userRole);
            }
            db.MsUsers.Add(user);
            db.SaveChanges();
        }

        public static void updateUser(int id, string username, string userGender, DateTime userDOB, string userPhone, string userAddress, string userPassword)
        {
            MsUser updateUser = getUserById(id);
            updateUser.Username = username;
            updateUser.UserGender = userGender;
            updateUser.UserDOB = userDOB;
            updateUser.UserPhone = userPhone;
            updateUser.UserAddress = userAddress;
            updateUser.UserPassword = userPassword;
            db.SaveChanges();
        }


    }
}