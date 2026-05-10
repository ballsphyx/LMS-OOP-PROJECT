using ColegioLibrarySystem.GlobalEnums;
using ColegioLibrarySystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace ColegioLibrarySystem.Helpers
{
    public class UserDB
    {
        private readonly DatabaseHelper _databaseHelper;

        public UserDB(DatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }
        private int RegisterUser(User user) // Private base method - only inserts into users table
        {
            string query = @"INSERT INTO users (username, password, full_name, role_id) 
                             VALUES (@Username, @Password, @FullName, @RoleId)";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Username", user.Username),
                new MySqlParameter("@Password", user.Password),
                new MySqlParameter("@FullName", user.FullName),
                new MySqlParameter("@RoleId", user.RoleId)
            };

            return _databaseHelper.ExecuteNonQueryGetID(query, parameters);
        }

        public bool RegisterStudent(Student student)
        {
            int newUserId = RegisterUser(student.User);
            if (newUserId <= 0) return false;

            string query = @"INSERT INTO students (user_id, course, year_level) 
                             VALUES (@UserId, @Course, @YearLevel)";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserId", newUserId),
                new MySqlParameter("@Course", student.Program),
                new MySqlParameter("@YearLevel", student.YearLevel)
            };

            return _databaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool RegisterAdmin(Admin admin)
        {
            int newUserId = RegisterUser(admin.User);
            if (newUserId <= 0) return false;

            string query = @"INSERT INTO admins (user_id) 
                             VALUES (@UserId)";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserId", newUserId)
            };

            return _databaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool RegisterInstructor(Instructor instructor)
        {
            int newUserId = RegisterUser(instructor.User);
            if (newUserId <= 0) return false;

            string query = @"INSERT INTO instructors (user_id, department) 
                             VALUES (@UserId, @Department)";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserId", newUserId),
                new MySqlParameter("@Department", instructor.Department)
            };

            return _databaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteUser(int userId)
        {
            string query = "DELETE FROM users WHERE user_id = @UserId";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserId", userId)
            };
            return _databaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateUser(User user)
        {
            string query = @"UPDATE users SET 
                                username = @Username, 
                                password = @Password, 
                                full_name = @FullName, 
                                role_id = @RoleId
                             WHERE user_id = @UserId";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserId", user.UserId),
                new MySqlParameter("@Username", user.Username),
                new MySqlParameter("@Password", user.Password),
                new MySqlParameter("@FullName", user.FullName),
                new MySqlParameter("@RoleId", user.RoleId)
            };

            return _databaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public List<User> GetAllUsers()
        {
            string query = @"SELECT user_id, username, full_name, password, role_id 
                             FROM users";

            DataTable dt = _databaseHelper.ExecuteQuery(query);
            return MapUsers(dt);
        }

        public User GetUserByCredentials(string username, string password)
        {
            string query = @"SELECT user_id, username, full_name, password, role_id 
                             FROM users
                             WHERE username = @Username AND password = @Password";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Username", username),
                new MySqlParameter("@Password", password)
            };

            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count == 0) return null;

            return MapUser(dt.Rows[0]);
        }

        public User GetUserByID(int id)
        {
            string query = @"SELECT user_id, username, full_name, password, role_id 
                             FROM users
                             WHERE user_id = @UserId";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserId", id)
            };

            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count == 0) return null;

            return MapUser(dt.Rows[0]);
        }

        public List<User> GetUsersByFullName(string name)
        {
            string query = @"SELECT user_id, username, full_name, password, role_id 
                             FROM users
                             WHERE full_name LIKE @Name";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Name", $"%{name}%")
            };

            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);
            return MapUsers(dt);
        }

        public User GetUserByUsername(string username)
        {
            string query = @"SELECT * 
                             FROM users
                             WHERE username = @Username";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Username", username)
            };

            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count == 0) return null;

            return MapUser(dt.Rows[0]);
        }

        private User MapUser(DataRow row)
        {
            return new User
            {
                UserId = Convert.ToInt32(row["user_id"]),
                Username = row["username"].ToString(),
                FullName = row["full_name"].ToString(),
                Password = row["password"].ToString(),
                RoleId = Convert.ToInt32(row["role_id"]),
                Role = new Roles
                {
                    RoleId = Convert.ToInt32(row["role_id"]),
                    RoleName = (RoleEnum)Convert.ToInt32(row["role_id"])
                }
            };
        }

        private List<User> MapUsers(DataTable dt)
        {
            List<User> users = new List<User>();
            foreach (DataRow row in dt.Rows)
            {
                users.Add(MapUser(row));
            }
            return users;
        }
    }
}