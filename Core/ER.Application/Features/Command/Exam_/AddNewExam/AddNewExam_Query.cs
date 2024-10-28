using ER.Domain.ViewModels;
using MediatR;

namespace ER.Application.Features.Command.Exam_.AddNewExam
{
    public class AddNewExam_Query:IRequest<bool>
    {
        public ExamVM Exam { get; set; }

        public AddNewExam_Query(ExamVM exam)
        {
            Exam = exam;
        }
    }
}
