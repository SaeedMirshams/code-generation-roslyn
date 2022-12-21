using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.DevelopmentPrograms.Commands.UpdateDevelopmentProgram;

public class UpdateDevelopmentProgramCommandValidator : BaseRequestValidator<UpdateDevelopmentProgramCommand>
{
    public UpdateDevelopmentProgramCommandValidator()
    {
        RuleFor(v => v.Id)
           .NotEmpty();
        //Other Rules
    }
}
