using ColegioLibrarySystem.GlobalEnums;
using Microsoft.VisualBasic.ApplicationServices;
using System;

namespace ColegioLibrarySystem.Models
{
    public static class Session
    {
        public static User CurrentUser { get; set; }

        public static void Login(User user) => CurrentUser = user;
        public static void Logout() => CurrentUser = null;
        public static bool IsLoggedIn => CurrentUser != null;
    }
}