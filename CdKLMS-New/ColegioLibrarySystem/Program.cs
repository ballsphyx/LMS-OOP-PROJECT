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
            TransactionDB transactionDB = new(databaseHelper);
            UserDB userDB = new(databaseHelper);

            UserManagement userManagement = new UserManagement(userDB, transactionDB);
            BookManagement bookManagement = new BookManagement(bookDB, transactionDB);
            TransactionManagement borrowManagement = new TransactionManagement(transactionDB, bookDB);

            //Application.Run(new librarymanagement.LoginForm(userManagement, borrowManagement, bookManagement));
        }
    }
}
