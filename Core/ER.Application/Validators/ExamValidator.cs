using ER.Domain.ViewModels;
using FluentValidation;

namespace ER.Application.Validators
{
    public class ExamValidator: AbstractValidator<ExamVM>
    {
        public ExamValidator()
        {
            RuleFor(x=>x.StudentId)
                .NotEmpty().WithMessage("Şagird mütləq seçilməlidir")
                .NotNull().WithMessage("Şagird mütləq seçilməlidir")
                .NotEqual(0).WithMessage("Şagird mütləq seçilməlidir");

            RuleFor(x => x.CourseId)
               .NotEmpty().WithMessage("Dərs mütləq seçilməlidir")
               .NotNull().WithMessage("Dərs mütləq seçilməlidir")
               .NotEqual(0).WithMessage("Dərs mütləq seçilməlidir");

            RuleFor(x => x.ExamDate)
            .NotEmpty().WithMessage("İmtahan tarixi seçilməlidir")
            .NotNull().WithMessage("İmtahan tarixi seçilməlidir")
            .WithMessage("İmtahan tarixi seçilməlidir");

            RuleFor(x => x.Grade)
           .NotEmpty().WithMessage("İmtahan tarixi seçilməlidir")
           .NotNull().WithMessage("İmtahan tarixi seçilməlidir")
           .WithMessage("İmtahan tarixi seçilməlidir")
           .InclusiveBetween(1, 5)
           .WithMessage("Qiymət 1 ilə 5 arasında olmalıdır");
        }
    }
}
