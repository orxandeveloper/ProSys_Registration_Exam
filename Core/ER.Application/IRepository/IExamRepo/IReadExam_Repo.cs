using ER.Domain.Models;
using ER.Domain.ViewModels;

namespace ER.Application.IRepository.IExamRepo
{
    public interface IReadExam_Repo:IRead_Repository<Exam>
    {
        Task<List<ExamVM>> GetExamWithJoin();
        Task<ExamVM> GetExamDetailWithJoin(int Id);
    }
}
