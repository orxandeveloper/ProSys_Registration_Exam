using ER.Domain.ViewModels;
using MediatR;

namespace ER.Application.Features.Query.Exam.GetDetailOfExam
{
    public class GetDetailOfExam_Query:IRequest<ExamVM>
    {
        public int Id { get; set; }

        public GetDetailOfExam_Query(int id)
        {
            Id = id;
        }
    }
}
