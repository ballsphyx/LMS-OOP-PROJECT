using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColegioLibrarySystem.GlobalEnums;
namespace ColegioLibrarySystem.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public DateTime PublicationDate { get; set; }
        public int TotalCopies { get; set; }
        public List<BookCopy> BookCopies { get; set; }
        public Book(int bookID, string title, string author, string category, DateTime publicationDate, int totalCopies)
        {
            this.BookID = bookID;
            this.Title = title;
            this.Author = author;
            this.Category = category;
            this.PublicationDate = publicationDate;
            this.TotalCopies = totalCopies;
        }
        public Book(string title, string author, string category, DateTime publicationDate, int totalCopies)
        {
            this.Title = title;
            this.Author = author;
            this.Category = category;
            this.PublicationDate = publicationDate;
            this.TotalCopies = totalCopies;
        }
    }
}
