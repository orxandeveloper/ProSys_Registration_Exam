using ER.Application.Features.Command.Student_.AddNewStudent;
using ER.Application.Features.Query.Students.GetDetailOfStudent;
using ER.Application.Features.Query.Students.GetListOfStudents;
using ER.Domain.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ER.WebApp.Controllers
{
    public class StudentsController : Controller
    {
        readonly IMediator mediator;

        public StudentsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(StudentVM student)
        {
            if (ModelState.IsValid)
            {
                await mediator.Send(new AddNewStudent_Query(student));
            }
            return RedirectToAction("List");
        }
        public async Task<IActionResult> List()
        {
            var result = await mediator.Send(new GetListOfStudents_Query());
            return View(result);
        }
        public async Task<IActionResult> Detail(int Id)
        {
            var result = await mediator.Send(new GetDetailOfStudent_Query(Id));
            return View(result);
        }
    }
}
