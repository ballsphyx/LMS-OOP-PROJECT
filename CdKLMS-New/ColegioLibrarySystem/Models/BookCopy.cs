using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioLibrarySystem.Models
{
    public class BookCopy
    {
        public int copyID { get; set; }
        public int bookID { get; set; }
        public bool isAvailable { get; set; }
    }
}
