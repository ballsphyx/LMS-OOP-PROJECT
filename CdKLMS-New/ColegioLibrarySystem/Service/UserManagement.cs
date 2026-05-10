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
        private readonly TransactionDB _borrowDB;
        public UserManagement(UserDB userDB, TransactionDB borrowDB)
        {
            _userDB = userDB;
            _borrowDB = borrowDB;
        }

        public bool RegisterStudent(string username, string password, string fullName, string program, int yearLevel)
        {
            if (_userDB.GetUserByUsername(username) != null) return false;

            Student newStudent = new Student
            {
                User = new User
                {
                    Username = username,
                    Password = password,
                    FullName = fullName,
                    RoleId = (int)RoleEnum.Student,
                    Role = new Roles
                    {
                        RoleId = (int)RoleEnum.Student,
                        RoleName = RoleEnum.Student
                    }
                },
                Program = program,
                YearLevel = yearLevel
            };

            return _userDB.RegisterStudent(newStudent);
        }
        public bool RegisterInstructor(string username, string password, string fullName, string department)
        {
            if (_userDB.GetUserByUsername(username) != null) return false;

            Instructor newInstructor = new Instructor
            {
                User = new User
                {
                    Username = username,
                    Password = password,
                    FullName = fullName,
                    RoleId = (int)RoleEnum.Instructor,
                    Role = new Roles
                    {
                        RoleId = (int)RoleEnum.Instructor,
                        RoleName = RoleEnum.Instructor
                    }
                },
                Department = department
            };

            return _userDB.RegisterInstructor(newInstructor);
        }
        public bool RegisterAdmin(string username, string password, string fullName)
        {
            if (_userDB.GetUserByUsername(username) != null) return false;

            Admin newAdmin = new Admin
            {
                User = new User
                {
                    Username = username,
                    Password = password,
                    FullName = fullName,
                    RoleId = (int)RoleEnum.Admin,
                    Role = new Roles
                    {
                        RoleId = (int)RoleEnum.Admin,
                        RoleName = RoleEnum.Admin
                    }
                }
            };

            return _userDB.RegisterAdmin(newAdmin);
        }
        public bool DeleteUser(string username)
        {
            User user = _userDB.GetUserByUsername(username);
            if (user == null) return false;

            if (_borrowDB.HasActiveBorrow(user.UserId)) return false;

            return _userDB.DeleteUser(user.UserId);
        }
        public bool UpdateUser(int userID, string username, string password, string fullName, Roles role)
        {
            User user = _userDB.GetUserByUsername(username);
            if (user == null) return false;
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
            return _userDB.GetUserByCredentials(username, password);
        }
        public User GetUserByID(int userID)
        {
            return _userDB.GetUserByID(userID);
        }
    }
}
