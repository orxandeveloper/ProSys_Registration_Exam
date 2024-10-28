using System;
using System.Collections.Generic;

namespace ER.Domain.Models
{
    public partial class Student
    {
        public Student()
        {
            Exams = new HashSet<Exam>();
        }

        public int Id { get; set; }
        public int? StudentNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? GradeLevel { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }
    }
}
