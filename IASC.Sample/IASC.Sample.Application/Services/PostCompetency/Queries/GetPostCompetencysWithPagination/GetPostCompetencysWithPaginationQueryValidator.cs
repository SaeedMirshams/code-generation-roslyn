        using FluentValidation;
        using IASC.Core.Validation;

        namespace IASC.Sample.Application.PostCompetencys.Queries.GetPostCompetencysWithPagination;

        public class GetPostCompetencysWithPaginationQueryValidator : BaseRequestValidator<GetPostCompetencysWithPaginationQuery>
        {
            public GetPostCompetencysWithPaginationQueryValidator()
            {
                RuleFor(x => x.PageNumber).NotNull().GreaterThan(0);
                RuleFor(x => x.PageSize).GreaterThan(0);
            }
        }
