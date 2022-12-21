using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.Employees.Queries.GetEmployeesWithPagination;

public class GetEmployeesByIdQueryValidator : BaseRequestValidator<GetEmployeesByIdQuery>
{
    public GetEmployeesByIdQueryValidator()
    {
        RuleFor(x => x.Id).NotNull();
    }
}
