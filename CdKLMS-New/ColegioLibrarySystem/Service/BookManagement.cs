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
            Book newBook = new Book(bookID, title, author, category, publicationDate, totalCopies);
            return _bookDB.AddBook(newBook);
        }
        public bool UpdateBook(int bookID, string title, string author, string category, DateTime publicationDate, int totalCopies)
        {
            Book updatedBook = new Book(bookID, title, author, category, publicationDate, totalCopies);
            return _bookDB.UpdateBook(updatedBook);
        }
        public bool DeleteBook(int bookID)
        {
            return _bookDB.DeleteBook(bookID);
        }
        public DataTable GetAllBooks()
        {
            return _bookDB.GetAllBooks();
        }
        public DataTable GetBookByID(int bookID)
        {
            return _bookDB.GetBookByID(bookID);
        }
    }
}
