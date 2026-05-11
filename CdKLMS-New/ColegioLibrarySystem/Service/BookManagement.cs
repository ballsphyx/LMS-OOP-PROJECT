using ColegioLibrarySystem.Helpers;
using ColegioLibrarySystem.Models;
using ColegioLibrarySystem.GlobalEnums;

namespace ColegioLibrarySystem.Service
{
    public class BookManagement
    {
        private readonly BookDB _bookDB;
        private readonly TransactionDB _transactionDB;

        public BookManagement(BookDB bookDB, TransactionDB transactionDB)
        {
            _bookDB = bookDB;
            _transactionDB = transactionDB;
        }
        public bool AddBook(string title, string author, CategoryEnum category, DateTime publicationDate, int totalCopies, string isbn)
        {
            if (_bookDB.GetBookByISBN(isbn) != null) return false; //if isbn is not found, exit funciton

            Book newBook = new Book
            {
                Title = title,
                Author = author,
                CatId = (int)category,          // cast enum to int for DB
                Category = new Category         // navigation property
                {
                    CatId = (int)category,
                    CatName = category
                },
                PublicationDate = publicationDate,
                TotalCopies = totalCopies,
                ISBN = isbn
            };

            return _bookDB.AddBook(newBook);
        }
        public bool AddBookCopy(string isbn)
        {
            Book book = _bookDB.GetBookByISBN(isbn);
            if (book == null) return false;

            BookCopy newCopy = new BookCopy { BookId = book.BookID, CopyStatus = StatusEnum.Available };
            return _bookDB.AddBookCopy(newCopy);
        }
        public bool UpdateBook(string isbn, string title, string author, CategoryEnum category, DateTime publicationDate, int totalCopies)
        {
            Book book = _bookDB.GetBookByISBN(isbn);
            if (book == null) return false;

            Book updatedBook = new Book
            {
                BookID = book.BookID,  // get ID from the found book
                Title = title,
                Author = author,
                CatId = (int)category,
                Category = new Category
                {
                    CatId = (int)category,
                    CatName = category
                },
                PublicationDate = publicationDate,
                TotalCopies = totalCopies,
                ISBN = isbn
            };

            return _bookDB.UpdateBook(updatedBook);
        }
        public bool DeleteBook(string isbn)
        {
            Book book = GetBookByISBN(isbn);
            if (book == null) return false;
            if (_transactionDB.HasActiveBookBorrow(book.BookID)) return false; //admin cant delete book if it is currently borrowed
            return _bookDB.DeleteBook(isbn);
        }
        public List<Book> GetAllBooks()
        {
            return _bookDB.GetAllBooks();
        }
        public Book GetBookByISBN(string isbn)
        {
            return _bookDB.GetBookByISBN(isbn);
        }
    }
}
