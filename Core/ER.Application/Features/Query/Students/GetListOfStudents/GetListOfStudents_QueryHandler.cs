using AutoMapper;
using ER.Application.IRepository.IStudenRepo;
using ER.Domain.ViewModels;
using MediatR;

namespace ER.Application.Features.Query.Students.GetListOfStudents
{
    internal class GetListOfStudents_QueryHandler : IRequestHandler<GetListOfStudents_Query, List<StudentVM>>
    {
        readonly IReadStudent_Repo readStudent;
        readonly IMapper mapper;

        public GetListOfStudents_QueryHandler(IReadStudent_Repo readStudent, IMapper mapper)
        {
            this.readStudent = readStudent;
            this.mapper = mapper;
        }

        public async Task<List<StudentVM>> Handle(GetListOfStudents_Query request, CancellationToken cancellationToken)
        {
            var Students = await readStudent.GetAllAsync();
            var StudentsVM=mapper.Map<List<StudentVM>>(Students);
            return StudentsVM;
        }
    }
}
