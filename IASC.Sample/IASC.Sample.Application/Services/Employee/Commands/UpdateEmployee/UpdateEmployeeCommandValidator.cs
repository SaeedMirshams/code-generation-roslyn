using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.Employees.Commands.UpdateEmployee;

public class UpdateEmployeeCommandValidator : BaseRequestValidator<UpdateEmployeeCommand>
{
    public UpdateEmployeeCommandValidator()
    {
        RuleFor(v => v.Id)
           .NotEmpty();
        //Other Rules
    }
}
