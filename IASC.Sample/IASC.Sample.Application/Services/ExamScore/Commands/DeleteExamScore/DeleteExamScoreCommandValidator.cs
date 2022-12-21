using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.ExamScores.Commands.DeleteExamScore;

public class DeleteExamScoreCommandValidator : BaseRequestValidator<DeleteExamScoreCommand>
{
    public DeleteExamScoreCommandValidator()
    {
         RuleFor(v => v.Id)
           .NotNull();

    }
}
