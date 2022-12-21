        using FluentValidation;
        using IASC.Core.Validation;

        namespace IASC.Sample.Application.DevelopmentPrograms.Queries.GetDevelopmentProgramsWithPagination;

        public class GetDevelopmentProgramsWithPaginationQueryValidator : BaseRequestValidator<GetDevelopmentProgramsWithPaginationQuery>
        {
            public GetDevelopmentProgramsWithPaginationQueryValidator()
            {
                RuleFor(x => x.PageNumber).NotNull().GreaterThan(0);
                RuleFor(x => x.PageSize).GreaterThan(0);
            }
        }
