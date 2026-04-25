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
        public int bookID { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string category { get; set; }
        public DateTime publicationDate { get; set; }
        public int totalCopies;
        public Book(int bookID, string title, string author, string category, DateTime publicationDate, int totalCopies)
        {
            this.bookID = bookID;
            this.title = title;
            this.author = author;
            this.category = category;
            this.publicationDate = publicationDate;
            this.totalCopies = totalCopies;
        }
    }
}
