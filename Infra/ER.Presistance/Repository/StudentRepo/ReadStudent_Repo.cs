using ER.Application.IRepository.IStudenRepo;
using ER.Domain;
using ER.Domain.Models;

namespace ER.Presistance.Repository.StudentRepo
{
    public class ReadStudent_Repo : ReadRepository<Student>, IReadStudent_Repo
    {
        public ReadStudent_Repo(ProSysExamContext context) : base(context)
        {
        }
    }
}
