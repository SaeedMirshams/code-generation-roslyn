using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.DevelopmentPrograms.Commands.DeleteDevelopmentProgram;

public class DeleteDevelopmentProgramCommandValidator : BaseRequestValidator<DeleteDevelopmentProgramCommand>
{
    public DeleteDevelopmentProgramCommandValidator()
    {
         RuleFor(v => v.Id)
           .NotNull();

    }
}
