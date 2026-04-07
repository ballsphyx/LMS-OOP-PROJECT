using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioLibrarySystem.Models
{
    public class Book
    {
        public int bookID { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string Catgory { get; set; }
        public DateTime publicationDate { get; set; }
        public int totalCopies { get; set; }
        //Add later on availableCopies//
    }
}
