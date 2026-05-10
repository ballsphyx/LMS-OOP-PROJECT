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
            TransactionDB borrowDB = new (databaseHelper);
            UserDB userDB = new (databaseHelper);

            UserManagement userManagement = new UserManagement(userDB, borrowDB);
            BookManagement bookManagement = new BookManagement(bookDB, borrowDB);
            TransactionManagement borrowManagement = new TransactionManagement (borrowDB, bookDB, userDB);

            //Application.Run(new librarymanagement.LoginForm(userManagement, borrowManagement, bookManagement));
        }
    }
}