        using FluentValidation;
        using IASC.Core.Validation;

        namespace IASC.Sample.Application.ExamScores.Queries.GetExamScoresWithPagination;

        public class GetExamScoresWithPaginationQueryValidator : BaseRequestValidator<GetExamScoresWithPaginationQuery>
        {
            public GetExamScoresWithPaginationQueryValidator()
            {
                RuleFor(x => x.PageNumber).NotNull().GreaterThan(0);
                RuleFor(x => x.PageSize).GreaterThan(0);
            }
        }
