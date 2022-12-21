using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.CompetencyScores.Commands.CreateCompetencyScore;

public class CreateCompetencyScoreCommandValidator : BaseRequestValidator<CreateCompetencyScoreCommand>
{
    public CreateCompetencyScoreCommandValidator()
    {
        //RuleFor

    }
}
