        using FluentValidation;
        using IASC.Core.Validation;

        namespace IASC.Sample.Application.Competencys.Queries.GetCompetencysWithPagination;

        public class GetCompetencysWithPaginationQueryValidator : BaseRequestValidator<GetCompetencysWithPaginationQuery>
        {
            public GetCompetencysWithPaginationQueryValidator()
            {
                RuleFor(x => x.PageNumber).NotNull().GreaterThan(0);
                RuleFor(x => x.PageSize).GreaterThan(0);
            }
        }
