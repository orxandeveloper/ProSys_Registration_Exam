using ER.Application.IRepository.IExamRepo;
using ER.Domain;
using ER.Domain.Models;

namespace ER.Presistance.Repository.ExamRepo
{
    public class WriteExam_Repo : WriteRepository<Exam>, IWriteExam_Repo
    {
        public WriteExam_Repo(ProSysExamContext context) : base(context)
        {
        }
    }
}
