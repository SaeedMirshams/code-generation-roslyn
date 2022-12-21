using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.PostCompetencys.Commands.UpdatePostCompetency;

public class UpdatePostCompetencyCommandValidator : BaseRequestValidator<UpdatePostCompetencyCommand>
{
    public UpdatePostCompetencyCommandValidator()
    {
        RuleFor(v => v.Id)
           .NotEmpty();
        //Other Rules
    }
}
