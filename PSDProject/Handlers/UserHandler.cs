using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Handler
{
    public class UserHandler
    {
        public List<MsUser> getUser()
        {
            return UserRepo.getUsers();
        }

       
        public static bool isNameUnique(string username)
        {
            return UserRepo.CheckNameUnique(username);
        }


        public static MsUser getUserById(int id)
        {
            return UserRepo.getUserById(id);
        }


        public MsUser getUserByName(string name)
        {
            return UserRepo.getUserByName(name);
        }


        public static void createUser(string username, string userGender, DateTime userDOB, string userPhone, string userAddress, string userPassword)
        {
            UserRepo.createUser(username, userGender, userDOB, userPhone, userAddress, userPassword, "Customer");
        }

        
        public static void updateUser(int id, string username, string userGender, DateTime userDOB, string userPhone, string userAddress, string userPassword)
        {
            UserRepo.updateUser(id, username, userGender, userDOB, userPhone, userAddress, userPassword);
        }
    }
}