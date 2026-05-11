using ColegioLibrarySystem.GlobalEnums;

namespace ColegioLibrarySystem.Models
{
    public static class Session
    {
        public static User CurrentUser { get; set; }

        public static void Login(User user) => CurrentUser = user;
        public static void Logout() => CurrentUser = null;
        public static bool IsLoggedIn => CurrentUser != null;

        public static bool IsAdmin => CurrentUser?.Role.RoleName == RoleEnum.Admin;
        public static bool IsStudent => CurrentUser?.Role.RoleName == RoleEnum.Student;
        public static bool IsInstructor => CurrentUser?.Role.RoleName == RoleEnum.Instructor;
    }
}