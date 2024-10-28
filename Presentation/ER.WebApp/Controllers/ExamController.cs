using ER.Application.Features.Command.Exam_.AddNewExam;
using ER.Application.Features.Query.Exam.GetDetailOfExam;
using ER.Application.Features.Query.Exam.GetInitalDataForExam;
using ER.Application.Features.Query.Exam.GetListOfExam;
using ER.Domain.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ER.WebApp.Controllers
{
    public class ExamController : Controller
    {
        readonly IMediator mediator;

        public ExamController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IActionResult> List()
        {
            var result = await mediator.Send(new GetListOfExam_Query());
            return View(result);
        }
        public async Task<IActionResult>Detail(int Id)
        {
            var result = await mediator.Send(new GetDetailOfExam_Query(Id));
            return View(result);
        }
        public async Task<IActionResult> Create()
        {
            var result = await mediator.Send(new GetInitalDataForExam_Query());

            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ExamVM exam)
        {

            if (ModelState.IsValid)
            {
                await mediator.Send(new AddNewExam_Query(exam));
            }
            return RedirectToAction("List");
        }
    }
}
