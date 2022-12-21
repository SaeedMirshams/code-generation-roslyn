using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.EvaluationResults.Commands.UpdateEvaluationResult;

public class UpdateEvaluationResultCommandValidator : BaseRequestValidator<UpdateEvaluationResultCommand>
{
    public UpdateEvaluationResultCommandValidator()
    {
        RuleFor(v => v.Id)
           .NotEmpty();
        //Other Rules
    }
}
