using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.CompetencyModels.Commands.UpdateCompetencyModel;

public class UpdateCompetencyModelCommandValidator : BaseRequestValidator<UpdateCompetencyModelCommand>
{
    public UpdateCompetencyModelCommandValidator()
    {
        RuleFor(v => v.Id)
           .NotEmpty();
        //Other Rules
    }
}
