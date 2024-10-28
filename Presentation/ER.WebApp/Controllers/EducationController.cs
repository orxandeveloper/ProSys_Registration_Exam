using ER.Application.Features.Command.Course_.AddNewCourse;
using ER.Application.Features.Query.Course.GetDetailOfCourse; 
using ER.Application.Features.Query.Course.GetListOfCourse;
using ER.Domain.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ER.WebApp.Controllers
{
    public class EducationController : Controller
    {
        IMediator mediator;

        public EducationController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IActionResult> List()
        {
            var ListOfCourses = await mediator.Send(new GetListOfCourse_Query());
            return View(ListOfCourses);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CourseVM  course)
        {
            if (ModelState.IsValid)
            {
                var result = await mediator.Send(new AddNewCourse_Command(course));
            }
            return RedirectToAction("List");
        }
        public async Task<IActionResult> Detail(int Id)
        {
            var result = await mediator.Send(new GetDetailOfCourse_Query(Id));
            return View(result);
        }
    }
}
