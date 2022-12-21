using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.ExamParameters.Commands.DeleteExamParameter;

public class DeleteExamParameterCommandValidator : BaseRequestValidator<DeleteExamParameterCommand>
{
    public DeleteExamParameterCommandValidator()
    {
         RuleFor(v => v.Id)
           .NotNull();

    }
}
