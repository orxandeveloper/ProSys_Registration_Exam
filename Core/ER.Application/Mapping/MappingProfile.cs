using AutoMapper;
using ER.Domain.Models;
using ER.Domain.ViewModels;

namespace ER.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Course,CourseVM>().ReverseMap();
            CreateMap<Exam,ExamVM>().ReverseMap();
            CreateMap<Student,StudentVM>().ReverseMap();
        }
    }
}
