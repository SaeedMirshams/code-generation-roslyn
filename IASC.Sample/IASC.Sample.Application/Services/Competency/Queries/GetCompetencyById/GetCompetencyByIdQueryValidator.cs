using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.Competencys.Queries.GetCompetencysWithPagination;

public class GetCompetencysByIdQueryValidator : BaseRequestValidator<GetCompetencysByIdQuery>
{
    public GetCompetencysByIdQueryValidator()
    {
        RuleFor(x => x.Id).NotNull();
    }
}
