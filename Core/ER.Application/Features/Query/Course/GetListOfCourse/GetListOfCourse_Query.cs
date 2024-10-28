using ER.Domain.ViewModels;
using MediatR;

namespace ER.Application.Features.Query.Course.GetListOfCourse
{
    public class GetListOfCourse_Query:IRequest<List<CourseVM>>
    {
    }
}
