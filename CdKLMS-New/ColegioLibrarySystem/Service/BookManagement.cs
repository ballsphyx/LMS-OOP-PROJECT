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
        public bool AddBook(string title, string author, CategoryEnum category, int publicationYear, int totalCopies, string isbn)
        {
            if (_bookDB.GetBookByISBN(isbn) != null)
                throw new InvalidOperationException("A book with this ISBN already exists."); //if isbn is found, exit funciton

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
                PublicationYear = publicationYear,
                TotalCopies = totalCopies,
                ISBN = isbn
            };

            return _bookDB.AddBook(newBook);
        }
        private bool AddBookCopy(int bookid)
        {
            Book book = _bookDB.GetBookByID(bookid);
            if (book == null) throw new InvalidOperationException("Book was not found");

            BookCopy newCopy = new BookCopy { BookId = book.BookID, CopyStatus = StatusEnum.Available };
            return _bookDB.AddBookCopy(newCopy);
        }
        public bool UpdateBook(string title, string isbn, string author, CategoryEnum category, int publicationYear, int totalCopies)
        {
            Book book = _bookDB.GetBookByISBN(isbn);
            if (book == null) throw new InvalidOperationException("Book does not exist");

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
                PublicationYear = publicationYear,
                TotalCopies = totalCopies,
                ISBN = isbn
            };

            int current = CountCopies(book.BookID);
            int newTotal = updatedBook.TotalCopies;
            int difference = newTotal - current;
            if (difference > 0)
            {
                for (int i = 0; i < difference; i++)
                {
                    AddBookCopy(book.BookID); 
                }
            }
            else
            {
                DeleteBookCopy(updatedBook.BookID, difference);
            }
                return _bookDB.UpdateBook(updatedBook);
        }
        public bool DeleteBook(int bookid)
        {
            Book book = GetBookByID(bookid);
            if (book == null) 
                throw new InvalidOperationException("Book does not exist");
            if (_transactionDB.HasActiveBookBorrow(book.BookID))
                throw new InvalidOperationException("Book is currently borrowed");//admin cant delete book if it is currently borrowed
            return _bookDB.DeleteBook(bookid);
        }
        public int CountCopies(int bookid)
        {
            return _bookDB.CountAllCopies(bookid);
        }
        private bool DeleteBookCopy(int bookid, int amount)
        {
            int safeAmount = Math.Abs(amount);
            return _bookDB.DeleteBookCopy(bookid, safeAmount);
        }
        public List<Book> GetAllBooks()
        {
            return _bookDB.GetAllBooks();
        }
        public Book GetBookByISBN(string isbn)
        {
            return _bookDB.GetBookByISBN(isbn);
        }
        public List<Book> GetBookByTitle(string title)
        {
            return _bookDB.GetBooksByTitle(title);
        }
        public Book GetBookByID(int bookid)
        {
            return _bookDB.GetBookByID(bookid);
        }
    }
}
