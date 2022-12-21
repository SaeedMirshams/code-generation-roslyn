using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.SuccessorRepositorys.Queries.GetSuccessorRepositorysWithPagination;

public class GetSuccessorRepositorysByIdQueryValidator : BaseRequestValidator<GetSuccessorRepositorysByIdQuery>
{
    public GetSuccessorRepositorysByIdQueryValidator()
    {
        RuleFor(x => x.Id).NotNull();
    }
}
