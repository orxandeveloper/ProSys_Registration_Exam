using AutoMapper;
using ER.Application.IRepository.ICourseRpo;
using ER.Domain.Models;
using MediatR;

namespace ER.Application.Features.Command.Course_.AddNewCourse
{
    internal class AddNewCourse_CommandHandler : IRequestHandler<AddNewCourse_Command, bool>
    {
        readonly IWriteCourse_Repo writeCourse;
        readonly IMapper mapper;

        public AddNewCourse_CommandHandler(IWriteCourse_Repo writeCourse, IMapper mapper)
        {
            this.writeCourse = writeCourse;
            this.mapper = mapper;
        }

        public async Task<bool> Handle(AddNewCourse_Command request, CancellationToken cancellationToken)
        {
            var Course_ = mapper.Map<Course>(request.Course);
         return await writeCourse.SaveDataAsync(Course_)==1;
            
        }
    }
}
