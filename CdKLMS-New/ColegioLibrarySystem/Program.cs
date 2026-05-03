using System;
using System.Windows.Forms;
using ColegioLibrarySystem;
using ColegioLibrarySystem.Helpers;
using ColegioLibrarySystem.Service;

namespace ColegioLibrarySystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DatabaseHelper databaseHelper = new DatabaseHelper();

            BookDB bookDB = new(databaseHelper);
            BorrowDB borrowDB = new (databaseHelper);
            UserDB userDB = new (databaseHelper);

            UserManagement userManagement = new UserManagement(userDB, borrowDB);
            BookManagement bookManagement = new BookManagement(bookDB);
            BorrowManagement borrowManagement = new BorrowManagement (borrowDB, bookDB, userDB);

            //Application.Run(new librarymanagement.LoginForm(userManagement, borrowManagement, bookManagement));
            Application.Run(new librarymanagement.views.adminDashpanUser(userManagement));
        }
    }
}