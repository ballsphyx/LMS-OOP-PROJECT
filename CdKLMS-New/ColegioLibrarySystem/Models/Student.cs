namespace ColegioLibrarySystem.Models
{
    public class Student
    {
        public int UserId { get; set; }
        public int StudentId { get; set; }
        public string Program { get; set; }
        public string YearLevel { get; set; }
        public User User { get; set; }

        public string FullName => User?.FullName;
        public string Username => User?.Username;
    }
}
