using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioLibrarySystem.Service
{
    public class AppServices
    {
        public UserManagement UserManagement { get; }
        public BookManagement BookManagement { get; }
        public BorrowManagement BorrowManagement { get; }
        public AppServices(UserManagement userManagement, BookManagement bookManagement, BorrowManagement borrowManagement)
        {
            UserManagement = userManagement;
            BookManagement = bookManagement;
            BorrowManagement = borrowManagement;
        }
    }
}
