using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.EvaluationResults.Commands.CreateEvaluationResult;

public class CreateEvaluationResultCommandValidator : BaseRequestValidator<CreateEvaluationResultCommand>
{
    public CreateEvaluationResultCommandValidator()
    {
        //RuleFor

    }
}
