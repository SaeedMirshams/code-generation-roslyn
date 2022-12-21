using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.DevelopmentPrograms.Queries.GetDevelopmentProgramsWithPagination;

public class GetDevelopmentProgramsByIdQueryValidator : BaseRequestValidator<GetDevelopmentProgramsByIdQuery>
{
    public GetDevelopmentProgramsByIdQueryValidator()
    {
        RuleFor(x => x.Id).NotNull();
    }
}
