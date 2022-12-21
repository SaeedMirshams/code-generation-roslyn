using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.ExamParameters.Commands.CreateExamParameter;

public class CreateExamParameterCommandValidator : BaseRequestValidator<CreateExamParameterCommand>
{
    public CreateExamParameterCommandValidator()
    {
        //RuleFor

    }
}
