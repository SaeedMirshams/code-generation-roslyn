using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.CompetencyModels.Commands.DeleteCompetencyModel;

public class DeleteCompetencyModelCommandValidator : BaseRequestValidator<DeleteCompetencyModelCommand>
{
    public DeleteCompetencyModelCommandValidator()
    {
         RuleFor(v => v.Id)
           .NotNull();

    }
}
