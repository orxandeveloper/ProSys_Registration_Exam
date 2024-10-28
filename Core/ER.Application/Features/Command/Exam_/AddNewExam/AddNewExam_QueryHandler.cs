using AutoMapper;
using ER.Application.IRepository.IExamRepo;
using ER.Domain.Models;
using MediatR;

namespace ER.Application.Features.Command.Exam_.AddNewExam
{
    public class AddNewExam_QueryHandler : IRequestHandler<AddNewExam_Query, bool>
    {
        readonly IWriteExam_Repo writeExam;
        readonly IMapper mapper;

        public AddNewExam_QueryHandler(IWriteExam_Repo writeExam, IMapper mapper)
        {
            this.writeExam = writeExam;
            this.mapper = mapper;
        }

        public async Task<bool> Handle(AddNewExam_Query request, CancellationToken cancellationToken)
        {
            var Exam_ = mapper.Map<Exam>(request.Exam);

            return await writeExam.SaveDataAsync(Exam_) == 1;
        }
    }
}
