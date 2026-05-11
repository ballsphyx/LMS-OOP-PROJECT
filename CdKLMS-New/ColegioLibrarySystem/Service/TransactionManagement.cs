using ColegioLibrarySystem.GlobalEnums;
using ColegioLibrarySystem.Helpers;
using ColegioLibrarySystem.Models;

namespace ColegioLibrarySystem.Service
{
    public class TransactionManagement
    {
        private readonly TransactionDB _borrowDB;
        private readonly BookDB _bookDB;
        public TransactionManagement(TransactionDB borrowDB, BookDB bookDB)
        {
            _borrowDB = borrowDB;
            _bookDB = bookDB;
        }

        public bool BorrowBook(string isbn, int quantity = 1)
        {
            if (!Session.IsLoggedIn) return false;

            int userId = Session.CurrentUser.UserId;
            Roles role = Session.CurrentUser.Role;

            Book book = _bookDB.GetBookByISBN(isbn);
            if (book == null) return false;

            if (role.RoleName == RoleEnum.Student)
            {
                quantity = 1;
                if (_borrowDB.HasActiveBookBorrow(userId, book.BookID)) return false;
            }

            int availableCount = _bookDB.GetAvailableCopies(book.BookID);
            if (availableCount < quantity) return false;

            List<int> copyIds = _bookDB.GetAvailableCopyIds(book.BookID, quantity);
            if (copyIds.Count < quantity) return false;

            foreach (int copyId in copyIds)
            {
                Transaction record = new Transaction
                {
                    UserID = userId,
                    CopyID = copyId,
                    BorrowDate = DateTime.Now,
                    DueDate = DateTime.Now.AddDays(7),
                    DateReturned = null,
                    Quantity = quantity
                };

                bool success = _borrowDB.BorrowBook(record);
                if (!success) return false;
            }

            return true;
        }
        public bool ReturnBook(int transactionId)
        {
            if (!_borrowDB.BorrowExists(transactionId)) return false; //if this borrow record does not exist, exit function

            int copyId = _borrowDB.GetCopyId(transactionId);
            if (copyId == -1) return false;

            return _borrowDB.ReturnBook(transactionId, copyId);
        }

        public List<Transaction> GetAllBorrows()
        {
            return _borrowDB.GetAllBorrows();
        }

        public List<Transaction> GetActiveBorrows()
        {
            return _borrowDB.GetActiveBorrows();
        }

        public List<Transaction> GetBorrowsByUser(int userId)
        {
            return _borrowDB.GetBorrowsByUser(userId);
        }
    }
}