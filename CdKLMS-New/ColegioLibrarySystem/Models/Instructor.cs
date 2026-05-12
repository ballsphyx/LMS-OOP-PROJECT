namespace ColegioLibrarySystem.Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public int UserId { get; set; }
        public string Department { get; set; }
        public User User { get; set; }

        public string FullName => User?.FullName;
        public string Username => User?.Username;
    }
}
