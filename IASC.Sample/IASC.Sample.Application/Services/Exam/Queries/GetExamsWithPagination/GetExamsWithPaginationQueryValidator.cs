        using FluentValidation;
        using IASC.Core.Validation;

        namespace IASC.Sample.Application.Exams.Queries.GetExamsWithPagination;

        public class GetExamsWithPaginationQueryValidator : BaseRequestValidator<GetExamsWithPaginationQuery>
        {
            public GetExamsWithPaginationQueryValidator()
            {
                RuleFor(x => x.PageNumber).NotNull().GreaterThan(0);
                RuleFor(x => x.PageSize).GreaterThan(0);
            }
        }
