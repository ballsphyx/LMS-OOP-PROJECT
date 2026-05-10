using ColegioLibrarySystem.GlobalEnums;
using ColegioLibrarySystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace ColegioLibrarySystem.Helpers
{
    public class TransactionDB
    {
        private readonly DatabaseHelper _databaseHelper;

        public TransactionDB(DatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }

        private bool AddBorrowRecord(Transaction record)
        {
            string query = @"INSERT INTO transactions (user_id, copy_id, borrow_date, due_date, date_returned, quantity)
                     VALUES (@UserId, @CopyId, @BorrowDate, @DueDate, NULL, @Quantity)";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserId", record.UserID),
                new MySqlParameter("@CopyId", record.CopyID),
                new MySqlParameter("@BorrowDate", record.BorrowDate),
                new MySqlParameter("@DueDate", record.DueDate),
                new MySqlParameter("@Quantity", record.Quantity)
            };

            return _databaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool BorrowBook(Transaction record)
        {
            // Step 1: Add transaction record
            bool borrowAdded = AddBorrowRecord(record);
            if (!borrowAdded) return false;

            // Step 2: Update copy status to Borrowed
            string query = @"UPDATE book_copies SET status = @Status 
                             WHERE copy_id = @CopyId";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Status", StatusEnum.Unavailable.ToString()),
                new MySqlParameter("@CopyId", record.CopyID)
            };

            return _databaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool ReturnBook(int transactionId, int copyId)
        {
            // Step 1: Update date_returned in transactions
            string transQuery = @"UPDATE transactions SET 
                                    date_returned = @DateReturned
                                  WHERE transaction_id = @TransactionId";

            var transParams = new MySqlParameter[]
            {
                new MySqlParameter("@DateReturned", DateTime.Now),
                new MySqlParameter("@TransactionId", transactionId)
            };

            bool updated = _databaseHelper.ExecuteNonQuery(transQuery, transParams) > 0;
            if (!updated) return false;

            // Step 2: Update copy status back to Available
            string copyQuery = @"UPDATE book_copies SET status = @Status 
                                 WHERE copy_id = @CopyId";

            var copyParams = new MySqlParameter[]
            {
                new MySqlParameter("@Status", StatusEnum.Available.ToString()),
                new MySqlParameter("@CopyId", copyId)
            };

            return _databaseHelper.ExecuteNonQuery(copyQuery, copyParams) > 0;
        }

        public bool BorrowExists(int transactionId)
        {
            string query = "SELECT * FROM transactions WHERE transaction_id = @TransactionId";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@TransactionId", transactionId)
            };
            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);
            return dt.Rows.Count > 0;
        }

        public bool HasActiveBookBorrow(int userId, int bookId)
        {
            string query = @"SELECT * FROM transactions t
                     JOIN book_copies bc ON t.copy_id = bc.copy_id
                     WHERE t.user_id = @UserId AND bc.book_id = @BookId 
                     AND t.date_returned IS NULL";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserId", userId),
                new MySqlParameter("@BookId", bookId)
            };

            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);
            return dt.Rows.Count > 0;
        }
        public bool HasActiveBookBorrow(int bookId)
        {
            string query = @"SELECT * FROM transactions t
                     JOIN book_copies bc ON t.copy_id = bc.copy_id
                     WHERE bc.book_id = @BookId AND t.date_returned IS NULL";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@BookId", bookId)
            };

            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);
            return dt.Rows.Count > 0;
        }
        public bool HasActiveBorrow(int userId)
        {
            string query = @"SELECT * FROM transactions 
                             WHERE user_id = @UserId AND date_returned IS NULL";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserId", userId)
            };

            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);
            return dt.Rows.Count > 0;
        }

        public int GetCopyId(int transactionId)
        {
            string query = "SELECT copy_id FROM transactions WHERE transaction_id = @TransactionId";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@TransactionId", transactionId)
            };

            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count == 0) return -1;
            return Convert.ToInt32(dt.Rows[0]["copy_id"]);
        }

        public List<Transaction> GetAllBorrows()
        {
            string query = @"SELECT * FROM transactions";

            DataTable dt = _databaseHelper.ExecuteQuery(query);
            return MapTransactions(dt);
        }

        public List<Transaction> GetActiveBorrows()
        {
            string query = @"SELECT transaction_id, user_id, copy_id, borrow_date, due_date, date_returned
                             FROM transactions
                             WHERE date_returned IS NULL";

            DataTable dt = _databaseHelper.ExecuteQuery(query);
            return MapTransactions(dt);
        }

        public List<Transaction> GetBorrowsByUser(int userId)
        {
            string query = @"SELECT transaction_id, user_id, copy_id, borrow_date, due_date, date_returned
                             FROM transactions
                             WHERE user_id = @UserId";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserId", userId)
            };

            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);
            return MapTransactions(dt);
        }

        private Transaction MapTransaction(DataRow row)
        {
            return new Transaction
            {
                TransactionId = Convert.ToInt32(row["transaction_id"]),
                UserID = Convert.ToInt32(row["user_id"]),
                CopyID = Convert.ToInt32(row["copy_id"]),
                BorrowDate = Convert.ToDateTime(row["borrow_date"]),
                DueDate = Convert.ToDateTime(row["due_date"]),
                DateReturned = row["date_returned"] == DBNull.Value
                               ? (DateTime?)null
                               : Convert.ToDateTime(row["date_returned"]),
                Quantity = Convert.ToInt32(row["quantity"])
            };
        }

        private List<Transaction> MapTransactions(DataTable dt)
        {
            List<Transaction> transactions = new List<Transaction>();
            foreach (DataRow row in dt.Rows)
            {
                transactions.Add(MapTransaction(row));
            }
            return transactions;
        }
    }
}