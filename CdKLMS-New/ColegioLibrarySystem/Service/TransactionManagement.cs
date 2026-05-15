using ColegioLibrarySystem.GlobalEnums;
using ColegioLibrarySystem.Helpers;
using ColegioLibrarySystem.Models;
using System.Data;

namespace ColegioLibrarySystem.Service
{
    public class TransactionManagement
    {
        private readonly TransactionDB _transactionDB;
        private readonly BookDB _bookDB;
        public TransactionManagement(TransactionDB borrowDB, BookDB bookDB)
        {
            _transactionDB = borrowDB;
            _bookDB = bookDB;
        }

        public bool BorrowBook(int bookID, int quantity = 1)
        {
            if (!Session.IsLoggedIn) return false;

            int userId = Session.CurrentUser.UserId;
            Roles role = Session.CurrentUser.Role;

            Book book = _bookDB.GetBookByID(bookID);
            if (book == null) return false;

            if (role.RoleName == RoleEnum.Student)
            {
                quantity = 1;
                if (_transactionDB.HasActiveBookBorrow(userId, book.BookID)) throw new InvalidOperationException("Student is currently borrowing a copy of this book");
            }
            if (quantity <= 0) throw new InvalidOperationException("Borrow quantity must be greater than zero");
            int availableCount = _bookDB.CountAvailableCopies(book.BookID);
            if (availableCount < quantity) throw new InvalidOperationException("Borrow quantity is greater than available copies");

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

                bool success = _transactionDB.BorrowBook(record);
                if (!success) return false;
            }

            return true;
        }
        public bool ReturnBook(int transactionId)
        {
            if (!_transactionDB.BorrowExists(transactionId)) throw new InvalidOperationException("Borrow record does not exist"); //if this borrow record does not exist, exit function

            int copyId = _transactionDB.GetCopyId(transactionId);
            if (copyId == -1) return false;

            return _transactionDB.ReturnBook(transactionId, copyId);
        }

        public List<Transaction> GetAllBorrows()
        {
            return _transactionDB.GetAllBorrows();
        }

        public List<Transaction> GetActiveBorrows()
        {
            return _transactionDB.GetActiveBorrows();
        }

        public DataTable GetBorrowsByUser(int userId)
        {
            return _transactionDB.GetBorrowsByUser(userId);
        }
    }
}