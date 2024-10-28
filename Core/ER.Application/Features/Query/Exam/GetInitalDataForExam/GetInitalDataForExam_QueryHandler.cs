using AutoMapper;
using ER.Application.IRepository.ICourseRpo;
using ER.Application.IRepository.IStudenRepo;
using ER.Domain.ViewModels;
using MediatR;

namespace ER.Application.Features.Query.Exam.GetInitalDataForExam
{
    public class GetInitalDataForExam_QueryHandler : IRequestHandler<GetInitalDataForExam_Query, ExamVM>
    {
        readonly IReadStudent_Repo readStudent;
        readonly IReadCourse_Repo readCourse;
        readonly IMapper mapper;

        public GetInitalDataForExam_QueryHandler(IReadStudent_Repo readStudent, IReadCourse_Repo readCourse, IMapper mapper)
        {
            this.readStudent = readStudent;
            this.readCourse = readCourse;
            this.mapper = mapper;
        }

        public async Task<ExamVM> Handle(GetInitalDataForExam_Query request, CancellationToken cancellationToken)
        {
            var Students = await readStudent.GetAllAsync();
            var StudentsVM = mapper.Map<List<StudentVM>>(Students);
            var Course = await readCourse.GetAllAsync();
            var CourseVm= mapper.Map<List<CourseVM>>(Course);

            return new ExamVM() { Students = StudentsVM, Courses = CourseVm };
        }
    }
}
