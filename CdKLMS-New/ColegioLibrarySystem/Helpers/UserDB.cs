using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColegioLibrarySystem.Models;
using MySql.Data.MySqlClient;

namespace ColegioLibrarySystem.Helpers
{
    internal class UserDB
    {
        private readonly DatabaseHelper _databaseHelper;

        public UserDB(DatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }

        public bool RegisterUser(string username, string password, string fullName, string role)
        {
            string query = @"INSERT INTO USERS (username, password, full_name, role)
                     VALUES (@Username, @Password, @FullName, @Role)";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Username", username),
                new MySqlParameter("@Password", password),
                new MySqlParameter("@FullName", fullName),
                new MySqlParameter("@Role", role)
            };

            return _databaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public bool DeleteUser(int userID)
        {
            string query = "DELETE FROM USERS WHERE ID = @UserID";
            var param = new MySqlParameter[]
            {
                new MySqlParameter("@UserID", userID)
            };
            return _databaseHelper.ExecuteNonQuery(query, param) > 0;
        }
        public bool UpdateUser(int userID, string username, string password, string fullName, string role)
        {
            string query = @"UPDATE USERS SET username = @Username, password = @Password, full_name = @FullName, role = @Role
                             WHERE ID = @UserID";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserID", userID),
                new MySqlParameter("@Username", username),
                new MySqlParameter("@Password", password),
                new MySqlParameter("@FullName", fullName),
                new MySqlParameter("@Role", role)
            };

            return _databaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public bool ChangePassword(int userID, string newPassword)
        {
            string query = "UPDATE USERS SET password = @NewPassword WHERE ID = @UserID";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserID", userID),
                new MySqlParameter("@NewPassword", newPassword)
            };
            return _databaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public DataTable GetAllUsers()
        {
            string query = "SELECT ID, username, full_name, role FROM USERS";
            return _databaseHelper.ExecuteQuery(query);
        }
        public DataTable GetUsers()
        {
            string query = "SELECT ID, username, full_name, role FROM USERS WHERE ID = @UserID";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserID", Session.UserID)
            };
            return _databaseHelper.ExecuteQuery(query, parameters);
        }
    }
}
