using ER.Domain.ViewModels;
using MediatR;

namespace ER.Application.Features.Command.Student_.AddNewStudent
{
    public class AddNewStudent_Query:IRequest<bool>
    {
        public StudentVM Student { get; set; }

        public AddNewStudent_Query(StudentVM student)
        {
            Student = student;
        }
    }
}
