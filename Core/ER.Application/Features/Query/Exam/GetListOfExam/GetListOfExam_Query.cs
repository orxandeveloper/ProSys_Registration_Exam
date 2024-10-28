using ER.Domain.ViewModels;
using MediatR;

namespace ER.Application.Features.Query.Exam.GetListOfExam
{
    public class GetListOfExam_Query:IRequest<List<ExamVM>>
    {

    }
}
