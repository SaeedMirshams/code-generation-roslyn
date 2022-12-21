using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.DevelopmentProgramItems.Commands.UpdateDevelopmentProgramItem;

public class UpdateDevelopmentProgramItemCommandValidator : BaseRequestValidator<UpdateDevelopmentProgramItemCommand>
{
    public UpdateDevelopmentProgramItemCommandValidator()
    {
        RuleFor(v => v.Id)
           .NotEmpty();
        //Other Rules
    }
}
