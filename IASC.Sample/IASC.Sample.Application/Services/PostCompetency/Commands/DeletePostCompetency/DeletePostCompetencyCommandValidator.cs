using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.PostCompetencys.Commands.DeletePostCompetency;

public class DeletePostCompetencyCommandValidator : BaseRequestValidator<DeletePostCompetencyCommand>
{
    public DeletePostCompetencyCommandValidator()
    {
         RuleFor(v => v.Id)
           .NotNull();

    }
}
