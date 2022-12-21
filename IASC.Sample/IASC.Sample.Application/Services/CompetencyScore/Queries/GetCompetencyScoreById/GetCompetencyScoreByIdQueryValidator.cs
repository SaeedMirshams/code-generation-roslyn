using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.CompetencyScores.Queries.GetCompetencyScoresWithPagination;

public class GetCompetencyScoresByIdQueryValidator : BaseRequestValidator<GetCompetencyScoresByIdQuery>
{
    public GetCompetencyScoresByIdQueryValidator()
    {
        RuleFor(x => x.Id).NotNull();
    }
}
