using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.ExamParameters.Queries.GetExamParametersWithPagination;

public class GetExamParametersByIdQueryValidator : BaseRequestValidator<GetExamParametersByIdQuery>
{
    public GetExamParametersByIdQueryValidator()
    {
        RuleFor(x => x.Id).NotNull();
    }
}
