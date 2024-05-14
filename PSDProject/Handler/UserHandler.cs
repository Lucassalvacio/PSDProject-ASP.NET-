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

       
        public bool isNameUnique(string username)
        {
            return UserRepo.CheckNameUnique(username);
        }

        
        public MsUser getUserById(int id)
        {
            return UserRepo.getUserById(id);
        }

        
        public MsUser getUserByName(string name)
        {
            return UserRepo.getUserByName(name);
        }

        
        public void createUser(string username, string userGender, DateTime userDOB, string userPhone, string userAddress, string userPassword, string userRole)
        {
            UserRepo.createUser(username, userGender, userDOB, userPhone, userAddress, userPassword, userRole);
        }

        
        public void updateUser(int id, string username, string userGender, DateTime userDOB, string userPhone, string userAddress, string userPassword, string userRole)
        {
            UserRepo.updateUser(id, username, userGender, userDOB, userPhone, userAddress, userPassword, userRole);
        }
    }
}