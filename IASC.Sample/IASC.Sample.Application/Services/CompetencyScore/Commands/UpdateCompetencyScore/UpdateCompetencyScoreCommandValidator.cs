using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.CompetencyScores.Commands.UpdateCompetencyScore;

public class UpdateCompetencyScoreCommandValidator : BaseRequestValidator<UpdateCompetencyScoreCommand>
{
    public UpdateCompetencyScoreCommandValidator()
    {
        RuleFor(v => v.Id)
           .NotEmpty();
        //Other Rules
    }
}
