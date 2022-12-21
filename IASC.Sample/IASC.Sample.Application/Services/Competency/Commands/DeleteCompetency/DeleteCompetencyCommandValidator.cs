using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.Competencys.Commands.DeleteCompetency;

public class DeleteCompetencyCommandValidator : BaseRequestValidator<DeleteCompetencyCommand>
{
    public DeleteCompetencyCommandValidator()
    {
         RuleFor(v => v.Id)
           .NotNull();

    }
}
