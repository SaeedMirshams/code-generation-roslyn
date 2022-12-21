using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.DevelopmentProgramItems.Queries.GetDevelopmentProgramItemsWithPagination;

public class GetDevelopmentProgramItemsByIdQueryValidator : BaseRequestValidator<GetDevelopmentProgramItemsByIdQuery>
{
    public GetDevelopmentProgramItemsByIdQueryValidator()
    {
        RuleFor(x => x.Id).NotNull();
    }
}
