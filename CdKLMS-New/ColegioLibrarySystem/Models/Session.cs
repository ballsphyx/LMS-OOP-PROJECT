using System;
using ColegioLibrarySystem.GlobalEnums;

namespace ColegioLibrarySystem.Models
{
    public static class Session
    {
        public static int UserID { get; set; }
        public static string Username { get; set; }
        public static Roles Role { get; set; }
        public static string FullName { get; set; }

        public static void Clear()
        {
            UserID = 0;
            Username = null;
            Role = Roles.None;
            FullName = null;
        }
    }
}