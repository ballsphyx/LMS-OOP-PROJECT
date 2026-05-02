using ColegioLibrarySystem.GlobalEnums;
using ColegioLibrarySystem.Helpers;
using ColegioLibrarySystem.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User = ColegioLibrarySystem.Models.User;
namespace ColegioLibrarySystem.Service
{
    public class UserManagement
    {
        private readonly UserDB _userDB;
        private readonly BorrowDB _borrowDB;
        public UserManagement(UserDB userDB, BorrowDB borrowDB)
        {
            _userDB = userDB;
            _borrowDB = borrowDB;
        }

        public bool RegisterUser(string username, string password, string fullName, Roles role)
        {
            if (_userDB.GetUserByUsername(username) != null) //if user already exists, exit method
                return false;
            User newUser = new User
            {
                Username = username,
                Password = password,
                FullName = fullName,
                Role = role
            };
            return _userDB.RegisterUser(newUser);
        }
        public bool DeleteUser(int userID)
        {
            if (_borrowDB.HasActiveBorrow(userID))
                return false;
            if (_userDB.GetUsersByID(userID) == null) //if user does not exist, exit method
                return false;
            return _userDB.DeleteUser(userID);
        }
        public bool UpdateUser(int userID, string username, string password, string fullName, Roles role)
        {
            if (_userDB.GetUsersByID(userID) == null) //if user does not exist, exit method
                return false;
            User updatedUser = new User
            {
                Username = username,
                Password = password,
                FullName = fullName,
                Role = role
            };
            return _userDB.UpdateUser(updatedUser);
        }
        public List<User> GetAllUsers()
        {
            return _userDB.GetAllUsers();
        }
        public User GetUserByCredentials(string username, string password)
        {
            return _userDB.GetUsersByCredentials(username, password);
        }
        public User GetUserByID(int userID)
        {
            return _userDB.GetUsersByID(userID);
        }
    }
}
