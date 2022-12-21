using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.ExamScores.Commands.UpdateExamScore;

public class UpdateExamScoreCommandValidator : BaseRequestValidator<UpdateExamScoreCommand>
{
    public UpdateExamScoreCommandValidator()
    {
        RuleFor(v => v.Id)
           .NotEmpty();
        //Other Rules
    }
}
