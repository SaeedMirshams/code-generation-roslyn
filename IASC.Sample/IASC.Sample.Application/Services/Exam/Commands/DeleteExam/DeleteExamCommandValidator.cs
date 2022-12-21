using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.Exams.Commands.DeleteExam;

public class DeleteExamCommandValidator : BaseRequestValidator<DeleteExamCommand>
{
    public DeleteExamCommandValidator()
    {
         RuleFor(v => v.Id)
           .NotNull();

    }
}
