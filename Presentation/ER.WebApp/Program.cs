using ER.Application.Registration;
using ER.Application.Validators;
using ER.Domain.ViewModels;
using ER.Presistance.Registration;
using ER.WebApp.Exceptions;
using FluentValidation;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddPersistanceServices(builder.Configuration);
builder.Services.AddApplicationServices();
builder.Services.AddControllersWithViews()
                .AddFluentValidation(configuration =>
                {
                    configuration.RegisterValidatorsFromAssemblyContaining<CourseValidator>();
                    configuration.RegisterValidatorsFromAssemblyContaining<StudentValidator>();
                    configuration.RegisterValidatorsFromAssemblyContaining<ExamValidator>(); 

                }); 
var app = builder.Build();

app.UseMiddleware<ExceptionHandlingMiddleware>();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Exam}/{action=List}/{id?}");

app.Run();
