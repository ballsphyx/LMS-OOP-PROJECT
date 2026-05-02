using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioLibrarySystem.Models
{
    public class BorrowRecord
    {
        public int BorrowId { get; set; }
        public int BookID { get; set; }
        public int CopyID { get; set; }
        public int UserID { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }
        public BookCopy BookCopy { get; set; }
        public BorrowRecord()
        {

        }

    }
}
