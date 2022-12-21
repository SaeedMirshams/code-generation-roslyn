using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.ExamScores.Commands.CreateExamScore;

public class CreateExamScoreCommandValidator : BaseRequestValidator<CreateExamScoreCommand>
{
    public CreateExamScoreCommandValidator()
    {
        //RuleFor

    }
}
