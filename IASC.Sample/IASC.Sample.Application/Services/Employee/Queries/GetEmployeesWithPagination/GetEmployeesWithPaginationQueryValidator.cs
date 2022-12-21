        using FluentValidation;
        using IASC.Core.Validation;

        namespace IASC.Sample.Application.Employees.Queries.GetEmployeesWithPagination;

        public class GetEmployeesWithPaginationQueryValidator : BaseRequestValidator<GetEmployeesWithPaginationQuery>
        {
            public GetEmployeesWithPaginationQueryValidator()
            {
                RuleFor(x => x.PageNumber).NotNull().GreaterThan(0);
                RuleFor(x => x.PageSize).GreaterThan(0);
            }
        }
