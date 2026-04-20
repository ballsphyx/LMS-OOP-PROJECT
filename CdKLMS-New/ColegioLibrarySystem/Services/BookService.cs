using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColegioLibrarySystem.Repositories;
using ColegioLibrarySystem.Models;
using ColegioLibrarySystem.GlobalEnums;

namespace ColegioLibrarySystem.Services
{
    public class BookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public void AddBook(Book book, int numCopies)
        {
            _bookRepository.AddBook(book);
                for (int i = 0; i < numCopies; i++)
                {
                    var copy = new BookCopy
                    {
                        bookID = book.bookID,
                        isAvailable = Status.Available
                    };
                    _bookRepository.AddBookCopy(copy);
            }
        }
        public void AddCopy(int bookID, int numCopies)
        {
            for (int i = 0; i < numCopies; i++)
            {
                var copy = new BookCopy
                {
                    bookID = bookID,
                    isAvailable = Status.Available
                };
                _bookRepository.AddBookCopy(copy);
            }
        }
        public void UpdateBook(Book book)
        {
            _bookRepository.UpdateBook(book);
        }
        public void DeleteBook(int bookID)
        {
            _bookRepository.DeleteBook(bookID);
        }
        public Book GetBookByID(int bookID)
        {
            throw new NotImplementedException();
        }
        public List<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }
    }
}
