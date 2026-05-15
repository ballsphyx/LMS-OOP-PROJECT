namespace ColegioLibrarySystem.Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public int UserId { get; set; }
        public int DepartmentId { get; set; }
        public User User { get; set; }
        public Department Department { get; set; }

        public string FullName => User?.FullName;
        public string Username => User?.Username;
        public string DepartmentName => Department.DepartmentName;
    }
}
