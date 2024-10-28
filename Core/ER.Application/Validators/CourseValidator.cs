using ER.Domain.ViewModels;
using FluentValidation;

namespace ER.Application.Validators
{
    public class CourseValidator: AbstractValidator<CourseVM>
    {
        public CourseValidator()
        {
            RuleFor(x => x.CourseCode)
          .NotNull().WithMessage("Dərsin kodu doldurulmalıdır.")
          .NotEmpty().WithMessage("Dərsin kodu doldurulmalıdır.")
          .MaximumLength(3).WithMessage("Maksimum 3 simvol girilə bilər");

            RuleFor(x => x.CourseName)
                .NotNull().WithMessage("Dərsin adı doldurulmalıdır.")
                .NotEmpty().WithMessage("Dərsin adı doldurulmalıdır.")
                .MaximumLength(30).WithMessage("Maksimum 30 simvol girilə bilər"); ;

            RuleFor(x => x.GradeLevel)
                .NotNull().WithMessage("Sinif doldurulmalıdır.")
                .LessThanOrEqualTo(12).WithMessage("Maksimum 12 ci sinifə qədər girile bilər");

            RuleFor(x => x.TeacherFirstName)
                .NotNull().WithMessage("Dərsi verən müəllimin adı doldurulmalıdır.")
                .NotEmpty().WithMessage("Dərsi verən müəllimin adı doldurulmalıdır.")
                .MaximumLength(20).WithMessage("Maksimum 20 simvol girilə bilər"); ;

            RuleFor(x => x.TeacherLastName)
                .NotNull().WithMessage("Dərsi verən müəlimin soyadı doldurulmalıdır.")
                .NotEmpty().WithMessage("Dərsi verən müəlimin soyadı doldurulmalıdır.")
                .MaximumLength(20).WithMessage("Maksimum 20 simvol girilə bilər"); 
        }
    }
}
