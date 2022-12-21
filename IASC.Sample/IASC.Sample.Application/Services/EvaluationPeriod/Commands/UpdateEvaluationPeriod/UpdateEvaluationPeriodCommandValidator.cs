using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.EvaluationPeriods.Commands.UpdateEvaluationPeriod;

public class UpdateEvaluationPeriodCommandValidator : BaseRequestValidator<UpdateEvaluationPeriodCommand>
{
    public UpdateEvaluationPeriodCommandValidator()
    {
        RuleFor(v => v.Id)
           .NotEmpty();
        //Other Rules
    }
}
