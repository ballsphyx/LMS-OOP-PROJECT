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
            BorrowDB borrowDB = new BorrowDB(databaseHelper);
            UserDB userDB = new UserDB(databaseHelper);
            UserManagement userManagement = new UserManagement(userDB, borrowDB);
            Application.Run(new librarymanagement.LoginForm(userManagement));
        }
    }
}