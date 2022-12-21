        using FluentValidation;
        using IASC.Core.Validation;

        namespace IASC.Sample.Application.CompetencyCategorys.Queries.GetCompetencyCategorysWithPagination;

        public class GetCompetencyCategorysWithPaginationQueryValidator : BaseRequestValidator<GetCompetencyCategorysWithPaginationQuery>
        {
            public GetCompetencyCategorysWithPaginationQueryValidator()
            {
                RuleFor(x => x.PageNumber).NotNull().GreaterThan(0);
                RuleFor(x => x.PageSize).GreaterThan(0);
            }
        }
