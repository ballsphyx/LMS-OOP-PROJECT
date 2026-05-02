using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColegioLibrarySystem.Helpers;
using ColegioLibrarySystem.Models;

namespace ColegioLibrarySystem.Service
{
    public class BookManagement
    {
        private readonly BookDB _bookDB;

        public BookManagement(BookDB bookDB)
        {
            _bookDB = bookDB;
        }
        public bool AddBook(int bookID, string title, string author, string category, DateTime publicationDate, int totalCopies)
        {
            if (_bookDB.GetBookByID(bookID) != null) return false; //if book exists, stop method
            Book newBook = new Book(bookID, title, author, category, publicationDate, totalCopies);
            return _bookDB.AddBook(newBook);
        }
        public bool AddBookCopy(int bookID)
        {
            if (_bookDB.GetBookByID(bookID) == null) //if book does not exist, stop method. Cannot add a copy of a book that does not exist
            {
                return false;
            }
            BookCopy newCopy = new BookCopy(bookID);
            return _bookDB.AddBookCopy(newCopy);
        }
        public bool UpdateBook(int bookID, string title, string author, string category, DateTime publicationDate, int totalCopies)
        {
            if (_bookDB.GetBookByID(bookID) == null) //if book does not exist, stop method
            {
                return false;
            }
            Book updatedBook = new Book(bookID, title, author, category, publicationDate, totalCopies);
            return _bookDB.UpdateBook(updatedBook);
        }
        public bool DeleteBook(int bookID)
        {
            if (_bookDB.GetBookByID(bookID) == null) //if book does not exist, stop method
            {
                
                return false;
            }
            return _bookDB.DeleteBook(bookID);
        }
        public List<Book> GetAllBooks()
        {
            return _bookDB.GetAllBooks();
        }
        public Book GetBookByID(int bookID)
        {
            return _bookDB.GetBookByID(bookID);
        }
    }
}
