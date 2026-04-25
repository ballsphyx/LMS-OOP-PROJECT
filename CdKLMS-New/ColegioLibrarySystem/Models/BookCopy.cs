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
        public int copyID { get; set; }
        public int bookID { get; set; }
        public Status isAvailable { get; set; } 
        public BookCopy(int copyID, int bookID)
        {
            this.copyID = copyID;
            this.bookID = bookID;
            isAvailable = Status.Available;
        }
    }
}
