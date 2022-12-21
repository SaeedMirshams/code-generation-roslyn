using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.EvaluationResults.Commands.DeleteEvaluationResult;

public class DeleteEvaluationResultCommandValidator : BaseRequestValidator<DeleteEvaluationResultCommand>
{
    public DeleteEvaluationResultCommandValidator()
    {
         RuleFor(v => v.Id)
           .NotNull();

    }
}
