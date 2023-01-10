

using FluentValidation;
using Microsoft.Extensions.Localization;
using Prochef.Core.Dtos.Request.Registration;

namespace Prochef.WebApi.Validators
{
    public class EmployeeRegistrationRequestValidator : AbstractValidator<RegistrationEmployeeRequest>
    {
        public EmployeeRegistrationRequestValidator(IStringLocalizer localizer)
        {
            RuleFor(request => request.Email).NotEmpty()
                .WithMessage(localizer["The email is incorrect."]);
            RuleFor(request => request.Password).NotEmpty()
                .WithMessage(localizer["The password field must not be empty."]);
        }
    }
}
