using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.CompetencyScores.Commands.DeleteCompetencyScore;

public class DeleteCompetencyScoreCommandValidator : BaseRequestValidator<DeleteCompetencyScoreCommand>
{
    public DeleteCompetencyScoreCommandValidator()
    {
         RuleFor(v => v.Id)
           .NotNull();

    }
}
