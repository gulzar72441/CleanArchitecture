﻿using CleanArchitectureDemo.Application.Features.Players.Queries.GetPlayersWithPagination;
using FluentValidation;

namespace CleanArchitectureDemo.Application.Common.Validators
{
    public class GetPlayersWithPaginationValidator : AbstractValidator<GetPlayersWithPaginationQuery>
    {
        public GetPlayersWithPaginationValidator()
        {
            RuleFor(x => x.PageNumber)
                .GreaterThanOrEqualTo(1)
                .WithMessage("PageNumber at least greater than or equal to 1.");

            RuleFor(x => x.PageSize)
                .GreaterThanOrEqualTo(1)
                .WithMessage("PageSize at least greater than or equal to 1.");
        }
    }
}
