using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColegioLibrarySystem.Models;
using System.Data;
using MySql.Data.MySqlClient;

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
            string query = @"INSERT INTO BOOKS (title, author, isbn, genre)
                     VALUES (@BookID, @Title, @Author, @Category, @PublicationDate, @TotalCopies, @Available)";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@BookID",  book.bookID  ),
                new MySqlParameter("@Title",  book.title  ),
                new MySqlParameter("@Author", book.author ),
                new MySqlParameter("@Category",   book.category   ),
                new MySqlParameter("@PublicationDate",  book.publicationDate  ),
                new MySqlParameter("@TotalCopies", book.totalCopies),
                new MySqlParameter("@Available", book.available)
            };

            int rowsAffected = _databaseHelper.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool AddBookCopy(BookCopy copy)
        {
            string query = @"INSERT INTO BOOK_COPIES (book_id, copy_number, status)
                     VALUES (@BookID, @CopyNumber, @Status)";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@BookID", copy.bookID),
                new MySqlParameter("@CopyNumber", copy.copyID),
                new MySqlParameter("@Status", copy.isAvailable)
            };
            int rowsAffected = _databaseHelper.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool DeleteBook(int bookID)
        {
            string query = "DELETE FROM BOOKS WHERE ID = @bookID";
            var param = new MySqlParameter[]
            {
                new MySqlParameter("@bookID", bookID)
            };
            return _databaseHelper.ExecuteNonQuery(query, param) > 0;
        }

        public DataTable GetAllBooks()
        {
            string query = "SELECT * FROM BOOKS";
            return _databaseHelper.ExecuteQuery(query);
        }

        public DataTable GetBookByID(int bookID)
        {
            string query = "SELECT * FROM BOOKS WHERE ID = @bookID";
            var param = new MySqlParameter[]
            {
                new MySqlParameter("@bookID", bookID)
            };
            return _databaseHelper.ExecuteQuery(query, param);
        }

        public bool UpdateBook(Book book)
        {
            string query = @"UPDATE BOOKS SET title = @Title, author = @Author, isbn = @Isbn, genre = @Genre
                             WHERE ID = @BookID";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@BookID", book.bookID),
                new MySqlParameter("@Title", book.title),
                new MySqlParameter("@Author", book.author),
                new MySqlParameter("@Category", book.category),
                new MySqlParameter("@PublicationDate", book.publicationDate)
            };

            int rowsAffected = _databaseHelper.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
    }
}
