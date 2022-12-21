using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.Employees.Commands.DeleteEmployee;

public class DeleteEmployeeCommandValidator : BaseRequestValidator<DeleteEmployeeCommand>
{
    public DeleteEmployeeCommandValidator()
    {
         RuleFor(v => v.Id)
           .NotNull();

    }
}
