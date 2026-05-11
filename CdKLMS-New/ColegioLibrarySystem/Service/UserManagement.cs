using ColegioLibrarySystem.GlobalEnums;
using ColegioLibrarySystem.Helpers;
using ColegioLibrarySystem.Models;
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

        public bool RegisterStudent(string username, string password, string fullName, string program, string yearLevel)
        {
            if (_userDB.GetUserByUsername(username) != null) throw new InvalidOperationException("Student already exists"); //if user already exists, exit function

            Student newStudent = new Student //create new student object to pass into function
            {
                User = new User //creates user object bcuz student is a user
                {
                    Username = username,
                    Password = password,
                    FullName = fullName,
                    RoleId = (int)RoleEnum.Student,
                    Role = new Roles 
                    {
                        RoleId = (int)RoleEnum.Student, //casts roleEnum type into int
                        RoleName = RoleEnum.Student //sets roleName to Student
                    }
                },
                Program = program,
                YearLevel = yearLevel
            };

            return _userDB.RegisterStudent(newStudent); //registers into DB
        }
        public bool RegisterInstructor(string username, string password, string fullName, string department)
        {
            if (_userDB.GetUserByUsername(username) != null) throw new InvalidOperationException("Instructor already exists"); //if user already exists, exit function

            Instructor newInstructor = new Instructor //create new instructor object to pass into function
            {
                User = new User //creates user object bcuz instructor is a user
                {
                    Username = username,
                    Password = password,
                    FullName = fullName,
                    RoleId = (int)RoleEnum.Instructor,
                    Role = new Roles
                    {
                        RoleId = (int)RoleEnum.Instructor, //casts roleEnum type into int
                        RoleName = RoleEnum.Instructor //sets roleName to Student
                    }
                },
                Department = department
            };

            return _userDB.RegisterInstructor(newInstructor); //registers into DB
        }
        public bool RegisterAdmin(string username, string password, string fullName)
        {
            if (_userDB.GetUserByUsername(username) != null) throw new InvalidOperationException("Admin already exists");

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
            User user = _userDB.GetUserByUsername(username); //creates a new user object that contains the information of username
            if (user == null) return false; //if username does not exist, then exit function

            if (_borrowDB.HasActiveBorrow(user.UserId)) return false; //if user has an active borrow, exit function cuz thats a no no

            return _userDB.DeleteUser(user.UserId); //delete from DB
        }
        public bool UpdateUser(int userID, string username, string password, string fullName, Roles role)
        {
            User user = _userDB.GetUserByUsername(username); //creates a new user object that contains the information of username
            if (user == null) return false; //if user does not exist, exit function
            User updatedUser = new User //create a new user object with the new details to pass into our function
            {
                Username = username,
                Password = password,
                FullName = fullName,
                Role = role
            };
            return _userDB.UpdateUser(updatedUser); //update to DB
        }
        public Student GetStudentByUserId(int userId)
        {
            return _userDB.GetStudentByUserId(userId);
        }

        public Instructor GetInstructorByUserId(int userId)
        {
            return _userDB.GetInstructorByUserId(userId);
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
