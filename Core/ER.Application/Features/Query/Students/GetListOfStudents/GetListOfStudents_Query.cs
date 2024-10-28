using ER.Domain.ViewModels;
using MediatR;

namespace ER.Application.Features.Query.Students.GetListOfStudents
{
    public class GetListOfStudents_Query:IRequest<List<StudentVM>>
    {
    }
}
