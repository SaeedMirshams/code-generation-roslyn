        using FluentValidation;
        using IASC.Core.Validation;

        namespace IASC.Sample.Application.Posts.Queries.GetPostsWithPagination;

        public class GetPostsWithPaginationQueryValidator : BaseRequestValidator<GetPostsWithPaginationQuery>
        {
            public GetPostsWithPaginationQueryValidator()
            {
                RuleFor(x => x.PageNumber).NotNull().GreaterThan(0);
                RuleFor(x => x.PageSize).GreaterThan(0);
            }
        }
