using ColegioLibrarySystem.GlobalEnums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ColegioLibrarySystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public Roles Role { get; set; }
        public List<BorrowRecord> BorrowRecords { get; set; }
    }
}
