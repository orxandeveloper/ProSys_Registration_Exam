using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER.Domain.ViewModels
{
    public class ExamVM
    {
        public int Id { get; set; }
        public int? CourseId { get; set; }
        public int? StudentNumber { get; set; }
        public string? CourseCode { get; set; } 
        public int? StudentId { get; set; }
        public DateTime? ExamDate { get; set; }
        public int? Grade { get; set; }
        public List<CourseVM>? Courses { get; set; }
        public List<StudentVM>? Students { get; set; }

    }
}
