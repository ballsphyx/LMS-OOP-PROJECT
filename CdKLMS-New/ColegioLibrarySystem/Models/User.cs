namespace ColegioLibrarySystem.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public int RoleId { get; set; }
        public Roles Role { get; set; }
        public List<Transaction> BorrowRecords { get; set; }
    }
}
