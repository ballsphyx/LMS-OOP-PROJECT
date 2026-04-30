//using ColegioLibrarySystem.GlobalEnums;
//using ColegioLibrarySystem.Helpers;
//using ColegioLibrarySystem.Models;
//using Microsoft.VisualBasic.ApplicationServices;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace ColegioLibrarySystem.Service
//{
//    public class UserManagement
//    {
//        private readonly UserDB _userDB;
//        private readonly BorrowDB _borrowDB;
//        public UserManagement(UserDB userDB, BorrowDB borrowDB)
//        {
//            _userDB = userDB;
//            _borrowDB = borrowDB;
//        }

//        public bool RegisterUser(string username, string password, string fullName, Roles role)
//        {
//            if (_userDB.GetUsersByFullName(fullName).Rows.Count > 0)
//                return false;
//            Models.User newUser = new Models.User(0, username, password, fullName, role);
//            return _userDB.RegisterUser(newUser);
//        }
//        public bool DeleteUser(int userID)
//        {
//            if (_borrowDB.HasActiveBorrow(userID))
//                return false;
//            if (_userDB.GetUsersByID(userID).Rows.Count == 0)
//                return false;
//            return _userDB.DeleteUser(userID);
//        }
//        public bool UpdateUser(int userID, string username, string password, string fullName, Roles role)
//        {
//            if (_userDB.GetUsersByID(userID).Rows.Count == 0)
//                return false;
//            Models.User updatedUser = new Models.User(userID, username, password, fullName, role);
//            return _userDB.UpdateUser(updatedUser);
//        }
//        public DataTable GetAllUsers()
//        {
//            return _userDB.GetAllUsers();
//        }
//        public Models.User GetUserByCredentials(string username, string password)
//        {
//            DataTable dt = _userDB.GetUsersByCredentials(username, password);

//            if (dt.Rows.Count == 0)
//                return null;

//            DataRow row = dt.Rows[0];
//            return new Models.User
//            {
//                Id = Convert.ToInt32(row["ID"]),
//                Username = row["username"].ToString(),
//                FullName = row["full_name"].ToString(),
//                Role = (Roles)Enum.Parse(typeof(Roles), row["role"].ToString())
//            };
//        }
//        public DataTable GetUserByID(int userID)
//        {
//            return _userDB.GetUsersByID(userID);
//        }
//    }
//}
