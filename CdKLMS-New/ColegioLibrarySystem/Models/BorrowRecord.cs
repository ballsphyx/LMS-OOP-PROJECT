using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioLibrarySystem.Models
{
    public class BorrowRecord
    {
        public int BorrowRecordId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int BookCopyId { get; set; }
        public BookCopy BookCopy { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
