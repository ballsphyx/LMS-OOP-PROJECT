using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColegioLibrarySystem.Models;
using System.Data;
using MySql.Data.MySqlClient;
using ColegioLibrarySystem.GlobalEnums;

namespace ColegioLibrarySystem.Helpers
{
    public class BookDB
    {
        private readonly DatabaseHelper _databaseHelper;
        public BookDB(DatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }

        public bool AddBook(Book book)
        {
            string bookQuery = @"INSERT INTO BOOKS (bookId, title, author, category, publicationDate, totalCopies)
                         VALUES (@BookID, @Title, @Author, @Category, @PublicationDate, @TotalCopies)";
            var bookParams = new MySqlParameter[]
            {
        new MySqlParameter("@BookID", book.BookID),
        new MySqlParameter("@Title", book.Title),
        new MySqlParameter("@Author", book.Author),
        new MySqlParameter("@Category", book.Category),
        new MySqlParameter("@PublicationDate", book.PublicationDate),
        new MySqlParameter("@TotalCopies", book.TotalCopies)
            };

            int rowsAffected = _databaseHelper.ExecuteNonQuery(bookQuery, bookParams);
            if (rowsAffected == 0) return false;

            for (int i = 0; i < book.TotalCopies; i++)
                if (!AddBookCopy(new BookCopy(book.BookID))) return false;

            return true;
        }

        public bool AddBookCopy(BookCopy copy)
        {
            string query = @"INSERT INTO BOOK_COPIES (book_id, status)
                     VALUES (@BookID, @Status)";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@BookID", copy.BookId),
                new MySqlParameter("@Status", copy.CopyStatus)
            };
            int rowsAffected = _databaseHelper.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool DeleteBook(int bookID)
        {
            string query = "DELETE FROM BOOKS WHERE bookId = @bookID";
            var param = new MySqlParameter[]
            {
                new MySqlParameter("@bookID", bookID)
            };
            return _databaseHelper.ExecuteNonQuery(query, param) > 0;
        }

        public List<Book> GetAllBooks()
        {
            string query = "SELECT * FROM BOOKS";
            DataTable dt = _databaseHelper.ExecuteQuery(query);
            List<Book> books = new List<Book>();

            foreach (DataRow row in dt.Rows)
            {
                books.Add(new Book(
                    Convert.ToInt32(row["bookId"]),
                    row["title"].ToString(),
                    row["author"].ToString(),
                    row["category"].ToString(),
                    Convert.ToDateTime(row["publicationDate"]),
                    Convert.ToInt32(row["totalCopies"])
                ));
            }
            return books;
        }


        public Book GetBookByID(int bookID)
        {
            string query = "SELECT * FROM BOOKS WHERE bookId = @bookID";
            var param = new MySqlParameter[]
            {
                new MySqlParameter("@bookID", bookID)
            };
            DataTable dt = _databaseHelper.ExecuteQuery(query, param);
            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];

            return new Book(Convert.ToInt32(row["bookId"]),
                    row["title"].ToString(),
                    row["author"].ToString(),
                    row["category"].ToString(),
                    Convert.ToDateTime(row["publicationDate"]),
                    Convert.ToInt32(row["totalCopies"]));
        }

        public bool UpdateBook(Book book)
        {
            string query = @"UPDATE BOOKS SET title = @Title, author = @Author, category = @Category, publicationDate = @PublicationDate
                 WHERE bookId = @BookID";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@BookID", book.BookID),
                new MySqlParameter("@Title", book.Title),
                new MySqlParameter("@Author", book.Author),
                new MySqlParameter("@Category", book.Category),
                new MySqlParameter("@PublicationDate", book.PublicationDate)
            };

            int rowsAffected = _databaseHelper.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
        public int GetAvailableCopy(int bookID)
        {
            string query = @"SELECT copy_id FROM BOOK_COPIES 
                     WHERE book_id = @BookID AND status = 'Available' 
                     LIMIT 1";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@BookID", bookID)
            };
            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count == 0)
                return -1;
            return Convert.ToInt32(dt.Rows[0]["copy_id"]);
        }
        public bool UpdateCopyStatus(int copyID, Status status)
        {
            string query = "UPDATE BOOK_COPIES SET status = @Status WHERE copy_id = @CopyID";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Status", status.ToString()),
                new MySqlParameter("@CopyID", copyID)
            };
            return _databaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
