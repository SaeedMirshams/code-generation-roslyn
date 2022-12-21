        using FluentValidation;
        using IASC.Core.Validation;

        namespace IASC.Sample.Application.SuccessorRepositorys.Queries.GetSuccessorRepositorysWithPagination;

        public class GetSuccessorRepositorysWithPaginationQueryValidator : BaseRequestValidator<GetSuccessorRepositorysWithPaginationQuery>
        {
            public GetSuccessorRepositorysWithPaginationQueryValidator()
            {
                RuleFor(x => x.PageNumber).NotNull().GreaterThan(0);
                RuleFor(x => x.PageSize).GreaterThan(0);
            }
        }
