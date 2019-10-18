using FluentValidation;
using iODS.Model;

namespace iODS.WebApiService.Validator
{
    public class DepartmentValidator:AbstractValidator<Department>
    {
        public DepartmentValidator()
        {
            this.RuleFor(d => d.Name).NotEmpty().WithMessage("");
            this.RuleFor(d => d.Name).NotEqual("xx集团").WithMessage("");
        }
    }
}