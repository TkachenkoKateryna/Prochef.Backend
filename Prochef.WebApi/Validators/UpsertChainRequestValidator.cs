using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.Extensions.Localization;
using Prochef.Core.Dtos.Request.Chains;

namespace Prochef.WebApi.Validators
{
    public class UpsertChainRequestValidator : AbstractValidator<UpsertChainRequest>
    {
        public UpsertChainRequestValidator(IStringLocalizer localizer)
        {
            RuleFor(request => request.Name).NotEmpty()
                .WithMessage(localizer["The name field must not be empty."]);
            RuleFor(request => request.City).NotEmpty()
                .WithMessage(localizer["The city field must not be empty."]);
            RuleFor(request => request.Country).NotEmpty()
                .WithMessage(localizer["The country field must not be empty."]);
        }
    }
}
