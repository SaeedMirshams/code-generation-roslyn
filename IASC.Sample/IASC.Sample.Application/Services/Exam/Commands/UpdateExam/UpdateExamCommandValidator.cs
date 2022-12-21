using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.Exams.Commands.UpdateExam;

public class UpdateExamCommandValidator : BaseRequestValidator<UpdateExamCommand>
{
    public UpdateExamCommandValidator()
    {
        RuleFor(v => v.Id)
           .NotEmpty();
        //Other Rules
    }
}
