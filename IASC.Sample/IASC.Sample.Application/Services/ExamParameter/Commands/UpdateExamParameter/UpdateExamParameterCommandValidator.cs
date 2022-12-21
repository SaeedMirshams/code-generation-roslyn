using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.ExamParameters.Commands.UpdateExamParameter;

public class UpdateExamParameterCommandValidator : BaseRequestValidator<UpdateExamParameterCommand>
{
    public UpdateExamParameterCommandValidator()
    {
        RuleFor(v => v.Id)
           .NotEmpty();
        //Other Rules
    }
}
