using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.ExamScores.Queries.GetExamScoresWithPagination;

public class GetExamScoresByIdQueryValidator : BaseRequestValidator<GetExamScoresByIdQuery>
{
    public GetExamScoresByIdQueryValidator()
    {
        RuleFor(x => x.Id).NotNull();
    }
}
