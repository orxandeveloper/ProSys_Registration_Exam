using AutoMapper;
using ER.Application.IRepository.ICourseRpo;
using ER.Domain.ViewModels;
using MediatR;

namespace ER.Application.Features.Query.Course.GetListOfCourse
{
    public class GetListOfCourse_QueryHandler : IRequestHandler<GetListOfCourse_Query, List<CourseVM>>
    {
        readonly IReadCourse_Repo readCourse;
        readonly IMapper mapper;

        public GetListOfCourse_QueryHandler(IReadCourse_Repo readCourse, IMapper mapper)
        {
            this.readCourse = readCourse;
            this.mapper = mapper;
        }

        public async Task<List<CourseVM>> Handle(GetListOfCourse_Query request, CancellationToken cancellationToken)
        {
            var Courses= await readCourse.GetAllAsync();
            var CoursesVM = mapper.Map<List<CourseVM>>(Courses);
            return CoursesVM;
        }
    }
}
