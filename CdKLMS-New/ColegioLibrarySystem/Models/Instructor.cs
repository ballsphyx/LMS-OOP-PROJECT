using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioLibrarySystem.Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public int UserId { get; set; }
        public string Department { get; set; }
        public User User { get; set; }
    }
}
