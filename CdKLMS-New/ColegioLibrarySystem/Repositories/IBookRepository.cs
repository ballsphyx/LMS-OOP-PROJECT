using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColegioLibrarySystem.Models;

namespace ColegioLibrarySystem.Repositories
{
    public interface IBookRepository
    {
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int bookID);
        Book? GetBookByID(int bookID);
        List<Book> GetAllBooks();
    }
}
