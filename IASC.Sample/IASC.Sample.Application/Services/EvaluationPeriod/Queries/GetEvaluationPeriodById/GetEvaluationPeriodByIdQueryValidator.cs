using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.EvaluationPeriods.Queries.GetEvaluationPeriodsWithPagination;

public class GetEvaluationPeriodsByIdQueryValidator : BaseRequestValidator<GetEvaluationPeriodsByIdQuery>
{
    public GetEvaluationPeriodsByIdQueryValidator()
    {
        RuleFor(x => x.Id).NotNull();
    }
}
