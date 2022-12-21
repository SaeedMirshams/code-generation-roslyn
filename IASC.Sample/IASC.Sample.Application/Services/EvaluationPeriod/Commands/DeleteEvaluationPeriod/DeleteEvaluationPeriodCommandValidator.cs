using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.EvaluationPeriods.Commands.DeleteEvaluationPeriod;

public class DeleteEvaluationPeriodCommandValidator : BaseRequestValidator<DeleteEvaluationPeriodCommand>
{
    public DeleteEvaluationPeriodCommandValidator()
    {
         RuleFor(v => v.Id)
           .NotNull();

    }
}
