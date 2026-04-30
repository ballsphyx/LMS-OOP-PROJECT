using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using ColegioLibrarySystem.Models;

namespace ColegioLibrarySystem.Helpers
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookCopy> BookCopies { get; set; }
        public DbSet<BorrowRecord> BorrowRecords { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=librarydb;user=root;password=;", 
                ServerVersion.AutoDetect("server=localhost;database=librarydb;user=root;password=;"));
        }
    }
}