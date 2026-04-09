using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColegioLibrarySystem.Models;
using ColegioLibrarySystem.Helpers;
using System.Data;
using MySql.Data.MySqlClient;

namespace ColegioLibrarySystem.Repositories
{
    public class DBRepo : IBookRepository
    {
        private readonly DatabaseHelper _databaseHelper;
        public DBRepo(DatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }

        public bool AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public bool AddBookCopy(BookCopy copy)
        {
            throw new NotImplementedException();
        }

        public bool DeleteBook(int bookID)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAllBooks()
        {
            string query = "SELECT * FROM "; //put table name sunod
            return _databaseHelper.ExecuteQuery(query);
        }

        public DataTable GetBookByID(int bookID)
        {
            string query = "SELECT"; //finish dis
            var param = new MySqlParameter[] 
            {
                //new MySqlParameter("")add params//
                
            };
            return _databaseHelper.ExecuteQuery(query, param);
        }

        public bool UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
