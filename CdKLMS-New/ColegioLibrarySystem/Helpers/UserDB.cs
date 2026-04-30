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
    public class UserDB
    {
        private readonly DatabaseHelper _databaseHelper;

        public UserDB(DatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }

        public bool RegisterUser(User users)
        {
            string query = @"INSERT INTO USERS (username, password, full_name, role)
                     VALUES (@Username, @Password, @FullName, @Role)";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Username", users.Username),
                new MySqlParameter("@Password", users.Password),
                new MySqlParameter("@FullName", users.FullName),
                new MySqlParameter("@Role", users.Role)
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
        public bool UpdateUser(User user)
        {
            string query = @"UPDATE USERS SET username = @Username, password = @Password, full_name = @FullName, role = @Role
                             WHERE ID = @UserID";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserID", user.Id),
                new MySqlParameter("@Username", user.Username),
                new MySqlParameter("@Password", user.Password),
                new MySqlParameter("@FullName", user.FullName),
                new MySqlParameter("@Role", user.Role)
            };

            return _databaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public DataTable GetAllUsers()
        {
            string query = "SELECT ID, username, full_name, role FROM USERS";
            return _databaseHelper.ExecuteQuery(query);
        }
        public DataTable GetUsersByCredentials(string username, string password)
        {
            string query = "SELECT ID, username, full_name, role FROM USERS WHERE username = @Username AND password = @Password";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Username", username),
                new MySqlParameter("@Password", password)
            };
            return _databaseHelper.ExecuteQuery(query, parameters);
        }
        public DataTable GetUsersByID(int id)
        {
            string query = "SELECT ID, username, full_name, role FROM USERS WHERE ID = @UserID";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserID", id)
            };
            return _databaseHelper.ExecuteQuery(query, parameters);
        }
        public DataTable GetUsersByFullName(string name)
        {
            string query = "SELECT ID, username, full_name, role FROM USERS WHERE full_name LIKE @Name";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Name", name)
            };
            return _databaseHelper.ExecuteQuery(query, parameters);
        }
    }
}
