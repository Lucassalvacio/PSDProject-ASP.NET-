using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Controller
{
    public class UserController
    {
        public bool authenticateUser(string username, string password)
        {
            MsUser authUser = UserRepo.getUserByName(username);

            if (authUser == null) return false;
            if (authUser.UserPassword != password) return false;
            return true;
        }

        public void register()
        {

        }
    }
}