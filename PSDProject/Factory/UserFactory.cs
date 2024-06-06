using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Factory
{
    public class UserFactory
    {
        public static MsUser Create(string username, string UserGender, DateTime UserDOB, string UserPhone, string UserAddress, string UserPassword, string UserRole)
        {
            MsUser user = new MsUser();

            user.Username = username;
            user.UserGender = UserGender;
            user.UserDOB = UserDOB;
            user.UserPhone = UserPhone;
            user.UserAddress = UserAddress;
            user.UserPassword = UserPassword;
            user.UserRole = UserRole;
            return user;
        }

        public static MsUser CreateAdmin(string username, string UserGender, DateTime UserDOB, string UserPhone, string UserAddress, string UserPassword, string UserRole)
        {
            MsUser user = new MsUser();

            user.Username = username;
            user.UserGender = UserGender;
            user.UserDOB = UserDOB;
            user.UserPhone = UserPhone;
            user.UserAddress = UserAddress;
            user.UserPassword = "admin";
            user.UserRole = "Admin";
            return user;
        }
    }
}