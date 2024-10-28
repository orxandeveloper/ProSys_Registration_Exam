using ER.Application.IRepository.IStudenRepo;
using ER.Domain;
using ER.Domain.Models;

namespace ER.Presistance.Repository.StudentRepo
{
    public class WriteStudent_Repo : WriteRepository<Student>, IWriteStudent_Repo
    {
        public WriteStudent_Repo(ProSysExamContext context) : base(context)
        {
        }
    }
}
