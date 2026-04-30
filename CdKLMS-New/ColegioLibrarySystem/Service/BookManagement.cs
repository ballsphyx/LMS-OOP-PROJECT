//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using ColegioLibrarySystem.Helpers;
//using ColegioLibrarySystem.Models;

//namespace ColegioLibrarySystem.Service
//{
//    public class BookManagement
//    {
//        private readonly BookDB _bookDB;

//        public BookManagement(BookDB bookDB)
//        {
//            _bookDB = bookDB;
//        }
//        public bool AddBook(int bookID, string title, string author, string category, DateTime publicationDate, int totalCopies)
//        {
//            if (_bookDB.GetBookByID(bookID).Rows.Count > 0) return false;
//            Book newBook = new Book(bookID, title, author, category, publicationDate, totalCopies);
//            return _bookDB.AddBook(newBook);
//        }
//        public bool AddBookCopy(int bookID)
//        {
//            //validate that book exists before adding copy//
//            if (_bookDB.GetBookByID(bookID).Rows.Count == 0)
//            {
//                return false;
//            }
//            BookCopy newCopy = new BookCopy(bookID);
//            return _bookDB.AddBookCopy(newCopy);
//        }
//        public bool UpdateBook(int bookID, string title, string author, string category, DateTime publicationDate, int totalCopies)
//        {
//            //validate that book exists before updating//
//            if (_bookDB.GetBookByID(bookID).Rows.Count == 0)
//            {
//                return false;
//            }
//            Book updatedBook = new Book(bookID, title, author, category, publicationDate, totalCopies);
//            return _bookDB.UpdateBook(updatedBook);
//        }
//        public bool DeleteBook(int bookID)
//        {
//            //validate that book exists before deleting//
//            if (_bookDB.GetBookByID(bookID).Rows.Count == 0)
//            {
//                return false;
//            }
//            return _bookDB.DeleteBook(bookID);
//        }
//        public DataTable GetAllBooks()
//        {
//            return _bookDB.GetAllBooks();
//        }
//        public DataTable GetBookByID(int bookID)
//        {
//            return _bookDB.GetBookByID(bookID);
//        }
//    }
//}
