        using FluentValidation;
        using IASC.Core.Validation;

        namespace IASC.Sample.Application.EvaluationResults.Queries.GetEvaluationResultsWithPagination;

        public class GetEvaluationResultsWithPaginationQueryValidator : BaseRequestValidator<GetEvaluationResultsWithPaginationQuery>
        {
            public GetEvaluationResultsWithPaginationQueryValidator()
            {
                RuleFor(x => x.PageNumber).NotNull().GreaterThan(0);
                RuleFor(x => x.PageSize).GreaterThan(0);
            }
        }
