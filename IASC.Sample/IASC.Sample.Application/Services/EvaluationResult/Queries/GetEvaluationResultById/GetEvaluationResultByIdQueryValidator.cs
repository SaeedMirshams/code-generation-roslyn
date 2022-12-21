using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.EvaluationResults.Queries.GetEvaluationResultsWithPagination;

public class GetEvaluationResultsByIdQueryValidator : BaseRequestValidator<GetEvaluationResultsByIdQuery>
{
    public GetEvaluationResultsByIdQueryValidator()
    {
        RuleFor(x => x.Id).NotNull();
    }
}
