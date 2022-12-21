using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.Exams.Queries.GetExamsWithPagination;

public class GetExamsByIdQueryValidator : BaseRequestValidator<GetExamsByIdQuery>
{
    public GetExamsByIdQueryValidator()
    {
        RuleFor(x => x.Id).NotNull();
    }
}
