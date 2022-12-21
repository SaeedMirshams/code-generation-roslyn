using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.Employees.Commands.CreateEmployee;

public class CreateEmployeeCommandValidator : BaseRequestValidator<CreateEmployeeCommand>
{
    public CreateEmployeeCommandValidator()
    {
        //RuleFor

    }
}
