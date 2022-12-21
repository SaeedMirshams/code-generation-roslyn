        using FluentValidation;
        using IASC.Core.Validation;

        namespace IASC.Sample.Application.CompetencyModels.Queries.GetCompetencyModelsWithPagination;

        public class GetCompetencyModelsWithPaginationQueryValidator : BaseRequestValidator<GetCompetencyModelsWithPaginationQuery>
        {
            public GetCompetencyModelsWithPaginationQueryValidator()
            {
                RuleFor(x => x.PageNumber).NotNull().GreaterThan(0);
                RuleFor(x => x.PageSize).GreaterThan(0);
            }
        }
