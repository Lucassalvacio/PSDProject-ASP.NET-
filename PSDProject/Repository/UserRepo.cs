using PSDProject.Factory;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Repository
{
    public class UserRepo
    {
        UserDatabaseEntities db = DatabaseSingleton.GetInstance();
        
        public List<MsUser> getUsers()
        {
            return (from x in db.MsUsers select x).ToList();
        }

        public bool CheckNameUnique(string username)
        {
            MsUser temp = (from x in db.MsUsers where x.Username.Equals(username) select x).FirstOrDefault();

            if (temp == null) return true;
            return false;
        }

        public MsUser getUserById(int id)
        {
            return (from x in db.MsUsers where x.UserID == id select x).FirstOrDefault();
        }

        public MsUser getUserByName(string name) 
        {
            return (from x in db.MsUsers where x.Username == name select x).FirstOrDefault();
        }

        public void createUser(string username, string userGender, DateTime userDOB, string userPhone, string userAddress, string userPassword, string userRole) 
        {
            MsUser user = UserFactory.Create(username, userGender, userDOB, userPhone, userAddress, userPassword, userRole);
            db.MsUsers.Add(user);
            db.SaveChanges();
        }

        public void updateUser(int id, string username, string userGender, DateTime userDOB, string userPhone, string userAddress, string userPassword, string userRole)
        {
            MsUser updateUser = getUserById(id);
            updateUser.Username = username;
            updateUser.UserGender = userGender;
            updateUser.UserDOB = userDOB;
            updateUser.UserPhone = userPhone;
            updateUser.UserAddress = userAddress;
            updateUser.UserPassword = userPassword;
            updateUser.UserRole = userRole;
            db.SaveChanges();
        }


    }
}