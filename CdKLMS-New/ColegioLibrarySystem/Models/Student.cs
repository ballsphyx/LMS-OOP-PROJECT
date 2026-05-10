using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioLibrarySystem.Models
{
    public class Student
    {
        public int UserId { get; set; }
        public int StudentId { get; set; }
        public string Program { get; set; }
        public int YearLevel { get; set; }
        public User User { get; set; }
    }
}
