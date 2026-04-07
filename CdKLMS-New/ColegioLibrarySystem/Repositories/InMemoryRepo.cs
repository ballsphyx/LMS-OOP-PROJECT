using ColegioLibrarySystem.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColegioLibrarySystem.Models;

namespace ColegioLibrarySystem.Repositories
{
    public class InMemoryRepo : IBookRepository
    {
        private readonly List<Book> _books;
        private readonly List<BookCopy> _booksCopy;
        private int _nextBookID = 1;
        public void AddBook(Book book)
        {
            book.bookID = _nextBookID++;    
            _books.Add(book);
        }

        public void UpdateBook(Book book)
        {
            int index = _books.FindIndex(b => b.bookID == book.bookID);
            if (index >= 0)
                _books[index] = book;
        }

        public void DeleteBook(int id) => _books.RemoveAll(b => b.bookID == id);

        public Book? GetBookByID(int id) => _books.Find(b => b.bookID == id);

        public List<Book> GetAllBooks() => new List<Book>(_books);
    }
}
