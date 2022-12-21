using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.DevelopmentProgramItems.Commands.DeleteDevelopmentProgramItem;

public class DeleteDevelopmentProgramItemCommandValidator : BaseRequestValidator<DeleteDevelopmentProgramItemCommand>
{
    public DeleteDevelopmentProgramItemCommandValidator()
    {
         RuleFor(v => v.Id)
           .NotNull();

    }
}
