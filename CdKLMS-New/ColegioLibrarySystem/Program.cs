//using ColegioLibrarySystem.Helpers;
//using ColegioLibrarySystem.Service;

//namespace ColegioLibrarySystem
//{
//    static class Program
//    {
//        [STAThread]
//        static void Main()
//        {
//            //Application.EnableVisualStyles();
//            //Application.SetCompatibleTextRenderingDefault(false);

//            DatabaseHelper databaseHelper = new DatabaseHelper();

//            BookDB bookDB = new(databaseHelper);
//            TransactionDB transactionDB = new (databaseHelper);
//            UserDB userDB = new (databaseHelper);

//            UserManagement userManagement = new UserManagement(userDB, transactionDB);
//            BookManagement bookManagement = new BookManagement(bookDB, transactionDB);
//            TransactionManagement borrowManagement = new TransactionManagement (transactionDB, bookDB);

//            //Application.Run(new librarymanagement.LoginForm(userManagement, borrowManagement, bookManagement));
//        }
//    }
//}
using ColegioLibrarySystem.Helpers;
using ColegioLibrarySystem.Service;
using ColegioLibrarySystem.GlobalEnums;
using ColegioLibrarySystem.Models;
using System;
using System.Windows.Forms;

namespace ColegioLibrarySystem
{
    internal static class Program
    {
        static int passed = 0;
        static int failed = 0;

        static void Test(string testName, bool result, bool expected = true)
        {
            bool success = result == expected;
            if (success)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[PASS] {testName}");
                passed++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[FAIL] {testName} (expected {expected}, got {result})");
                failed++;
            }
            Console.ResetColor();
        }

        [STAThread]
        static void Main()
        {
            var db = new DatabaseHelper();
            var userDB = new UserDB(db);
            var bookDB = new BookDB(db);
            var transactionDB = new TransactionDB(db);

            var userManagement = new UserManagement(userDB, transactionDB);
            var bookManagement = new BookManagement(bookDB, transactionDB);
            var transactionManagement = new TransactionManagement(transactionDB, bookDB);

            // ── REGISTER TESTS ──────────────────────────
            Console.WriteLine("\n=== REGISTER TESTS ===");
            Test("Register Student",
                userManagement.RegisterStudent("jdoe", "pass123", "John Doe", "BSIT", 2));

            Test("Register Duplicate Student should fail",
                userManagement.RegisterStudent("jdoe", "pass123", "John Doe", "BSIT", 2), false);

            Test("Register Instructor",
                userManagement.RegisterInstructor("prof1", "pass123", "Prof Smith", "IT"));

            Test("Register Duplicate Instructor should fail",
                userManagement.RegisterInstructor("prof1", "pass123", "Prof Smith", "IT"), false);

            Test("Register Admin",
                userManagement.RegisterAdmin("admin1", "admin123", "Admin User"));

            Test("Register Duplicate Admin should fail",
                userManagement.RegisterAdmin("admin1", "admin123", "Admin User"), false);

            // ── LOGIN TESTS ──────────────────────────────
            Console.WriteLine("\n=== LOGIN TESTS ===");
            var student = userManagement.GetUserByCredentials("jdoe", "pass123");
            Test("Student Login", student != null);

            var instructor = userManagement.GetUserByCredentials("prof1", "pass123");
            Test("Instructor Login", instructor != null);

            var admin = userManagement.GetUserByCredentials("admin1", "admin123");
            Test("Admin Login", admin != null);

            Test("Wrong Password should fail",
                userManagement.GetUserByCredentials("jdoe", "wrongpass") == null);

            Test("Wrong Username should fail",
                userManagement.GetUserByCredentials("nobody", "pass123") == null);

            // ── ROLE TESTS ───────────────────────────────
            Console.WriteLine("\n=== ROLE TESTS ===");
            Test("Student Role is correct",
                student.Role.RoleName == RoleEnum.Student);

            Test("Instructor Role is correct",
                instructor.Role.RoleName == RoleEnum.Instructor);

            Test("Admin Role is correct",
                admin.Role.RoleName == RoleEnum.Admin);

            // ── BOOK TESTS ───────────────────────────────
            Console.WriteLine("\n=== BOOK TESTS ===");
            Test("Add Book",
                bookManagement.AddBook("Harry Potter", "J.K. Rowling", CategoryEnum.Paramedical, 2013, 3, "978-3-16"));

            Test("Add Duplicate Book should fail",
                bookManagement.AddBook("Harry Potter", "J.K. Rowling", CategoryEnum.IT, 2012, 3, "978-3-16"), false);

            Test("Add Second Book",
                bookManagement.AddBook("Clean Code", "Robert Martin", CategoryEnum.Education, 2014, 2, "978-0-13"));

            Test("Get Book by ISBN",
                bookManagement.GetBookByISBN("978-3-16") != null);

            Test("Get Non-existent Book should fail",
                bookManagement.GetBookByISBN("000-0-00") == null);

            Test("Available Copies is 3",
                bookDB.GetAvailableCopies(bookManagement.GetBookByISBN("978-3-16").BookID) == 3);

            // ── BORROW TESTS (STUDENT) ───────────────────
            Console.WriteLine("\n=== STUDENT BORROW TESTS ===");
            Session.Login(student);

            Test("Student Borrow Book",
                transactionManagement.BorrowBook("978-3-16"));

            Test("Student Borrow Same Book Again should fail",
                transactionManagement.BorrowBook("978-3-16"), false);

            Test("Student Can Borrow Different Book",
                transactionManagement.BorrowBook("978-0-13"));

            Test("Available Copies decreased after borrow",
                bookDB.GetAvailableCopies(bookManagement.GetBookByISBN("978-3-16").BookID) == 2);

            // ── BORROW TESTS (INSTRUCTOR) ────────────────
            Console.WriteLine("\n=== INSTRUCTOR BORROW TESTS ===");
            Session.Login(instructor);

            Test("Instructor Borrow 2 Copies",
                transactionManagement.BorrowBook("978-3-16", 2));

            Test("Instructor Borrow More Than Available should fail",
                transactionManagement.BorrowBook("978-3-16", 10), false);

            Test("Available Copies is 0 after instructor borrow",
                bookDB.GetAvailableCopies(bookManagement.GetBookByISBN("978-3-16").BookID) == 0);

            Test("Instructor Cannot Borrow Unavailable Book should fail",
                transactionManagement.BorrowBook("978-3-16"), false);

            // ── RETURN TESTS ─────────────────────────────
            Console.WriteLine("\n=== RETURN TESTS ===");
            Session.Login(student);
            var studentBorrows = transactionManagement.GetBorrowsByUser(student.UserId);
            Test("Student Has Borrow Records", studentBorrows.Count > 0);

            if (studentBorrows.Count > 0)
            {
                int transactionId = studentBorrows[0].TransactionId;
                Test("Return Book", transactionManagement.ReturnBook(transactionId));
                Test("Return Non-existent Transaction should fail",
                    transactionManagement.ReturnBook(99999), false);
            }

            // ── DELETE USER TESTS ────────────────────────
            Console.WriteLine("\n=== DELETE USER TESTS ===");
            Session.Login(student);
            Test("Cannot Delete User With Active Borrow should fail",
                userManagement.DeleteUser("jdoe"), false);

            Test("Delete Non-existent User should fail",
                userManagement.DeleteUser("nobody"), false);

            // ── DELETE BOOK TESTS ────────────────────────
            Console.WriteLine("\n=== DELETE BOOK TESTS ===");
            Test("Cannot Delete Book With Active Borrow should fail",
                bookManagement.DeleteBook("978-3-16"), false);

            // ── CLEANUP ──────────────────────────────────
            Console.WriteLine("\n=== CLEANUP ===");
            // return all active borrows first
            var allBorrows = transactionManagement.GetActiveBorrows();
            foreach (var borrow in allBorrows)
                transactionManagement.ReturnBook(borrow.TransactionId);

            Test("Delete Student", userManagement.DeleteUser("jdoe"));
            Test("Delete Instructor", userManagement.DeleteUser("prof1"));
            Test("Delete Admin", userManagement.DeleteUser("admin1"));
            Test("Delete Book 1", bookManagement.DeleteBook("978-3-16"));
            Test("Delete Book 2", bookManagement.DeleteBook("978-0-13"));

            // ── SUMMARY ──────────────────────────────────
            Console.WriteLine("\n=============================");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"PASSED: {passed}");
            Console.ForegroundColor = failed > 0 ? ConsoleColor.Red : ConsoleColor.Green;
            Console.WriteLine($"FAILED: {failed}");
            Console.ResetColor();
            Console.WriteLine("=============================");
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}