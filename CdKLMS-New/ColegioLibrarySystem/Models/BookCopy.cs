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
        public int BookCopyId { get; set; }
        public Status CopyStatus { get; set; } 

        public int BookId { get; set; }
        public Book Book { get; set; }

        public List<BorrowRecord> BorrowRecords { get; set; }
    }
}
