using ER.Application.IRepository.IExamRepo;
using ER.Domain.ViewModels;
using MediatR;

namespace ER.Application.Features.Query.Exam.GetDetailOfExam
{
    public class GetDetailOfExam_QueryHandler : IRequestHandler<GetDetailOfExam_Query, ExamVM>
    {
        readonly IReadExam_Repo readExam;

        public GetDetailOfExam_QueryHandler(IReadExam_Repo readExam)
        {
            this.readExam = readExam;
        }

        public async Task<ExamVM> Handle(GetDetailOfExam_Query request, CancellationToken cancellationToken)
        {
            var result = await readExam.GetExamDetailWithJoin(request.Id);
            return result;
        }
    }
}
