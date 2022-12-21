using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.CompetencyCategorys.Queries.GetCompetencyCategorysWithPagination;

public class GetCompetencyCategorysByIdQueryValidator : BaseRequestValidator<GetCompetencyCategorysByIdQuery>
{
    public GetCompetencyCategorysByIdQueryValidator()
    {
        RuleFor(x => x.Id).NotNull();
    }
}
