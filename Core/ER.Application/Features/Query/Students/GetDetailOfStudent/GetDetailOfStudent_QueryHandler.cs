using AutoMapper;
using ER.Application.IRepository.IStudenRepo;
using ER.Domain.ViewModels;
using MediatR;

namespace ER.Application.Features.Query.Students.GetDetailOfStudent
{
    public class GetDetailOfStudent_QueryHandler : IRequestHandler<GetDetailOfStudent_Query, StudentVM>
    {
        readonly IReadStudent_Repo readStudent;
        readonly IMapper mapper;

        public GetDetailOfStudent_QueryHandler(IReadStudent_Repo readStudent, IMapper mapper)
        {
            this.readStudent = readStudent;
            this.mapper = mapper;
        }

        public async Task<StudentVM> Handle(GetDetailOfStudent_Query request, CancellationToken cancellationToken)
        { 
            var Student= await readStudent.GetWhere_singleAsync(x=>x.Id==request.Id);
            var StudentVM= mapper.Map<StudentVM>(Student);

            return StudentVM;
        }
    }
}
