using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColegioLibrarySystem.GlobalEnums;

namespace ColegioLibrarySystem.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public Roles Role { get; set; }

        public Users(int id, string username, string password, string fullName, Roles role)
        {
            Id = id;
            Username = username;
            Password = password;
            FullName = fullName;
            Role = role;
        }
        public Users()
        {

        }
    }
}
