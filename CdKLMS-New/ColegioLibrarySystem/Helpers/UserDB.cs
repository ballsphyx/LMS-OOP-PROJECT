using ColegioLibrarySystem.GlobalEnums;
using ColegioLibrarySystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string query = "DELETE FROM USERS WHERE user_id = @UserID";
            var param = new MySqlParameter[]
            {
                new MySqlParameter("@UserID", userID)
            };
            return _databaseHelper.ExecuteNonQuery(query, param) > 0;
        }
        public bool UpdateUser(User user)
        {
            string query = @"UPDATE USERS SET username = @Username, password = @Password, full_name = @FullName, role = @Role
                             WHERE user_id = @UserID";

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
        public List<User> GetAllUsers()
        {
            string query = "SELECT user_id, username, full_name, role FROM USERS";
            DataTable dt = _databaseHelper.ExecuteQuery(query);
            List<User> users = new List<User>();

            foreach (DataRow row in dt.Rows)
            {
                users.Add(new User
                {
                    Id = Convert.ToInt32(row["user_id"]),
                    Username = row["username"].ToString(),
                    FullName = row["full_name"].ToString(),
                    Role = (Roles)Convert.ToInt32(row["role"])
                });
            }

            return users;
        }
        public User GetUsersByCredentials(string username, string password)
        {
            string query = "SELECT user_id, username, full_name, role FROM USERS WHERE username = @Username AND password = @Password";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Username", username),
                new MySqlParameter("@Password", password)
            };
            var dt = _databaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new User
            {
                Id = Convert.ToInt32(row["user_id"]),
                Username = row["username"].ToString(),
                FullName = row["full_name"].ToString(),
                Password = row["password"].ToString(),
                Role = (Roles)Convert.ToInt32(row["role"])
            };

        }
        public User GetUsersByID(int id)
        {
            string query = "SELECT user_id, username, full_name, role FROM USERS WHERE id = @UserID";
            var parameters = new MySqlParameter[]
            {
        new MySqlParameter("@UserID", id)
            };
            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new User
            {
                Id = Convert.ToInt32(row["user_id"]),
                Username = row["username"].ToString(),
                FullName = row["full_name"].ToString(),
                Role = (Roles)Convert.ToInt32(row["role"])
            };
        }

        public List<User> GetUsersByFullName(string name)
        {
            string query = "SELECT user_id, username, full_name, role FROM USERS WHERE full_name LIKE @Name";
            var parameters = new MySqlParameter[]
            {
        new MySqlParameter("@Name", $"%{name}%") // % wildcards for partial match
            };
            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);

            List<User> users = new List<User>();
            foreach (DataRow row in dt.Rows)
            {
                users.Add(new User
                {
                    Id = Convert.ToInt32(row["user_id"]),
                    Username = row["username"].ToString(),
                    FullName = row["full_name"].ToString(),
                    Role = (Roles)Convert.ToInt32(row["role"])
                });
            }
            return users;
        }
        public User GetUserByUsername(string username)
        {
            string query = "SELECT user_id, username, full_name, role FROM USERS WHERE username = @Username";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Username", username)
            };
            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new User
            {
                Id = Convert.ToInt32(row["user_id"]),
                Username = row["username"].ToString(),
                FullName = row["full_name"].ToString(),
                Role = (Roles)Convert.ToInt32(row["role"])
            };
        }
    }
}
