using ColegioLibrarySystem.GlobalEnums;
using ColegioLibrarySystem.Models;
using MySql.Data.MySqlClient;
using System.Data;

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
            string bookQuery = @"INSERT INTO books (book_title, book_author, category_id, published_year, isbn)
                                 VALUES (@Title, @Author, @CategoryId, @PublishedYear, @ISBN)";

            var bookParams = new MySqlParameter[]
            {
                new MySqlParameter("@Title", book.Title),
                new MySqlParameter("@Author", book.Author),
                new MySqlParameter("@CategoryId", book.CatId),
                new MySqlParameter("@PublishedYear", book.PublicationYear),
                new MySqlParameter("@ISBN", book.ISBN)
            };

            int newBookId = _databaseHelper.ExecuteNonQueryGetID(bookQuery, bookParams);
            if (newBookId <= 0) return false;

            for (int i = 0; i < book.TotalCopies; i++)
            {
                var copy = new BookCopy { BookId = newBookId, CopyStatus = StatusEnum.Available };
                AddBookCopy(copy);
            }

            return true;
        }

        public bool AddBookCopy(BookCopy copy)
        {
            string query = @"INSERT INTO book_copies (book_id, status) 
                             VALUES (@BookId, @Status)";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@BookId", copy.BookId),
                new MySqlParameter("@Status", copy.CopyStatus.ToString())
            };

            return _databaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateBook(Book book)
        {
            string query = @"UPDATE books SET 
                                book_title = @Title, 
                                book_author = @Author, 
                                category_id = @CategoryId, 
                                published_year = @PublishedYear,
                                isbn = @ISBN
                             WHERE book_id = @BookId";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@BookId", book.BookID),
                new MySqlParameter("@Title", book.Title),
                new MySqlParameter("@Author", book.Author),
                new MySqlParameter("@CategoryId", book.CatId),
                new MySqlParameter("@PublishedYear", book.PublicationYear),
                new MySqlParameter("@ISBN", book.ISBN),
            };

            return _databaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteBook(int bookid)
        {
            string query = "DELETE FROM books WHERE book_id = @BookID";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@BookID", bookid)
            };
            return _databaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public bool DeleteBookCopy(int bookid, int amount)
        {
            string query = "DELETE FROM book_copies WHERE book_id = @BOOKID AND status = 'Available' LIMIT " + amount;
            var param = new MySqlParameter[]
            {
                new MySqlParameter("@BOOKID", bookid)
            };
            return _databaseHelper.ExecuteNonQuery(query, param) > 0;
        }

        //public List<Book> GetAllBooks()
        //{
        //    string query = @"SELECT *
        //                     FROM books";

        //    DataTable dt = _databaseHelper.ExecuteQuery(query);
        //    return MapBooks(dt);
        //}
        public List<Book> GetAllBooks()
        {
            string query = @"SELECT b.*,
                             COUNT(bc.copy_id) AS TotalCopies,

                                COUNT(CASE 
                                    WHEN bc.status = 'Available' THEN 1 
                                END) AS AvailableCopies

                             FROM books b

                             LEFT JOIN book_copies bc 
                             ON b.book_id = bc.book_id

                             GROUP BY b.book_id";

            DataTable dt = _databaseHelper.ExecuteQuery(query);
            return MapBooks(dt);
        }

        public Book GetBookByISBN(string isbn)
        {
            string query = @"SELECT *
                             FROM books
                             WHERE isbn = @ISBN";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@ISBN", isbn)
            };

            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count == 0) return null;

            return MapBook(dt.Rows[0]);
        }
        public Book GetBookByID(int ID)
        {
            string query = @"SELECT * FROM books WHERE book_id = @BOOKID";
            var param = new MySqlParameter[]
            {
                new MySqlParameter("@BOOKID", ID)
            };
            DataTable dt = _databaseHelper.ExecuteQuery(query, param);
            if (dt.Rows.Count == 0) return null;

            return MapBook(dt.Rows[0]);
        }

        public List<Book> GetBooksByTitle(string title)
        {
            string query = @"SELECT *
                             FROM books
                             WHERE book_title LIKE @Title";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Title", $"%{title}%")
            };

            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);
            return MapBooks(dt);
        }

        public List<Book> GetBooksByCategory(CategoryEnum category)
        {
            string query = @"SELECT *
                             FROM books
                             WHERE category_id = @CategoryId";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@CategoryId", (int)category)
            };

            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);
            return MapBooks(dt);
        }
        public int CountAllCopies(int bookId)
        {
            string query = @"SELECT COUNT(*) as numCopies FROM book_copies WHERE book_id = @BOOKID";
            var parameters =  new MySqlParameter[]
            {
                new MySqlParameter("@BOOKID", bookId)
            };
            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);
            return Convert.ToInt32(dt.Rows[0]["numCopies"]);
        }
        public int CountAvailableCopies(int bookId)
        {
            string query = @"SELECT COUNT(*) as available FROM book_copies 
                             WHERE book_id = @BookId AND status = 'Available'";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@BookId", bookId)
            };

            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);
            return Convert.ToInt32(dt.Rows[0]["available"]);
        }
        public List<int> GetAvailableCopyIds(int bookId, int quantity)
        {
            string query = @"SELECT copy_id FROM book_copies 
                     WHERE book_id = @BookId AND status = @Status
                     LIMIT @Quantity";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@BookId", bookId),
                new MySqlParameter("@Status", StatusEnum.Available.ToString()),
                new MySqlParameter("@Quantity", quantity)
            };

            DataTable dt = _databaseHelper.ExecuteQuery(query, parameters);
            List<int> copyIds = new List<int>();
            foreach (DataRow row in dt.Rows)
            {
                copyIds.Add(Convert.ToInt32(row["copy_id"]));
            }
            return copyIds;
        }

        private Book MapBook(DataRow row)
        {
            var book = new Book
            {
                BookID = Convert.ToInt32(row["book_id"]),
                Title = row["book_title"].ToString(),
                Author = row["book_author"].ToString(),
                CatId = Convert.ToInt32(row["category_id"]),
                Category = new Category
                {
                    CatId = Convert.ToInt32(row["category_id"]),
                    CatName = (CategoryEnum)Convert.ToInt32(row["category_id"])
                },
                PublicationYear = Convert.ToInt32(row["published_year"]),
                ISBN = row["isbn"].ToString(),
            };

                if (row.Table.Columns.Contains("TotalCopies"))
                book.TotalCopies = Convert.ToInt32(row["TotalCopies"]);

                if (row.Table.Columns.Contains("AvailableCopies"))
                book.AvailableCopies = Convert.ToInt32(row["AvailableCopies"]);
            return book;
        }
        

        private List<Book> MapBooks(DataTable dt)
        {
            List<Book> books = new List<Book>();
            foreach (DataRow row in dt.Rows)
            {
                books.Add(MapBook(row));
            }
            return books;
        }
    }
}