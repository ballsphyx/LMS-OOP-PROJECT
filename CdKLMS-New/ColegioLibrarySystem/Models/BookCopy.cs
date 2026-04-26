using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColegioLibrarySystem.GlobalEnums;

namespace ColegioLibrarySystem.Models
{
    public class BookCopy
    {
        public int CopyId { get; set; }
        public int BookId { get; set; }
        public Status CopyStatus { get; set; } 
        public BookCopy(int bookID)
        {
            this.BookId = bookID;
            CopyStatus = Status.Available;
        }
    }
}
