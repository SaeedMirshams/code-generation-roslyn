using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.Posts.Queries.GetPostsWithPagination;

public class GetPostsByIdQueryValidator : BaseRequestValidator<GetPostsByIdQuery>
{
    public GetPostsByIdQueryValidator()
    {
        RuleFor(x => x.Id).NotNull();
    }
}
