using System;
using System.Collections.Generic;

namespace ER.Domain.Models
{
    public partial class Course
    {
        public Course()
        {
            Exams = new HashSet<Exam>();
        }

        public int Id { get; set; }
        public string? CourseCode { get; set; }
        public string? CourseName { get; set; }
        public int? GradeLevel { get; set; }
        public string? TeacherFirstName { get; set; }
        public string? TeacherLastName { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }
    }
}
