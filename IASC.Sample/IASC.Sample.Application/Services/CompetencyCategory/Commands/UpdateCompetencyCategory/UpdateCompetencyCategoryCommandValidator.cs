using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.CompetencyCategorys.Commands.UpdateCompetencyCategory;

public class UpdateCompetencyCategoryCommandValidator : BaseRequestValidator<UpdateCompetencyCategoryCommand>
{
    public UpdateCompetencyCategoryCommandValidator()
    {
        RuleFor(v => v.Id)
           .NotEmpty();
        //Other Rules
    }
}
