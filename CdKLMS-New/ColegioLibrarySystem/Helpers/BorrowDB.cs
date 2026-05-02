using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColegioLibrarySystem.Models;

namespace ColegioLibrarySystem.Helpers
{
    public class BorrowDB
    {
        private readonly DatabaseHelper _databaseHelper;

        public BorrowDB(DatabaseHelper dbHelper)
        {
            _databaseHelper = dbHelper;
        }
        public bool AddBorrowRecord(BorrowRecord record)
        {
            string query = @"INSERT INTO BORROWRECORD (user_id, book_id, copy_id, borrow_date, due_date, return_date)
                     VALUES (@UserID, @BookID, @CopyID, @BorrowDate, @DueDate, NULL)";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserID", record.UserID),
                new MySqlParameter("@BookID", record.BookID),
                new MySqlParameter("@CopyID", record.CopyID),
                new MySqlParameter("@BorrowDate", record.BorrowDate),
                new MySqlParameter("@DueDate", record.DueDate),
            };
            return _databaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateReturnDate(BorrowRecord record)
        {
            string query = @"UPDATE BORROWRECORD SET return_date = @ReturnDate 
                     WHERE borrow_id = @BorrowID";
            var parameters = new MySqlParameter[]
            {
        new MySqlParameter("@ReturnDate", record.ReturnDate),
        new MySqlParameter("@BorrowID", record.BorrowId)
            };
            return _databaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool BorrowExists(int borrowID)
        {
            string query = "SELECT * FROM BORROWRECORD WHERE borrow_id = @BorrowID";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@BorrowID", borrowID)
            };
            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);
            return dt.Rows.Count > 0;
        }

        public bool HasEverBorrowedBook(int userID, int bookID)
        {
            string query = @"SELECT * FROM BORROWRECORD 
                     WHERE user_id = @UserID AND book_id = @BookID";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserID", userID),
                new MySqlParameter("@BookID", bookID)
            };
            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);
            return dt.Rows.Count > 0;
        }
        public bool HasActiveBookBorrow(int userID, int bookID)
        {
            string query = @"SELECT * FROM BORROWRECORD
                     WHERE user_id = @UserID AND book_id = @BookID 
                     AND return_date IS NULL";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserID", userID),
                new MySqlParameter("@BookID", bookID)
            };
            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);
            return dt.Rows.Count > 0;
        }

        public bool HasBorrowedCopy(int userID, int copyID)
        {
            string query = @"SELECT * FROM BORROWRECORD 
                             WHERE user_id = @UserID AND copy_id = @CopyID AND return_date IS NULL";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserID", userID),
                new MySqlParameter("@CopyID", copyID)
            };
            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);
            return dt.Rows.Count > 0;
        }

        public int GetCopyID(int borrowID)
        {
            string query = "SELECT copy_id FROM BORROWRECORD WHERE borrow_id = @BorrowID";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@BorrowID", borrowID)
            };
            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count == 0)
                return -1;
            return Convert.ToInt32(dt.Rows[0]["copy_id"]);
        }

        public DataTable GetAllBorrows()
        {
            string query = @"SELECT b.borrow_id, u.username, bk.title, bc.copy_number, 
                                    b.borrow_date, b.return_date
                             FROM BORROWS b
                             JOIN USERS u ON b.user_id = u.ID
                             JOIN BOOK_COPIES bc ON b.copy_id = bc.copy_id
                             JOIN BOOKS bk ON bc.book_id = bk.bookId";
            return _databaseHelper.ExecuteQuery(query);
        }

        public DataTable GetActiveBorrows()
        {
            string query = @"SELECT b.borrow_id, u.username, bk.title, bc.copy_number, 
                                    b.borrow_date
                             FROM BORROWS b
                             JOIN USERS u ON b.user_id = u.ID
                             JOIN BOOK_COPIES bc ON b.copy_id = bc.copy_id
                             JOIN BOOKS bk ON bc.book_id = bk.bookId
                             WHERE b.return_date IS NULL";
            return _databaseHelper.ExecuteQuery(query);
        }

        public DataTable GetBorrowsByUser(int userID)
        {
            string query = @"SELECT b.borrow_id, bk.title, bc.copy_number, 
                                    b.borrow_date, b.return_date
                             FROM BORROWS b
                             JOIN BOOK_COPIES bc ON b.copy_id = bc.copy_id
                             JOIN BOOKS bk ON bc.book_id = bk.bookId
                             WHERE b.user_id = @UserID";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserID", userID)
            };
            return _databaseHelper.ExecuteQuery(query, parameters);
        }
        public bool HasActiveBorrow(int userID)
        {
            string query = @"SELECT * FROM BORROWRECORD 
                     WHERE user_id = @UserID AND return_date IS NULL";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserID", userID)
            };
            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);
            return dt.Rows.Count > 0;
        }
    }
}
