        using FluentValidation;
        using IASC.Core.Validation;

        namespace IASC.Sample.Application.CompetencyScores.Queries.GetCompetencyScoresWithPagination;

        public class GetCompetencyScoresWithPaginationQueryValidator : BaseRequestValidator<GetCompetencyScoresWithPaginationQuery>
        {
            public GetCompetencyScoresWithPaginationQueryValidator()
            {
                RuleFor(x => x.PageNumber).NotNull().GreaterThan(0);
                RuleFor(x => x.PageSize).GreaterThan(0);
            }
        }
