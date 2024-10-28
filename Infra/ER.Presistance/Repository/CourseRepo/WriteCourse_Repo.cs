using ER.Application.IRepository.ICourseRpo;
using ER.Domain;
using ER.Domain.Models;

namespace ER.Presistance.Repository.CourseRepo
{
    public class WriteCourse_Repo : WriteRepository<Course>, IWriteCourse_Repo
    {
        public WriteCourse_Repo(ProSysExamContext context) : base(context)
        {
        }
    }
}
