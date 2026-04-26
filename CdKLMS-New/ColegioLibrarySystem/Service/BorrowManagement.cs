using ColegioLibrarySystem.GlobalEnums;
using ColegioLibrarySystem.Helpers;
using ColegioLibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioLibrarySystem.Service
{
    public class BorrowManagement
    {
        private readonly BorrowDB _borrowDB;
        private readonly BookDB _bookDB;
        private readonly UserDB _userDB;
        public BorrowManagement(BorrowDB borrowDB, BookDB bookDB, UserDB userDB)
        {
            _borrowDB = borrowDB;
            _bookDB = bookDB;
            _userDB = userDB;
        }
        public bool BorrowBook(int userID, int bookID, Roles role)
        {
            if (_userDB.GetUsersByID(userID).Rows.Count == 0) return false;
            if (_bookDB.GetBookByID(bookID).Rows.Count == 0) return false;
            if (role == Roles.Student && _borrowDB.HasActiveBorrow(userID)) return false;

            int copyID = _bookDB.GetAvailableCopy(bookID);
            if (copyID == -1) return false;
            if (_borrowDB.HasBorrowedCopy(userID, copyID)) return false;

            BorrowRecord record = new BorrowRecord
            {
                UserID = userID,
                BookID = bookID,
                CopyID = copyID,
                BorrowDate = DateTime.Now
            };

            _bookDB.UpdateCopyStatus(copyID, Status.Unavailable);
            bool success = _borrowDB.AddBorrowRecord(record);
            if (!success) _bookDB.UpdateCopyStatus(copyID, Status.Available); 
            return success;
        }

        public bool ReturnBook(int borrowID)
        {
            if (!_borrowDB.BorrowExists(borrowID)) return false;

            int copyID = _borrowDB.GetCopyID(borrowID);
            if (copyID == -1) return false;

            BorrowRecord record = new BorrowRecord
            {
                BorrowId = borrowID,
                ReturnDate = DateTime.Now
            };

            _bookDB.UpdateCopyStatus(copyID, Status.Available);
            bool success = _borrowDB.UpdateReturnDate(record);
            if (!success) _bookDB.UpdateCopyStatus(copyID, Status.Unavailable); 
            return success;
        }

        public DataTable GetAllBorrows()
        {
            return _borrowDB.GetAllBorrows();
        }

        public DataTable GetActiveBorrows()
        {
            return _borrowDB.GetActiveBorrows();
        }

        public DataTable GetBorrowsByUser(int userID)
        {
            return _borrowDB.GetBorrowsByUser(userID);
        }
    }
}
