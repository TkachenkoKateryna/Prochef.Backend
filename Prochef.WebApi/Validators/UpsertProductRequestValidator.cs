
using FluentValidation;
using Microsoft.Extensions.Localization;
using Prochef.Core.Dtos.Request.Products;

namespace Prochef.WebApi.Validators
{
    public class UpsertProductRequestValidator : AbstractValidator<UpsertProductRequest>
    {
        public UpsertProductRequestValidator(IStringLocalizer localizer)
        {
            RuleFor(request => request.Name).NotEmpty()
                .WithMessage(localizer["The name field must not be empty."]);
            RuleFor(request => request.CategoryId).NotEmpty()
                .WithMessage(localizer["Place must be selected"]);
            RuleFor(request => request.PlaceId).NotEmpty()
                .WithMessage(localizer["Category must be selected"]);
        }
    }
}
