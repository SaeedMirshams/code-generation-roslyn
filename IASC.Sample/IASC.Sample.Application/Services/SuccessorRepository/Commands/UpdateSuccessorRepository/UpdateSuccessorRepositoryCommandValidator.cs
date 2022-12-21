using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.SuccessorRepositorys.Commands.UpdateSuccessorRepository;

public class UpdateSuccessorRepositoryCommandValidator : BaseRequestValidator<UpdateSuccessorRepositoryCommand>
{
    public UpdateSuccessorRepositoryCommandValidator()
    {
        RuleFor(v => v.Id)
           .NotEmpty();
        //Other Rules
    }
}
