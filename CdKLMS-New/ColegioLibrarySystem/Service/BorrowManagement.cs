using ColegioLibrarySystem.GlobalEnums;
using ColegioLibrarySystem.Helpers;
using ColegioLibrarySystem.Models;
using System;
using System.Collections.Generic;

namespace ColegioLibrarySystem.Service
{
    public class BorrowManagement
    {
        private readonly TransactionDB _borrowDB;
        private readonly BookDB _bookDB;
        private readonly UserDB _userDB;

        public BorrowManagement(TransactionDB borrowDB, BookDB bookDB, UserDB userDB)
        {
            _borrowDB = borrowDB;
            _bookDB = bookDB;
            _userDB = userDB;
        }

        public bool BorrowBook(string isbn, int userId, Roles role, int quantity = 1)
        {
            if (_userDB.GetUserByID(userId) == null) return false; //if user does not exist, exit function
            Book book = _bookDB.GetBookByISBN(isbn); //find book by ISBN since isbn are unique per book
            if (book == null) return false; //if ISBN was not found, exit function

            if (role.RoleName == RoleEnum.Student) //if role is student, initialize quantity to only 1
            {
                quantity = 1;
                if (_borrowDB.HasActiveBookBorrow(userId, book.BookID)) return false; //if student is already borrowing this book, exit function
            }

            int availableCount = _bookDB.GetAvailableCopies(book.BookID);
            if (availableCount < quantity) return false;

            int copyId = _bookDB.GetAvailableCopyId(book.BookID);
            if (copyId == -1) return false;

            Transaction record = new Transaction
            {
                UserID = userId,
                CopyID = copyId,
                BorrowDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(7),
                DateReturned = null,
                Quantity = quantity
            };

            return _borrowDB.BorrowBook(record);
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