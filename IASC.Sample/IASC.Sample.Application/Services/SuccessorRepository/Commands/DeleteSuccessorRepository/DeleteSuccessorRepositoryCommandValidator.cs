using FluentValidation;
using IASC.Core.Validation;

namespace IASC.Sample.Application.SuccessorRepositorys.Commands.DeleteSuccessorRepository;

public class DeleteSuccessorRepositoryCommandValidator : BaseRequestValidator<DeleteSuccessorRepositoryCommand>
{
    public DeleteSuccessorRepositoryCommandValidator()
    {
         RuleFor(v => v.Id)
           .NotNull();

    }
}
