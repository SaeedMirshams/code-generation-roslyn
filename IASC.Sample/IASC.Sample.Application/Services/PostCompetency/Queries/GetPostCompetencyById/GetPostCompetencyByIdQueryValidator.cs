using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.PostCompetencys.Queries.GetPostCompetencysWithPagination;

public class GetPostCompetencysByIdQueryValidator : BaseRequestValidator<GetPostCompetencysByIdQuery>
{
    public GetPostCompetencysByIdQueryValidator()
    {
        RuleFor(x => x.Id).NotNull();
    }
}
