using ER.Application.IRepository.ICourseRpo;
using ER.Application.IRepository.IExamRepo;
using ER.Application.IRepository.IStudenRepo;
using ER.Domain;
using ER.Presistance.Repository.CourseRepo;
using ER.Presistance.Repository.ExamRepo;
using ER.Presistance.Repository.StudentRepo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ER.Presistance.Registration
{
    public static class Services
    {
        public static IServiceCollection AddPersistanceServices(this IServiceCollection services,IConfiguration configuration)
        {

            services.AddDbContext<ProSysExamContext>(options => options.UseSqlServer(configuration.GetConnectionString("ProSysExamDatabase")));
           
            services.AddTransient<IReadStudent_Repo, ReadStudent_Repo>();
            services.AddTransient<IWriteStudent_Repo, WriteStudent_Repo>();

            services.AddTransient<IReadExam_Repo, ReadExam_Repo>();
            services.AddTransient<IWriteExam_Repo, WriteExam_Repo>();

            services.AddTransient<IReadCourse_Repo, ReadCoursRepo>();
            services.AddTransient<IWriteCourse_Repo, WriteCourse_Repo>();
        

            return services;
        }
    }
}
