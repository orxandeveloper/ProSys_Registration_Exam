using System;
using System.Collections.Generic;

namespace ER.Domain.Models
{
    public partial class Exam
    {
        public int Id { get; set; }
        public int? CourseId { get; set; }
        public int? StudentId { get; set; }
        public DateTime? ExamDate { get; set; }
        public int? Grade { get; set; }

        public virtual Course? Course { get; set; }
        public virtual Student? Student { get; set; }
    }
}
