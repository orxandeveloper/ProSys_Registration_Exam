namespace ER.Domain.ViewModels
{
    public class CourseVM
    {
        public int Id { get; set; }
        public string? CourseCode { get; set; }
        public string? CourseName { get; set; }
        public int? GradeLevel { get; set; }
        public string? TeacherFirstName { get; set; }
        public string? TeacherLastName { get; set; }
        
    }
}
