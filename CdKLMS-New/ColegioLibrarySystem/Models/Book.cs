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
        public List<BookCopy> Copies { get; set; }
    }
}
