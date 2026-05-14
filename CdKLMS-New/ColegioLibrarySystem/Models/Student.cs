namespace ColegioLibrarySystem.Models
{
    public class Student
    {
        public int UserId { get; set; }
        public int StudentId { get; set; }
        public int CourseID { get; set; }
        public string YearLevel { get; set; }
        public User User { get; set; }
        public Course Course { get; set; }

        public string FullName => User?.FullName;
        public string Username => User?.Username;
        public string Program => Course?.CourseName;
    }
}
