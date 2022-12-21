        using FluentValidation;
        using IASC.Core.Validation;

        namespace IASC.Sample.Application.DevelopmentProgramItems.Queries.GetDevelopmentProgramItemsWithPagination;

        public class GetDevelopmentProgramItemsWithPaginationQueryValidator : BaseRequestValidator<GetDevelopmentProgramItemsWithPaginationQuery>
        {
            public GetDevelopmentProgramItemsWithPaginationQueryValidator()
            {
                RuleFor(x => x.PageNumber).NotNull().GreaterThan(0);
                RuleFor(x => x.PageSize).GreaterThan(0);
            }
        }
