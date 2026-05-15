using ColegioLibrarySystem.GlobalEnums;
using ColegioLibrarySystem.Models;
using MySql.Data.MySqlClient;
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

            string query = @"INSERT INTO students (user_id, program_id, year_level) 
                             VALUES (@UserId, @CourseID, @YearLevel)";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserId", newUserId),
                new MySqlParameter("@CourseID", student.ProgramID),
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

            string query = @"INSERT INTO instructors (user_id, dept_id) 
                             VALUES (@UserId, @Department)";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserId", newUserId),
                new MySqlParameter("@Department", instructor.DepartmentId)
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

        private bool UpdateUser(User user)
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
        public bool UpdateStudent(Student student)
        {
            bool updateUser = UpdateUser(student.User);
            if (!updateUser)
            {
                MessageBox.Show("updateUser failed");
                return false;
            }
            string query = @"UPDATE students SET
                                program_id = @CourseID,
                                year_level = @YearLevel
                                WHERE student_id = @StudentID";

            var param = new MySqlParameter[]
            {
                new MySqlParameter("@StudentID", student.StudentId),
                new MySqlParameter("@CourseID", student.ProgramID),
                new MySqlParameter("@YearLevel", student.YearLevel)
            };
            return _databaseHelper.ExecuteNonQuery(query, param) > 0;
        }
        public bool UpdateAdmin(Admin admin)
        {
            return UpdateUser(admin.User);
        }
        public bool UpdateInstructor(Instructor instructor)
        {
            bool updateUser = UpdateUser(instructor.User);
            string query = @"UPDATE instructors SET dept_id = @Department WHERE instructor_id = @InstructorID";
            var param = new MySqlParameter[]
            {
                new MySqlParameter("@Department", instructor.DepartmentId),
                new MySqlParameter("@InstructorID", instructor.InstructorId)
            };
            return _databaseHelper.ExecuteNonQuery(query, param) > 0;
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
        public Student GetStudentByUserId(int userId)
        {
            string query = @"SELECT s.student_id, s.user_id, s.program_id, p.program_name, s.year_level
                             FROM students s
                             JOIN programs p ON s.program_id = p.program_id
                             WHERE s.user_id = @UserId";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserId", userId)
            };

            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new Student
            {
                StudentId = Convert.ToInt32(row["student_id"]),
                UserId = Convert.ToInt32(row["user_id"]),
                ProgramID = Convert.ToInt32(row["program_id"]),
                YearLevel = row["year_level"].ToString(),

                program = new StudentProgram
                {
                    ProgramId = Convert.ToInt32(row["program_id"]),
                    ProgramName = row["program_name"].ToString()
                }
            };
        }
        public List<Student> GetAllStudents()
        {
            string query = @"SELECT u.user_id, u.full_name, u.username, u.password, u.role_id,
                            s.student_id, s.program_id, p.program_name, s.year_level
                            FROM users u
                            JOIN students s ON u.user_id = s.user_id
                            JOIN programs p ON s.program_id = p.program_id";


            DataTable dt = _databaseHelper.ExecuteQuery(query);
            List<Student> students = new List<Student>();
            foreach (DataRow row in dt.Rows)
            {
                students.Add(new Student
                {
                    UserId = Convert.ToInt32(row["user_id"]),
                    StudentId = Convert.ToInt32(row["student_id"]),
                    ProgramID = Convert.ToInt32(row["program_id"]),
                    YearLevel = row["year_level"].ToString(),
                    User = MapUser(row),

                    program = new StudentProgram
                    {
                        ProgramId = Convert.ToInt32(row["program_id"]),
                        ProgramName = row["program_name"].ToString()
                    }
                });
            }
            return students;
        }

        public List<Instructor> GetAllInstructors()
        {
            string query = @"SELECT u.user_id, u.full_name, u.username, u.password, u.role_id,
                            i.instructor_id, i.dept_id, d.department_name
                            FROM users u
                            JOIN instructors i ON u.user_id = i.user_id
                            JOIN departments d ON i.dept_id = d.department_id";

            DataTable dt = _databaseHelper.ExecuteQuery(query);
            List<Instructor> instructors = new List<Instructor>();
            foreach (DataRow row in dt.Rows)
            {
                instructors.Add(new Instructor
                {
                    UserId = Convert.ToInt32(row["user_id"]),
                    InstructorId = Convert.ToInt32(row["instructor_id"]),
                    DepartmentId = Convert.ToInt32(row["dept_id"]),
                    User = MapUser(row),
                    Department = new Department
                    {
                        DepartmentId = Convert.ToInt32(row["dept_id"]),
                        DepartmentName = row["department_name"].ToString()
                    }

                });
            }
            return instructors;
        }

        public Instructor GetInstructorByUserId(int userId)
        {
            string query = @"SELECT i.instructor_id, i.user_id, i.dept_id, d.department_name
                     FROM instructors i
                     JOIN departments d ON i.dept_id = d.department_id
                     WHERE i.user_id = @UserId";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserId", userId)
            };

            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new Instructor
            {
                UserId = Convert.ToInt32(row["user_id"]),
                InstructorId = Convert.ToInt32(row["instructor_id"]),
                DepartmentId = Convert.ToInt32(row["dept_id"]),
                Department = new Department
                {
                    DepartmentId = Convert.ToInt32(row["dept_id"]),
                    DepartmentName = row["department_name"].ToString()
                }
            };
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
        public List<StudentProgram> GetAllCourses()
        {
            string query = @"SELECT program_id, program_name FROM programs";

            DataTable dt = _databaseHelper.ExecuteQuery(query);

            List<StudentProgram> courses = new List<StudentProgram>();

            foreach (DataRow row in dt.Rows)
            {
                courses.Add(new StudentProgram
                {
                    ProgramId = Convert.ToInt32(row["program_id"]),
                    ProgramName = row["program_name"].ToString()
                });
            }

            return courses;
        }
        public List<Department> GetAllDepartments()
        {
            string query = @"SELECT department_id, department_name FROM departments";
            DataTable dt = _databaseHelper.ExecuteQuery(query);
            List<Department> departments = new List<Department>();
            foreach (DataRow row in dt.Rows)
            {
                departments.Add(new Department
                {
                    DepartmentId = Convert.ToInt32(row["department_id"]),
                    DepartmentName = row["department_name"].ToString()
                });
            }
            return departments;
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