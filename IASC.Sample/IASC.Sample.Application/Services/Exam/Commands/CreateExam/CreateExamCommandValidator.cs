using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.Exams.Commands.CreateExam;

public class CreateExamCommandValidator : BaseRequestValidator<CreateExamCommand>
{
    public CreateExamCommandValidator()
    {
        //RuleFor

    }
}
