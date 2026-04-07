using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColegioLibrarySystem.Repositories;
using ColegioLibrarySystem.Models;

namespace ColegioLibrarySystem.Services
{
    public class UserService
    {
        private readonly IBookRepository _bookRepository;
        public UserService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public void AddBook(Book book)
        {
            if (string.IsNullOrEmpty(book.title) || string.IsNullOrEmpty(book.author))
                throw new ArgumentException("Book title and author cannot be empty.");
            _bookRepository.AddBook(book);
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
            return _bookRepository.GetBookByID(bookID);
        }
        public List<Book> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }
    }
}
