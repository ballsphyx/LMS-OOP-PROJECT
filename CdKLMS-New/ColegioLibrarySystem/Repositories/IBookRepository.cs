using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColegioLibrarySystem.Models;


namespace ColegioLibrarySystem.Repositories
{
    public interface IBookRepository
    {
        bool AddBook(Book book);
        bool AddBookCopy(BookCopy copy);
        bool UpdateBook(Book book);
        bool DeleteBook(int bookID);
        DataTable GetBookByID(int bookID);
        DataTable GetAllBooks();
    }
}
