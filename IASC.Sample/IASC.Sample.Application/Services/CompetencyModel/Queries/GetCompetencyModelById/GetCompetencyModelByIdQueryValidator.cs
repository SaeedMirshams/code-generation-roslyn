using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.CompetencyModels.Queries.GetCompetencyModelsWithPagination;

public class GetCompetencyModelsByIdQueryValidator : BaseRequestValidator<GetCompetencyModelsByIdQuery>
{
    public GetCompetencyModelsByIdQueryValidator()
    {
        RuleFor(x => x.Id).NotNull();
    }
}
