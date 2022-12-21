        using FluentValidation;
        using IASC.Core.Validation;

        namespace IASC.Sample.Application.EvaluationPeriods.Queries.GetEvaluationPeriodsWithPagination;

        public class GetEvaluationPeriodsWithPaginationQueryValidator : BaseRequestValidator<GetEvaluationPeriodsWithPaginationQuery>
        {
            public GetEvaluationPeriodsWithPaginationQueryValidator()
            {
                RuleFor(x => x.PageNumber).NotNull().GreaterThan(0);
                RuleFor(x => x.PageSize).GreaterThan(0);
            }
        }
