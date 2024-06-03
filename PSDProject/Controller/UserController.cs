using PSDProject.Handler;
using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Controller
{
    public static class UserController
    {
        public static MsUser authenticateUser(string username, string password)
        {
            MsUser authUser = UserRepo.getUserByName(username);

            if (authUser.UserPassword.Equals(password)) return authUser;
            return null;
            
        }

        public static string register(string username, string password, DateTime dateOfBirth, string gender, string address, string phone)
        {
            if (username == null) {
                return "Username must be filled";
            }
            if(username.Length < 5 || username.Length > 50)
            {
                return "Username must be between 5 - 50 characters";
            }
            if (!UserHandler.isNameUnique(username))
            {
                return "Username has been taken";
            }
            if (dateOfBirth == null)
            {
                return "DOB must be filled";
            }
            if(dateOfBirth.AddYears(1) > DateTime.Now)
            {
                return "Age must be more than 1 year";
            }
            if (gender == null) 
            {
                return "Gender must be selected";
            }
            if (address == null)
            {
                return "Address must be filled";
            }
            if (phone == null)
            {
                return "Phone must be filled";
            }
            if (password == null)
            {
                return "Password must be filled";
            }
            if (!password.Any(char.IsDigit) || !password.Any(char.IsLetter))
            {
                return "Password must be alphanumeric";
            }

            UserHandler.createUser(username, gender, dateOfBirth, phone, address, password);
            return null;
        }

        public static string updateUser(int id, string username, string password, DateTime dateOfBirth, string gender, string address, string phone)
        {
            MsUser temp = UserHandler.getUserById(id);
            if(temp != null)
            {
                return "Invalid User";
            }

            if (username == null)
            {
                return "Username must be filled";
            }
            if (username.Length < 5 || username.Length > 50)
            {
                return "Username must be between 5 - 50 characters";
            }
            if (!UserHandler.isNameUnique(username))
            {
                return "Username has been taken";
            }
            if (dateOfBirth == null)
            {
                return "DOB must be filled";
            }
            if (dateOfBirth.AddYears(1) > DateTime.Now)
            {
                return "Age must be more than 1 year";
            }
            if (gender == null)
            {
                return "Gender must be selected";
            }
            if (address == null)
            {
                return "Address must be filled";
            }
            if (phone == null)
            {
                return "Phone must be filled";
            }
            if (password == null)
            {
                return "Password must be filled";
            }
            if (!password.Any(char.IsDigit) || !password.Any(char.IsLetter))
            {
                return "Password must be alphanumeric";
            }

            UserHandler.updateUser(id, username, gender, dateOfBirth, phone, address, password);
            return null;
        }
    }
}