using ER.Domain.ViewModels;
using MediatR;

namespace ER.Application.Features.Query.Course.GetDetailOfCourse
{
    public class GetDetailOfCourse_Query:IRequest<CourseVM>
    {
        public int Id { get; set; }

        public GetDetailOfCourse_Query(int id)
        {
            Id = id;
        }
    }
}
