using ER.Domain.ViewModels;
using FluentValidation;

namespace ER.Application.Validators
{
    public class StudentValidator:AbstractValidator<StudentVM>
    {
        public StudentValidator()
        {
            RuleFor(x => x.StudentNumber)
       .NotNull().WithMessage("Şagird Nömrəsi  doldurulmalıdır.")
       .NotEmpty().WithMessage("Şagird Nömrəsi doldurulmalıdır.");

            RuleFor(x => x.FirstName)
                .NotNull().WithMessage("Şagird adı doldurulmalıdır.")
                .NotEmpty().WithMessage("Şagird adı doldurulmalıdır.")
                .MaximumLength(30).WithMessage("Maksimum 30 simvol girilə bilər"); ;

            RuleFor(x => x.LastName)
             .NotNull().WithMessage("Şagird soyadı doldurulmalıdır.")
             .NotEmpty().WithMessage("Şagird soyadı doldurulmalıdır.")
             .MaximumLength(30).WithMessage("Maksimum 30 simvol girilə bilər"); ;

            RuleFor(x => x.GradeLevel)
              .NotNull().WithMessage("Sinif doldurulmalıdır.")
              .LessThanOrEqualTo(12).WithMessage("Maksimum 12 ci sinifə qədər girile bilər");



        }
    }
}
