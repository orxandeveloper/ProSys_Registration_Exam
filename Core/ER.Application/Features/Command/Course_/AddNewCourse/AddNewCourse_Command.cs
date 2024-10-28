using ER.Domain.ViewModels;
using MediatR;

namespace ER.Application.Features.Command.Course_.AddNewCourse
{
    public class AddNewCourse_Command:IRequest<bool>
    {
        public CourseVM  Course { get; set; }

        public AddNewCourse_Command(CourseVM course)
        {
            Course = course;
        }
    }
}
