using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.Extensions.Localization;
using Prochef.Core.Dtos.Request.Upsert;

namespace Prochef.WebApi.Validators
{
    public class UpsertRestaurantRequestValidator : AbstractValidator<UpsertRestaurantRequest>
    {
        public UpsertRestaurantRequestValidator(IStringLocalizer localizer)
        {
            RuleFor(request => request.Name).NotEmpty()
                .WithMessage(localizer["The name field must not be empty."]);
            RuleFor(request => request.Phone).NotEmpty()
                .WithMessage(localizer["The phone field must not be empty."]);
            RuleFor(request => request.ChainId).NotEmpty()
                .WithMessage(localizer["Chain must be selected"]);
            RuleFor(request => request.MenuId).NotEmpty()
                .WithMessage(localizer["Menu must be selected"]);
        }
    }
}
