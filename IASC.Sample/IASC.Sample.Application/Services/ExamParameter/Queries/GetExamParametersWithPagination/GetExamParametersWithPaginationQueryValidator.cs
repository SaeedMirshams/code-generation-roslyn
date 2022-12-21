        using FluentValidation;
        using IASC.Core.Validation;

        namespace IASC.Sample.Application.ExamParameters.Queries.GetExamParametersWithPagination;

        public class GetExamParametersWithPaginationQueryValidator : BaseRequestValidator<GetExamParametersWithPaginationQuery>
        {
            public GetExamParametersWithPaginationQueryValidator()
            {
                RuleFor(x => x.PageNumber).NotNull().GreaterThan(0);
                RuleFor(x => x.PageSize).GreaterThan(0);
            }
        }
