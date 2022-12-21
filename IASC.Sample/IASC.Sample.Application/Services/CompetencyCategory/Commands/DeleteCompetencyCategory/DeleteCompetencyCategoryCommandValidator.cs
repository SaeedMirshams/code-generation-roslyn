using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.CompetencyCategorys.Commands.DeleteCompetencyCategory;

public class DeleteCompetencyCategoryCommandValidator : BaseRequestValidator<DeleteCompetencyCategoryCommand>
{
    public DeleteCompetencyCategoryCommandValidator()
    {
         RuleFor(v => v.Id)
           .NotNull();

    }
}
