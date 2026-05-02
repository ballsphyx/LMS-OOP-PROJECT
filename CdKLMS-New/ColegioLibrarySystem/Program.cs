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
            BookDB bookDB = new BookDB(databaseHelper);

            UserManagement userManagement = new UserManagement(userDB, borrowDB);
            BookManagement bookManagement = new BookManagement(bookDB);
            BorrowManagement borrowManagement = new BorrowManagement(borrowDB,bookDB, userDB);

            var services = new AppServices(userManagement, bookManagement, borrowManagement);
            Application.Run(new librarymanagement.LoginForm(services));
        }
    }
}