using ER.Domain.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER.Application.Features.Query.Students.GetDetailOfStudent
{
    public class GetDetailOfStudent_Query:IRequest<StudentVM>
    {
        public int Id { get; set; }

        public GetDetailOfStudent_Query(int id)
        {
            Id = id;
        }
    }
}
