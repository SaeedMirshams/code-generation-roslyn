using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.CompetencyModels.Commands.CreateCompetencyModel;

public class CreateCompetencyModelCommandValidator : BaseRequestValidator<CreateCompetencyModelCommand>
{
    public CreateCompetencyModelCommandValidator()
    {
        //RuleFor

    }
}
