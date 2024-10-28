using AutoMapper;
using ER.Application.IRepository.ICourseRpo;
using ER.Domain.ViewModels;
using MediatR;

namespace ER.Application.Features.Query.Course.GetDetailOfCourse
{
    public class GetDetailOfCourse_QueryHandler : IRequestHandler<GetDetailOfCourse_Query, CourseVM>
    {
        readonly IReadCourse_Repo readCourse_Repo;
        readonly IMapper mapper;

        public GetDetailOfCourse_QueryHandler(IReadCourse_Repo readCourse_Repo, IMapper mapper)
        {
            this.readCourse_Repo = readCourse_Repo;
            this.mapper = mapper;
        }

        public async Task<CourseVM> Handle(GetDetailOfCourse_Query request, CancellationToken cancellationToken)
        {
            var Course= await readCourse_Repo.GetWhere_singleAsync(x=>x.Id==request.Id);
            var CourseVM = mapper.Map<CourseVM>(Course);
            return CourseVM;
        }
    }
}
