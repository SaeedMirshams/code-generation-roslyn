using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.Competencys.Commands.UpdateCompetency;

public class UpdateCompetencyCommandValidator : BaseRequestValidator<UpdateCompetencyCommand>
{
    public UpdateCompetencyCommandValidator()
    {
        RuleFor(v => v.Id)
           .NotEmpty();
        //Other Rules
    }
}
