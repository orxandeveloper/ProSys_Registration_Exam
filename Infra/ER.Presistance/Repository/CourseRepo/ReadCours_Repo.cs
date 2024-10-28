using ER.Application.IRepository.ICourseRpo;
using ER.Domain;
using ER.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER.Presistance.Repository.CourseRepo
{
    public class ReadCoursRepo : ReadRepository<Course>, IReadCourse_Repo
    {
        public ReadCoursRepo(ProSysExamContext context) : base(context)
        {
        }
    }
}
