using AutoMapper;
using ER.Application.IRepository.IExamRepo;
using ER.Domain.ViewModels;
using MediatR;

namespace ER.Application.Features.Query.Exam.GetListOfExam
{
    public class GetListOfExam_QueryHandler : IRequestHandler<GetListOfExam_Query, List<ExamVM>>
    {
        readonly IReadExam_Repo readExam; 

        public GetListOfExam_QueryHandler(IReadExam_Repo readExam)
        {
            this.readExam = readExam;
            
        }

        public async Task<List<ExamVM>> Handle(GetListOfExam_Query request, CancellationToken cancellationToken)
        {
            var ExamVM = await readExam.GetExamWithJoin();
            return ExamVM;
        }
    }
}
