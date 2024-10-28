using AutoMapper;
using ER.Application.IRepository.IStudenRepo;
using ER.Domain.Models;
using MediatR;

namespace ER.Application.Features.Command.Student_.AddNewStudent
{
    public class AddNewStudent_QueryHandler : IRequestHandler<AddNewStudent_Query, bool>
    {
        readonly IWriteStudent_Repo writeStudent;
        readonly IMapper mapper;

        public AddNewStudent_QueryHandler(IWriteStudent_Repo writeStudent, IMapper mapper)
        {
            this.writeStudent = writeStudent;
            this.mapper = mapper;
        }

        public async Task<bool> Handle(AddNewStudent_Query request, CancellationToken cancellationToken)
        {
            var Student=mapper.Map<Student>(request.Student);

            return await writeStudent.SaveDataAsync(Student) == 1;
        }
    }
}
