using ER.Application.IRepository.IExamRepo;
using ER.Domain;
using ER.Domain.Models;
using ER.Domain.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ER.Presistance.Repository.ExamRepo
{
    public class ReadExam_Repo : ReadRepository<Exam>, IReadExam_Repo
    {
        public ProSysExamContext _context;
        public ReadExam_Repo(ProSysExamContext context) : base(context)
        {
            _context = context;
        }
        public async Task<ExamVM> GetExamDetailWithJoin(int Id)
        {
         var result = await _context.Set<Exam>()
                .Join(
                    _context.Set<Student>(),
                    exam => exam.StudentId,
                    student => student.Id,
                    (exam, student) => new { exam, student }
                )
                .Join(
                    _context.Set<Course>(),
                    combined => combined.exam.CourseId,
                    course => course.Id,
                    (combined, course) => new ExamVM
                    {
                        Id = combined.exam.Id,
                        StudentNumber = combined.student.StudentNumber,
                        CourseCode = course.CourseCode,
                        ExamDate = combined.exam.ExamDate,
                        Grade = combined.exam.Grade
                    }
                ).FirstOrDefaultAsync(x=>x.Id==Id);
            return result;
        }
        public async Task<List<ExamVM>> GetExamWithJoin()
        {
            var result = await _context.Set<Exam>()
                .Join(
                    _context.Set<Student>(),                
                    exam => exam.StudentId,               
                    student => student.Id,                  
                    (exam, student) => new { exam, student } 
                )
                .Join(
                    _context.Set<Course>(),                 
                    combined => combined.exam.CourseId,    
                    course => course.Id,                  
                    (combined, course) => new ExamVM
                    {
                         Id = combined.exam.Id,
                        StudentNumber = combined.student.StudentNumber,
                        CourseCode = course.CourseCode,
                        ExamDate = combined.exam.ExamDate,
                        Grade = combined.exam.Grade
                    }
                ).ToListAsync();
            return result;
        }
    }
}
